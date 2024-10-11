using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFernando.model
{
    internal class Trabajador
    {
        
        public string Nombre {  get; set; }
        public double Salario {  get; set; }
        public int Anno {  get; set; }
        

        public void AgregarNombre(string nombre)
        {
            this.Nombre = nombre;
        } 
        
        public void AgregarSalario(double salario)
        {
            this.Salario = salario;
        }

        public void AgregarAnno(int anno)
        {
            this.Anno = anno;
        }
    }
}
