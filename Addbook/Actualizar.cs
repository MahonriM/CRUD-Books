using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Addbook.Utilerias;
namespace Addbook
{
    public partial class Actualizar : Form
    {
        
        string nombre;
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            int idlibro = int.Parse(txtidlibro.Text);
            nombre = txtnombre.Text;
            parametros.Add(new SqlParameter("@idlibro",idlibro));
            parametros.Add(new SqlParameter("@Nombre",nombre));
            Conexion.ejecutarSelect("Update libro set nombre=@Nombre where idlibro=@idlibro", CommandType.Text,parametros);
            MessageBox.Show("Registro actualizado");
            this.Close();
        }
    }
}
