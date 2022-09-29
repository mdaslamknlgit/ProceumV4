using biTsSCommonClasses.ApiModels;
using biTsSCommonClasses.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
using Proceum.Migrations;
using System.Device.Location;
using log4net;
using log4net.Config;


namespace Proceum
{
    static class Program
    {

        public static string CommandParams0 = "";

        public static string CommandParams1 = "";

        public readonly static string salt = "00000000";
       
        public static BrandContext BrandDb { get; set; }
       

        public static GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        public static string authkey = "243958A3wiQavzcuzl5bcdba89";
        public static string senderId = "EDUDRV";

        public static byte[] Key = { 0x00, 0x00, 0x00, 0x00, 0xb8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99 };
        public static byte[] IV = { 0x00, 0x00, 0x00, 0x55, 0x55, 0x55, 0x55, 0x55 };

        public static int ChunkSize = 1024 * 1024;

        public static string userid;


        internal static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommandParams0 = Environment.GetCommandLineArgs()[0];
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                CommandParams1 = Environment.GetCommandLineArgs()[1];
                //MessageBox.Show(CommandParams0 + " \n" + CommandParams1);
            }

            //MessageBox.Show(CommandParams0 +" \n"+ CommandParams1);
            
            //MessageBox.Show("A");
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
#if CUSTOMER
            hasAdministrativeRight = true; //pricipal.IsInRole(WindowsBuiltInRole.Administrator);
#endif
            //MessageBox.Show("B");

            if (!hasAdministrativeRight)
            {
                //MessageBox.Show("C");
                RunElevated(Environment.GetCommandLineArgs()[0]);
                //MessageBox.Show("D");
            }
            else
            {
                try
                {
                    //MessageBox.Show("E");
                    watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

                    BrandDb = new BrandContext();

                    //MessageBox.Show("F");

                }
                catch (Exception ex)
                {
                    ex.ReportException(ex, "Entry Point");
                }

                try
                {

                    //MessageBox.Show("Execute");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    XmlConfigurator.Configure();
                    //MessageBox.Show("G");

                    //Main form runnint
                    //Application.Run(new Customer_cloud.frmViewContent(CommandParams1));

                    //Application.Run(new MainForm(CommandParams1));

                    //MainDesign
                    //Application.Run(new MainDesign(CommandParams1));


                    //MainVideo
                    //Application.Run(new MainVideo(CommandParams1));

                    //MainVideo2
                    Application.Run(new MainVideo2(CommandParams1));


                    //Proceum.Customer_cloud.MessagingTest()

                    //Testing 
                    //Application.Run(new Forms.frmViewContentTest(CommandParams1));


                    //MessageBox.Show("frmViewContent Executed");

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error " + exp.ToString());
                }



            }
        }
        static void RunElevated(string s)
        {
            //MessageBox.Show("Run Elevated");
            ProcessStartInfo p = new ProcessStartInfo
            {
                UseShellExecute=false,
                Verb = "runas",
                FileName = s
            };
            Process.Start(p);
        }

       
    }
}
