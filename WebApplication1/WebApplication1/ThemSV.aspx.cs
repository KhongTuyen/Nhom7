using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ThemSV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertedCmd(object sender, FormViewPageEventArgs e)
        {
         //  if(e.Exception != null)
            {

            }
        }

        protected void InsertedCmd(object sender, FormViewInsertedEventArgs e)
        {
            if(e.Exception != null)
            {
                e.KeepInInsertMode = true;
                e.ExceptionHandled = true;
                errmsg.Text = "Đã xảy ra lỗi :" + e.Exception.Message;
            }
        }
    }
}