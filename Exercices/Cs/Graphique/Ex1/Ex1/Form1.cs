using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        // Taux de change "exemple" vers l'euro
        private const double TauxSwiss = 1.06;   
        private const double TauxUsa = 0.97;   
        private const double TauxUk = 1.24;   
        private const double TauxJap = 0.0064; 

        public Form1()
        {
            InitializeComponent();
        }

        // Lors du clic sur le PictureBox (optionnel)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Laissez vide ou utilisez-le si nécessaire
        }

        // Lors du clic sur le label1 (optionnel)
        private void label1_Click(object sender, EventArgs e)
        {
            // Laissez vide ou utilisez-le si nécessaire
        }

        // Dès qu'on sélectionne les francs suisses
        private void rdSwiss_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSwiss.Checked)
            {
                // l'image de la Suisse est dans l’index 0 de la ImageList
                picDevises.Image = imageList1.Images[0];
            }
        }

        // Dès qu'on sélectionne les dollars US
        private void rbUSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUSA.Checked)
            {
                // l'image des États-Unis est dans l’index 1
                picDevises.Image = imageList1.Images[1];
            }
        }

        // Dès qu'on sélectionne les livres sterling
        private void rbUK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUK.Checked)
            {
                // l'image des États-Unis est dans l’index 1
                picDevises.Image = imageList1.Images[2];
            }

        }

        // Dès qu'on sélectionne les yens japonais
        private void rbJAP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJAP.Checked)
            {
                // l'image du Japon est dans l’index 3
                picDevises.Image = imageList1.Images[3];
            }
        }

        // Clic sur le bouton Convertir
        private void btConvert_Click(object sender, EventArgs e)
        {
            double montant;

            // On vérifie si l’utilisateur a bien tapé un nombre
            if (!double.TryParse(txtMontant.Text, out montant))
            {
                MessageBox.Show("Veuillez saisir un montant valide.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            double resultat = 0.0;

            // On vérifie quel RadioButton est coché pour définir le taux de change
            if (rdSwiss.Checked)
            {
                resultat = montant * TauxSwiss;
            }
            else if (rbUSA.Checked)
            {
                resultat = montant * TauxUsa;
            }
            else if (rbUK.Checked)
            {
                resultat = montant * TauxUk;
            }
            else if (rbJAP.Checked)
            {
                resultat = montant * TauxJap;
            }
            else
            {
                // Si aucune devise n'est sélectionnée
                MessageBox.Show("Veuillez sélectionner une devise.",
                                "Attention",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // On affiche le résultat dans le TextBox de résultat
            txtResultat.Text = resultat.ToString("F3");
        }
    }
}
