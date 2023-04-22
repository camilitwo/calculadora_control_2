using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mis_clases;

namespace Control2_V2._1
{
    public partial class calculator : System.Web.UI.Page
    {
        string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            nombre = Request.QueryString["nombre"];
            lbl_nombre.Text = "Usuario Registrado: "+nombre;
            lbl_error2.Text = null;
            lbl_error.Text = null;
            link_login.Visible = false;
            lbl_result.Text = null;
            if (nombre == null || nombre.Length < 1)
            {
                lbl_error2.Text = "Debe iniciar sesión";
                lbl_nombre.Visible = false;
                lbl_result.Visible = false;
                txt_num1.Visible = false;
                txt_num2.Visible = false;
                btn_div.Visible = false;
                btn_mult.Visible = false;
                btn_resta.Visible = false;
                btn_suma.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                link_login.Visible = true;
            }
        }

        protected void btn_suma_Click(object sender, EventArgs e)
        {
            Calculadora op = this.SetearNumeros("suma");
            if (op != null)
            {
                this.ImprimirResultado(op.MostrarSuma().ToString());
            }
        }

        private Calculadora SetearNumeros(string opt)
        {
            try
            {
                int.Parse(txt_num1.Text);
                int.Parse(txt_num2.Text);
                
            }
            catch (Exception)
            {
                lbl_error.Text = "Debe ingresar valores numericos";
                return null;
            }

            Calculadora op = new Calculadora();
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            if("division".Equals(opt) && num2 == 0)
            {
                lbl_error.Text = "El divisor no puede ser cero";
                return null;
            } 

            op.ingresaNumeros(num1, num2);

            return op;
        }

        protected void btn_resta_Click(object sender, EventArgs e)
        {
            Calculadora op = this.SetearNumeros("resta");
            if (op != null)
            {
                this.ImprimirResultado(op.MostrarResta().ToString());
            }
        }

        protected void btn_mult_Click(object sender, EventArgs e)
        {
            Calculadora op = this.SetearNumeros("multi");
            if (op != null)
            {
                this.ImprimirResultado(op.MostrarMultiplicacion().ToString());
            }
        }

        protected void btn_div_Click(object sender, EventArgs e)
        {
            Calculadora op = this.SetearNumeros("division");
            if (op != null)
            {
                this.ImprimirResultado(op.MostrarDivision().ToString());
            }
        }

        private void ImprimirResultado(string resultado)
        {
            lbl_result.Text = "El resultado de la operación es: "+resultado;
        }

        protected void link_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}