using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlannerClient.PlannerInfo
{
    public class EmploymentInfo
    {
        const string GET_EMPLOYMENT_API = "Employment/Get?id={0}";

        public Employment Get(int id)
        {
            Employment employmentObj = new Employment();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_EMPLOYMENT_API,id);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<Employment>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    employmentObj = jsonSerialization.DeserializeFromString<Employment>(restResult.ToString());
                }
                return employmentObj;
            }
            catch (Exception ex)
            {
                Logger.LogDebug(ex);
                return null;
            }
        }

        public bool Update(Employment employment)
        {
            return true;
        }
    }
}
