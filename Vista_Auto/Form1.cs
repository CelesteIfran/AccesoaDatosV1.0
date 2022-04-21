using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using ServicioValidacionVista;
using Microsoft.VisualBasic;

namespace Vista_Auto
{
    public partial class Form1 : Form
    {
        bll_Concesionaria _bllcon;
        Vista _vista;
        ent_Concesionaria _entcon;

        VAL_Auto _vauto;

        bll_Auto _bllAuto;

        public Form1()
        {
            InitializeComponent();
            _bllcon = new bll_Concesionaria();
            _entcon = new ent_Concesionaria();
            _vista = new Vista();

            _vauto = new VAL_Auto();

            _bllAuto = new bll_Auto();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;




            dataGridView1.Refresh();
        }

        private void ActualizarGrilla(DataGridView pData, Object _p)
        {
            pData.DataSource = null; pData.DataSource = _p;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            

            try
            {
                ent_Auto _aut = new ent_Auto();
                _aut.AuPatente = Interaction.InputBox("Número de patente: ");
                _aut.AuAño = int.Parse(Interaction.InputBox("Año del auto: "));
                _aut.AuFechaIngreso = DateTime.Parse(Interaction.InputBox("Fecha de ingreso: (formato DD/MM/AAAA)"));
                _aut.AuFechaBaja = DateTime.Parse(Interaction.InputBox("Fecha de baja: (si el auto no está dado de baja colocar 01/01/2999)"));           
                _aut.AuValor = decimal.Parse(Interaction.InputBox("El valor del auto: "));
              
                _bllcon.CargarAuto(_aut);
                ActualizarGrilla(dataGridView1, _vista.RetornaListaVista(_bllcon.ConsultaTodo()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra el formulario
        }
    }
}
