﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using SalesDataQS.Client.DTO;
using TrackableEntities.Client;



namespace SalesDataQS.Client.Entities
{

    public partial class SalesData 
    {
       public SalesData()
        {
            this.DTO = new DTO.SalesData();//{TrackingState = TrackableEntities.TrackingState.Added}
            _changeTracker = new ChangeTrackingCollection<DTO.SalesData>(this.DTO);

            CustomClassStartUp();
            MyNavPropStartUp();
            IIdentifiableEntityStartUp();
            AutoGenStartUp();
        }
    partial void CustomClassStartUp();
    partial void AutoGenStartUp();
    partial void MyNavPropStartUp();
    partial void IIdentifiableEntityStartUp();
   
    }
}
		