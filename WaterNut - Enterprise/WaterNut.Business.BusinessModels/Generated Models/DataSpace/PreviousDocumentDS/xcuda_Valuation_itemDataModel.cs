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
using PreviousDocumentDS.Business.Entities;
using PreviousDocumentDS.Business.Services;




namespace WaterNut.DataSpace.PreviousDocumentDS.DataModels
{
	public partial class xcuda_Valuation_itemDataModel_AutoGen 
	{
        private static readonly xcuda_Valuation_itemDataModel_AutoGen instance;
        static xcuda_Valuation_itemDataModel_AutoGen()
        {
            instance = new xcuda_Valuation_itemDataModel_AutoGen();
        }

        public static  xcuda_Valuation_itemDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Valuation_item>> Searchxcuda_Valuation_item(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Valuation_itemService())
            {
                return await ctx.Getxcuda_Valuation_itemByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
