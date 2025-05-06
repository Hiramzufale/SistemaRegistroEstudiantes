using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_5
{
    
    public partial class Form1: Form
    {
        //Instaciar 
        LogicEstudiantes objlogicEstudiantes;

        //lista de personas que recolecta los datos de la clase Persona
        List<Personas> listaPersonas = new List<Personas>();
        public Form1()
        {
            InitializeComponent();

            //Utilizaremos esta lista para el datagridview
            dataGridView1.DataSource = new BindingList<Personas>();


            List<TextBox> listaTextBox = new List<TextBox>();
            listaTextBox.Add(txtId);//[0]
            listaTextBox.Add(txtNombre);//[1]
            listaTextBox.Add(txtApellidop);//[2]
            listaTextBox.Add(txtApellidom);//[3]
            listaTextBox.Add(txtDireccion);//[4]
            listaTextBox.Add(txtTelefono);//[5]
            listaTextBox.Add(txtCorreo);//[6]

            List<Label> listaLabel = new List<Label>();
            listaLabel.Add(lblId);//[0]
            listaLabel.Add(lblNombre);//[1]
            listaLabel.Add(lblApellidop);//[2]
            listaLabel.Add(lblApellidom);//[3]
            listaLabel.Add(lblDireccion);//[4]
            listaLabel.Add(lblTelefono);//[5]
            listaLabel.Add(lblCorreo);//[6]

            //Utilizamos un objeto

            Object[] objects = { pictureBox, dataGridView1 };

            objlogicEstudiantes = new LogicEstudiantes(listaTextBox, listaLabel, objects);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //Utilizar el objeto logic estudiantes tiene acceso al metodo cargar imagenes
            //objlogicEstudiantes.cargarImagen(pictureBox);
            objlogicEstudiantes.objSubirImagen.cargarImagen(pictureBox);
        }

        private void txtApellidom_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidom.Text.Equals(""))
            {
                lblApellidom.ForeColor = Color.Red;
            }
            else
            {
                lblApellidom.ForeColor = Color.Green;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            //Estructura condicional 
            if (txtId.Text.Equals(""))
            {
                //Cambiamos la apariencia de la etiqueta (color)
                lblId.ForeColor = Color.Red;
            }
            else
            {
                lblId.ForeColor = Color.Green;
            }
    }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Green;
            }
        }

        private void TxtApellidop_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidop.Text.Equals(""))
            {
                lblApellidop.ForeColor = Color.Red;
            }
            else
            {
                lblApellidop.ForeColor = Color.Green;
            }
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals(""))
            {
                lblDireccion.ForeColor = Color.Red;
            }
            else
            {
                lblDireccion.ForeColor = Color.Green;
            }
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals(""))
            {
                lblTelefono.ForeColor = Color.Red;
            }
            else
            {
                lblTelefono.ForeColor = Color.Green;
            }
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                lblCorreo.ForeColor = Color.Red;
            }
            else
            {
                lblCorreo.ForeColor = Color.Green;
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Utilizando el objeto tendremos acceso al metodo que hemos creado en TextBoxEvent
            objlogicEstudiantes.objTextBoxEvent.soloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objlogicEstudiantes.objTextBoxEvent.soloLetras(e);
        }

        private void TxtApellidop_KeyPress(object sender, KeyPressEventArgs e)
        {
            objlogicEstudiantes.objTextBoxEvent.soloLetras(e);
        }

        private void txtApellidom_KeyPress(object sender, KeyPressEventArgs e)
        {
            objlogicEstudiantes.objTextBoxEvent.soloLetras(e);
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            objlogicEstudiantes.objTextBoxEvent.validarCorreoElectronico(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            objlogicEstudiantes.objTextBoxEvent.soloNumeros(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objlogicEstudiantes.registrarDatosFormulario();

            objlogicEstudiantes.ListarRegistros();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            Personas objPersona = new Personas
            {
                ClaveUsuario = txtId.Text,
                Nombre = txtNombre.Text,
                ApellidoPaterno = txtApellidop.Text,
                ApellidoMaterno = txtApellidom.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                CorreoElectronico = txtCorreo.Text,
            };

            listaPersonas.Add(objPersona);

            //agregaremos la lista al control dataGridview
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPersonas;

            //Convertir imgagen a byte
            objlogicEstudiantes.objSubirImagen.ImgToByte(pictureBox.Image);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objlogicEstudiantes.ListarRegistros();

        }
    }
}