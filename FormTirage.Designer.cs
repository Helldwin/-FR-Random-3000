namespace Random
{
    partial class FormTirage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDonnees = new System.Windows.Forms.TextBox();
            this.groupBoxTraitement = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUneListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.groupBoxTraitement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(27, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter au tirage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(81, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Faire le tirage !";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDonnees
            // 
            this.textBoxDonnees.Location = new System.Drawing.Point(54, 39);
            this.textBoxDonnees.Name = "textBoxDonnees";
            this.textBoxDonnees.Size = new System.Drawing.Size(179, 20);
            this.textBoxDonnees.TabIndex = 1;
            // 
            // groupBoxTraitement
            // 
            this.groupBoxTraitement.Controls.Add(this.button3);
            this.groupBoxTraitement.Controls.Add(this.button1);
            this.groupBoxTraitement.Controls.Add(this.textBoxDonnees);
            this.groupBoxTraitement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxTraitement.Location = new System.Drawing.Point(264, 40);
            this.groupBoxTraitement.Name = "groupBoxTraitement";
            this.groupBoxTraitement.Size = new System.Drawing.Size(282, 127);
            this.groupBoxTraitement.TabIndex = 5;
            this.groupBoxTraitement.TabStop = false;
            this.groupBoxTraitement.Text = "Traitements";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(146, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer du tirage";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(264, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tirer au sort";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUneListeToolStripMenuItem,
            this.sauvegarderLaListeToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirUneListeToolStripMenuItem
            // 
            this.ouvrirUneListeToolStripMenuItem.Name = "ouvrirUneListeToolStripMenuItem";
            this.ouvrirUneListeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirUneListeToolStripMenuItem.Text = "Ouvrir une liste";
            this.ouvrirUneListeToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUneListeToolStripMenuItem_Click);
            // 
            // sauvegarderLaListeToolStripMenuItem
            // 
            this.sauvegarderLaListeToolStripMenuItem.Enabled = false;
            this.sauvegarderLaListeToolStripMenuItem.Name = "sauvegarderLaListeToolStripMenuItem";
            this.sauvegarderLaListeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sauvegarderLaListeToolStripMenuItem.Text = "Sauvegarder la liste";
            this.sauvegarderLaListeToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLaListeToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.Location = new System.Drawing.Point(12, 44);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(246, 225);
            this.listBoxParticipants.TabIndex = 12;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            // 
            // FormTirage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 283);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTraitement);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTirage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Random 3000";
            this.groupBoxTraitement.ResumeLayout(false);
            this.groupBoxTraitement.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDonnees;
        private System.Windows.Forms.GroupBox groupBoxTraitement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUneListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLaListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxParticipants;
    }
}

