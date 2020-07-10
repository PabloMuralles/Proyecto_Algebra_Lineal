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

                Color pixel;

                for (int y = 0; y < largo; y++)
                {
                    for (int x = 0; x < ancho; x++)
                    {
                        pixel = bmp.GetPixel(x, y);

                        var A = pixel.A;
                        var G = pixel.G;
                        var R = pixel.R;
                        var B = pixel.B;

                        var promedio = (A + G + B) / 3;


                        bmpgrises.SetPixel(x, y, Color.FromArgb(promedio, promedio, promedio));

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
