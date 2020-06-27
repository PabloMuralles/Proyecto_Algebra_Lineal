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

        private void ActivarMatriz()
        {
            if (radio)
            {

            }
        }
    }
}
