using DebugTools.Tools;
//using Gecko;//no use of this on this project
using log4net;
using MetroFramework.Forms;
using Microsoft.Web.WebView2.Core;
using Proceum.Help;
using Proceum.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static Proceum.Models.MyModels;
using Timer = System.Windows.Forms.Timer;

namespace Proceum
{
    public partial class MainVideo2 : Form
    {
        #region Variables

        string DEVELOPMENT_QA = "https://dev.medvizz3d.com/login/application";
        string DEVELOPMENT_PROD = "https://uat.proceum.com/login/application";

        string UAT_QA = "https://dev.medvizz3d.com/login/application";
        string UAT_PROD = "https://uat.proceum.com/login/application";

        string CurrentEnvironment = "";
        string CurrentEnvironmentStr = "";

        string AuthenticationToken = "";
        string JSONContentStr = "";
        string ContentStr = "";

        string URLParseStr="";

        string NavigatingURL = "about:blank";

        string PreviousResolutionOfVideo = "";

        //FirebaseClient Client;
        IDisposable Observable;

        public static string _Node = "UserTokens";
        Proceum.Customer_cloud.Controls.Player_Controls PlayerControls;

        bool PreviousControl = false;

        //bool PreviousControl = true;

        bool Is_Logging_Off = false;

        int TimeToUpdateValidity = 20;
        int CountSecondsToValidate = 0;
        double? PreviousCurrentTimeOfPlayer = null;

        int TimeToChangeTree = 0;

        int SecondsToUpdateData = 0;


        int try_Loggout = 0;

        bool MainSettingShown = false;
        System.Windows.Forms.Timer Setting_Popup = new System.Windows.Forms.Timer();

        Stopwatch sw = new Stopwatch();

        bool Video_Menu_Shown = false;

        private bool FstRun = true;
        private bool WebReady = false;

        string Main_Url;

        string MessageToShow = "";

        int TryingTime = 5;
        int Refresh_Time = 0;

        TreeNode SelectedNode = new TreeNode();
        private int Current_Player = 0;
        long go_live_counter = 0;

        int Video_Type = 0; // 0 = m3u8 , 1 = mpd


        bool isBlinked = true;
        public string PURL = "";
        public string PURLVAL = "";
        DisplayWatermark watermark;
        FormState formState = new FormState();
        StreamWriter Log_File;
        SecurityManager securityManager;
        Form _prevForm;
        string _pDrive;
        public RandomGenerator rgenerator = null;

        public string VideoID = "";
        public string RoleID = "2";
        public string UserID = "";
        public string TokenStr = "";
        public string ProceumStr = "";


        public string useid;
        public string Water_Marktext;
        public string videoid;
        public string Courseid;
        public string VodNode;
        public string img_url;
        public string remaing_time;
        string time_left = "";
        string video_id;
        string title;
        string User_Id;
        bool strated = true;
        long Start_date = 0;

        private readonly ILog _logger;

        Font font;

        int OriginalExStyle = -1;

        Proceum.Customer_cloud.Controls.TransparentPanel ClickGrabber;

        string Offline_Video_File_Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ProceumData\Offline_Content\";

        bool IsWindows7 = false;
        string FirxFoxDirectory = "";
        string FireFoxDirectoryFullPath = "";
        #endregion

        #region DLL Imports

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // width of ellipse
        //    int nHeightEllipse // height of ellipse
        //);

        #endregion

        #region Constructor

        public MainVideo2(string URL)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            string TempPath = Path.GetTempPath();

            //MessageBox.Show("Temp Path: " +  TempPath);
            PURL = URL;
            //rgenerator = new RandomGenerator();

            //MessageBox.Show("frmViewContent InitializeComponent");
            InitializeComponent();

            //MessageBox.Show("frmViewContent InitializeComponent Executed");
            try
            {
                //MessageBox.Show("frmViewContent Initialier");

                ///MessageBox.Show("Setting Logger");

                //_logger = LogManager.GetLogger(GetType().Name);
                ////_logger.Info("Started");

                //MessageBox.Show("Logger Set " + //_logger.ToString());

                //MessageBox.Show("Firefox Initializing");

                //Set Firefox Directory
                FirxFoxDirectory = Environment.CurrentDirectory;
                FireFoxDirectoryFullPath = FirxFoxDirectory + "\\FireFox";

                font = new Font(SystemFonts.MenuFont.FontFamily, 12, FontStyle.Regular);
                //treeView1.Font = font;
                //formState.Maximize(this);

                //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

                //MessageBox.Show("Loading Water Mark");

                //Load_Online_Watermark();

                //MessageBox.Show("Water Mark Loaded");

                OperatingSystem os = Environment.OSVersion;
                Version vs = os.Version;
                //MessageBox.Show("Os Info " + string.Format("{0}, {1}, {2}",os.Platform,vs.Major,vs.Minor));
                if (os.Platform == PlatformID.Win32NT && vs.Major == 6 && vs.Minor == 1)
                {
                    IsWindows7 = true;
                }
                else
                {
                    IsWindows7 = false;
                }


                //this.Resizable = true;
                this.TopMost = false;

                //securityManager = SecurityManager.Instance;
                //securityManager.SecurityNotice += SecurityManager_SecurityNotice;

                //this.Resizable = false;
                //this.TopMost = true;
                //MessageBox.Show("Set Double Buffer");
                
                //Set_Doble_Buffer();
                //bool virtualmachin = DetectVirtualMachine();
                //if (virtualmachin == true)
                //{
                //    MessageBox.Show("Cannot Run on Virtual Machine");
                //    return;
                //    //Application.Exit();
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error frmViewContent Initialize  " + exp.ToString());
            }
        }


       
        #endregion

        #region Player Functions

        private void PlayerFullScreenClick(object sender, EventArgs e)
        {
            //if (!PreviousControl)
            //{
            //    TopPanel.Visible = false;
            //    VideoValidity.Visible = false;
            //    CourseValidity.Visible = false;


            //    FullScreenPanel.Visible = true;
            //    FullScreenPanel.Controls.Add(pnPlayer);
            //    FullScreenPanel.Dock = DockStyle.Fill;


            //    webView21.Dock = DockStyle.Fill;
            //    pnPlayer.Dock = DockStyle.Fill;
            //    PreviousControl = true;


            //}
            //else
            //{
            //    pnContent.Controls.Add(pnPlayer);
            //    FullScreenPanel.Visible = false;
            //    TopPanel.Visible = true;

            //    //VideoValidity.Visible = true;
            //    //CourseValidity.Visible = true;

            //    PreviousControl = false;
            //}


        }

        private void PlayerPlayPauseClick(object sender, EventArgs e)
        {
            //if (Log_File.Equals(StreamWriter.Null))
            //{
            //    var randomNumber = rgenerator.RandomNumber(5, 100);

            //    //Log_File = new StreamWriter("Text_File.Text");
            //    //Log_File = new StreamWriter(@"C:\Users\ASLAM~1.MOH\AppData\Local\Temp\Text_File.Text");
            //    //Log_File.Write("Sender " + randomNumber);
            //    ////Log_File.Close();
            //}
            ////Log_File.Close();

            try
            {
                if (PlayerControls.IsPlaying)
                {
                    webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).pause();" : "$('#video')[0].pause();");
                    webView21.Visible = false;

                }
                else
                {
                    webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).play();" : "$('#video')[0].play();");
                    webView21.Visible = true;
                }
            }
            catch (Exception ex)
            {
                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                MessageBox.Show(ex.ToString());
                //_logger.Error(ex);

            }
            finally
            {
                //Log_File.Close();
            }


        }

        private void PlayerVolumeChange(object sender, EventArgs e)
        {
            double Volume = (100 - PlayerControls.Volume) / 100.0;
            webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).volume(" + Volume + ");" : "$('#video')[0].volume = " + Volume);

        }

        private void PlayerCurrentTimeChange(object sender, EventArgs e)
        {

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");
            try
            {
                string Duration_Query = "";
                string Current_Time_Query = "";
                if (Video_Type == 1)
                {
                    Duration_Query = "(player).duration();";
                    Current_Time_Query = "(player).currentTime();";
                }
                else
                {
                    Duration_Query = "$('#video')[0].duration";
                    Current_Time_Query = "$('#video')[0].currentTime";
                }

                if ((!PlayerControls.IsLoaded && !PlayerControls.IsLiveVideo))//
                {
                    webView21.CoreWebView2.ExecuteScriptAsync(Duration_Query).ContinueWith(x =>
                    {
                        if (x.IsFaulted == false)
                        {
                            var Duration = x.Result;

                            try
                            {
                                if (Duration != "null")
                                {
                                    if (!string.IsNullOrEmpty(Duration))
                                    {
                                        if (Convert.ToDouble(Duration) == 0)
                                        {
                                            return;
                                        }
                                        Invoke(new Action(() =>
                                        {
                                            PlayerControls.SetMedia(Convert.ToDouble(Duration));
                                            webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).volume(1);" : "$('#video')[0].volume = 1");
                                            webView21.CoreWebView2.ExecuteScriptAsync("player.enterFullWindow();");
                                            //webView21.CoreWebView2.ExecuteScriptAsync("player.play();");
                                        }));
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                //_logger.Error(ex);
                                //Log_File.Write(ex);
                                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));

                                //throw ex;

                                //return;
                            }
                            finally
                            {
                                //Log_File.Close();
                            }
                        }
                        else
                        {
                            return;
                        }

                    });
                }

                webView21.CoreWebView2.ExecuteScriptAsync(Current_Time_Query).ContinueWith(y =>
                {

                    if (y.IsFaulted == false)
                    {
                        var CurrentTime = y.Result;

                        if (!string.IsNullOrWhiteSpace(CurrentTime))
                        {
                            Invoke(new Action(() =>
                            {
                                if (!PlayerControls.IsLoaded && PlayerControls.IsLiveVideo)
                                {
                                    PlayerControls.SetMedia(Convert.ToDouble(CurrentTime));
                                    webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).volume(1);" : "$('#video')[0].volume = 1");
                                    webView21.CoreWebView2.ExecuteScriptAsync("player.enterFullWindow();");
                                    //pnLoading.Visible = false;
                                }
                                if (CurrentTime != "null")
                                {
                                    PlayerControls.CurrentTime = Convert.ToDouble(CurrentTime);//needed correction
                                }

                            }));
                        }
                    }
                });

            }
            catch (Exception ex)
            {
                ////_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));

                //MessageBox.Show("LogFile", String.Format("{0} @ {1}", ex.ToString(), DateTime.Now));
                MessageBox.Show("PlayerCurrentTimeChange : \n" + ex.ToString());
                //throw ex;

            }
            finally
            {
                ////Log_File.Close();
            }


        }

        private void PlayerProgressChange(object sender, EventArgs e)
        {

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");
            try
            {
                webView21.CoreWebView2.ExecuteScriptAsync(Video_Type == 1 ? "(player).currentTime(" + PlayerControls.CurrentTime + ");" : "$('#video')[0].currentTime = " + PlayerControls.CurrentTime);
            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                throw ex;

            }
            finally
            {
                //Log_File.Close();
            }

        }

        private void PlayerSpeedChanged(object sender, EventArgs e)
        {

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");
            try
            {
                webView21.CoreWebView2.ExecuteScriptAsync(
                    Video_Type == 0 ?
                    "document.querySelector('video').playbackRate = " + PlayerControls.SpeedCode
                    :
                    "document.getElementById('my_video_1_shaka_api').playbackRate = " + PlayerControls.SpeedCode
                    );
            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                //throw ex;

            }
            finally
            {
                //Log_File.Close();
            }

        }

        private void PlayerQualityChange(object sender, EventArgs e)
        {

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");

            try
            {
                if (Video_Type == 0)
                {
                    webView21.CoreWebView2.ExecuteScriptAsync("hls.nextLevel=" + PlayerControls.QualityCode);
                }
                else
                {
                    webView21.CoreWebView2.ExecuteScriptAsync("document.getElementsByClassName('vjs-menu-item-text').length").ContinueWith(y =>
                    {
                        if (y.IsFaulted == false)
                        {
                            var Total_Elements = y.Result;

                            if (!string.IsNullOrWhiteSpace(Total_Elements))
                            {
                                Invoke(new Action(() =>
                                {
                                    var Quality_Code = PlayerControls.QualityCode == -1 ? 3 : PlayerControls.QualityCode - 1;
                                    webView21.CoreWebView2.ExecuteScriptAsync("document.getElementsByClassName('vjs-menu-item-text')[" + (int.Parse(Total_Elements) - (Quality_Code + 2)) + "].click();");
                                }));
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                //throw ex;

            }
            finally
            {
                //Log_File.Close();
            }


        }

        #endregion

        #region Webview Code

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            WebReady = true;
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (webView21.Source.AbsoluteUri != "about:blank")
            {
                try
                {
                    //watermark.Start();
                }
                catch (Exception ex)
                {
                    //_logger.Error(ex);
                    //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));
                    //throw ex;
                }
                finally
                {
                    //Log_File.Close();
                }

                //pnLoading.Visible = false;
                //pnPlayer.Visible = true;
                //pnContent.Visible = true;
                //pnPlayer.Dock = DockStyle.Left;
                // pnPlayer.Width = pnContent.Width - (pnChatting.Visible ? pnChatting.Width : 0);
                //pnYoutube.Visible = true;
                //pnYoutube.Height = pnPlayer.Height;
                //pnM3u8.Visible = true;
                //VideoValidityTimer.Enabled = true;


            }
        }

        private void WebView21_CoreWebView2Ready(object sender, EventArgs e)
        {
            WebReady = true;
        }

        private void webView21_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode==Keys.F5)
            {
                MessageBox.Show("F5 Pressed");
            }
            else
            {
                MessageBox.Show(e.KeyCode.ToString());
            }
        }
        #endregion

        #region Watermark
        private void SparshWatermark(object sender, EventArgs e)
        {

            List<string> b1 = new List<string>();
            b1.Add("Sparsh Communications Pvt Ltd.");
            b1.Add("7729005136");
            b1.Add("info@sparshcom.net");
            b1.Add("Developed By: Sparsh Communications Pvt Ltd.");
            int index = DateTime.Now.Second % 4;
            this.watermark.Text = b1[index];

        }

        private void Load_Online_Watermark()
        {
            watermark = new DisplayWatermark(this, webView21);
            Timer tm = new Timer();
            tm.Interval = 1000;
            //tm.Tick += new EventHandler(change);
            tm.Tick += new EventHandler(SparshWatermark);
            //SparshWatermark
            tm.Start();


        }

        #endregion

        #region Private Methods

        public bool DetectVirtualMachine()
        {
            using (var searcher = new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        string manufacturer = item["Manufacturer"].ToString().ToLower();
                        if ((manufacturer == "microsoft corporation" && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                            || manufacturer.Contains("vmware")
                            || item["Model"].ToString() == "VirtualBox")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void Set_Doble_Buffer()
        {
            int style = WinApi.GetWindowLong(TopPanel.Handle, WinApi.GWL_EXSTYLE);
            style |= WinApi.WS_EX_COMPOSITED;
            WinApi.SetWindowLong(TopPanel.Handle, WinApi.GWL_EXSTYLE, style);

            //style = WinApi.GetWindowLong(treeView1.Handle, WinApi.GWL_EXSTYLE);
            //style |= WinApi.WS_EX_COMPOSITED;
            //WinApi.SetWindowLong(treeView1.Handle, WinApi.GWL_EXSTYLE, style);
        }

        private void change(object sender, EventArgs e)
        {

            List<string> b1 = new List<string>();
            b1.Add("John Doe");
            b1.Add("7729005136");
            b1.Add("john.doe@gmail.com");
            b1.Add("John Doe 1st year");
            int index = DateTime.Now.Second % 4;
            this.watermark.Text = b1[index];

        }

        private string GetTimeInServerFormat(string TimeInSeconds)
        {
            long Time = Convert.ToInt64(TimeInSeconds);

            int sec = (int)Time % 60;
            var ss = sec < 10 ? ("0" + sec) : sec.ToString();

            int min = ((int)Time / 60) % 60;
            var mm = min < 10 ? ("0" + min) : min.ToString();

            int hrs = ((int)Time / 60) / 60;
            var hh = hrs < 10 ? ("0" + hrs) : hrs.ToString();

            return hh + ":" + mm + ":" + ss;
        }

        private long ServerTimeFormatToSeconds(string ServerTime)
        {
            var Time = ServerTime.Split(':');

            long hrs = Convert.ToInt64(Time[0]);
            long min = (hrs * 60) + Convert.ToInt64(Time[1]);
            long sec = (min * 60) + Convert.ToInt64(Time[2]);

            return sec;
        }

        private string GenerateKey(string Token)
        {
            string StaticKeyStirng = "!*@#)($^%1fgv&C=";
            return Parser(StaticKeyStirng, Token);
        }

        private string GenerateIV(string Token)
        {
            string StaticKeyStirng = @"?\:><{}@#Vjekl/4";  // Old AV
                                                           // string StaticKeyStirng = "?\\:><{}@#Vjekl/4";   // New AV
            return Parser(StaticKeyStirng, Token);
        }

        private string Parser(string Key, string Token)
        {
            string StaticKeyString = Key;
            char[] StaticKey = StaticKeyString.ToCharArray();


            string FinalToken = Token.Split('_').Last();
            char[] DynamicKey = FinalToken.ToCharArray();

            List<char> FinalKey = new List<char>();

            foreach (char ch in DynamicKey)
            {
                int index = Convert.ToInt32(ch.ToString());
                FinalKey.Add(StaticKey[index]);
            }
            return new string(FinalKey.ToArray());
        }

        private string DecryptURL(string data, string Key, string IV)
        {
            RijndaelManaged rijndael = new RijndaelManaged();
            System.Text.UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

            rijndael.Mode = CipherMode.CBC;

            rijndael.KeySize = 128;
            rijndael.BlockSize = 128;

            rijndael.Key = Encoding.UTF8.GetBytes(Key);    //Convert.FromBase64String("1234567890123456");
            rijndael.IV = Encoding.UTF8.GetBytes(IV);     // Convert.FromBase64String("1234567890123456");

            ICryptoTransform transform = rijndael.CreateDecryptor();
            byte[] ByteData = Convert.FromBase64String(data);
            byte[] decryptedValue = transform.TransformFinalBlock(ByteData, 0, ByteData.Length);

            return Encoding.UTF8.GetString(decryptedValue);
        }

        private string GetTimeFromSeconds(double seconds)
        {
            string time = "";
            TimeSpan span = TimeSpan.FromSeconds(seconds);
            if (span.Days > 0)
            {
                time += span.Days + "days,  ";
            }
            if (span.Hours > 0)
            {
                time += span.Hours + "hrs, ";
            }
            if (span.Minutes > 0)
            {
                time += span.Minutes + "min, ";
            }

            time += span.Seconds + "sec.";

            return time;
        }

        private void SecurityManager_SecurityNotice(object sender, EventArgs e)
        {

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");

            try
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        resetContentArea();
                        lblInfo.Text = "Suspicious activity has been detected. Please try again later.\n\n" +
                        "This might happen because of one of the following reason.\n" +
                        "1. You might have any screen sharing application open. e.g. Anydesk, TeamViewer etc.\n" +
                        "2. You might have connected any secondary display through HDMI or VGA cable.\n" +
                        "3. You might be having any video recording application open. Screen Recorder Lite. etc.\n\n" +
                        "Please ensure the above points because these are against the rules and regulation.";
                        lblInfo.Font = VideoIDHolder.Font;

                        //lblInfo.Location = new Point((pnInfo.Width - lblInfo.Width) / 2, (pnInfo.Height - lblInfo.Height) / 2);
                        //pnInfo.Show();

                    });
                    return;
                }
            }
            catch (Exception ex)
            {
                ex.ReportException(ex, "Security notice event");
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));
                //Log_File.Write(ex);
                //_logger.Error(ex);
            }
            finally
            {
                ////Log_File.Close();
            }
        }

        void resetContentArea()
        {
            //treeView1.Enabled = false;
            securityManager.StopSecurity();
            webView21.CoreWebView2.Stop();
            webView21.CoreWebView2.Navigate(NavigatingURL);

            watermark.Stop();

            if (PreviousControl != null) PlayerFullScreenClick(null, null);

            Current_Player = 0;


            //pnInfo.Hide();
            
            //pnLoading.Visible = false;
            //pnPlayer.Visible = false;
            //VideoValidityTimer.Enabled = false;
            //TimerValidityUpdate.Enabled = false;
            //VideoValidity.Visible = false;
            //VideoValidity.Text = "";

            SelectedNode = new TreeNode();

            //treeView1.Enabled = true;

            GC.Collect();
        }

        #endregion

        #region Timer Functions

        private void Wait()
        {
            while (!WebReady == true)
                System.Windows.Forms.Application.DoEvents();
        }

        private void Blinker_Tick(object sender, EventArgs e)
        {

        }

        private void VideoValidityTimer_Tick(object sender, EventArgs e)
        {
            string result = Path.GetTempPath();
            ////Log_File = new StreamWriter(result + "\\" + "Text_File.Text");

            if (strated)
            {
                if (remaing_time != "")
                    time_left = remaing_time;
                else
                    time_left = "0";
                //time_left = "150000";

            }
            // var NodeToChange = SelectedNode.Tag as Modals.StreamList;
            try
            {
                if (go_live_counter == -1)
                {
                    if (Convert.ToDouble(time_left) > 0)
                    {
                        strated = false;
                        if (PreviousCurrentTimeOfPlayer != null)
                        {

                            if ((PreviousCurrentTimeOfPlayer != PlayerControls.CurrentTime) && !PlayerControls.IsPlaying)
                            {
                                PreviousCurrentTimeOfPlayer = PlayerControls.CurrentTime;

                                time_left = (Convert.ToDecimal(time_left) - 1).ToString();
                                //VideoValidity.Text = "Time Left: " + GetTimeFromSeconds(Convert.ToDouble(time_left));
                                //VideoValidity.Visible = true;
                                //VideoValidity.Refresh();

                                //Report_Remaining_Time = time_left;
                                //Report_View_Time++;




                                if (TimeToChangeTree >= 0)
                                {
                                    string apend = "\nRemaining Time:  " + GetTimeFromSeconds(Convert.ToDouble(time_left));         //"\nTotal Time:  " + GetTimeFromSeconds(Convert.ToInt32(NodeToChange.playtime)) +
                                                                                                                                    // SelectedNode.Text = NodeToChange.title + apend;
                                    TimeToChangeTree = 0;
                                }
                                else
                                {
                                    TimeToChangeTree += 1;
                                }

                                if (CountSecondsToValidate > TimeToUpdateValidity)
                                {
                                    CountSecondsToValidate = 0;
                                    UpdateVideoValidityFunction();
                                }
                                else
                                {
                                    CountSecondsToValidate += 1;
                                }
                            }
                        }
                        else
                        {
                            PreviousCurrentTimeOfPlayer = PlayerControls.CurrentTime;
                        }
                    }
                    else
                    {
                        UpdateVideoValidityFunction();
                        //VideoValidity.Text = "VOD time is exhausted.";

                        //StatusDisplayer.Visible = true;

                        //VideoValidity.Visible = true;
                        //CourseValidity.Visible = true;

                        resetContentArea();
                        MessageBox.Show("VOD time is exhausted.");
                    }

                }
                else
                {
                    if (PreviousCurrentTimeOfPlayer != null)
                    {

                        if ((PreviousCurrentTimeOfPlayer != PlayerControls.CurrentTime) && !PlayerControls.IsPlaying)
                        {
                            go_live_counter++;
                            //VideoValidity.Text = DateTimeOffset.FromUnixTimeSeconds(go_live_counter).ToString("HH:mm:ss");
                        }
                    }
                    else
                    {
                        PreviousCurrentTimeOfPlayer = PlayerControls.CurrentTime;
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                throw ex;

            }
            finally
            {
                ////Log_File.Close();
            }
        }

        private void TimerValidityUpdate_Tick(object sender, EventArgs e)
        {
            UpdateVideoValidityFunction();
        }

        #endregion

        #region Form Functions

        private void first_Activated(object sender, EventArgs e)
        {
            if (FstRun == true)
            {
                FstRun = false;
                InitAsync();
                Wait();
            }
        }

        private async void InitAsync()
        {
            try
            {
                //MessageBox.Show("InitAsync Started ..");
                CoreWebView2Environment webView2Environment = null;

                string tempDir = Path.GetTempPath();

                //MessageBox.Show("Getting Temp Dir .. " + tempDir);

                CoreWebView2EnvironmentOptions options = null;
                options = new CoreWebView2EnvironmentOptions("--disk-cache-size=200");
                //options = new CoreWebView2EnvironmentOptions("–incognito ");

                //MessageBox.Show("Creating Webview Async Started .. " + tempDir);
                webView2Environment = await CoreWebView2Environment.CreateAsync(null, tempDir, options);
                webView21.Source = null;

                //Settings
                //webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                //webView21.CoreWebView2.Settings.IsZoomControlEnabled = false;
                
                //webView21.CoreWebView2.Settings.IsPinchZoomEnabled = false;
                //webView21.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;

                //MessageBox.Show("Creating Webview Async Created .. " + tempDir);
                await webView21.EnsureCoreWebView2Async(webView2Environment);
                //MessageBox.Show("InitAsync End ..");
            }
            catch (WebView2RuntimeNotFoundException nexp)
            {
                MessageBox.Show("Please Install Microsoft Edge WebVie2 Runtime \n below link \n https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section");
                Application.ExitThread();
            }
            catch(Exception exp)
            {
                MessageBox.Show("InitAsync Error : " + exp);
            }
        }


        private void MainVideo2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("MainVideo2 Load ");
            //JSONContent jSONContent = new JSONContent();
            //pnlLeft.Visible = false;

            
            //pnlRight.Visible = false;
            pnlLeft.Dock = DockStyle.Fill;
           

            TopPanel.Visible = false;
            try
            {
                this.BackColor = System.Drawing.Color.FromArgb(37, 49, 65);

                Inspector inspector = new Inspector();

                string S3_URL = "https://s3.ap-south-1.amazonaws.com/appsquadz.proceum.com/"; ////staging


                string result = Path.GetTempPath();
                string url = "";
                string token = "";
                string LoggedInUser = "";

                if (string.IsNullOrEmpty(PURL))
                {
                    webView21.BackColor = Color.Black;
                    webView21.Visible = true;

                    //Main_Url = "https://proceum.medvizz3d.com/";
                    //Mail URL Setting Here

                    //Development QA
#if DEV_QA
                    Main_Url = DEVELOPMENT_QA;
                    CurrentEnvironment = "Development QA";
#endif

                    //Development Prod
#if DEV_PROD
                    Main_Url = DEVELOPMENT_PROD;
                    CurrentEnvironment = "Development PROD";
#endif
                    //UAT Qa
#if UAT_QA
                    Main_Url = UAT_QA;
                    CurrentEnvironment = "UAT QA";
#endif

                    //UAT Prod
#if UAT_PROD
                    Main_Url = UAT_PROD;
                    CurrentEnvironment = "UAT PROD";
#endif
                }
                else
                {
                    if (PURL.IndexOf("proceuma") > -1)
                    {
                        if (PURL.Split(':').Length > 2)
                        {
                            ProceumStr  = PURL.Split(':')[0];
                            VideoID=PURL.Split(':')[1];
                            UserID = PURL.Split(':')[2];
                            RoleID = PURL.Split(':')[3];
                            TokenStr = PURL.Split(':')[4];

                            

                            AuthenticationToken = PURL.Split(':')[4];
                            JSONContentStr = PURL.Split(':')[5];
                            ContentStr = JSONContentStr.Replace('_', '/');

                            //jSONContent.content_id = 0;
                            //jSONContent.curriculum_id = Convert.ToInt32(JSONContentStr.Split('_')[0]);
                            //jSONContent.is_individual = 0;
                            //jSONContent.level_id = Convert.ToInt32(JSONContentStr.Split('_')[1]);
                            //jSONContent.level_parent_id = Convert.ToInt32(JSONContentStr.Split('_')[2]);

                            URLParseStr = String.Format("Proceum : {0}\n Video ID :{1}\n User ID:{2} \nRole ID :{3}\nToken :{4}", ProceumStr, VideoID, UserID, RoleID, TokenStr);

                            //MessageBox.Show("URL Parse " + URLParseStr);

                        }
                        else
                        {
                            MessageBox.Show("Invalid Parameter: " + PURL);

                            Application.Exit();
                            return;

                            TokenStr = PURL.Split(':')[1];

                            //Get User Id from tokenstr
                            UserID = TokenStr.Split('_')[0];
                            //UserID = PURL.Split(':')[2];

                            //TokenStr = "37_0_7079202295220252";
                            //UserID = "37";
                        }
                    }
                    else
                    {
                        TokenStr = "3_0_9933166671773164";
                        UserID = "1";
                    }
                    //Models.WholeCoursePositiveResponseFromServer1 response = Api_Manager.GetVideolist(UserID).Result;//userid=2 static

                    //Commented only getting link from 02-09-2022 5:00PM
                    //proceuma:3019:2681:eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiMzUwZjFkNTNjMGIwOWZiYzAyNjk2YjdkZjJhMjFkOTIxYTExNjMwZWU3NjcwMDgyNTAyM2FiYTNkNjFmNGY2ZGU3YWU5MzFkOTZhZWI5Y2QiLCJpYXQiOjE2NjE4Njc1NjMuOTE5ODI2LCJuYmYiOjE2NjE4Njc1NjMuOTE5ODMsImV4cCI6MTY5MzQwMzU2My45MTI2NDEsInN1YiI6IjI2ODEiLCJzY29wZXMiOltdfQ.RvoljZeYPQp9rBHw-HRRDh0k6-GKdZi4Y-bYkLcjkombJn02Rphu5oWs4Mq22x2sk4-3-9oRyfzzOMfwUJ5-LlB4vARJ7_JT1Jlm6-TCL3xtTf8ZA0BJ1bfwxGmGIKX8f0MgXntoQuHkdlUpu4nKxsLAgm0Wrhyhxf4LPsug6iYu-6L-Mu2jqATSls1Q88LyKKI8nQfrZXxWdkMTANLkMvk4p6vIdLRDX4BZyffxk3m8wuxogIy4wvEC4Px1um5wANF9WuG5JA7aHAshGHpZ4ndafWhWxbExe5-XSt_JzSCBMVb6ZYYB5SLzflWaL8804B07qZNQFh7bC1Zjwrpb0diA09giwaU08213b51JcP5w6nZRIM0tG7v0tr1Vh6gtqKUkTzobRcni2Fp7M4ePwn7Z3AV2zIpujYtxZPtdbSjil-4zgqOOPmEDlHSUiL-JKUo5JXNzKNG5l95HLqXxAqhU1ZLsOQxt6EUtnsZUFG-RZWxxO-NK7NBDUM5v60RqsB9Gybic7OdC62Bn8TJxjgLjisLg_8Fx0ASAPChV6ikBbPKZ8oAknbQODuLbhYEIh6TxQP_vwgUiQYei32EYRoOkWTpNEnQd5fWXjhA3ZTUy6k32ZNAoxBtdvi4sJ1NkJrkL8NWtKr639TOPeZaNQh1Lcqs31cWQDhFJC5cfyD4:1_3_1107
                    //WholeCoursePositiveResponseFromServer1 RetResponse = new WholeCoursePositiveResponseFromServer1();

                    //MyCurriculumData RetResponseContent = new MyCurriculumData();

                    //RetResponse = Api_Manager.GetVideolistWUserNToken(UserID, TokenStr).Result;//userid=2 static

                    //if (RetResponse.data != null)
                    //{
                    //    //string RetResult = Api_Manager.GetCourses(TokenStr);

                    //    //var GreetingSMessage = await Greetings(Name);
                    //    //var RResult= Api_Manager.GetCourses(UserID, TokenStr);

                    //    var RResult = Api_Manager.GetContentOfVideoById(AuthenticationToken, jSONContent);

                    //    //RetResponse = Api_Manager.GetContentOfVideo(UserID, TokenStr).Result;

                    //    foreach (var VideoInfos in RetResponse.data)
                    //    {
                    //        User_Id = VideoInfos.id;
                    //        title = VideoInfos.title;
                    //        url = VideoInfos.original_video_url;
                    //        video_id = VideoInfos.id;
                    //        token = VideoInfos.token;
                    //        remaing_time = VideoInfos.remaining_time;
                    //        LoggedInUser = VideoInfos.user_name;
                    //        lblTitle.Text = title;
                    //        UserName.Text = LoggedInUser;
                    //    }

                    //    if (!string.IsNullOrEmpty(LoggedInUser))
                    //    {
                    //        UserName.Text = string.Format("Welcome : {0} ", LoggedInUser);
                    //    }
                    //    else
                    //    {
                    //        UserName.Text = "Welcome: Proceum Student";
                    //    }
                    //    UserName.Refresh();
                    //    lblTitle.Refresh();
                    //    //MessageBox.Show("Parameter: " + PURL);
                    //    //var a = response.data.Where(x => x.id == "7").ToList().FirstOrDefault();

                    //    //var a = response.data.Where(x => x.id == UserID).ToList().FirstOrDefault();
                    //    var a = RetResponse.data.FirstOrDefault();

                    //    url = a.original_video_url;
                    //    token = a.token;
                    //}
                    //else
                    //{

                    //    url = "pq/2IOAPnUOFMjgxqM7va6SW7IFEVAs8VNLACh3mQWqO44HpVWAqfeEn7g2RiOf8weF4oLzQZDaeqofpfvspyg==:MTIzNDU2Nzg5MDEyMzQ1Ng==";
                    //    token = "13_0_7862425158029433";
                    //    lblTitle.Text = "Title";
                    //}

                    Current_Player = 1;
                    //pnM3u8.Controls.Clear();
                    //PlayerControls = new Proceum.Customer_cloud.Controls.Player_Controls(false);
                    //PlayerControls.PlayPauseClick += PlayerPlayPauseClick;
                    //PlayerControls.FullScreenClick += PlayerFullScreenClick;
                    //PlayerControls.QualityChanged += PlayerQualityChange;
                    //PlayerControls.SpeedChanged += PlayerSpeedChanged;
                    //PlayerControls.OnProgressChange += PlayerProgressChange;
                    //PlayerControls.OnMediaCurrentTimeChange += PlayerCurrentTimeChange;
                    //PlayerControls.VolumeChange += PlayerVolumeChange;
                    //PlayerControls.Dock = DockStyle.Fill;


                    //pnM3u8.Controls.Add(PlayerControls);
                    //pnM3u8.Dock = DockStyle.Bottom;
                    //pnM3u8.Height = 50;
                    //pnM3u8.Padding = new Padding(0, 0, 0, 10);
                    //pnM3u8.BringToFront();

                    //ClickGrabber = new Proceum.Customer_cloud.Controls.TransparentPanel();
                    //ClickGrabber.Size = this.Size;
                    //ClickGrabber.Location = new Point(0, 0);
                    //ClickGrabber.Opacity = 0;

                    //pnYoutube.Controls.Add(ClickGrabber);

                    //ClickGrabber.BringToFront();

                    //VideoValidity.Visible = true;
                    //CourseValidity.Visible = true;

                    go_live_counter = -1;

                    webView21.BackColor = Color.Black;
                    webView21.Visible = true;


                    //play video code
                    //string VideoURL = DecryptURL(url.Split(':').First(), GenerateKey(token), GenerateIV(token));
                    //string VideoURL = "file_library/videos/vod/674024214070244100_video_VOD.m3u8";
                    //string link = "https://dyfw02p513obs.cloudfront.net/" + VideoURL;
                    //string S3_link = Convert.ToString(S3_URL);
                    //string link = "https://s3.ap-south-1.amazonaws.com/appsquadz.proceum.com/" + VideoURL;
                    //string link = S3_link + VideoURL;
                    //SLogFile.WriteLog("LogFile", String.Format("{0} @ {1}", link, DateTime.Now));

                    //Main URL changes on 04-01-2022
                    //Main_Url = String.Format(Api_Manager.BASE_URL.Replace("index.php/", "") + @"hls/index.php?url={0}", link);

                    //link = S3_link + PURL;
                    //Main_Url = String.Format(Api_Manager.VIDEO_URL.Replace("index.php/", "") + @"hls/index.php?url={0}", link);

                    //Main_Url = link;
                    //Main_Url = "https://proceum.medvizz3d.com/student/curriculum/details/1/3/1107";
                    //Main_Url = "https://proceum.medvizz3d.com/login";

                    ///mobile/windows-details/1/3/1107/eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiMzUwZjFkNTNjMGIwOWZiYzAyNjk2YjdkZjJhMjFkOTIxYTExNjMwZWU3NjcwMDgyNTAyM2FiYTNkNjFmNGY2ZGU3YWU5MzFkOTZhZWI5Y2QiLCJpYXQiOjE2NjE4Njc1NjMuOTE5ODI2LCJuYmYiOjE2NjE4Njc1NjMuOTE5ODMsImV4cCI6MTY5MzQwMzU2My45MTI2NDEsInN1YiI6IjI2ODEiLCJzY29wZXMiOltdfQ.RvoljZeYPQp9rBHw-HRRDh0k6-GKdZi4Y-bYkLcjkombJn02Rphu5oWs4Mq22x2sk4-3-9oRyfzzOMfwUJ5-LlB4vARJ7_JT1Jlm6-TCL3xtTf8ZA0BJ1bfwxGmGIKX8f0MgXntoQuHkdlUpu4nKxsLAgm0Wrhyhxf4LPsug6iYu-6L-Mu2jqATSls1Q88LyKKI8nQfrZXxWdkMTANLkMvk4p6vIdLRDX4BZyffxk3m8wuxogIy4wvEC4Px1um5wANF9WuG5JA7aHAshGHpZ4ndafWhWxbExe5-XSt_JzSCBMVb6ZYYB5SLzflWaL8804B07qZNQFh7bC1Zjwrpb0diA09giwaU08213b51JcP5w6nZRIM0tG7v0tr1Vh6gtqKUkTzobRcni2Fp7M4ePwn7Z3AV2zIpujYtxZPtdbSjil-4zgqOOPmEDlHSUiL-JKUo5JXNzKNG5l95HLqXxAqhU1ZLsOQxt6EUtnsZUFG-RZWxxO-NK7NBDUM5v60RqsB9Gybic7OdC62Bn8TJxjgLjisLg_8Fx0ASAPChV6ikBbPKZ8oAknbQODuLbhYEIh6TxQP_vwgUiQYei32EYRoOkWTpNEnQd5fWXjhA3ZTUy6k32ZNAoxBtdvi4sJ1NkJrkL8NWtKr639TOPeZaNQh1Lcqs31cWQDhFJC5cfyD4/2681/2
                    //This is complete URL just append domain name
                    ///mobile/mob-details/:curriculum_id/:level_id/:level_parent_id/:user_token/:user_id/:role_id
                    //////mobile/mob-details/:curriculum_id/:level_id/:level_parent_id/:user_token/:user_id/:role_id/:video_id
                    Main_Url = string.Format("https://dev.medvizz3d.com/mobile/windows-details/{0}/{1}/{2}/{3}/{4}",ContentStr,AuthenticationToken, UserID,RoleID, VideoID);

                    //MessageBox.Show("Main URL " + Main_Url);
                    //Main_Url = "file:///D:/MdAslam/m3u8/Index.html";

                    //Main_Url = "https://proceum.medvizz3d.com/login";

                    //Main_Url = "https://proceum.medvizz3d.com/student/curriculum/details/1/3/1107";
                }
                try
                {
                    //MessageBox.Show("Navigate Started " + Main_Url);
                    //https://proceum.medvizz3d.com/student/curriculum/details/1/3/1107
                    //webView21.CoreWebView2.Navigate(Main_Url);
                    //webView21.CoreWebView2.OpenDevToolsWindow();

                    //WebViewSettings.IsPinchZoomEnabled = !WebViewSettings.IsPinchZoomEnabled;

                    webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                    webView21.CoreWebView2.Settings.IsZoomControlEnabled = false;

                    //WebBrowserShortcutsEnabled 
                    
                    CurrentEnvironmentStr = string.Format("Current Environment {0} \n URL: {1}",CurrentEnvironment,Main_Url);

                    //MessageBox.Show(CurrentEnvironmentStr);
                    webView21.CoreWebView2.Navigate(Main_Url);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error frmViewContent 1070 : " + exp.ToString());
                }
                Start_date = (Int64)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;

                try
                {
                    //MessageBox.Show("Screen Sharing Disabled Started ..");
                    //Code To prevent Screeenshot of form and screen sharing
                    const uint WDA_MONITOR = 1;
                    //SetWindowDisplayAffinity(this.Handle, WDA_MONITOR);

                    //MessageBox.Show("Screen Sharing Disabled End ..");
                    //MainFormContainer.Height = this.Height - 20;
                    //MainFormContainer.Width = this.Width;

                }
                catch (Exception ex)
                {
                    //_logger.Error(ex);

                    MessageBox.Show("Exception While loading");
                    //Log_File.Write(ex);
                    //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                    //throw ex;

                }
                finally
                {
                    //Log_File.Close();
                    //newfile.Close();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ërror frmViewContent_Load: " + exp.ToString());
            }

            //Call Fullscreen 1548
            //PlayerFullScreenClick(sender, e);
        }


        private void MainVideo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //webView21.Dispose();

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");

            //UpdateVideoValidityFunction();

            //if (_prevForm != null)
            //{
            //    try
            //    {
            //        try
            //        {
            //            Observable.Dispose();
            //            //Client.Dispose();
            //        }
            //        catch (Exception ex)
            //        {
            //            //_logger.Error(ex);

            //            //Log_File.Write(ex);
            //            //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));
            //            ////Log_File.Close();
            //            //throw ex;

            //        }
            //        finally
            //        {
            //            //Log_File.Close();
            //        }

            //        if (!Is_Logging_Off)
            //        {
            //            _prevForm.Dispose();
            //            Application.Exit();
            //        }
            //        //Environment.Exit(0);
            //    }
            //    catch (Exception ex)
            //    {
            //        //_logger.Error(ex);

            //        //Log_File.Write(ex);
            //        //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


            //        //throw ex;

            //    }
            //    finally
            //    {
            //        //Log_File.Close();
            //    }
            //}

            //if (MessageBox.Show("Do you really want to Exit.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //    e.Cancel = false;

            //    //_prevForm.Dispose();
            //    Application.Exit();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}

            if (e.CloseReason == CloseReason.UserClosing)
            {
                //"Do you really want to Exit. A", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                if (MessageBox.Show("Do you really want to Exi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Application.Exit();
                    //Environment.Exit(0)
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel =true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
        #endregion

        #region Video Functions

        private void UpdateVideoValidityFunction()
        {
            //VideoValidity.Text = "Updated " + rgenerator.RandomNumber(5, 100).ToString();
            //VideoValidity.Refresh();
        }



        private async void UpdateVideoTimeToServer(string User_Id, string CourseID, string VideoID, string Total_Time, string Remaining_Time, string token)
        {
            var Response = Api_Manager.UpdateRemainingTimeOfVideo(User_Id, CourseID, VideoID, Total_Time, Remaining_Time, token);


        }

        private void VideoTimeUpdatingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var TimeInfo = e.Argument as RemainingTimeInfo;
            UpdateVideoTimeToServer(TimeInfo.User_Id, TimeInfo.CourseID, TimeInfo.VideoID, TimeInfo.Total_Time, TimeInfo.Remaining_Time, TimeInfo.Token);
        }

        private async void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //throw ex;
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


            }
            finally
            {
                //Log_File.Close();
            }


            UpdateVideoValidityFunction();
            resetContentArea();

            string UserDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ProceumData\HD84JGI839.txt";



            if (File.Exists(UserDataFolder))
            {

            }
            Is_Logging_Off = true;
            Observable.Dispose();
            //Client.Dispose();
            string path = Environment.CurrentDirectory + "\\" + System.AppDomain.CurrentDomain.FriendlyName;
            Process.Start(path);
            _prevForm.Dispose();
            Application.Exit();
        }

        private async void RefreshCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVideoValidityFunction();

        }

        #endregion

        #region Classes

        private class RemainingTimeInfo
        {
            public string User_Id { get; set; }
            public string CourseID { get; set; }
            public string VideoID { get; set; }
            public string Total_Time { get; set; }
            public string Remaining_Time { get; set; }
            public string Token { get; set; }
        }


        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(1, 143, 165); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(1, 143, 165); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(230, 230, 230); }
            }
        }



        #endregion

        #region Picturebox Functions
        private void picClose_Click(object sender, EventArgs e)
        {
            long End_date = (Int64)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;

            string result = Path.GetTempPath();
            //Log_File = new StreamWriter(result + "\\" + "Text_File.Text");

            //Log_File.Close();


            bool IsPlaying = false;
            try
            {
                if (Current_Player == 1)
                {
                    IsPlaying = PlayerControls.IsPlaying;
                    PlayerControls.Pause();
                }
                else if (Current_Player == 2)
                {

                }
            }
            catch (Exception ex)
            {
                //_logger.Error(ex);

                //Log_File.Write(ex);
                //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));

                //throw ex;

            }
            finally
            {
                //Log_File.Close();
            }
            //var Response = Api_Manager.UpdateRemainingTimeOfVideo("2", video_id, Report_View_Time.ToString(), Report_Remaining_Time, Start_date.ToString(), End_date.ToString());//user_id=2 static
            if (MessageBox.Show("Do you really want to Exit. A", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    //if (chattingRoom != null)
                    //{
                    //    chattingRoom.Dispose();
                    //    chattingRoom = null;
                    //}
                }
                catch (Exception ex)
                {
                    //_logger.Error(ex);

                    //Log_File.Write(ex);
                    //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                    //throw ex;

                }
                finally
                {
                    //Log_File.Close();
                }

                //if (labelPerc.Visible == true)
                //{
                //    DownloadedCanceled();
                //}

                // pnChatting.Visible = false;
                //pnInfo.Visible = false;
                //pnPlayer.Visible = false;
                //pnPdf.Visible = false;
                //pnLoading.Visible = true;
                this.Hide();

                //_prevForm.Dispose();
                Application.Exit();
            }
            else
            {
                try
                {
                    if (Current_Player == 1)
                    {
                        if (!IsPlaying) PlayerControls.Play();
                    }
                    else if (Current_Player == 2)
                    {
                        //  if (!IsPlaying) Offline_Video_Player.Ctlcontrols.play();
                    }
                }
                catch (Exception ex)
                {
                    //_logger.Error(ex);

                    //Log_File.Write(ex);
                    //LogFile.WriteLog("LogFile", String.Format("{0} @ {1}", ex, DateTime.Now));


                    //throw ex;

                }
                finally
                {
                    //Log_File.Close();
                }
            }
        }

        #endregion

      
    }
}
