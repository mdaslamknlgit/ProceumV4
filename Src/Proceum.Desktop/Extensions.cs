using biTsSCommonClasses.Models;
//using Proceum.Models;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
//using biTsSCommonClasses.ApiModels.Enums;

namespace Proceum
{
    static class Extensions
    {
        delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        public static void SetControlPropertyThreadSafe(this Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }
        public static void ReportException(this Object obj, object exception, string remarks)
        {
            List<ExceptionDetail> exceptions = getExceptions();
            if (exceptions == null)
                exceptions = new List<ExceptionDetail>();

            ExceptionDetail ex = new ExceptionDetail
            {
                Exception = exception,
                Datetime = DateTime.Now,
                Remarks = remarks
            };
            exceptions.Add(ex);

            saveExceptions(exceptions);
        }
        static List<ExceptionDetail> getExceptions()
        {
            List<ExceptionDetail> exceptions = null;
            try
            {
                string filename = Environment.CurrentDirectory + "\\error.log";
                if (File.Exists(filename))
                {
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        object obj = bf.Deserialize(fs);
                        exceptions = (List<ExceptionDetail>)obj;
                        fs.Close();
                    }

                }
            }
            catch { }
            return exceptions;
        }

        static void saveExceptions(List<ExceptionDetail> exceptions)
        {
            try
            {
                string filename = Environment.CurrentDirectory + "\\error.log";

                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, exceptions);
                    fs.Close();


                }
            }
            catch //(Exception ex)
            {

            }
        }

        public static string CalculateMD5Checksum(this FileInfo file)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(file.FullName))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            catch { return ""; }
        }

        


        public static void SetStyle(this IContainer container, MetroForm ownerForm, biTsSCommonClasses.ApiModels.Enums.ClientColorTheme colortheme, biTsSCommonClasses.ApiModels.Enums.ClientTheme theme)
        {
            MetroColorStyle colorStyle;
            MetroThemeStyle themeStyle;

            switch (colortheme)
            {
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Red:
                    colorStyle = MetroColorStyle.Red;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Blue:
                    colorStyle = MetroColorStyle.Blue;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Yellow:
                    colorStyle = MetroColorStyle.Yellow;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Green:
                    colorStyle = MetroColorStyle.Green;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.White:
                    colorStyle = MetroColorStyle.White;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Orange:
                    colorStyle = MetroColorStyle.Orange;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Teal:
                    colorStyle = MetroColorStyle.Teal;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Brown:
                    colorStyle = MetroColorStyle.Brown;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Lime:
                    colorStyle = MetroColorStyle.Lime;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Silver:
                    colorStyle = MetroColorStyle.Silver;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientColorTheme.Black:
                    colorStyle = MetroColorStyle.Black;
                    break;
                default:
                    colorStyle = MetroColorStyle.Default;
                    break;
            }

            switch (theme)
            {
                case biTsSCommonClasses.ApiModels.Enums.ClientTheme.Dark:
                    themeStyle = MetroThemeStyle.Dark;
                    break;
                case biTsSCommonClasses.ApiModels.Enums.ClientTheme.Light:
                    themeStyle = MetroThemeStyle.Light;
                    break;
                default:
                    themeStyle = MetroThemeStyle.Default;
                    break;
            }

            if (container == null)
            {
                container = new System.ComponentModel.Container();
            }
            var manager = new MetroFramework.Components.MetroStyleManager(container);
            manager.Owner = ownerForm;
            container.SetDefaultTheme(ownerForm, themeStyle);
            container.SetDefaultStyle(ownerForm, colorStyle);
        }
        private static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }
        private static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle thme)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = thme;
        }
        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
            {
                if (item is MetroStyleManager)
                {
                    if (((MetroStyleManager)item).Owner == owner)
                    {
                        manager = (MetroStyleManager)item;
                    }
                }
            }
            return manager;
        }


        [DllImport("Psapi.dll", CharSet = CharSet.Unicode)]
        private static extern uint GetProcessImageFileName([In] IntPtr hProcess, [Out] StringBuilder lpImageFileName, [In] uint nSize);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern uint QueryDosDevice([In] string lpDeviceName, [Out] StringBuilder lpTargetPath, [In] int ucchMax);

        public static string GetMainModuleFileName(this Process process, int buffer = 1024)
        {
            var devicePathBuilder = new StringBuilder(buffer);
            if (GetProcessImageFileName(process.Handle, devicePathBuilder, (uint)devicePathBuilder.Capacity + 1) == 0)
            {
                return null;
            }

            string devicePath = devicePathBuilder.ToString();
            var drive = Array.Find(DriveInfo.GetDrives(), d => devicePath.StartsWith(d.GetDevicePath(), StringComparison.InvariantCultureIgnoreCase));

            return drive != null ?
                devicePath.ReplaceFirst(drive.GetDevicePath(), drive.GetDriveLetter()) :
                null;
        }

        private static string GetDevicePath(this DriveInfo driveInfo)
        {
            var devicePathBuilder = new StringBuilder(128);
            return QueryDosDevice(driveInfo.GetDriveLetter(), devicePathBuilder, devicePathBuilder.Capacity + 1) != 0 ?
                devicePathBuilder.ToString() :
                null;
        }

        private static string GetDriveLetter(this DriveInfo driveInfo)
        {
            return driveInfo.Name.Substring(0, 2);
        }

        private static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public static int? ParseAsInteger(this object obj)
        {
          
            if (obj != null)
            {
                if (!string.IsNullOrWhiteSpace(obj.ToString()))
                {
                    int val;
                    if(int.TryParse(obj.ToString(), out val))
                    {
                        return val;
                    }
                }
            }

            return null;
        }
    }
}
