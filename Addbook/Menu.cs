using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Addbook.Utilerias;
namespace Addbook
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnlibro_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete fr2 = new Delete();
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizar fr = new Actualizar();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable datosamostrar = new DataTable();//Para sacar datos de una tabla y de´positarlo en la variable
            datosamostrar = Conexion.ejecutarSelect("Select*From libro", CommandType.Text);//Para que llene la variable
            dataGridView1.DataSource = datosamostrar;
        }
    }
}
