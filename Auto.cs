using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    public class Auto
    {
        private string patente;
        private int marca;
        private int modelo;
        private int color;
        private double precio;

        public Auto()
        {
            patente = string.Empty;
            marca = 0;
            modelo = 0;
            color = 0;
            precio = 0;
        }
        public Auto(string patente, int marca, int modelo, int color, double precio)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public override string ToString()
        {
            return patente + " - " + MostrarMarca() + " - " + MostrarColores();
        }
        
        public string MostrarMarca()
        {
            string sas = "";
            switch (marca)
            {
                case 1:
                    sas = "Fiat";
                    break;
                case 2:
                    sas = "Ford";
                    break;
                case 3:
                    sas = "Renault";
                    break;
                case 4:
                    sas = "Audi";
                    break;
                case 5:
                    sas = "Volkswagen";
                    break;
                case 6:
                    sas = "Skoda";
                    break;
                case 7:
                    sas = "Pagani";
                    break;
                case 8:
                    sas = "Chevrolet";
                    break;
                case 9:
                    sas = "Hyundai";
                    break;
                case 10:
                    sas = "Peugeot";
                    break;
                case 11:
                    sas = "Citroen";
                    break;
                case 12:
                    sas = "Toyota";
                    break;
                case 13:
                    sas = "Mazda";
                    break;
                case 14:
                    sas = "Mini Cooper";
                    break;
                case 15:
                    sas = "Jeep";
                    break;
            }
            return sas;
        }

        public string MostrarColores()
        {
            string sas = "";
            switch (color)
            {
                case 1:
                    sas = "Negro";
                    break;
                case 2:
                    sas = "Gris";
                    break;
                case 3:
                    sas = "Blanco";
                    break;
                case 4:
                    sas = "Rojo";
                    break;
                case 5:
                    sas = "Amarillo";
                    break;
                case 6:
                    sas = "Azul";
                    break;
                case 7:
                    sas = "Naranja";
                    break;
                case 8:
                    sas = "Verde";
                    break;
                case 9:
                    sas = "Lima";
                    break;
            }
            return sas;
        }
    }
}
