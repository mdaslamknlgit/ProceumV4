using biTsSCommonClasses.ApiModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;

namespace Proceum
{
    class BrandContext
    {
        string dataDir = "";
        string datafilename = "company.dll";
        string parse = "ks7d8jfn$dfj#vdkf*df14";

        public BrandContext()
        {
           
            Company = null;

            //Testing Purpose
            //Company company = new Company();
            //company.Amazon_AccessKeyName = "AccessKeyName";
            //company.Amazon_BucketName = "BucketName";

            //Company = company;

            dataDir = Environment.CurrentDirectory;

            //MessageBox.Show("Directory :" + dataDir);
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
            }
            //MessageBox.Show("Load");
            Load();

            //Save();
            //MessageBox.Show("Loaded");
        }

        
        public Company Company { get; set; }
        

        public void Save()
        {
            try
            {
                using (FileStream fs = new FileStream(dataDir +"\\" +datafilename, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, this.Company);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ReportException(ex, "Saving Data");
            }
        }


        void Load()
        {
            if (System.IO.File.Exists(dataDir + "\\" + datafilename))
            {
                try
                {
                    //MessageBox.Show("Load File Stream : " + dataDir + "\\" + datafilename);
                    using (FileStream fs = new FileStream(dataDir + "\\" + datafilename, FileMode.Open,FileAccess.Read))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        this.Company = (Company)bf.Deserialize(fs);
                        fs.Close();
                    }

                }
                catch (Exception ex)
                {
                   // System.Windows.Forms.MessageBox.Show(ex.Message);
                    ex.ReportException(ex, "Load Data");
                    //MessageBox.Show("Load Function Error : " + ex.ToString());
                }
            }        
        }


        internal void Delete()
        {
            try
            {
                if (File.Exists(dataDir + "\\" + datafilename))
                {
                    File.Delete(dataDir + "\\" + datafilename);
                }
            }
            catch (Exception ex)
            {
                ex.ReportException(ex, "Delete drive data file");
            }
        }
    }

}
