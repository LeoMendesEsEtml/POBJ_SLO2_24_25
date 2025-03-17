using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ex5
{
    public partial class Form1 : Form
    {
        private byte[] m_tabBin = new byte[5]; // Tableau binaire à 5 bits

        public Form1()
        {
            InitializeComponent();
            txtBoxShortHex.Text = "00";
            txtBoxMsb.Text = "";
            txtBoxLsb.Text = "";
            txtDecimal.Text = "0";
        }

        // Méthode Extraire : Sépare un ushort en Msb et Lsb
        private byte Extraire(ushort valeur, out byte msb)
        {
            msb = (byte)(valeur >> 8); // Octet de poids fort
            return (byte)(valeur & 0xFF); // Octet de poids faible
        }

        private void btnExtraire_Click(object sender, EventArgs e)
        {
            if (ushort.TryParse(txtBoxShortHex.Text, System.Globalization.NumberStyles.HexNumber, null, out ushort valeur))
            {
                txtBoxLsb.Text = Extraire(valeur, out byte msb).ToString("X2");
                txtBoxMsb.Text = msb.ToString("X2");
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur hexadécimale valide.");
            }
        }

        // Méthode Permute : Échange les valeurs de deux TextBox
        private void Permute(ref TextBox valA, ref TextBox valB)
        {
            string temp = valA.Text;
            valA.Text = valB.Text;
            valB.Text = temp;
        }

        private void btnPermuter_Click(object sender, EventArgs e)
        {
            Permute(ref txtBoxValA, ref txtBoxValB);
        }

        // Méthode GestionBit : Inverse un bit et met à jour l'affichage
        private void GestionBit(ref byte bit, ref Button bouton)
        {
            bit = (byte)(bit == 0 ? 1 : 0);
            bouton.Text = bit.ToString();
            DispDecimal();
        }

        // Méthode DispDecimal : Convertit le tableau binaire en valeur décimale
        private void DispDecimal()
        {
            int valeurDecimal = (m_tabBin[0] << 4) | (m_tabBin[1] << 3) | (m_tabBin[2] << 2) | (m_tabBin[3] << 1) | m_tabBin[4];
            txtDecimal.Text = valeurDecimal.ToString();
        }

        private void bit0_Click(object sender, EventArgs e)
        {
            GestionBit(ref m_tabBin[0], ref btnBin1);
        }

        private void bit1_Click(object sender, EventArgs e)
        {
            GestionBit(ref m_tabBin[1], ref btnBin2);
        }

        private void bit2_Click(object sender, EventArgs e)
        {
            GestionBit(ref m_tabBin[2], ref btnBin3);
        }

        private void bit3_Click(object sender, EventArgs e)
        {
            GestionBit(ref m_tabBin[3], ref btnBin4);
        }

        private void bit4_Click(object sender, EventArgs e)
        {
            GestionBit(ref m_tabBin[4], ref btnBin5);
        }
    }
}

