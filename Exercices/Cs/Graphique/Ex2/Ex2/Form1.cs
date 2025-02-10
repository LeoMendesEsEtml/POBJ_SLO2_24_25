using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 1) Populate the ListBox with names
            lstPersonnes.Items.Add("Christian Huber");
            lstPersonnes.Items.Add("Ivan Desclous");
            lstPersonnes.Items.Add("Serge Lama");
            lstPersonnes.Items.Add("Jean Exemple");
            lstPersonnes.Items.Add("Paul Masson");

            // 2) Populate the ComboBox with street names
            cboRues.Items.Add("Ch. de la Damatiare");
            cboRues.Items.Add("Rue de la Gare");
            cboRues.Items.Add("Av. du Léman");

            // 3) Populate the DomainUpDown with city+NPA
            domVilles.Items.Add("1009 Pully");
            domVilles.Items.Add("1007 Lausanne");
            domVilles.Items.Add("1008 Prilly");

            // Optionally set default selections
            lstPersonnes.SelectedIndex = 0; // First name by default
            cboRues.SelectedIndex = 0;      // First street
            domVilles.SelectedIndex = 0;    // First city
            numericUpDown1.Value = 7;       // Default house number

            // Hook the Composer button click event
            button1.Click += button1_Click;
        }

        // This is triggered when the user chooses a different name from the ListBox
        // (Optional logic—only if you want immediate updates or extra actions)
        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Just as an example, we clear the richTextBox every time a new person is selected.
            richTextBox1.Clear();
        }

        // When "Composer" is clicked, we build the multiline address
        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure a valid selection is made for each control
            if (lstPersonnes.SelectedIndex < 0 ||
                cboRues.SelectedIndex < 0 ||
                domVilles.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un nom, une rue et une ville !");
                return;
            }

            // Retrieve the selected or entered values
            string nom = lstPersonnes.SelectedItem.ToString();
            string rue = cboRues.SelectedItem.ToString();
            int numero = (int)numericUpDown1.Value;
            string ville = domVilles.SelectedItem.ToString(); // e.g. "1009 Pully"

            // Construct the multiline address
            string adresseComplete = $"{nom}\n{rue} {numero}\n{ville}";

            // Display in the RichTextBox
            richTextBox1.Text = adresseComplete;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

