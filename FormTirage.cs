using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class FormTirage : Form
    {
        string monFichier;
        public FormTirage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Random rnd = new System.Random();
                int monChiffre = rnd.Next(listBoxParticipants.Items.Count);
                MessageBox.Show("Félicitation à " + listBoxParticipants.Items[monChiffre].ToString(), "Tirage !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite lors du tirage !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxParticipants.Items.Add(new Participant(textBoxDonnees.Text));
            listBoxParticipants.SelectedItem = listBoxParticipants.Items[listBoxParticipants.Items.Count - 1];
            textBoxDonnees.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxParticipants.Items.Remove(listBoxParticipants.SelectedItem);
            if(listBoxParticipants.Items.Count != 0)
            {
                listBoxParticipants.SelectedItem = listBoxParticipants.Items[listBoxParticipants.Items.Count - 1];
            }        
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ouvrirUneListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxParticipants.Items.Clear();

            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                filePath = openFileDialog.FileName;
                
                var fileStream = openFileDialog.OpenFile();

                StreamReader reader = new StreamReader(fileStream);
                while ((monFichier = reader.ReadLine()) != null)
                {
                    listBoxParticipants.Items.Add(monFichier);
                }
                reader.Close();

                if (listBoxParticipants.Items.Count != 0)
                {
                    listBoxParticipants.SelectedItem = listBoxParticipants.Items[0];
                }
            }
        }

        private void sauvegarderLaListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();
            path.Filter = "txt files (*.txt)|*.txt";
            if (path.ShowDialog() == DialogResult.OK)
            {
                string monChemin = path.FileName;
                StreamWriter sw = new StreamWriter(monChemin);
                foreach (var item in listBoxParticipants.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();

            }

        }

        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParticipants.Items.Count != 0)
            {
                sauvegarderLaListeToolStripMenuItem.Enabled = true;
            }
            else
            {
                sauvegarderLaListeToolStripMenuItem.Enabled = false;
            }
        }
    }

}
