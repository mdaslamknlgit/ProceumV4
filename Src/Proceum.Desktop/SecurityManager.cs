using biTsSCommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Proceum
{
  sealed  class  SecurityManager
    {
        GlobalKeyboardHook gkh ;
        public event EventHandler SecurityNotice;
        void OnSecurityNotice(EventArgs e)
        {
            EventHandler handler = SecurityNotice;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public delegate bool EnumThreadWindowsCallback(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindows(EnumThreadWindowsCallback callback, IntPtr extraData);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        [DllImport("psapi.dll")]
        static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In] [MarshalAs(UnmanagedType.U4)] int nSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        BackgroundWorker backgroundWorkerSecurity;
        BackgroundWorker BackgroundKillProcess;
        Timer timerSecurity;

        List<string> exemptedProcess = new List<string>();
        List<string> blacklistedProcesses = new List<string>();

        private static readonly Lazy<SecurityManager> lazy = new Lazy<SecurityManager>(() => new SecurityManager());

        public static SecurityManager Instance { get { return lazy.Value; } }

        private SecurityManager()
        {
            getBlacklistApplication();
            getExemptedApplication();

            backgroundWorkerSecurity = new BackgroundWorker();
            BackgroundKillProcess = new BackgroundWorker();
            timerSecurity = new Timer();
            timerSecurity.Interval = 1000;

            backgroundWorkerSecurity.DoWork += BackgroundWorkerSecurity_DoWork;
            BackgroundKillProcess.DoWork += BackgroundKillProcess_DoWork;
            timerSecurity.Tick += TimerSecurity_Tick;

            gkh = new GlobalKeyboardHook();
            gkh.HookedKeys.Add(Keys.PrintScreen);
            gkh.HookedKeys.Add(Keys.LWin);
            gkh.HookedKeys.Add(Keys.RWin);
            gkh.HookedKeys.Add(Keys.Tab);
            //gkh.HookedKeys.Add(Keys.Control);
            gkh.HookedKeys.Add(Keys.Alt | Keys.Tab);
            gkh.HookedKeys.Add(Keys.Control | Keys.Shift | Keys.Escape);
            gkh.HookedKeys.Add(Keys.Control | Keys.Shift);
            gkh.HookedKeys.Add(Keys.Alt | Keys.Shift);
            gkh.HookedKeys.Add(Keys.Alt);
            gkh.HookedKeys.Add(Keys.Delete);

            //By Vikash singh
            gkh.HookedKeys.Add(Keys.Escape);
            gkh.HookedKeys.Add(Keys.Shift);
            gkh.HookedKeys.Add(Keys.F1);
            gkh.HookedKeys.Add(Keys.F2);
            gkh.HookedKeys.Add(Keys.F3);
            gkh.HookedKeys.Add(Keys.F4);
            gkh.HookedKeys.Add(Keys.F5);
            gkh.HookedKeys.Add(Keys.F6);
            gkh.HookedKeys.Add(Keys.F7);
            gkh.HookedKeys.Add(Keys.F8);
            gkh.HookedKeys.Add(Keys.F9);
            gkh.HookedKeys.Add(Keys.F10);
            gkh.HookedKeys.Add(Keys.F11);
            gkh.HookedKeys.Add(Keys.F12);
            gkh.HookedKeys.Add(Keys.F13);
            gkh.HookedKeys.Add(Keys.F14);
            gkh.HookedKeys.Add(Keys.F15);
            gkh.HookedKeys.Add(Keys.F16);
            gkh.HookedKeys.Add(Keys.F17);
            gkh.HookedKeys.Add(Keys.F18);
            gkh.HookedKeys.Add(Keys.F19);
            gkh.HookedKeys.Add(Keys.F20);
            gkh.HookedKeys.Add(Keys.F21);
            gkh.HookedKeys.Add(Keys.F22);
            gkh.HookedKeys.Add(Keys.F23);
            gkh.HookedKeys.Add(Keys.F24);
            gkh.HookedKeys.Add(Keys.Insert);
            gkh.HookedKeys.Add(Keys.Home);
            //gkh.HookedKeys.Add(Keys.Back);
            gkh.HookedKeys.Add(Keys.Pause);
            gkh.HookedKeys.Add(Keys.End);

            gkh.HookedKeys.Add(Keys.Oem1);
            gkh.HookedKeys.Add(Keys.Oem102);
            gkh.HookedKeys.Add(Keys.Oem2);
            gkh.HookedKeys.Add(Keys.Oem3);
            gkh.HookedKeys.Add(Keys.Oem4);
            gkh.HookedKeys.Add(Keys.Oem5);
            gkh.HookedKeys.Add(Keys.Oem6);
            gkh.HookedKeys.Add(Keys.Oem7);
            gkh.HookedKeys.Add(Keys.Oem8);

            //gkh.HookedKeys.Add(Keys.OemBackslash);
            //gkh.HookedKeys.Add(Keys.OemClear);
            //gkh.HookedKeys.Add(Keys.OemCloseBrackets);
            //gkh.HookedKeys.Add(Keys.Oemcomma);
            //gkh.HookedKeys.Add(Keys.OemMinus);
            //gkh.HookedKeys.Add(Keys.OemOpenBrackets);
            //gkh.HookedKeys.Add(Keys.OemPeriod);
            //gkh.HookedKeys.Add(Keys.OemPipe);
            //gkh.HookedKeys.Add(Keys.Oemplus);
            //gkh.HookedKeys.Add(Keys.OemQuestion);
            //gkh.HookedKeys.Add(Keys.OemQuotes);
            //gkh.HookedKeys.Add(Keys.OemSemicolon);
            //gkh.HookedKeys.Add(Keys.Oemtilde);

            //end vikash 


            gkh.KeyDown += new KeyEventHandler(Gkh_KeyDown);
        }

        int Invoke_Hardware_ChangeDetection_Time = 0;
        int Invokation_End_Time = 8;
        private void Invoke_Hardware_Scan()
        {
            int pdnDevInst = 0;
            var res = WinApi.CM_Locate_DevNodeA(ref pdnDevInst, null, WinApi.CM_LOCATE_DEVNODE_NORMAL);
            var res2 = WinApi.CM_Reenumerate_DevNode(pdnDevInst, WinApi.CM_REENUMERATE_NORMAL);
        }
        private void TimerSecurity_Tick(object sender, EventArgs e)
        {
            if (Invoke_Hardware_ChangeDetection_Time > Invokation_End_Time)
            {
                Invoke_Hardware_Scan();
                Invoke_Hardware_ChangeDetection_Time = 0;
            }
            else
            {
                Invoke_Hardware_ChangeDetection_Time++;
            }
            if (!backgroundWorkerSecurity.IsBusy)
            {
                backgroundWorkerSecurity.RunWorkerAsync();
            }

            if (!BackgroundKillProcess.IsBusy)
            {
                BackgroundKillProcess.RunWorkerAsync();
            }
        }

        const int KillProcessTime = 3;
        int KillProcessTimeCount = 0;

        private void BackgroundKillProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            if (KillProcessTimeCount > KillProcessTime)
            {
                termApps();
                KillProcessTimeCount = 0;
            }

            KillProcessTimeCount++;
        }
        
        private void BackgroundWorkerSecurity_DoWork(object sender, DoWorkEventArgs e)
        {
            getMultipleDisplayDedect();
        }

        void getExemptedApplication()
        {
            exemptedProcess = new List<string>();
            //var data = Program.CourseDb.Course.applications.Where(x => x.applicationType == biTsSCommonClasses.ApiModels.Enums.ApplicationTypeEnum.Exempted).ToList();
            //foreach (var d in data)
            //{
            //    exemptedProcess.Add(d.ApplicationName.ToLower());

            //}

            exemptedProcess.Add("explorer");
            //exemptedProcess.Add("anydesk");
        }
        [MethodImpl(MethodImplOptions.NoOptimization)]
        static string GetProcessName(int pid)
        {
            var processHandle = OpenProcess(0x0400 | 0x0010, false, pid);

            if (processHandle == IntPtr.Zero)
            {
                return null;
            }

            const int lengthSb = 4000;

            var sb = new StringBuilder(lengthSb);

            string result = null;

            if (GetModuleFileNameEx(processHandle, IntPtr.Zero, sb, lengthSb) > 0)
            {
                result = sb.ToString();
            }

            CloseHandle(processHandle);

            return result;
        }
        void getBlacklistApplication()
        {
            blacklistedProcesses = new List<string>();
            //var data = Program.CourseDb.Course.applications.Where(x => x.applicationType == biTsSCommonClasses.ApiModels.Enums.ApplicationTypeEnum.Blacklist).ToList();
            //foreach (var d in data)
            //{
            //    blacklistedProcesses.Add(d.ApplicationName.ToLower());
            //}
        }
        void tryKillProcess(Process ps)
        {
            try
            {
                if (isProcessExempted(ps)) return;

                if (ps.ProcessName.ToLower().Contains("anydesk") || ps.ProcessName.ToLower().Contains("team"))
                {
                    OnSecurityNotice(EventArgs.Empty);
                }

                if (ps.ProcessName == "dwm" || ps.ProcessName == "ctfmon" || ps.ProcessName == "SynTPHelper" | ps.ProcessName == "SynTPEnh" | ps.ProcessName == "explorer" || ps.ProcessName.ToLower().Contains("explorer") || ps.ProcessName.ToLower().Contains("desktime")) return;

                if (!isProcessBlacklisted(ps))
                {
                    try
                    {
                        X509Certificate cert = X509Certificate.CreateFromSignedFile(ps.GetMainModuleFileName());
                        if (cert.Issuer.ToLower().Contains("o=microsoft corporation"))
                        {
                            return; ;
                        }
                    }
                    catch { }
                }
                //ps.ReportException(new Exception("Info only"), "killing " + ps.ProcessName);
                ps.Kill();
            }
            catch (Exception ex)
            {
                ex.ReportException(ex, "Killing App " + ps.ProcessName);
            }


        }
        bool isProcessBlacklisted(Process ps)
        {
            try
            {
                if (blacklistedProcesses != null)
                {
                    if (blacklistedProcesses.Any(x => x.ToLower() == ps.ProcessName))
                    {
                        return true;
                    }
                    var psPath = GetProcessName(ps.Id);
                    if (!string.IsNullOrWhiteSpace(psPath))
                    {
                        FileVersionInfo psVersionInfo = FileVersionInfo.GetVersionInfo(psPath);
                        if (blacklistedProcesses.Any(x => x.ToLower() == psVersionInfo.InternalName || x.ToLower() == psVersionInfo.FileName || x.ToLower() == psVersionInfo.OriginalFilename))
                        {
                            return true;
                        }
                    }
                }
            }
            catch { }
            return false;
        }
        bool isProcessExempted(Process ps)
        {
            try
            {
                if (exemptedProcess != null)
                {
                    var psPath = GetProcessName(ps.Id);
                    if (!string.IsNullOrWhiteSpace(psPath))
                    {
                        FileVersionInfo psVersionInfo = FileVersionInfo.GetVersionInfo(psPath);

                        if (exemptedProcess.Any(x => psVersionInfo.FileDescription.ToLower().Contains(x.ToLower()) || x.ToLower() == psVersionInfo.ProductName.ToLower() || x.ToLower() == psVersionInfo.InternalName.ToLower() || x.ToLower() == psVersionInfo.OriginalFilename.ToLower() || x.ToLower() + ".exe" == psVersionInfo.InternalName.ToLower()))
                        {
                            return true;
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        void termApps()
        {
            this.ReportException("", "term apps...");
            var cp = Process.GetCurrentProcess();
            var processes = Process.GetProcesses();//.Where(x => blacklistedProcesses.Contains(x.ProcessName.ToLower()));

            this.ReportException("", "term apps2...");
            foreach (var item in processes)
            {
                if (isProcessBlacklisted(item))
                {
                    tryKillProcess(item);
                    if (!item.HasExited)
                    {
                        OnSecurityNotice(EventArgs.Empty);
                    }
                }
            }
            this.ReportException("", "term apps3...");

            var pss = processes.Where(x => x.MainWindowHandle != IntPtr.Zero && x.Id != cp.Id);
            foreach (var item in pss)
            {
                tryKillProcess(item);
            }
            this.ReportException("", "term apps4...");
            var handles = new List<IntPtr>();
            EnumWindows((hwnd, lp) => { handles.Add(hwnd); return true; }, IntPtr.Zero);
            foreach (var item in handles)
            {
                int pid;
                var res = GetWindowThreadProcessId(new HandleRef(null, item), out pid);
                if (pid != cp.Id)
                {
                    try
                    {
                        var ps = Process.GetProcessById(pid);
                        tryKillProcess(ps);
                    }
                    catch(Exception ex) {
                        ex.ReportException(ex, "try kill..");
                    }
                }
            }
            this.ReportException("", "term apps5...");
        }
        public void StartSecurity()
        {
            if (!backgroundWorkerSecurity.IsBusy)
                backgroundWorkerSecurity.RunWorkerAsync();

            timerSecurity.Start();
        }

        public void StopSecurity()
        {
            timerSecurity.Stop();
        }
       
        void Gkh_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;//prevent it from propogating further...
            if (e.KeyCode == Keys.PrintScreen)
            {
                OnSecurityNotice(EventArgs.Empty);
            }
        }
      
        void getMultipleDisplayDedect()
        {
            ManagementObjectCollection collecton;
            using (var devices = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Service = 'monitor'"))
            {

                collecton = devices.Get();

            }

            if (collecton.Count > 1)
            {
                OnSecurityNotice(EventArgs.Empty);
            }
        }
    }
}
