using System;
using System.Drawing;

namespace Proyecto.Manipulacon_Imagen
{
    public class EscalaGrises
    {
        /// <summary>
        /// Metodo para convertir la imagen a escala de grises
        /// </summary>
        /// <param name="direccion">direccion de la imagen original</param>
        /// <returns>bitmap de la imagen a escala a grises</returns>
        public Bitmap ConvertirImagen(string direccion)
        {
            try
            {
                var bmp = new Bitmap(direccion);
                var bmpgrises = new Bitmap(bmp);
                var ancho = bmp.Width;
                var largo = bmp.Height;

                

                for (int y = 0; y < largo; y++)
                {
                    for (int x = 0; x < ancho; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);

                        var A = pixel.A;
                        var G = pixel.G;
                        var R = pixel.R;
                        var B = pixel.B;

                        var promedio = Convert.ToInt32((R * 0.3) + (G * 0.59) + (B * 0.11));
                   

                        bmpgrises.SetPixel(x, y, Color.FromArgb(A, promedio, promedio, promedio));

                    }

                }
                return bmpgrises;

            }
            catch (Exception)
            {
                throw new Exception("La profundidad de los bits es menor a 32");
            }


        }






    }
}
