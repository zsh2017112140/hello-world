using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Register : System.Web.UI.Page
    {
       
        protected void Button_Confirm(object sender, EventArgs e)
        {
            if (Username.Text == "")
                WebMessage.Show("请输入用户名");
            else if (name.Text == "")
                WebMessage.Show("请输入姓名");
            else if (xueyuan.Text == "")
                WebMessage.Show("请输入学院");
            else if (banji.Text == "")
                WebMessage.Show("请输入班级");
            else if (Password.Text == "")
                WebMessage.Show("请输入密码");
            else if (Check.Text == "")
                WebMessage.Show("请再次输入密码");
           else if(Password.Text!=Check.Text)
                WebMessage.Show("密码不一致！");
            
            else
            {
                string sql = "INSERT INTO bookuser (id,pwd,name,class,xueyuan,status,sex,admin,times1) VALUES ('" + Username.Text.Trim() + "','" + Password.Text.Trim() + "','" + name.Text.Trim() + "','" + banji.Text.Trim() + "','" + xueyuan.Text.Trim() + "','1','" + RadioButtonList1.SelectedValue + "','0','0')";
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

        protected void Check_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Username1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadionButton_Changed(object sender, EventArgs e)
        {

        }


        
       
        
    }
}