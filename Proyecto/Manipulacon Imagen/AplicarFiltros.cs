using System.Drawing;

namespace Proyecto.Manipulacon_Imagen
{
    public class AplicarFiltros
    {
        /// <summary>
        /// Metodo para obtener la imagen con el filtro aplicado sin contar el de personalizado
        /// </summary>
        /// <param name="imagenGrises">bitmap de la imagen a escala a grises</param>
        /// <param name="opcion">nombre del filtro</param>
        /// <returns>el bitmap de la imagen con el filtro aplicado y la matriz kernel aplicada</returns>
        public (Bitmap, double[,]) ObtenerImagenFiltro(Bitmap imagenGrises, string opcion)
        {
            return ObtenerMatriz(imagenGrises, opcion);
        }

        /// <summary>
        /// Metodo para obtener la imagen con el filtro aplicado unicamente para la matriz personalizada
        /// </summary>
        /// <param name="imagenGrises">bitmap de la imagen a escala a grises</param>
        /// <param name="kernel">kernel ingresado por el usuario</param>
        /// <returns>el bitmap de la imagen con el filtro aplicado</returns>
        public Bitmap ObtenerImagenFiltroPersonalizado(Bitmap imagenGrises, double[,] kernel)
        {
            return OperarMatriz(imagenGrises, kernel); ;
        }

        /// <summary>
        /// Metodo para poder aplicar el filtro correspondiente sin contar la personalizada
        /// </summary>
        /// <param name="imagen">el bitmap de la imagen original en escala a grises</param>
        /// <param name="opc">la opcion seleccionada</param>
        /// <returns>el bitmap de la nueva imagen con el filtro aplicado</returns>
        private (Bitmap, double[,]) ObtenerMatriz(Bitmap imagen, string opc)
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
            return (imagenFiltrada, kernel);

        }


        /// <summary>
        /// Metodo para poder obtener los pixeles en el rango de 0-255
        /// </summary>
        /// <param name="matriz"> la matriz con el filtro ya aplicado</param>
        /// <returns> la matriz con la normalizacion aplicada</returns>
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
                    else if (pixel > 255)
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

        /// <summary>
        /// Metodo para pasar el bitmap de la imagen a grises a un matriz
        /// </summary>
        /// <param name="imagen">bitmap de la imagen original a escala a grises</param>
        /// <returns>matriz de double de los pixeles de la original a escala a grises</returns>
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

        /// <summary>
        /// Metodo para aplicar el kernel a toda la imagen
        /// </summary>
        /// <param name="imagen">bitmap de la imagen original en escala a grises</param>
        /// <param name="kernel">matriz kernel del filtro seleccionado</param>
        /// <returns>bitmap de la imagen con le filtro aplicado</returns>
        private Bitmap OperarMatriz(Bitmap imagen, double[,] kernel)
        {
            var w = imagen.Width;
            var h = imagen.Height;
            var nuevaImagen = new double[w, h];

            var matrizGrises = ObtenerMatrizGrises(imagen);

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i < w - 2 && j < h - 2)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { matrizGrises[i,j],  matrizGrises[i, j+1],  matrizGrises[i, j+2] },
                                {  matrizGrises[i+1,j],  matrizGrises[i+1,j + 1],  matrizGrises[i+1,j + 2] },
                                {  matrizGrises[i+2,j],  matrizGrises[i+2,j+1],   matrizGrises[i+2,j+2] }
                        };
                        nuevaImagen[i + 1, j + 1] = MultiplicarMatrices(matriztemp, kernel);

                    }
                    if (i == 0 && j == 0)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { 0,  0,  0},
                                {  0,  matrizGrises[i,j],  matrizGrises[i,j + 1] },
                                {  0,  matrizGrises[i+1,j],   matrizGrises[i+1,j+1] }
                        };
                        nuevaImagen[i, j] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i == 0 && j == h)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { 0,  0,  0},
                                { matrizGrises[i,j-1], matrizGrises[i,j], 0},
                                {  matrizGrises[i+1,j-1],  matrizGrises[i+1,j],  0}
                        };
                        nuevaImagen[i, j] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i == w && j == 0)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { 0,  matrizGrises[i-1,j],matrizGrises[i-1,j+1]},
                                { 0, matrizGrises[i,j], matrizGrises[i,j+1]},
                                { 0, 0,  0}
                        };
                        nuevaImagen[i, j] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i == w && j == h)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { matrizGrises[i-1,j-1],  matrizGrises[i-1,j],0},
                                {  matrizGrises[i,j-1], matrizGrises[i,j], matrizGrises[i,j+1]},
                                { 0, 0,  0}
                        };
                        nuevaImagen[i, j] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i == 0 && j < h - 2)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { 0,  0 ,0},
                                {  matrizGrises[i,j], matrizGrises[i,j+1], matrizGrises[i,j+2]},
                                {  matrizGrises[i+1,j],  matrizGrises[i+1,j + 1],  matrizGrises[i+1,j + 2] },
                        };
                        nuevaImagen[i, j + 1] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i < w - 2 && j == 0)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { 0,  matrizGrises[i,j] , matrizGrises[i,j+1]},
                                { 0, matrizGrises[i+1,j], matrizGrises[i+1,j+1]},
                                { 0,  matrizGrises[i+2,j],  matrizGrises[i+2,j + 1] },
                        };
                        nuevaImagen[i + 1, j] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i == w && j < h - 2)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { matrizGrises[i-1,j] ,  matrizGrises[i-1,j+1] , matrizGrises[i-1,j+2]},
                                { matrizGrises[i,j], matrizGrises[i,j+1], matrizGrises[i,j+2]},
                                { 0,  0,  0},
                        };
                        nuevaImagen[i, j + 1] = MultiplicarMatrices(matriztemp, kernel);
                    }
                    if (i < w - 2 && j == h)
                    {
                        var matriztemp = new double[3, 3]
                        {
                               { matrizGrises[i,j-1] ,  matrizGrises[i,j] , 0},
                                { matrizGrises[i+1,j-1], matrizGrises[i+1,j], 0},
                                { matrizGrises[i+2,j-1], matrizGrises[i+2,j],  0},
                        };
                        nuevaImagen[i, j + 1] = MultiplicarMatrices(matriztemp, kernel);
                    }
                }

            }


            var imagenFinal = EscalonarMatriz(nuevaImagen);

            return imagenFinal;

        }


        /// <summary>
        /// Metodo para multiplicar las submatrices con la matriz kernel
        /// </summary>
        /// <param name="submatriz">la submatriz de la imagen original</param>
        /// <param name="kernel">kernel a aplicar</param>
        /// <returns>resultado del nuevo pixel que sera el que ira en el centro</returns>
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
