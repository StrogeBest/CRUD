using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        private Form frmActual;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            this.AbrirFormHija(new FrmUno());
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            this.AbrirFormHija(new FrmDos());
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.AbrirFormHija(new FrmTres());
        }

        private void ActualizarDataGridView()
        {
            /*
            this.dgvLista.Rows.Clear();

            foreach (Partida partida in this._listaPartidas)
            {
                string jugadorUno = partida.NombreJugadorUno;
                string jugadorDos = partida.NombreJugadorDos;

                this.dgvLista.Rows.Add(jugadorUno, jugadorDos);
            }
            */
        }

        private void AbrirFormHija(Form frmHijo)
        {
            if (frmActual != null)
            {
                frmActual.Close();
            }

            frmActual = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frmHijo);
            frmHijo.BringToFront();
            frmHijo.Show();
        }
    }
}
