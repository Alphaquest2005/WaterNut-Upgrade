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
using AllocationDS.Business.Entities;
using AllocationDS.Business.Services;




namespace WaterNut.DataSpace.AllocationDS.DataModels
{
	public partial class xcuda_HScodeDataModel_AutoGen 
	{
        private static readonly xcuda_HScodeDataModel_AutoGen instance;
        static xcuda_HScodeDataModel_AutoGen()
        {
            instance = new xcuda_HScodeDataModel_AutoGen();
        }

        public static  xcuda_HScodeDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_HScode>> Searchxcuda_HScode(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_HScodeService())
            {
                return await ctx.Getxcuda_HScodeByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
