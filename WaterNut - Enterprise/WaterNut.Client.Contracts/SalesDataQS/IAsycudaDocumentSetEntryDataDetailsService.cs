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
    public partial interface IAsycudaDocumentSetEntryDataDetailsService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetails(List<string> includesLst = null);

        [OperationContract]
        Task<AsycudaDocumentSetEntryDataDetails> GetAsycudaDocumentSetEntryDataDetailsByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<AsycudaDocumentSetEntryDataDetails> UpdateAsycudaDocumentSetEntryDataDetails(AsycudaDocumentSetEntryDataDetails entity);

        [OperationContract]
        Task<AsycudaDocumentSetEntryDataDetails> CreateAsycudaDocumentSetEntryDataDetails(AsycudaDocumentSetEntryDataDetails entity);

        [OperationContract]
        Task<bool> DeleteAsycudaDocumentSetEntryDataDetails(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetails>> GetAsycudaDocumentSetEntryDataDetailsById(string Id, List<string> includesLst = null);
        
  		
    }
}

