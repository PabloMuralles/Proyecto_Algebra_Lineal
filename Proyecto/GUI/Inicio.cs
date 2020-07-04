using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Drawing;
using System.Linq;

namespace Proyecto.GUI
{
    public partial class Inicio : Form
    {
        private string direccion = string.Empty;
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
            // variable para poder abrir el dialog
            OpenFileDialog Abrir = new OpenFileDialog();

            // abre el explorador de archivos   
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // da la direccion del archivo que se abrio
                    direccion = Abrir.FileName;

                    // da la extecion del archivo para poder validarlo que sea txt
                    var Extencion = Path.GetExtension(direccion);
                    /*valido la extencion del archivo y si es txt lo leo para posteriomente 
                     * guardarlo y sino es un txt se muestra un messaje*/

                    //var prueba = Image.FromFile(direccion);
                    //var asdf = prueba.PixelFormat;

                    if (Extencion != ".png" && direccion == null)
                    {
                        throw new Exception("No se cargo nada o la extencion no es png");
                    }
                    else
                    {
                        textBox_direccion.Text = direccion;
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

        /// <summary>
        /// metodo para verificar que lo que se ingreso a cada posicion de la matriz este de manera correcta y que solo sean numeros
        /// </summary>
        /// <returns></returns>
        private bool VerificarTextBoxs()
        {
            Regex numeros = new Regex(@"^([0-9]+\.[0-9]+)|([0-9]+)$");
         

            if (numeros.IsMatch(textBox_a.Text) && numeros.IsMatch(textBox_b.Text) && numeros.IsMatch(textBox_c.Text) && numeros.IsMatch(textBox_d.Text)
                && numeros.IsMatch(textBox_e.Text) && numeros.IsMatch(textBox_f.Text) && numeros.IsMatch(textBox_g.Text) && numeros.IsMatch(textBox_h.Text)
                && numeros.IsMatch(textBox_i.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button_aplicar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(direccion))
            {
                if (radioButton_personalizado.Checked == true)
                {
                    if (VerificarTextBoxs() == true)
                    {
                        AplicarFiltros();

                    }
                    else
                    {
                        MessageBox.Show("Ingreso algo difierente a un número decimal, entero, dejo en blanco alguna o ingreso mal el número");
                    }
                }
                else
                {
                    AplicarFiltros();
                }

            }
            else
            {
                MessageBox.Show("No se cargado ninguna imagen");
            }

        }

        /// <summary>
        /// Metodo para aplicar los filtros a la imagen y llamar al form para motrarlos
        /// </summary>
        private void AplicarFiltros()
        {
            //try
            //{
                // se manda a llamar al otro forms filtros y se manda como parametro el actual asi se pueden guardar la informacion ingresada
                this.Hide();
                Filtros frmFiltros = new Filtros(this);// llamar al forms filtro y mandarle el form actual
                frmFiltros.MostrarImagenOriginal(direccion); // mostrar la imagen original
                var objEscalaGrises = new Manipulacon_Imagen.EscalaGrises();// objeto de la clase escalas a grices
                var opcionSeleccionada = groupBox_opciones.Controls.OfType<RadioButton>().
                Where(x => x.Checked).SingleOrDefault<RadioButton>();// linq para poder saber que opcion fue seleccionada
                var bmpGrises = objEscalaGrises.ConvertirImagen(direccion);// convertir la imagen a escala de grises 
                var objFiltros = new Manipulacon_Imagen.AplicarFiltros();// aplicar los filtros a la imgen a grises
                var bmpFiltrada = objFiltros.ObtenerImagenFiltro(bmpGrises, opcionSeleccionada.Text);// obtener la imagen filtadra
                frmFiltros.MostrarImgenGrises(bmpGrises);// mostrar la imagen a escala de grises en el form filtros
                frmFiltros.MostrarImgenFiltrada(bmpFiltrada);// mostrar la imagen filtrada de la escala a grises
                frmFiltros.Show();

            //}
            //catch (Exception p)
            //{
            //    MessageBox.Show(p.Message);
            //    this.Show();
            //}

        }

        private void OpcionSeleccionada()
        {
            var opcionSeleccionada = groupBox_opciones.Controls.OfType<RadioButton>().
                Where(x => x.Checked).SingleOrDefault<RadioButton>();

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

        #region key press textbox

 
        private void textBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_b_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_f_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox_g_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        #endregion

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_matrizPersonalizada_Enter(object sender, EventArgs e)
        {

        }
    }
}
