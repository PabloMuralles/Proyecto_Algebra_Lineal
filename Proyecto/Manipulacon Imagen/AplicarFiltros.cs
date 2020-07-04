using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Proyecto.Manipulacon_Imagen
{
    public class AplicarFiltros
    {
        public Bitmap ObtenerImagenFiltro(Bitmap imagenGrises, string opcion)
        {
            return ObtenerMatriz(imagenGrises, opcion);
        }
        private Bitmap ObtenerMatriz(Bitmap imagen, string opc)
        {
            double[,] kernel;
            Bitmap imagenFiltrada;
            switch (opc)
            {
                case "Difuminado":

                    kernel = new double[3, 3]
                    {
                        {0.0625, 0.125, 0.0625 },
                        {0.125, 0.25, 0.125 },
                        {0.0625, 0.125, 0.0625 }
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;


                case "Sobel Inferior":

                    kernel = new double[3, 3]
                    {
                        {-1, -2, -1},
                        {0, 0, 0 },
                        {1, 2, 1}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Sobel Izquierdo":

                    kernel = new double[3, 3]
                    {
                        {1, 0, -1},
                        {2, 0, -2},
                        {1, 0, -1}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Contorno":


                    kernel = new double[3, 3]
                    {
                        {-1, -1, -1},
                        {-1, 8, -1},
                        {-1, -1, -1}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Original":

                    kernel = new double[3, 3]
                    {
                        {0, 0, 0},
                        {0, 1, 0},
                        {0, 0, 0}
                    };

                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Realzar":

                    kernel = new double[3, 3]
                    {
                       {-2, -1, 0},
                       {-1, 1, 1 },
                       {0, 1, 2}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Sobel Superior":

                    kernel = new double[3, 3]
                    {
                       {1, 2, 1},
                       {0, 0, 0 },
                       {-1, -2, -2}
                    };

                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Sobel Derecho":

                    kernel = new double[3, 3]
                    {
                       {-1, 0, 1},
                       {-2, 0, 2},
                       {-1, 0, 1}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                case "Afilar":

                    kernel = new double[3, 3]
                    {
                       {0, -1, 0},
                       {-1, 5, -1},
                       {0, -1, 0}
                    };
                    imagenFiltrada = OperarMatriz(imagen, kernel);
                    break;

                default:
                    return default;

            }
            return imagenFiltrada;

        }



        private Bitmap EscalonarMatriz(double[,] matriz)
        {

            //(double max, double min) = MaxMinValores(matriz);

            var nuevaImagen = new Bitmap(matriz.GetLength(0), matriz.GetLength(1));

            for (int i = 1; i < matriz.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matriz.GetLength(1) - 1; j++)
                {
                    var pixel = matriz[i, j];
                    if (pixel < 0)
                    {
                        nuevaImagen.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else if ( pixel > 255)
                    {
                        nuevaImagen.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        nuevaImagen.SetPixel(i, j, Color.FromArgb((int)pixel, (int)pixel, (int)pixel));
                    }
                   

                }

            }


            return nuevaImagen; ;
        }

        private (double, double) MaxMinValores(double[,] matrix)
        {
            double max = matrix[0, 0];
            double min = matrix[0, 0];

            var pued = matrix.GetLength(0);
            var hola = matrix.GetLength(0);
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {

                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                    else if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }

            }

            return (max, min);
        }
        private double[,] ObtenerMatrizGrises(Bitmap imagen)
        {
            // x= width y y=heigth matriz[y,x]
            var w = imagen.Width;
            var h = imagen.Height;
            var matrizImagenGrises = new double[w, h];
             
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrizImagenGrises[i, j] = imagen.GetPixel(i, j).R;
                }

            }
            return matrizImagenGrises;
        }
        private Bitmap OperarMatriz(Bitmap imagen, double[,] kernel)
        {
            var w = imagen.Width;
            var h = imagen.Height;
            var nuevaImagen = new double[w, h];

            var matrizGrises = ObtenerMatrizGrises(imagen);

            var contador = 0;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i < w - 2 && j < h - 2)
                    {
                        if (contador == 1021)
                        {

                        }
                        var matriztemp = new double[3, 3]
                        {
                               { matrizGrises[i,j],  matrizGrises[i, j+1],  matrizGrises[i, j+2] },
                                {  matrizGrises[i+1,j],  matrizGrises[i+1,j + 1],  matrizGrises[i+1,j + 2] },
                                {  matrizGrises[i+2,j],  matrizGrises[i+2,j+1],   matrizGrises[i+2,j+2] }
                        };
                        nuevaImagen[i + 1, j + 1] = MultiplicarMatrices(matriztemp, kernel);

                        contador++;

                    }
                }

            }


            var imagenFinal = EscalonarMatriz(nuevaImagen);

            return imagenFinal;

        }


        private double MultiplicarMatrices(double[,] submatriz, double[,] kernel)
        {
            double resultado = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado += (submatriz[i, j] * kernel[i, j]);
                }
            }

            return resultado;
        }


    }
}
