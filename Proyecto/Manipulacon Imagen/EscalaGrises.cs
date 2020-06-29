using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Proyecto.Manipulacon_Imagen
{
    public class EscalaGrises
    {
        public Bitmap ConvertirImagen(string direccion)
        {
            try
            {
                var bmp = new Bitmap(direccion);
                var ancho = bmp.Width;
                var largo = bmp.Height;

                Color pixel;

                for (int y = 0; y < largo; y++)
                {
                    for (int x = 0; x < ancho; x++)
                    {
                        pixel = bmp.GetPixel(x, y);

                        var a = pixel.A;
                        var r = pixel.R;
                        var g = pixel.G;
                        var b = pixel.B;

                        var promedio = (r + g + b) / 3;

                        bmp.SetPixel(x, y, Color.FromArgb(a, promedio, promedio, promedio));

                    }

                }
                return bmp;

            }
            catch (Exception)
            {
                throw new Exception("La imagen ingresada no es correcta intentar con otra imagen");
            }


        }






    }
}
