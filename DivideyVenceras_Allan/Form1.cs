using DivideyVenceras_Allan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideyVenceras_Allan
{
    public partial class Form1 : Form
    {
        List<Employee> workers = new List<Employee>();
        string name;
        string position;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            position = tbPosition.Text;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(position))
            {
                Employee employee = new Employee { Name = name, Position = position };
                workers.Add(employee);
                tbName.Clear();
                tbPosition.Clear();
                SortAll(workers);
                UpdateWorkersListBox();
            }
        }

        private void UpdateWorkersListBox()
        {
            lbWorkers.Items.Clear();

            foreach (Employee employee in workers)
            {
                lbWorkers.Items.Add($"{employee.Name} - {employee.Position}");
            }
        }

        private void SortAll(List<Employee> list)
        {
            list.Sort((x, y) => x.Name.CompareTo(y.Position);
        }

        private void BtnLookUp_Click(object sender, EventArgs e)
        {
            string searchName = tbLookUp1.Text; // Supongo que el nombre a buscar se introduce en tbLookUp
            if (!string.IsNullOrWhiteSpace(searchName))
            {
                // Buscar el empleado en la lista
                Employee foundEmployee = workers.FirstOrDefault(emp => emp.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

                // Mostrar el resultado en el Label
                if (foundEmployee != null)
                {
                    LbWrkLookedup.Text = $"Empleado encontrado: {foundEmployee.Name} - {foundEmployee.Position}";
                }
                else
                {
                    LbWrkLookedup.Text = "Empleado no encontrado.";
                }
            }
        }

    }

}