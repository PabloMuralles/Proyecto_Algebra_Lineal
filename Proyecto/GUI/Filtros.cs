using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto.GUI
{
    public partial class Filtros : Form
    {
        // variable para poder regresar al forms anterior con la informacion guardada
        private Form anteriorInicio;

        /// <summary>
        /// Es el contructor del form
        /// </summary>
        /// <param name="anteriorInicio">recibe el form anterior para poder regresar a el y no perder la informacion</param>
        public Filtros(Form anteriorInicio)
        {
            InitializeComponent();
            this.anteriorInicio = anteriorInicio;
            
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            // se regresa al form anterior y se cierra el actual
            this.Close();
            anteriorInicio.Show();

        }

        public void MostrarImagenOriginal(string direccion)
        {
            pictureBox_original.ImageLocation = direccion;
            pictureBox_original.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void MostrarImgenGrises(Bitmap imagen)
        {
            pictureBox_escalaGrises.Image = imagen;
            pictureBox_escalaGrises.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Filtros_Load(object sender, EventArgs e)
        {

        }
    }
}
