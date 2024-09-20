using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomorrow.DB;

namespace Tomorrow.Interpreter
{
    public class TodoInterpreter
    {
        public DataTable GetTodoList(string I_TODO_OWNER_ID)
        { 
            DataTable dt = new DataTable();

            SqlHelper helper = new SqlHelper();
            Dictionary<string, object> arrParamNames = new Dictionary<string, object>();
            arrParamNames.Add("I_TODO_OWNER_ID", "KIMSANGKI");
            arrParamNames.Add("I_TODO_WORK_YMD", DateTime.Now.AddDays(1).ToString("yyyyMMdd"));
            

            DataSet ds = helper.GetDataSet("SP_TODO_L", arrParamNames);

            if (ds != null)
            { 
                dt = ds.Tables[0];
            }
            return dt;
        }

        public int AddTodo(
                                int I_TODO_PARENT_SEQ, string I_TODO_CONTENT, string I_TODO_CATEGORY, string I_TODO_CATEGORY_DIV, string I_TODO_CATEGORY_SEQ
                            ,   string I_TODO_OWNER_ID, string I_TODO_COMPLETE_YN, string I_TODO_USE_YN, string I_TODO_DEL_YN, string I_TODO_WORK_YMD, string I_TODO_WORK_HMS
                            ,   string I_CREATE_ID, string I_UPDATE_ID
                          )
        {
            SqlHelper helper = new SqlHelper();
            Dictionary<string, object> arrParamNames = new Dictionary<string, object>();
            arrParamNames.Add("I_TODO_PARENT_SEQ", I_TODO_PARENT_SEQ);
            arrParamNames.Add("I_TODO_CONTENT", I_TODO_CONTENT);
            arrParamNames.Add("I_TODO_CATEGORY", I_TODO_CATEGORY);
            arrParamNames.Add("I_TODO_CATEGORY_DIV", I_TODO_CATEGORY_DIV);
            arrParamNames.Add("I_TODO_CATEGORY_SEQ", I_TODO_CATEGORY_SEQ);
            arrParamNames.Add("I_TODO_OWNER_ID", I_TODO_OWNER_ID);
            arrParamNames.Add("I_TODO_COMPLETE_YN", I_TODO_COMPLETE_YN);
            arrParamNames.Add("I_TODO_USE_YN", I_TODO_USE_YN);
            arrParamNames.Add("I_TODO_DEL_YN", I_TODO_DEL_YN);
            arrParamNames.Add("I_TODO_WORK_YMD", I_TODO_WORK_YMD);
            arrParamNames.Add("I_TODO_WORK_HMS", I_TODO_WORK_HMS);
            arrParamNames.Add("I_CREATE_ID", I_CREATE_ID);
            arrParamNames.Add("I_UPDATE_ID", I_UPDATE_ID);

            int iresult = helper.ExecuteNonQuery("SP_TODO_C", arrParamNames);
            return iresult;
        }
    }
}
