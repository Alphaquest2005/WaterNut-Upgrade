﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleMvvmToolkit;
using TrackableEntities;
using System;
using DocumentItemDS.Business.Entities;
using DocumentItemDS.Business.Services;




namespace WaterNut.DataSpace.DocumentItemDS.DataModels
{
	public partial class xcuda_Attached_documentsDataModel_AutoGen 
	{
        private static readonly xcuda_Attached_documentsDataModel_AutoGen instance;
        static xcuda_Attached_documentsDataModel_AutoGen()
        {
            instance = new xcuda_Attached_documentsDataModel_AutoGen();
        }

        public static  xcuda_Attached_documentsDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Attached_documents>> Searchxcuda_Attached_documents(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Attached_documentsService())
            {
                return await ctx.Getxcuda_Attached_documentsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
