﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;




namespace WaterNut.DataSpace.DocumentDS.DataModels
{
	public partial class xcuda_Transit_DestinationDataModel_AutoGen 
	{
        private static readonly xcuda_Transit_DestinationDataModel_AutoGen instance;
        static xcuda_Transit_DestinationDataModel_AutoGen()
        {
            instance = new xcuda_Transit_DestinationDataModel_AutoGen();
        }

        public static  xcuda_Transit_DestinationDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Transit_Destination>> Searchxcuda_Transit_Destination(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Transit_DestinationService())
            {
                return await ctx.Getxcuda_Transit_DestinationByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
