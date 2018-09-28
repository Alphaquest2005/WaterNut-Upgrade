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
	public partial class xcuda_Financial_AmountsDataModel_AutoGen 
	{
        private static readonly xcuda_Financial_AmountsDataModel_AutoGen instance;
        static xcuda_Financial_AmountsDataModel_AutoGen()
        {
            instance = new xcuda_Financial_AmountsDataModel_AutoGen();
        }

        public static  xcuda_Financial_AmountsDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Financial_Amounts>> Searchxcuda_Financial_Amounts(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Financial_AmountsService())
            {
                return await ctx.Getxcuda_Financial_AmountsByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
