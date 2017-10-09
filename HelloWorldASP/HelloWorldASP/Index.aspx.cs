using System;

namespace HelloWorldASP
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "WORLD";
            // TODO Aanroepen van HelloWorld.Hi.result
        }
    }
}