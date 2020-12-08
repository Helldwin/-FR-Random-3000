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
            this.panelDeco = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panelBande = new System.Windows.Forms.Panel();
            this.groupBoxTraitement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(17, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter au tirage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(68, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Faire le tirage !";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDonnees
            // 
            this.textBoxDonnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxDonnees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDonnees.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDonnees.Location = new System.Drawing.Point(54, 39);
            this.textBoxDonnees.Name = "textBoxDonnees";
            this.textBoxDonnees.Size = new System.Drawing.Size(179, 14);
            this.textBoxDonnees.TabIndex = 1;
            // 
            // groupBoxTraitement
            // 
            this.groupBoxTraitement.Controls.Add(this.panelDeco);
            this.groupBoxTraitement.Controls.Add(this.button3);
            this.groupBoxTraitement.Controls.Add(this.button1);
            this.groupBoxTraitement.Controls.Add(this.textBoxDonnees);
            this.groupBoxTraitement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBoxTraitement.Location = new System.Drawing.Point(483, 121);
            this.groupBoxTraitement.Name = "groupBoxTraitement";
            this.groupBoxTraitement.Size = new System.Drawing.Size(282, 127);
            this.groupBoxTraitement.TabIndex = 5;
            this.groupBoxTraitement.TabStop = false;
            this.groupBoxTraitement.Text = "Traitements";
            // 
            // panelDeco
            // 
            this.panelDeco.BackColor = System.Drawing.Color.Coral;
            this.panelDeco.Location = new System.Drawing.Point(54, 55);
            this.panelDeco.Name = "panelDeco";
            this.panelDeco.Size = new System.Drawing.Size(179, 4);
            this.panelDeco.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(139, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer du tirage";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(483, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tirer au sort";
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listBoxParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxParticipants.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 16;
            this.listBoxParticipants.Location = new System.Drawing.Point(228, 121);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(246, 226);
            this.listBoxParticipants.TabIndex = 12;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonQuitter);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonLoad);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 416);
            this.panelMenu.TabIndex = 13;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.ForeColor = System.Drawing.Color.White;
            this.buttonQuitter.Image = global::Random.Properties.Resources.logout;
            this.buttonQuitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuitter.Location = new System.Drawing.Point(0, 296);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(200, 69);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Random.Properties.Resources.Logo_Random_3000;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = global::Random.Properties.Resources.floppy_disk;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(0, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 90);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Sauvegarder la Liste";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Image = global::Random.Properties.Resources.refresh_button;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(0, 121);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 73);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Charger une Liste";
            this.buttonLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panelBande
            // 
            this.panelBande.BackColor = System.Drawing.Color.Coral;
            this.panelBande.Location = new System.Drawing.Point(202, 122);
            this.panelBande.Name = "panelBande";
            this.panelBande.Size = new System.Drawing.Size(10, 73);
            this.panelBande.TabIndex = 14;
            // 
            // FormTirage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(777, 416);
            this.Controls.Add(this.panelBande);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTraitement);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTirage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random 3000";
            this.groupBoxTraitement.ResumeLayout(false);
            this.groupBoxTraitement.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDonnees;
        private System.Windows.Forms.GroupBox groupBoxTraitement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.Panel panelDeco;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Panel panelBande;
    }
}

