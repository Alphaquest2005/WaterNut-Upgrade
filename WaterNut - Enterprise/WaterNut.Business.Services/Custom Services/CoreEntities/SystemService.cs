﻿using System;
using System.ComponentModel.Composition;
using System.ServiceModel;
using AllocationQS.Business.Services;
using Core.Common.Business.Services;
using Core.Common.Contracts;



namespace CoreEntities.Business.Services
{
    [Export(typeof(IAsycudaSalesAllocationsExService))]
    [Export(typeof(IBusinessService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
                     ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class SystemService : ISystemService, IDisposable
    {

        public bool ValidateInstallation()
        {
            try
            {
                RunCmd("sqllocaldb stop mssqllocaldb");
                RunCmd("sqllocaldb delete mssqllocaldb");
                RunCmd("sqllocaldb start \"MSSQLLocalDB\"");
                return WaterNut.DataSpace.BaseDataModel.Instance.ValidateInstallation();
            }
            catch (Exception e)
            {
                var ex = e;
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }

                if (ex.Message.Contains("Login failed for user"))
                {
                    RunCmd("sqllocaldb stop mssqllocaldb");
                    RunCmd("sqllocaldb delete mssqllocaldb");
                    RunCmd("sqllocaldb start \"MSSQLLocalDB\"");
                   
                }
                var fault = new ValidationFault
                {
                    
                    Result = false,
                    Message = ex.Message,
                    Description = ex.StackTrace
                };
                throw new FaultException<ValidationFault>(fault, ex.Message);
            }

        }

        private static void RunCmd(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + cmd;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        #region IDisposable Members

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        #endregion

    }
}

