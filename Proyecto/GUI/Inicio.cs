using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            // se desactiva los texbox de la matriz
            ActivarMatriz(false);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_opciones_Enter(object sender, EventArgs e)
        {

        }

        private void button_cargar_Click(object sender, EventArgs e)
        {

            var Direccion = string.Empty;
            

            // variable para poder abrir el dialog
            OpenFileDialog Abrir = new OpenFileDialog();

            // abre el explorador de archivos   
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // da la direccion del archivo que se abrio
                    Direccion = Abrir.FileName;

                    // da la extecion del archivo para poder validarlo que sea txt
                    var Extencion = Path.GetExtension(Direccion);

                    /*valido la extencion del archivo y si es txt lo leo para posteriomente 
                     * guardarlo y sino es un txt se muestra un messaje*/

                    if (Extencion != ".png" && Direccion == null)
                    {
                        throw new Exception("No se cargo nada o la extencion no es png");
                    }
                    else
                    {
                        textBox_direccion.Text = Direccion;
                    }
                    
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.Message);
                }
            }
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Metodo para poder desactivar o activar los textbox de la matriz personalizada
        /// </summary>
        /// <param name="accion"></param>
        private void ActivarMatriz(bool accion)
        {

            textBox_a.Enabled = accion;
            textBox_b.Enabled = accion;
            textBox_c.Enabled = accion;
            textBox_d.Enabled = accion;
            textBox_e.Enabled = accion;
            textBox_f.Enabled = accion;
            textBox_g.Enabled = accion;
            textBox_h.Enabled = accion;
            textBox_i.Enabled = accion;

        }

        private void radioButton_personalizado_CheckedChanged(object sender, EventArgs e)
        {
            // se verifica que si esta seleccionadio el radiobutton personalizado se active los textbox de la matriz y sino se desactiven
            if(radioButton_personalizado.Checked == true)
            {
                ActivarMatriz(true);
            }
            else
            {
                ActivarMatriz(false);
            }
        }

        private void button_aplicar_Click(object sender, EventArgs e)
        {
            // se manda a llamar al otro forms filtros y se manda como parametro el actual asi se pueden guardar la informacion ingresada
            this.Hide();
            Filtros frmFiltros = new Filtros(this);
            frmFiltros.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_a.Clear();
            textBox_b.Clear();
            textBox_c.Clear();
            textBox_d.Clear();
            textBox_e.Clear();
            textBox_f.Clear();
            textBox_g.Clear();
            textBox_h.Clear();
            textBox_i.Clear();
        }
    }
}
