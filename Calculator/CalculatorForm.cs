using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Estandar Estandar;
        Avanzada Avanzada;
        Experimental Experimental;
        Config Config;

        public Calculator()
        {
            InitializeComponent();
            PanelControls.Controls.Clear();
            Estandar = new Estandar();
            Avanzada = new Avanzada();
            Experimental = new Experimental();
            Config = new Config();
            Estandar.Dock = DockStyle.Fill;
            Avanzada.Dock = DockStyle.Fill;
            Experimental.Dock = DockStyle.Fill;
            Config.Dock = DockStyle.Fill;
            PanelControls.Controls.Add(Estandar);
            Estandar.Show();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void ButtonEstandar_Click(object sender, EventArgs e)
        {
            PanelControls.Controls.Clear();
            PanelControls.Controls.Add(Estandar);
            Estandar.Show();
        }

        private void ButtonAvanzada_Click(object sender, EventArgs e)
        {
            PanelControls.Controls.Clear();
            PanelControls.Controls.Add(Avanzada);
            Avanzada.Show();
        }

        private void ButtonExperimental_Click(object sender, EventArgs e)
        {
            PanelControls.Controls.Clear();
            PanelControls.Controls.Add(Experimental);
            Experimental.Show();
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            PanelControls.Controls.Clear();
            PanelControls.Controls.Add(Config);
            Config.Show();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
