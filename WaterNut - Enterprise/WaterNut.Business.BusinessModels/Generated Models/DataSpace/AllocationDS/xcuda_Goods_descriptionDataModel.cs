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
	public partial class xcuda_Goods_descriptionDataModel_AutoGen 
	{
        private static readonly xcuda_Goods_descriptionDataModel_AutoGen instance;
        static xcuda_Goods_descriptionDataModel_AutoGen()
        {
            instance = new xcuda_Goods_descriptionDataModel_AutoGen();
        }

        public static  xcuda_Goods_descriptionDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Goods_description>> Searchxcuda_Goods_description(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Goods_descriptionService())
            {
                return await ctx.Getxcuda_Goods_descriptionByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
