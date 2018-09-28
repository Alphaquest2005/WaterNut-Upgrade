﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Core.Common.Contracts;
using SalesDataQS.Client.DTO;


namespace SalesDataQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface ISalesDataAllocationsService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocations(List<string> includesLst = null);

        [OperationContract]
        Task<SalesDataAllocations> GetSalesDataAllocationsByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocationsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocationsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocationsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocationsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<SalesDataAllocations>> GetSalesDataAllocationsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<SalesDataAllocations> UpdateSalesDataAllocations(SalesDataAllocations entity);

        [OperationContract]
        Task<SalesDataAllocations> CreateSalesDataAllocations(SalesDataAllocations entity);

        [OperationContract]
        Task<bool> DeleteSalesDataAllocations(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<SalesDataAllocations>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<SalesDataAllocations>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				
    }
}

