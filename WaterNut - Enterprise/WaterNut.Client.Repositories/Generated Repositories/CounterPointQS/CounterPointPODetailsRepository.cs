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

using CounterPointPODetails = CounterPointQS.Client.Entities.CounterPointPODetails;

namespace CounterPointQS.Client.Repositories 
{
   
    public partial class CounterPointPODetailsRepository : BaseRepository<CounterPointPODetailsRepository>
    {

       private static readonly CounterPointPODetailsRepository instance;
       static CounterPointPODetailsRepository()
        {
            instance = new CounterPointPODetailsRepository();
        }

       public static CounterPointPODetailsRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<CounterPointPODetails>> CounterPointPODetails(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<CounterPointPODetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointPODetailsClient())
                    {
                        var res = await t.GetCounterPointPODetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointPODetails(x)).AsEnumerable();
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

		 public async Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<CounterPointPODetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointPODetailsClient())
                    {
					    IEnumerable<DTO.CounterPointPODetails> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetCounterPointPODetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetCounterPointPODetailsByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointPODetails(x)).AsEnumerable();
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

		 public async Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<CounterPointPODetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointPODetailsClient())
                    {
					    IEnumerable<DTO.CounterPointPODetails> res = null;
                       
                        res = await t.GetCounterPointPODetailsByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointPODetails(x)).AsEnumerable();
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


		 public async Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<CounterPointPODetails>().AsEnumerable();
            try
            {
                using (var t = new CounterPointPODetailsClient())
                    {
					    IEnumerable<DTO.CounterPointPODetails> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetCounterPointPODetails(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetCounterPointPODetailsByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new CounterPointPODetails(x)).AsEnumerable();
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


        public async Task<CounterPointPODetails> GetCounterPointPODetails(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new CounterPointPODetailsClient())
                    {
                        var res = await t.GetCounterPointPODetailsByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new CounterPointPODetails(res);
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

        public async Task<CounterPointPODetails> UpdateCounterPointPODetails(CounterPointPODetails entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new CounterPointPODetailsClient())
                    {
     
                        var updatedEntity =  await t.UpdateCounterPointPODetails(entitychanges).ConfigureAwait(false);
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

        public async Task<CounterPointPODetails> CreateCounterPointPODetails(CounterPointPODetails entity)
        {
            try
            {   
                using (var t = new CounterPointPODetailsClient())
                    {
                        return new CounterPointPODetails(await t.CreateCounterPointPODetails(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
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

        public async Task<bool> DeleteCounterPointPODetails(string id)
        {
            try
            {
             using (var t = new CounterPointPODetailsClient())
                {
                    return await t.DeleteCounterPointPODetails(id).ConfigureAwait(continueOnCapturedContext: false);
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

		public async Task<Tuple<IEnumerable<CounterPointPODetails>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<CounterPointPODetails>, int>(new List<CounterPointPODetails>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new CounterPointPODetailsClient())
                {

                    IEnumerable<DTO.CounterPointPODetails> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<CounterPointPODetails>, int>(res.Select(x => new CounterPointPODetails(x)).AsEnumerable(), overallCount);
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
                using (var t = new CounterPointPODetailsClient())
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
                using (var t = new CounterPointPODetailsClient())
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

