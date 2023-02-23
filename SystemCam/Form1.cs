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
using System.Data.SqlTypes;

namespace SystemCam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.productosTableAdapter.Fill(this.systemCamDataSet1.Productos);
            Connectionbd.ConectarDB();
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Connectionbd.ConectarDB();
            DataTable dt = new DataTable();
            string consulta = "SELECT *FROM Productos";
            SqlCommand cmd = new SqlCommand(consulta,Connectionbd.ConectarDB());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            Connectionbd.ConectarDB();

            string insert = "INSERT INTO Productos (CODIGO,NOMBRE,PRECIO,PRECIO_COMPRA,PRECIO_VENTA_POR_MAYOR) VALUES (@CODIGO,@NOMBRE,@PRECIO,@PRECIO_COMPRA,@PRECIO_VENTA_POR_MAYOR)";

            SqlCommand cmdinsert = new SqlCommand(insert,Connectionbd.ConectarDB());

            cmdinsert.Parameters.AddWithValue("@CODIGO", Codigo_txt.Text);
            cmdinsert.Parameters.AddWithValue("@NOMBRE", Nombre_txt.Text);
            cmdinsert.Parameters.AddWithValue("@PRECIO", Precio_Unidad_Venta_txt.Text);
            cmdinsert.Parameters.AddWithValue("@PRECIO_COMPRA", Precio_Unidad_Compra_txt.Text);
            cmdinsert.Parameters.AddWithValue("@PRECIO_VENTA_POR_MAYOR",Precioventapormayor_txt.Text);
            cmdinsert.Parameters.AddWithValue("@PRECIO_VENTA_POR_MAYOR", Precioventapormayor_txt.Text);

            cmdinsert.ExecuteNonQuery();

            MessageBox.Show("Se agrego Correctamente");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                Codigo_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Nombre_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Precio_Unidad_Venta_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Precio_Unidad_Compra_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Precioventapormayor_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            } catch { }
        }
        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            Connectionbd.ConectarDB();
            string update = "UPDATE Productos SET CODIGO= @CODIGO, NOMBRE=@NOMBRE,PRECIO=@PRECIO, PRECIO_COMPRA=@PRECIO_COMPRA,PRECIO_VENTA_POR_MAYOR=@PRECIO_VENTA_POR_MAYOR WHERE CODIGO=@CODIGO";
            SqlCommand cmdupdate = new SqlCommand(update,Connectionbd.ConectarDB());
            cmdupdate.Parameters.AddWithValue("@CODIGO", Codigo_txt.Text);
            cmdupdate.Parameters.AddWithValue("@NOMBRE", Nombre_txt.Text);
            cmdupdate.Parameters.AddWithValue("@PRECIO", Precio_Unidad_Venta_txt.Text);
            cmdupdate.Parameters.AddWithValue("@PRECIO_COMPRA", Precio_Unidad_Compra_txt.Text);
            cmdupdate.Parameters.AddWithValue("@PRECIO_VENTA_POR_MAYOR", Precioventapormayor_txt.Text);
            cmdupdate.ExecuteNonQuery();

            MessageBox.Show("Se Modifico Correctamente");
            dataGridView1.DataSource = llenar_grid();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            Connectionbd.ConectarDB();
            string delete = "DELETE FROM Productos WHERE CODIGO = @CODIGO";
            SqlCommand cmddelete = new SqlCommand(delete, Connectionbd.ConectarDB());
            cmddelete.Parameters.AddWithValue("@CODIGO", Codigo_txt.Text);
            cmddelete.ExecuteNonQuery();
            MessageBox.Show("Se Elimino Correctamente");
            dataGridView1.DataSource= llenar_grid();
        }

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            Codigo_txt.Clear();
            Nombre_txt.Clear();
            Precio_Unidad_Venta_txt.Clear();
            Precio_Unidad_Compra_txt.Clear();
            Precioventapormayor_txt.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Connectionbd.ConectarDB();
            string search = "SELECT * FROM Productos WHERE "+comboBox1.Text+ " LIKE '%" + textBox1.Text+ "%'";
            SqlDataAdapter ad = new SqlDataAdapter(search, Connectionbd.ConectarDB());
            DataSet data = new DataSet();
            ad.Fill(data,"Productos");
            dataGridView2.DataSource = data;
            dataGridView2.DataMember = "Productos";

        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Contar_btn_Click(object sender, EventArgs e)
        {
            Connectionbd.ConectarDB();
            SqlCommand cmdcontar = new SqlCommand("SELECT COUNT (CODIGO) FROM Productos",Connectionbd.ConectarDB());
            int contar = (int)cmdcontar.ExecuteScalar();
            Contar_txt.Text = contar.ToString() + " Productos";
            cmdcontar.ExecuteNonQuery();

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
