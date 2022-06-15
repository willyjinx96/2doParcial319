using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2doParcialASPNET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonCS_Click(object sender, EventArgs e)
        {
            int n = Int16.Parse(TextBox1.Text);
            LibreriaParcial.Fibonacci C1= new LibreriaParcial.Fibonacci();
            long[] lista = C1.genera(n);
            for (int j = 0; j < n; j++)
            {
                TableRow r = new TableRow();

                TableCell a = new TableCell();
                a.Controls.Add(new LiteralControl(lista[j].ToString()));
                r.Cells.Add(a);

                Table1.Rows.Add(r);
            }
        }
    }
}