using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Addbook.Utilerias;
using System.Data;
namespace Addbook
{
    public partial class Delete : Form
    {  int idlibro;
        public Delete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            idlibro = int.Parse(txtidlibro.Text);
            parametros.Add(new SqlParameter("@idLibro", idlibro));
            Conexion.ejecutarSentencia("Delete From Libro where idlibro=@idlibro", CommandType.Text, parametros);
            MessageBox.Show("Registro eliminado");
            this.Close();
        }
    }
}
