using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace FinancialPlannerClient.PlannerInfo
{
    public class LoanInfo
    {
        const string GET_ALL_LOAN_API = "Loan/GetAll?plannerId={0}";
        const string GET_ALL_BY_ID_API = "Loan/GetById?id={0},plannerId={1}";
        const string ADD_LOAN_API = "Loan/Add";
        const string UPDATE_LOAN_API = "Loan/Update";
        const string DELETE_LOAN_API = "Loan/Delete";
        internal IList<Loan> GetAll(int plannerId)
        {
            IList<Loan> loanObj = new List<Loan>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL_LOAN_API,plannerId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<Loan>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    loanObj = jsonSerialization.DeserializeFromString<IList<Loan>>(restResult.ToString());
                }
                return loanObj;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return null;
            }
        }

        internal Loan GetById(int id, int plannerId)
        {
            Loan loanObj = new Loan();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL_BY_ID_API,id,plannerId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<Loan>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    loanObj = jsonSerialization.DeserializeFromString<Loan>(restResult.ToString());
                }
                return loanObj;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return null;
            }
        }

        internal void FillGrid(DataGridView dtGridLoan)
        {
            dtGridLoan.Columns[0].Visible = false;
            dtGridLoan.Columns[1].Visible = false;
            dtGridLoan.Columns[2].HeaderText = "Type Of Loan";
            dtGridLoan.Columns[3].HeaderText = "Outstanding Amount";
            dtGridLoan.Columns[4].HeaderText = "EMIs";
            dtGridLoan.Columns[5].HeaderText = "Interest Rate";
            dtGridLoan.Columns[6].HeaderText = "Term left (Months)";
            dtGridLoan.Columns[7].HeaderText = "No. EMIs payable (Year)";
            dtGridLoan.Columns[8].HeaderText = "Description";
            dtGridLoan.Columns["CreatedOn"].Visible = false;
            dtGridLoan.Columns["CreatedBy"].Visible = false;
            dtGridLoan.Columns["UpdatedOn"].Visible = false;
            dtGridLoan.Columns["UpdatedBy"].Visible = false;
            dtGridLoan.Columns["UpdatedByUserName"].Visible = false;
            dtGridLoan.Columns["MachineName"].Visible = false;
        }

        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }

        internal bool Add(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");
                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }
        internal bool Update(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ UPDATE_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");

                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }
        internal bool Delete(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ DELETE_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");

                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }    
    }
}