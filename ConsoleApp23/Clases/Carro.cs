﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Clases
{
    public class Carro
    {



        public string Marca { get; }
        public int Modelo { get; }
        public string Color { get; set; }

        public string owner { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private int MAXVELOCIDAD { get; set; }




        public Carro(string m, int model, string col)
        {

            Marca = m;


            Modelo = model;
            Color = col;

        }



        public int Acelerar()
        {

            velocidad_actual += 10;
            return velocidad_actual;


            if (Encendido == 0)
            {

              
                return 0;


            }
            else
            {

                velocidad_actual += 10;
                return velocidad_actual;


            }

         
        }


    }
}



   