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
using InventoryQS.Client.Services;
using InventoryQS.Client.Entities;
using InventoryQS.Client.DTO;
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

using InventoryItemsEx = InventoryQS.Client.Entities.InventoryItemsEx;

namespace InventoryQS.Client.Repositories 
{
   
    public partial class InventoryItemsExRepository : BaseRepository<InventoryItemsExRepository>
    {

       private static readonly InventoryItemsExRepository instance;
       static InventoryItemsExRepository()
        {
            instance = new InventoryItemsExRepository();
        }

       public static InventoryItemsExRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<InventoryItemsEx>> InventoryItemsEx(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<InventoryItemsEx>().AsEnumerable();
            try
            {
                using (var t = new InventoryItemsExClient())
                    {
                        var res = await t.GetInventoryItemsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new InventoryItemsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<InventoryItemsEx>> GetInventoryItemsExByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<InventoryItemsEx>().AsEnumerable();
            try
            {
                using (var t = new InventoryItemsExClient())
                    {
					    IEnumerable<DTO.InventoryItemsEx> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetInventoryItemsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetInventoryItemsExByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new InventoryItemsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<InventoryItemsEx>> GetInventoryItemsExByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<InventoryItemsEx>().AsEnumerable();
            try
            {
                using (var t = new InventoryItemsExClient())
                    {
					    IEnumerable<DTO.InventoryItemsEx> res = null;
                       
                        res = await t.GetInventoryItemsExByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new InventoryItemsEx(x)).AsEnumerable();
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


		 public async Task<IEnumerable<InventoryItemsEx>> GetInventoryItemsExByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<InventoryItemsEx>().AsEnumerable();
            try
            {
                using (var t = new InventoryItemsExClient())
                    {
					    IEnumerable<DTO.InventoryItemsEx> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetInventoryItemsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetInventoryItemsExByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new InventoryItemsEx(x)).AsEnumerable();
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


        public async Task<InventoryItemsEx> GetInventoryItemsEx(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new InventoryItemsExClient())
                    {
                        var res = await t.GetInventoryItemsExByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new InventoryItemsEx(res)
                    {
                  // TariffCodes = (res.TariffCodes != null?new TariffCodes(res.TariffCodes): null),    
                     // EntryDataDetailsEx = new System.Collections.ObjectModel.ObservableCollection<EntryDataDetailsEx>(res.EntryDataDetailsEx.Select(y => new EntryDataDetailsEx(y)))    
                  };
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

        public async Task<InventoryItemsEx> UpdateInventoryItemsEx(InventoryItemsEx entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new InventoryItemsExClient())
                    {
     
                        var updatedEntity =  await t.UpdateInventoryItemsEx(entitychanges).ConfigureAwait(false);
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

        public async Task<InventoryItemsEx> CreateInventoryItemsEx(InventoryItemsEx entity)
        {
            try
            {   
                using (var t = new InventoryItemsExClient())
                    {
                        return new InventoryItemsEx(await t.CreateInventoryItemsEx(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
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

        public async Task<bool> DeleteInventoryItemsEx(string id)
        {
            try
            {
             using (var t = new InventoryItemsExClient())
                {
                    return await t.DeleteInventoryItemsEx(id).ConfigureAwait(continueOnCapturedContext: false);
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

		public async Task<Tuple<IEnumerable<InventoryItemsEx>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<InventoryItemsEx>, int>(new List<InventoryItemsEx>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new InventoryItemsExClient())
                {

                    IEnumerable<DTO.InventoryItemsEx> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<InventoryItemsEx>, int>(res.Select(x => new InventoryItemsEx(x)).AsEnumerable(), overallCount);
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
                using (var t = new InventoryItemsExClient())
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
                using (var t = new InventoryItemsExClient())
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

