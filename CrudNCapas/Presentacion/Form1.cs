using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Atributos;
using Dominio.Crud;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //variables
        CPersonas personas = new CPersonas();
        AtributosPersonas atributos = new AtributosPersonas();
        bool edit = false; 

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void getData()
        {
            CPersonas cPersonas = new CPersonas();
            DvgDatos.DataSource = cPersonas.Mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            getData();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre") txtNombre.Text = "";
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") txtNombre.Text = "Nombre";
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido") txtApellido.Text = "";
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") txtNombre.Text = "Apellidp";
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID") txtID.Text = "";
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "") txtID.Text = "ID";
        }

        private void ClearTextBoxs()
        {
            txtID.Text = "ID";
            txtApellido.Text = "Apellido";
            txtNombre.Text = "Nombre";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {    //Insertar
                try
                {
                    
                    atributos.Id = Convert.ToInt32(txtID.Text);
                    atributos.Nombre = txtNombre.Text;
                    atributos.Apellido = txtApellido.Text;
                    atributos.Sexo = cbSexo.Text;
                    personas.Insertar(atributos);
                    ClearTextBoxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    MessageBox.Show("SE GUARDO UN DATO DE FORMA CORRECTA","INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show( $"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }else if (edit == true)
            {
                //ACTUALIZAR

            }
            
        }
    }
}
