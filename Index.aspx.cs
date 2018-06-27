using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using Newtonsoft.Json;
using System.Web.UI.WebControls;

namespace JSONNET
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnJSON_Click(object sender, EventArgs e)
        {
           
        }

        protected void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPersona_Click1(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno
            {
                nombre = txtNombre.Text,
                apellidos = txtApellidos.Text,
                id = txtIdentificador.Text,
                dni = txtDNI.Text,

            };
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtIdentificador.Text = "";
            txtDNI.Text = "";

            if (Session["ARCHIVOJSON"].ToString() == string.Empty)
                Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(alumno);
            else
                Session["ARCHIVOjSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(alumno);
            ltbAlumno.Items.Add("Nombre: " + alumno.nombre + "Apellidos: " + alumno.apellidos + "DNI" + alumno.dni + "Identificador:" + alumno.id);
             
        }

        protected void btnJSON_Click1(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\MiFichero\aspnetJSON.json", "[" + Session["ARCHIVOJSON"].ToString() + "]");
            Response.Write("<script>alert('JSON listo!!');</script>");

        }

         /*  protected void btnAgregarPersona_Click1(object sender, EventArgs e)
          {

          }*/
    }
}