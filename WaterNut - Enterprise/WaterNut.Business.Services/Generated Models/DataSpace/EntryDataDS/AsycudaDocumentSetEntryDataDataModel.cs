﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using EntryDataDS.Business.Entities;
using EntryDataDS.Business.Services;




namespace WaterNut.DataSpace.EntryDataDS.DataModels
{
	public partial class AsycudaDocumentSetEntryDataDataModel_AutoGen 
	{
        private static readonly AsycudaDocumentSetEntryDataDataModel_AutoGen instance;
        static AsycudaDocumentSetEntryDataDataModel_AutoGen()
        {
            instance = new AsycudaDocumentSetEntryDataDataModel_AutoGen();
        }

        public static  AsycudaDocumentSetEntryDataDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<AsycudaDocumentSetEntryData>> SearchAsycudaDocumentSetEntryData(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new AsycudaDocumentSetEntryDataService())
            {
                return await ctx.GetAsycudaDocumentSetEntryDataByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
