using Sistema_de_incripcion_UAM.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_incripcion_UAM
{
    public partial class LbESst : Form
    {
        public LbESst()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = tbNombre.Text;
                string apellido = tbApe.Text;
                double edad = evaluaredad(double.Parse(tbEdad.Text));
                double promedio = evaluarprom(double.Parse(tbProm.Text));
                string facultad = cbFact.SelectedItem.ToString();
                string carrera = cbCarr.SelectedItem.ToString();

                Registro estudiantes = new Registro(nombre, apellido, edad, promedio, facultad, carrera);
                mostrar(estudiantes);
                lbSal.Text = estudiantes.CalculararBeca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        void mostrar(Registro estudiantes)
        {
            string datos = "";
            lbEst.Items.Clear();
            datos = estudiantes.Printf();
            lbEst.Items.Add(datos);
        }
        double evaluarprom(double prom)
        {
            if (prom < 0 || prom > 100)
            {
                throw new Exception("El promedio se calcula de 0 a 100");

            }
            else { return prom; }
        }
        double evaluaredad(double age)
        {
            if (age < 0 || age > 122)
            {
                throw new Exception("La edad maxima que vive alguien segun google son 122 años");
            }
            else { return age; }    
    }

        private void lbEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    }


    

