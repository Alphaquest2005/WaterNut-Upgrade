﻿// <autogenerated>
//   This file was generated by T4 code generator AllRepository.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using Core.Common.Client.Services;
using Core.Common.Client.Repositories;
using CounterPointQS.Client.Services;
using CounterPointQS.Client.Entities;
using CounterPointQS.Client.DTO;
using Core.Common.Business.Services;
using System.Diagnostics;


using System.Threading.Tasks;
using System.Linq;
using Core.Common;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.ServiceModel;
using TrackableEntities.Common;

using CounterPointSalesDetails = CounterPointQS.Client.Entities.CounterPointSalesDetails;

namespace CounterPointQS.Client.Repositories 
{
   
    public partial class CounterPointSalesDetailsRepository : BaseRepository<CounterPointSalesDetailsRepository>
    {

       private static readonly CounterPointSalesDetailsRepository instance;
       static CounterPointSalesDetailsRepository()
        {
            instance = new CounterPointSalesDetailsRepository();
        }

       public static CounterPointSalesDetailsRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<CounterPointSalesDetails>> CounterPointSalesDetails(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<CounterPointSalesDetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                    {
                        var res = await t.GetCounterPointSalesDetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointSalesDetails(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

		 public async Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<CounterPointSalesDetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                    {
					    IEnumerable<DTO.CounterPointSalesDetails> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetCounterPointSalesDetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetCounterPointSalesDetailsByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointSalesDetails(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

		 public async Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<CounterPointSalesDetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                    {
					    IEnumerable<DTO.CounterPointSalesDetails> res = null;
                       
                        res = await t.GetCounterPointSalesDetailsByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointSalesDetails(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }


		 public async Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<CounterPointSalesDetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                    {
					    IEnumerable<DTO.CounterPointSalesDetails> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetCounterPointSalesDetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetCounterPointSalesDetailsByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointSalesDetails(x)).AsEnumerable();
                        }
                        else
                        {
                            return null;
                        }                    
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }


        public async Task<CounterPointSalesDetails> GetCounterPointSalesDetails(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new CounterPointSalesDetailsClient())
                    {
                        var res = await t.GetCounterPointSalesDetailsByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new CounterPointSalesDetails(res);
                    }
                    else
                    {
                        return null;
                    }                    
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        public async Task<CounterPointSalesDetails> UpdateCounterPointSalesDetails(CounterPointSalesDetails entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new CounterPointSalesDetailsClient())
                    {
     
                        var updatedEntity =  await t.UpdateCounterPointSalesDetails(entitychanges).ConfigureAwait(false);
                        entity.EntityId = updatedEntity.EntityId;
                        entity.DTO.AcceptChanges();
                         //var  = entity.;
                        //entity.ChangeTracker.MergeChanges(,updatedEntity);
                        //entity. = ;
                        return entity;
                    }
                }
                catch (FaultException<ValidationFault> e)
                {
                    throw new Exception(e.Detail.Message, e.InnerException);
                }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
            }
            else
            {
                return entity;
            }

        }

        public async Task<CounterPointSalesDetails> CreateCounterPointSalesDetails(CounterPointSalesDetails entity)
        {
            try
            {   
                using (var t = new CounterPointSalesDetailsClient())
                    {
                        return new CounterPointSalesDetails(await t.CreateCounterPointSalesDetails(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
                    }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        public async Task<bool> DeleteCounterPointSalesDetails(string id)
        {
            try
            {
             using (var t = new CounterPointSalesDetailsClient())
                {
                    return await t.DeleteCounterPointSalesDetails(id).ConfigureAwait(continueOnCapturedContext: false);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }  
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }         
        }


		//Virtural List Implementation

		public async Task<Tuple<IEnumerable<CounterPointSalesDetails>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<CounterPointSalesDetails>, int>(new List<CounterPointSalesDetails>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                {

                    IEnumerable<DTO.CounterPointSalesDetails> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<CounterPointSalesDetails>, int>(res.Select(x => new CounterPointSalesDetails(x)).AsEnumerable(), overallCount);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }
        }

        
		public decimal SumField(string whereExp, string sumExp)
        {
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                {
                    return t.SumField(whereExp,sumExp);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }

        }

        public async Task<decimal> SumNav(string whereExp, Dictionary<string, string> navExp, string sumExp)
        {
            try
            {
                using (var t = new CounterPointSalesDetailsClient())
                {
                    return await t.SumNav(whereExp,navExp,sumExp).ConfigureAwait(false);
                }
            }
            catch (FaultException<ValidationFault> e)
            {
                throw new Exception(e.Detail.Message, e.InnerException);
            }
            catch (Exception)
            {
                Debugger.Break();
                throw;
            }

        }
    }
}

