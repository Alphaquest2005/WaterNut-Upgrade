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

using EntryDataDetailsEx = InventoryQS.Client.Entities.EntryDataDetailsEx;

namespace InventoryQS.Client.Repositories 
{
   
    public partial class EntryDataDetailsExRepository : BaseRepository<EntryDataDetailsExRepository>
    {

       private static readonly EntryDataDetailsExRepository instance;
       static EntryDataDetailsExRepository()
        {
            instance = new EntryDataDetailsExRepository();
        }

       public static EntryDataDetailsExRepository Instance
        {
            get { return instance; }
        }
        
        public async Task<IEnumerable<EntryDataDetailsEx>> EntryDataDetailsEx(List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return new List<EntryDataDetailsEx>().AsEnumerable();
            try
            {
                using (var t = new EntryDataDetailsExClient())
                    {
                        var res = await t.GetEntryDataDetailsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);
                        if (res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<EntryDataDetailsEx>> GetEntryDataDetailsExByExpression(string exp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<EntryDataDetailsEx>().AsEnumerable();
            try
            {
                using (var t = new EntryDataDetailsExClient())
                    {
					    IEnumerable<DTO.EntryDataDetailsEx> res = null;
                        if(exp == "All")
                        {                       
						    res = await t.GetEntryDataDetailsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetEntryDataDetailsExByExpression(exp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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

		 public async Task<IEnumerable<EntryDataDetailsEx>> GetEntryDataDetailsExByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || expLst.Count == 0 || expLst.FirstOrDefault() == "None") return new List<EntryDataDetailsEx>().AsEnumerable();
            try
            {
                using (var t = new EntryDataDetailsExClient())
                    {
					    IEnumerable<DTO.EntryDataDetailsEx> res = null;
                       
                        res = await t.GetEntryDataDetailsExByExpressionLst(expLst, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                      
                    
                        if (res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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


		 public async Task<IEnumerable<EntryDataDetailsEx>> GetEntryDataDetailsExByExpressionNav(string exp, Dictionary<string, string> navExp, List<string> includesLst = null)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None") return new List<EntryDataDetailsEx>().AsEnumerable();
            try
            {
                using (var t = new EntryDataDetailsExClient())
                    {
					    IEnumerable<DTO.EntryDataDetailsEx> res = null;
                        if(exp == "All" && navExp.Count == 0)
                        {                       
						    res = await t.GetEntryDataDetailsEx(includesLst).ConfigureAwait(continueOnCapturedContext: false);					
                        }
                        else
                        {
                             res = await t.GetEntryDataDetailsExByExpressionNav(exp, navExp, includesLst).ConfigureAwait(continueOnCapturedContext: false);	                         
                        }
                    
                        if (res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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


        public async Task<EntryDataDetailsEx> GetEntryDataDetailsEx(string id, List<string> includesLst = null)
        {
             try
             {   
                 using (var t = new EntryDataDetailsExClient())
                    {
                        var res = await t.GetEntryDataDetailsExByKey(id,includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return new EntryDataDetailsEx(res)
                    {
                  // InventoryItemsEx = (res.InventoryItemsEx != null?new InventoryItemsEx(res.InventoryItemsEx): null)    
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

        public async Task<EntryDataDetailsEx> UpdateEntryDataDetailsEx(EntryDataDetailsEx entity)
        {
            if (entity == null) return entity;
            var entitychanges = entity.ChangeTracker.GetChanges().FirstOrDefault();
            if (entitychanges != null)
            {
                try
                {
                    using (var t = new EntryDataDetailsExClient())
                    {
     
                        var updatedEntity =  await t.UpdateEntryDataDetailsEx(entitychanges).ConfigureAwait(false);
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

        public async Task<EntryDataDetailsEx> CreateEntryDataDetailsEx(EntryDataDetailsEx entity)
        {
            try
            {   
                using (var t = new EntryDataDetailsExClient())
                    {
                        return new EntryDataDetailsEx(await t.CreateEntryDataDetailsEx(entity.DTO).ConfigureAwait(continueOnCapturedContext: false));
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

        public async Task<bool> DeleteEntryDataDetailsEx(string id)
        {
            try
            {
             using (var t = new EntryDataDetailsExClient())
                {
                    return await t.DeleteEntryDataDetailsEx(id).ConfigureAwait(continueOnCapturedContext: false);
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

		public async Task<Tuple<IEnumerable<EntryDataDetailsEx>, int>> LoadRange(int startIndex, int count, string exp, Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
			var overallCount = 0;
            if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime || exp == null || exp == "None")
            {
                
                return new Tuple<IEnumerable<EntryDataDetailsEx>, int>(new List<EntryDataDetailsEx>().AsEnumerable(), overallCount);
            }
            
            try
            {
                using (var t = new EntryDataDetailsExClient())
                {

                    IEnumerable<DTO.EntryDataDetailsEx> res = null;
                                         
						    res = await t.LoadRangeNav(startIndex, count, exp, navExp, includeLst).ConfigureAwait(continueOnCapturedContext: false);
						    overallCount = await t.CountNav(exp, navExp).ConfigureAwait(continueOnCapturedContext: false);
                   
                   
                                
                    if (res != null)
                    {
                        return new Tuple<IEnumerable<EntryDataDetailsEx>, int>(res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable(), overallCount);
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

	 public async Task<IEnumerable<EntryDataDetailsEx>> GetEntryDataDetailsExByEntryDataId(string EntryDataId, List<string> includesLst = null)
        {
             if (EntryDataId == "0") return null;
            try
            {
                 using (EntryDataDetailsExClient t = new EntryDataDetailsExClient())
                    {
                        var res = await t.GetEntryDataDetailsExByEntryDataId(EntryDataId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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
 	 public async Task<IEnumerable<EntryDataDetailsEx>> GetEntryDataDetailsExByAsycudaDocumentSetId(string AsycudaDocumentSetId, List<string> includesLst = null)
        {
             if (AsycudaDocumentSetId == "0") return null;
            try
            {
                 using (EntryDataDetailsExClient t = new EntryDataDetailsExClient())
                    {
                        var res = await t.GetEntryDataDetailsExByAsycudaDocumentSetId(AsycudaDocumentSetId, includesLst).ConfigureAwait(continueOnCapturedContext: false);
                         if(res != null)
                        {
                            return res.Select(x => new EntryDataDetailsEx(x)).AsEnumerable();
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
                using (var t = new EntryDataDetailsExClient())
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
                using (var t = new EntryDataDetailsExClient())
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

