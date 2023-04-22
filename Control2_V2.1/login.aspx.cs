using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mis_clases;
namespace Control2_v2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Text = null;
        }

        protected void bnt_ingresar_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            user.Nombre = txt_usuario.Text;
            user.Clave = txt_clave.Text;
            lbl_error.Text = null;
            if (user.Nombre == null || user.Nombre.Length<1 
                    || user.Clave == null || user.Clave.Length<1)
            {
                lbl_error.Text = "Usuario y clave son obligatorios";
            }else
            {
                Response.Write(user.Nombre + "Ingresado");
                Response.Redirect("calculator.aspx?nombre=" + user.Nombre);
            }
        }
    }
}