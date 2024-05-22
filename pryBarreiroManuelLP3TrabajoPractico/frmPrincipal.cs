using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarreiroManuelLP3TrabajoPractico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        int contador;

        private void rbtQuenaken_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZonaAzul.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtZonaVerde.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
        }

        private void cmdReserva_Click(object sender, EventArgs e)
        {
            string local, zona;
            if (rbtQuenaken.Checked == true)
            {
                local = rbtQuenaken.Text;
            }
            else
            {
                if (rbtOnas.Checked == true)
                {
                    local = rbtOnas.Text;
                }
                else
                {
                    local=rbtTobas.Text;
                }
            }
            if (rbtZonaAzul.Checked == true)
            {
                zona = "Azul";
            }
            else
            {
                zona = "Verde";
            }
            MessageBox.Show("Lugar reservado en: " + local + "\n" + "Zona: " + zona + "\n" + "Fila: "
                + cmbFila.Text + "\n" + "Asiento: " + cmbAsiento.Text, "Reserva", MessageBoxButtons.OK);
            this.Close();
        }

        private void rbtOnas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZonaAzul.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 11)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 5)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtZonaVerde.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
        }

        private void rbtTobas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtZonaVerde.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 4)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtZonaAzul.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 4)
                {
                    if (cmbFila.Text == "1")
                    {
                        cmbAsiento.Items.Add(contador);
                        break;
                    }
                    else
                    {
                        cmbAsiento.Items.Add(contador);
                        contador++;
                    }
                }
            }
        }

        private void rbtZonaAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtQuenaken.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtOnas.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 11)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 5)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtTobas.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 4)
                {
                    if (cmbFila.Text == "1")
                    {
                        cmbAsiento.Items.Add(contador);
                        break;
                    }
                    else
                    {
                        cmbAsiento.Items.Add(contador);
                        contador++;
                    }
                }
            }
        }

        private void rbtZonaVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtQuenaken.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtOnas.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 5)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
            if (rbtTobas.Checked == true)
            {
                contador = 1;
                cmbFila.Items.Clear();
                cmbAsiento.Items.Clear();
                while (contador < 4)
                {
                    cmbFila.Items.Add(contador);
                    contador++;
                }
                contador = 1;
                while (contador < 6)
                {
                    cmbAsiento.Items.Add(contador);
                    contador++;
                }
            }
        }

        private void cmbFila_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtTobas.Checked == true && rbtZonaAzul.Checked == true && cmbFila.Text == "1")
            {
                cmbAsiento.Items.Clear();
                cmbAsiento.Items.Add("1");
            }
            else
            {
                if (rbtTobas.Checked == true)
                {
                    contador = 1;
                    cmbAsiento.Items.Clear();
                    while (contador < 4)
                    {
                        cmbAsiento.Items.Add(contador);
                        contador++;
                    }
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
