using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFormsContacto
{
    internal class Persona
    {
        protected string nombre;
        protected DateTime? fechaNacimiento;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        } 
        public int Edad
        {
            get
            {
                int edad;
                edad = (DateTime.Now.Year - fechaNacimiento.Value.Year);
                return edad;
            }
        }
        
        public Persona()
        {
            nombre = string.Empty;
            fechaNacimiento = null; //DateTime.MinValue;

        }
        public Persona(string nombre, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return nombre.ToUpper() + " " + fechaNacimiento + " " + Edad;
        }


    }

}
