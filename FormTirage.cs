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
                MessageBox.Show("Le tirage ne peut pas avoir lieu avec une liste vide :/", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParticipants.Items.Count != 0)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            panelBande.Height = buttonLoad.Height;
            panelBande.Top = buttonLoad.Top;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            panelBande.Height = buttonSave.Height;
            panelBande.Top = buttonSave.Top;

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

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            panelBande.Height = buttonQuitter.Height;
            panelBande.Top = buttonQuitter.Top;

            Application.Exit();
        }
    }

}
