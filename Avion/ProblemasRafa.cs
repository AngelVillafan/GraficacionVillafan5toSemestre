using System;
using System.Collections.Generic;
using System.Text;

namespace Avion
{
    class ProblemasRafa
    {
        

        public string QuitarAcentos(string PalabraAcentuada)
        {
            string PalabraNoAcentuada = "";
            for (int i = 0; i < PalabraAcentuada.Length; i++)
            {
                if (PalabraAcentuada[i] == 'á')
                {
                    PalabraNoAcentuada += 'a';
                }
                else if (PalabraAcentuada[i] == 'é')
                {
                    PalabraNoAcentuada += 'e';
                }
                else if (PalabraAcentuada[i] == 'í')
                {
                    PalabraNoAcentuada += 'i';
                }
                else if (PalabraAcentuada[i] == 'ó')
                {
                    PalabraNoAcentuada += 'o';
                }
                else if (PalabraAcentuada[i] == 'ú')
                {
                    PalabraNoAcentuada += 'u';
                }
                else
                {
                    PalabraNoAcentuada += PalabraAcentuada[i];
                }
            }

            return PalabraNoAcentuada;
        }


        public byte[] LlenarArreglo(byte[] Arreglo)
        {
            byte[] ArregloLleno = new byte[100];
            for (int i = 0; i == 100; i++)
            {
                ArregloLleno[i] = (byte)i;
            }
            return ArregloLleno;
        }


        public byte[] NumAleatorios()
        {
            Random r = new Random();
            byte[] ArregloAlAzar = new byte[20];
            for (int i = 0; i == 19; i++)
            {
                ArregloAlAzar[i] += (byte)r.Next(0, 101);
            }
            return ArregloAlAzar;
        }







    }
}
