using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotacionesEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Votacion v = new Votacion();
        private void btnIniciarVotacion_Click(object sender, EventArgs e)
        {
            v.IniciarVotacion();
            grpVotacion.Enabled = true;
            btnIniciarVotacion.Enabled = false;
        }

        private void btnCandidato1_Click(object sender, EventArgs e)
        {
            v.Votar(1);
        }

        private void btnCandidato2_Click(object sender, EventArgs e)
        {
            v.Votar(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v.VotacionEmpatada += V_VotacionEmpatada;
            v.VotacionGanada += V_VotacionGanada;
        }

        private void V_VotacionGanada(byte ganador)
        {
            grpVotacion.Enabled = false;
            btnIniciarVotacion.Enabled = true;
            lblMensaje.Text = $"Ganó el candidato {ganador}";
        }

        private void V_VotacionEmpatada()
        {
            lblMensaje.Text = "Votación empatada";
            grpVotacion.Enabled = false;
            btnIniciarVotacion.Enabled = true;
        }
    }
}
