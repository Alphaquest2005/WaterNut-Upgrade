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
	public partial class xcuda_TaxationDataModel_AutoGen 
	{
        private static readonly xcuda_TaxationDataModel_AutoGen instance;
        static xcuda_TaxationDataModel_AutoGen()
        {
            instance = new xcuda_TaxationDataModel_AutoGen();
        }

        public static  xcuda_TaxationDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Taxation>> Searchxcuda_Taxation(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_TaxationService())
            {
                return await ctx.Getxcuda_TaxationByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
