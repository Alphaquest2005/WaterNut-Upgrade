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
using OversShortQS.Client.DTO;


namespace OversShortQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface IOverShortDetailService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<OverShortDetail>> GetOverShortDetails(List<string> includesLst = null);

        [OperationContract]
        Task<OverShortDetail> GetOverShortDetailByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<OverShortDetail>> GetOverShortDetailsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<OverShortDetail>> GetOverShortDetailsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<OverShortDetail>> GetOverShortDetailsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<OverShortDetail>> GetOverShortDetailsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<OverShortDetail>> GetOverShortDetailsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<OverShortDetail> UpdateOverShortDetail(OverShortDetail entity);

        [OperationContract]
        Task<OverShortDetail> CreateOverShortDetail(OverShortDetail entity);

        [OperationContract]
        Task<bool> DeleteOverShortDetail(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<OverShortDetail>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<OverShortDetail>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<OverShortDetail>> GetOverShortDetailByOversShortsId(string OversShortsId, List<string> includesLst = null);
        
  		
    }
}

