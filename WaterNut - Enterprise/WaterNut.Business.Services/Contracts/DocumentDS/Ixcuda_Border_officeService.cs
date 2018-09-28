﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;

using Core.Common.Contracts;
using DocumentDS.Business.Entities;
using Core.Common.Business.Services;
using WaterNut.Interfaces;

namespace DocumentDS.Business.Services
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface Ixcuda_Border_officeService : IBusinessService
    {
        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_office(List<string> includesLst = null, bool tracking = true);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<xcuda_Border_office> Getxcuda_Border_officeByKey(string id, List<string> includesLst = null, bool tracking = true);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByExpression(string exp, List<string> includesLst = null, bool tracking = true);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByExpressionLst(List<string> expLst, List<string> includesLst = null, bool tracking = true);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
		Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByExpressionNav(string exp,
            Dictionary<string, string> navExp, List<string> includesLst = null, bool tracking = true);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByBatch(string exp,
            int totalrow, List<string> includesLst = null, bool tracking = true);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByBatchExpressionLst(List<string> exp,
            int totalrow, List<string> includesLst = null, bool tracking = true);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<xcuda_Border_office> Updatexcuda_Border_office(xcuda_Border_office entity);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<xcuda_Border_office> Createxcuda_Border_office(xcuda_Border_office entity);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<bool> Deletexcuda_Border_office(string id);
	
		//Virtural list implementation
        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<int> Count(string exp);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> LoadRange(int startIndex, int count, string exp);



		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
		Task<IEnumerable<xcuda_Border_office>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
        [FaultContract(typeof(ValidationFault))]
		string MinField(string whereExp, string field);

				[OperationContract]
        [FaultContract(typeof(ValidationFault))]
        Task<IEnumerable<xcuda_Border_office>> Getxcuda_Border_officeByTransport_Id(string Transport_Id, List<string> includesLst = null);
  



    }
}

