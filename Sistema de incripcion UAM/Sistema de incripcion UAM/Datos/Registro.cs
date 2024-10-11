using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_incripcion_UAM.Datos
{
    internal class Registro
    {

       public String nombre { get; set; }
        public String apellido { get; set; }
        public Double edad {  get; set; }
        public Double promedio { get; set; }
        public String facultad  { get; set; }
        public String carrera { get; set; }
        public Registro(String nombre, String apellido, Double edad, Double promedio, String facultad, String Carrera)
        {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.promedio = promedio;
        this.facultad = facultad;
        this.carrera = carrera;
          
        }


        public string CalculararBeca() 
        {
            if (promedio >= 90)
                return "70% de beca";
            else if (promedio >= 85)
                return "60% de beca";
            else if (promedio >= 80)
                return "50% de beca";
            else
                return "No tienes derecho a beca";
        }


        public string Printf ()
        {
            return $"{nombre} {apellido} - Facultad: {facultad}, Carrera: {carrera}, Promedio: {promedio}";
        }
    }
}
