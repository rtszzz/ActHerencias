using System;

namespace ActHerencias
{
    class Persona:Alumno
    {
        static void Main(string[] args)
        {
           private string Nombre;
        private string Fechadenacimiento;

        public string nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string fechadenacimiento
        {
            get
            {
                return fechadenacimiento;
            }
            set
            {
                fechadenacimiento = value;
            }

        }

        public Persona()
        {
            nombre = "";
            fechadenacimiento = "";
        }

        public Persona(string nombre, string fechadenacimiento);
        {
           this.nombre = nombre;
           this.fechadenacimiento = fechadenacimiento;
        }

       public override string ToString()
       {
        return. base ToString() + "nombre" + nombre + "fechadenacimiento[" + fechadenacimiento.ToString() + "]";
       }
    }
}




