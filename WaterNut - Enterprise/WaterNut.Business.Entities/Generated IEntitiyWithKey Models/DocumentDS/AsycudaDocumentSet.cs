﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace DocumentDS.Business.Entities
{
    public partial class AsycudaDocumentSet: IEntityWithKey
    {
    #region "IEntityWithKey Implementation"

	[IgnoreDataMember]
    [JsonIgnore]
	public EntityKey EntityKey
	{
		get
		{
			return _entityKey;
		}
		set
		{
			if (_entityKey != value)
			{
				_entityKey = value;				
			}
		}
	}
	private EntityKey _entityKey;
#endregion
    }
   
}
