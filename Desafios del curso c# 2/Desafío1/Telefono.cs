using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    class Telefono
    {
        public Telefono (string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        private string modelo;
        private string marca;
        private int codigoOperador;
        public string NumeroTelefónico { get; set; }
        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                    return;
                }
                else
                    codigoOperador = 0;
            }
        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }
        public string enviarMensaje(string mensaje, string contacto)
        {
            return "Se ha enviado su mensaje exitosamente a " + contacto;
        }
    }
}
