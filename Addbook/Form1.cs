using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Addbook
{
    public partial class Form1 : Form
    {
        int idlibro;
        string nombre;
        SqlConnection con = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnadd_Click(object sender, EventArgs e)
        {
            idlibro = int.Parse(txtidlibro.Text);
            nombre = txtnombre.Text;


            try
            {
                con.ConnectionString = ("Server=MAHO\\SQLEXPRESS; database=Biblioteca;integrated security=true");
                
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                    comando.Connection = con;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "spadd";
                    comando.Parameters.AddWithValue("idlibro", idlibro).Value = txtidlibro.Text;// txtprecio.Text;
                    comando.Parameters.AddWithValue("nombre", nombre).Value = txtnombre.Text;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Insertado");
                    this.Close();
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error"+ ex);
                
            }
            con.Close();
        }

        private void txtidlibro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
