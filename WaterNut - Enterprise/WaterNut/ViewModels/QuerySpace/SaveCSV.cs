﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CoreEntities.Client.Entities;
using EntryDataQS.Client.Repositories;
using Microsoft.Win32;

namespace WaterNut.QuerySpace
{
   public class SaveCSV
    {
        private static readonly SaveCSV instance;
        static SaveCSV()
        {
            instance = new SaveCSV();

        }

        public static SaveCSV Instance
        {
            get { return instance; }
        }

       public async Task SaveCSVFile(string fileType, AsycudaDocumentSetEx docSet)
        {
            //import asycuda xml id and details
            var od = new OpenFileDialog();
            od.Title = "Import Entry Data";
            od.DefaultExt = ".csv";
            od.Filter = "CSV Files (.csv)|*.csv|TXT Files (.txt)|*.txt";
            od.Multiselect = true;
            var result = od.ShowDialog();
            if (result == true)
            {
                bool overwrite = false;
                var res =
                    MessageBox.Show(
                        "Do you want to Over Write Existing Items?, Click Yes to Replace or No to Skip or Cancel to Stop.",
                        "Existing Item Found", MessageBoxButton.YesNoCancel);
                switch (res)
                {
                    case MessageBoxResult.Yes:
                        overwrite = true;
                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        return;
                }

                foreach (var f in od.FileNames)
                {
                    if (f.EndsWith(".csv"))
                    {
                        await
                            EntryDataExRepository.Instance.SaveCSV(f, fileType, docSet.AsycudaDocumentSetId, overwrite)
                                .ConfigureAwait(false);
                    }
                    if (f.EndsWith(".pdf"))
                    {
                        await
                            EntryDataExRepository.Instance.SavePDF(f, fileType, docSet.AsycudaDocumentSetId, overwrite)
                                .ConfigureAwait(false);
                    }
                    if (f.EndsWith(".txt"))
                    {
                        await
                            EntryDataExRepository.Instance.SaveTXT(f, fileType, docSet.AsycudaDocumentSetId, overwrite)
                                .ConfigureAwait(false);
                    }
                }


                MessageBox.Show("Complete");

            }
        }
    }
}
