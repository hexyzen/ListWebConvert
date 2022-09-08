using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : Page
    {
      static  List<int> listIs = new List<int>() { };



        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            
            int temp = Convert.ToInt32(TextBox1.Text);
            listIs.Add(temp);
            Label3.Text = string.Join(", ", listIs);


        }

        protected void btnDecr_Click1(object sender, EventArgs e)
        {

            listIs.Sort();
            listIs.Reverse();
            Label4.Text = string.Join(", ", listIs);
        }

        protected void btnIncr_Click1(object sender, EventArgs e)
        {
            listIs.Sort();
            Label4.Text = string.Join(", ", listIs);
        }
    }
}