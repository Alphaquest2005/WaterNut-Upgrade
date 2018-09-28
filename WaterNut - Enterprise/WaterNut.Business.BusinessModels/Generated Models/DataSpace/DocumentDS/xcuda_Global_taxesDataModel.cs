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
using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;




namespace WaterNut.DataSpace.DocumentDS.DataModels
{
	public partial class xcuda_Global_taxesDataModel_AutoGen 
	{
        private static readonly xcuda_Global_taxesDataModel_AutoGen instance;
        static xcuda_Global_taxesDataModel_AutoGen()
        {
            instance = new xcuda_Global_taxesDataModel_AutoGen();
        }

        public static  xcuda_Global_taxesDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Global_taxes>> Searchxcuda_Global_taxes(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Global_taxesService())
            {
                return await ctx.Getxcuda_Global_taxesByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
