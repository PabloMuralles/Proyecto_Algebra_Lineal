using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            // verficar si se cargo una imagen

            if (!string.IsNullOrEmpty(direccion))
            { 
               AplicarFiltros();
                 
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
            try
            {
                var objEscalaGrises = new Manipulacon_Imagen.EscalaGrises();// objeto de la clase escalas a grices
                var opcionSeleccionada = comboBox_filtros.Text;// linq para poder saber que opcion fue seleccionada
                var bmpGrises = objEscalaGrises.ConvertirImagen(direccion);// convertir la imagen a escala de grises 
                pictureBox_grises.Image = bmpGrises; // mostrar la imagen a grises
                pictureBox_grises.SizeMode = PictureBoxSizeMode.StretchImage;
                var objFiltros = new Manipulacon_Imagen.AplicarFiltros();// aplicar los filtros a la imgen a grises
                if (comboBox_filtros.SelectedIndex == 9)
                {
                    if (VerificarTextBoxs() == true)
                    {
                        var kernel = new double[3, 3]
                        {
                            {Convert.ToDouble(textBox_a.Text),Convert.ToDouble(textBox_b.Text),Convert.ToDouble(textBox_c.Text) },
                            {Convert.ToDouble(textBox_d.Text),Convert.ToDouble(textBox_e.Text),Convert.ToDouble(textBox_f.Text) },
                            {Convert.ToDouble(textBox_g.Text),Convert.ToDouble(textBox_h.Text),Convert.ToDouble(textBox_i.Text) }

                        };
                        var bmpFiltrada = objFiltros.ObtenerImagenFiltroPersonalizado(bmpGrises, kernel);
                        pictureBox_filtrada.Image = bmpFiltrada;//mostrar la imagen a grises
                        pictureBox_filtrada.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Ingreso algo difierente a un número decimal, entero, dejo en blanco alguna o ingreso mal el número");
                    }
                }
                else
                {
                    
                    (var bmpFiltrada, var kernelUtilizado) = objFiltros.ObtenerImagenFiltro(bmpGrises, opcionSeleccionada);// obtener la imagen filtadra
                    MostrarKernelUtilizado(kernelUtilizado, comboBox_filtros.SelectedIndex);// muesta la matriz kernel utilizada
                    pictureBox_filtrada.Image = bmpFiltrada;//mostrar la imagen a grises
                    pictureBox_filtrada.SizeMode = PictureBoxSizeMode.StretchImage;
                     
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
                this.Show();
            }

        }

        /// <summary>
        /// Metodo para mostrar la matriz kernel utilizada
        /// </summary>
        /// <param name="kernel">matriz kernel </param>
        /// <param name="opcion">index de la opcion de filtro seleccionada</param>
        private void MostrarKernelUtilizado(double[,] kernel, int opcion)
        {
            if (opcion != 9)
            {
                textBox_a.Text =  kernel[0, 0].ToString();
                textBox_b.Text = kernel[0, 1].ToString();
                textBox_c.Text = kernel[0, 2].ToString();
                textBox_d.Text = kernel[1, 0].ToString();
                textBox_e.Text = kernel[1, 1].ToString();
                textBox_f.Text = kernel[1, 2].ToString();
                textBox_g.Text = kernel[2, 0].ToString();
                textBox_h.Text = kernel[2, 1].ToString();
                textBox_i.Text = kernel[2, 2].ToString();
            }
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
            // definir las opciones de filtros
            comboBox_filtros.Items.Add("Difuminado");
            comboBox_filtros.Items.Add("Sobel Inferior");
            comboBox_filtros.Items.Add("Sobel Izquierdo");
            comboBox_filtros.Items.Add("Contorno");
            comboBox_filtros.Items.Add("Original");
            comboBox_filtros.Items.Add("Realzar");
            comboBox_filtros.Items.Add("Sobel Superior");
            comboBox_filtros.Items.Add("Sobel Derecho");
            comboBox_filtros.Items.Add("Afilar");
            comboBox_filtros.Items.Add("Personalizado");
            comboBox_filtros.SelectedIndex = 0;
            button_cargar.Select();
        }

        private void groupBox_matrizPersonalizada_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            // borrar el contenido de la matriz
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

        private void comboBox_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // la matriz se activa unicamente cuando esta seleccionada la opcion de personalizado al igual que le boton borrar
            if (comboBox_filtros.SelectedIndex == 9)
            {
                ActivarMatriz(true);
                button_borrar.Enabled = true;
            }
            else
            {
                ActivarMatriz(false);
                button_borrar.Enabled = false;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
