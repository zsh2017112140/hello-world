using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Button_Confirm(object sender, EventArgs e)
        {
            if (Username.Text == "")
                WebMessage.Show("请输入用户名");
            else if (name.Text == "")
                WebMessage.Show("请输入姓名");


            else if (Password.Text == "")
                WebMessage.Show("请输入密码");
            else if (Check.Text == "")
                WebMessage.Show("请再次输入密码");
            else if (Password.Text != Check.Text)
                WebMessage.Show("密码不一致！");

            else
            {
                string sql = "INSERT INTO bookuser (id,pwd,name,status,sex,admin,times1) VALUES ('" + Username.Text.Trim() + "','" + Password.Text.Trim() + "','" + name.Text.Trim() + "','1','" + RadioButtonList1.SelectedValue + "','1','0')";
                ConnSql conn = new ConnSql();
                int s = conn.RunSql(sql);
                if (s > 0)
                {
                    WebMessage.Show("添加成功", "Index.aspx");
                }
                else
                {
                    WebMessage.Show("添加失败");
                }





            }
        }

        protected void RadionButton_Changed(object sender, EventArgs e)
        {

        }
    }
}