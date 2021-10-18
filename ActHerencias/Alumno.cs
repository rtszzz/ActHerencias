using System;
using System.Collections.Generic;
using System.Text;

namespace ActHerencias
{
    class Alumno
    {
        private string Matricula;
        private string Carrera;
        public string matricula
        {
            get
            {
                return Matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public Alumno()
        {
            matricula = "";
            carrera = "";
        }

        public string (string matricula, string carrera)
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }
       
        public override string ToString()
        {
        return base.ToString() + "matricula" + matricula + "carrera[" + carrera.ToString() + "]";
        }
    }
}
