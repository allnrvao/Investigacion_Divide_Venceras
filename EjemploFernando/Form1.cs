using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploFernando.model;

namespace EjemploFernando
{
    public partial class Form1 : Form
    {
        List<Trabajador> trabajadores = new List<Trabajador>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btmOrdenar_Click(object sender, EventArgs e)
        {
            Trabajador trab = new Trabajador();
            try
            {
                trab.AgregarNombre(tbNombre.Text);
                trab.AgregarSalario(double.Parse(tbSalario.Text));
                trab.AgregarAnno(int.Parse(tbAntiguo.Text));

                Agregar(trab);
                Mostrar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void Agregar(Trabajador trab)
        {
            trabajadores.Add(trab);
        }
     

        private void btmOrdenar_Click_1(object sender, EventArgs e)
        {
            Ordenar();
            Mostrar();
        }

        void Mostrar()
        {
            lbSalida.Items.Clear();
            for( int i=0; i < trabajadores.Count; i++)
            {
                string datos = "";
                datos = $"{trabajadores[i].Nombre} C${trabajadores[i].Salario} Años {trabajadores[i].Anno}";
                lbSalida.Items.Add(datos);
            }
        }

        void Ordenar()
        {
            if(lbDato.SelectedItem.ToString()== "Años")
            {
                for (int i = 0; i < trabajadores.Count; i++)
                {
                    for (int j = i + 1; j < trabajadores.Count; j++)
                    {
                        if (trabajadores[j].Anno < trabajadores[i].Anno)
                        {
                            Trabajador aux = new Trabajador();
                            aux = trabajadores[j];
                            trabajadores[j] = trabajadores[i];
                            trabajadores[i] = aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < trabajadores.Count; i++)
                {
                    for (int j = i + 1; j < trabajadores.Count; j++)
                    {
                        if (trabajadores[j].Salario < trabajadores[i].Salario)
                        {
                            Trabajador aux = new Trabajador();
                            aux = trabajadores[j];
                            trabajadores[j] = trabajadores[i];
                            trabajadores[i] = aux;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opcion();
        }
        void Opcion()
        {
            lbDato.Items.Add("Años");
            lbDato.Items.Add("Salario");
        }
    }
}
