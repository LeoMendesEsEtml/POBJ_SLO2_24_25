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
        private byte[] m_tabBin = new byte[4]; // Tableau binaire

        public Form1()
        {
            InitializeComponent();
            txtBox1.Text = "0"; // Initialisation de l'angle à 0
            txtBox2.Text = "";  // Champ Sinus vide
            textBox3.Text = "0"; // Valeur décimale à 0
        }

        // Méthode de conversion degrés → radians
        private double ConvDegToRad(double angle)
        {
            return angle * Math.PI / 180.0;
        }

        // Gestion du bouton Calcul (Sinus)
        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBox1.Text, out double angle))
            {
                double rad = ConvDegToRad(angle);
                txtBox2.Text = Math.Sin(rad).ToString("F6"); // Format 6 décimales
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide pour l'angle.");
            }
        }

        // Inverse un bit dans le tableau binaire
        private void ToggleBit(int index)
        {
            if (index >= 0 && index < 4)
            {
                m_tabBin[index] = (byte)(m_tabBin[index] == 0 ? 1 : 0);
            }
        }

        // Convertit et affiche la valeur décimale
        private void DispDecimal()
        {
            int decimalValue = (m_tabBin[0] << 3) | (m_tabBin[1] << 2) | (m_tabBin[2] << 1) | m_tabBin[3];
            textBox3.Text = decimalValue.ToString();
        }

        // Gestion des boutons binaires
        private void btnBin1_Click(object sender, EventArgs e)
        {
            ToggleBit(0);
            btnBin1.Text = m_tabBin[0].ToString();
            DispDecimal();
        }

        private void btnBin2_Click(object sender, EventArgs e)
        {
            ToggleBit(1);
            btnBin2.Text = m_tabBin[1].ToString();
            DispDecimal();
        }

        private void btnBin3_Click(object sender, EventArgs e)
        {
            ToggleBit(2);
            btnBin3.Text = m_tabBin[2].ToString();
            DispDecimal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToggleBit(3);
            button5.Text = m_tabBin[3].ToString();
            DispDecimal();
        }
    }
}
