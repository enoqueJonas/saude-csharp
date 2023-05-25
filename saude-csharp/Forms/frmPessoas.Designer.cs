namespace saude_csharp.Forms
{
    partial class frmPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPageDoctors = new System.Windows.Forms.TabPage();
            this.dataGridViewDoutores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdicionarDoutores = new System.Windows.Forms.Button();
            this.btnRemoverDoutores = new System.Windows.Forms.Button();
            this.tabPagePacients = new System.Windows.Forms.TabPage();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdcionarPacientes = new System.Windows.Forms.Button();
            this.btnRemoverPacientes = new System.Windows.Forms.Button();
            this.lblEstado2 = new System.Windows.Forms.Label();
            this.lblEstado3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoutores)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPagePacients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPageDoctors);
            this.tabControl1.Controls.Add(this.tabPagePacients);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1305, 850);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.lblEstado);
            this.tabPageUsers.Controls.Add(this.panel1);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(8, 39);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1289, 803);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Utilizadores";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            this.tabPageUsers.Click += new System.EventHandler(this.tabPageUsers_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(577, 389);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(134, 25);
            this.lblEstado.TabIndex = 49;
            this.lblEstado.Text = "Sem Registo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(1283, 87);
            this.panel1.MinimumSize = new System.Drawing.Size(1283, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 87);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(13, 14);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(187, 60);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "  Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(235, 14);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(187, 60);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "  Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.White;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 82;
            this.dataGridViewUsers.RowTemplate.Height = 33;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1283, 704);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // tabPageDoctors
            // 
            this.tabPageDoctors.Controls.Add(this.lblEstado2);
            this.tabPageDoctors.Controls.Add(this.dataGridViewDoutores);
            this.tabPageDoctors.Controls.Add(this.panel2);
            this.tabPageDoctors.Location = new System.Drawing.Point(8, 39);
            this.tabPageDoctors.Name = "tabPageDoctors";
            this.tabPageDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctors.Size = new System.Drawing.Size(1289, 803);
            this.tabPageDoctors.TabIndex = 1;
            this.tabPageDoctors.Text = "Doutores";
            this.tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoutores
            // 
            this.dataGridViewDoutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoutores.GridColor = System.Drawing.Color.White;
            this.dataGridViewDoutores.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewDoutores.Name = "dataGridViewDoutores";
            this.dataGridViewDoutores.RowHeadersVisible = false;
            this.dataGridViewDoutores.RowHeadersWidth = 82;
            this.dataGridViewDoutores.RowTemplate.Height = 33;
            this.dataGridViewDoutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoutores.Size = new System.Drawing.Size(1283, 704);
            this.dataGridViewDoutores.TabIndex = 2;
            this.dataGridViewDoutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoutores_CellClick);
            this.dataGridViewDoutores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoutores_CellDoubleClick);
            this.dataGridViewDoutores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoutores_CellEnter);
            this.dataGridViewDoutores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDoutores_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAdicionarDoutores);
            this.panel2.Controls.Add(this.btnRemoverDoutores);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(1283, 87);
            this.panel2.MinimumSize = new System.Drawing.Size(1283, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 87);
            this.panel2.TabIndex = 3;
            // 
            // btnAdicionarDoutores
            // 
            this.btnAdicionarDoutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAdicionarDoutores.FlatAppearance.BorderSize = 0;
            this.btnAdicionarDoutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDoutores.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarDoutores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDoutores.Image")));
            this.btnAdicionarDoutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarDoutores.Location = new System.Drawing.Point(15, 14);
            this.btnAdicionarDoutores.Name = "btnAdicionarDoutores";
            this.btnAdicionarDoutores.Size = new System.Drawing.Size(187, 60);
            this.btnAdicionarDoutores.TabIndex = 4;
            this.btnAdicionarDoutores.Text = "  Adicionar";
            this.btnAdicionarDoutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarDoutores.UseVisualStyleBackColor = false;
            this.btnAdicionarDoutores.Click += new System.EventHandler(this.btnAdicionarDoutores_Click);
            // 
            // btnRemoverDoutores
            // 
            this.btnRemoverDoutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRemoverDoutores.FlatAppearance.BorderSize = 0;
            this.btnRemoverDoutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverDoutores.ForeColor = System.Drawing.Color.White;
            this.btnRemoverDoutores.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverDoutores.Image")));
            this.btnRemoverDoutores.Location = new System.Drawing.Point(237, 14);
            this.btnRemoverDoutores.Name = "btnRemoverDoutores";
            this.btnRemoverDoutores.Size = new System.Drawing.Size(187, 60);
            this.btnRemoverDoutores.TabIndex = 3;
            this.btnRemoverDoutores.Text = "  Remover";
            this.btnRemoverDoutores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverDoutores.UseVisualStyleBackColor = false;
            this.btnRemoverDoutores.Click += new System.EventHandler(this.btnRemoverDoutores_Click);
            // 
            // tabPagePacients
            // 
            this.tabPagePacients.Controls.Add(this.lblEstado3);
            this.tabPagePacients.Controls.Add(this.dataGridViewPacientes);
            this.tabPagePacients.Controls.Add(this.panel3);
            this.tabPagePacients.Location = new System.Drawing.Point(8, 39);
            this.tabPagePacients.Name = "tabPagePacients";
            this.tabPagePacients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacients.Size = new System.Drawing.Size(1289, 803);
            this.tabPagePacients.TabIndex = 2;
            this.tabPagePacients.Text = "Pacientes";
            this.tabPagePacients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.GridColor = System.Drawing.Color.White;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.RowHeadersVisible = false;
            this.dataGridViewPacientes.RowHeadersWidth = 82;
            this.dataGridViewPacientes.RowTemplate.Height = 33;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(1283, 704);
            this.dataGridViewPacientes.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnAdcionarPacientes);
            this.panel3.Controls.Add(this.btnRemoverPacientes);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.MaximumSize = new System.Drawing.Size(1283, 87);
            this.panel3.MinimumSize = new System.Drawing.Size(1283, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1283, 87);
            this.panel3.TabIndex = 3;
            // 
            // btnAdcionarPacientes
            // 
            this.btnAdcionarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAdcionarPacientes.FlatAppearance.BorderSize = 0;
            this.btnAdcionarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdcionarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnAdcionarPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarPacientes.Image")));
            this.btnAdcionarPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdcionarPacientes.Location = new System.Drawing.Point(16, 13);
            this.btnAdcionarPacientes.Name = "btnAdcionarPacientes";
            this.btnAdcionarPacientes.Size = new System.Drawing.Size(187, 60);
            this.btnAdcionarPacientes.TabIndex = 4;
            this.btnAdcionarPacientes.Text = "  Adicionar";
            this.btnAdcionarPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdcionarPacientes.UseVisualStyleBackColor = false;
            // 
            // btnRemoverPacientes
            // 
            this.btnRemoverPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRemoverPacientes.FlatAppearance.BorderSize = 0;
            this.btnRemoverPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPacientes.ForeColor = System.Drawing.Color.White;
            this.btnRemoverPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverPacientes.Image")));
            this.btnRemoverPacientes.Location = new System.Drawing.Point(238, 13);
            this.btnRemoverPacientes.Name = "btnRemoverPacientes";
            this.btnRemoverPacientes.Size = new System.Drawing.Size(187, 60);
            this.btnRemoverPacientes.TabIndex = 3;
            this.btnRemoverPacientes.Text = "  Remover";
            this.btnRemoverPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverPacientes.UseVisualStyleBackColor = false;
            this.btnRemoverPacientes.Click += new System.EventHandler(this.btnRemoverPacientes_Click);
            // 
            // lblEstado2
            // 
            this.lblEstado2.AutoSize = true;
            this.lblEstado2.Location = new System.Drawing.Point(577, 389);
            this.lblEstado2.Name = "lblEstado2";
            this.lblEstado2.Size = new System.Drawing.Size(134, 25);
            this.lblEstado2.TabIndex = 50;
            this.lblEstado2.Text = "Sem Registo";
            // 
            // lblEstado3
            // 
            this.lblEstado3.AutoSize = true;
            this.lblEstado3.Location = new System.Drawing.Point(577, 389);
            this.lblEstado3.Name = "lblEstado3";
            this.lblEstado3.Size = new System.Drawing.Size(134, 25);
            this.lblEstado3.TabIndex = 50;
            this.lblEstado3.Text = "Sem Registo";
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 850);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "frmPessoas";
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.frmPessoas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageDoctors.ResumeLayout(false);
            this.tabPageDoctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoutores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPagePacients.ResumeLayout(false);
            this.tabPagePacients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageDoctors;
        private System.Windows.Forms.TabPage tabPagePacients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewDoutores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionarDoutores;
        private System.Windows.Forms.Button btnRemoverDoutores;
        private System.Windows.Forms.Button btnAdcionarPacientes;
        private System.Windows.Forms.Button btnRemoverPacientes;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstado2;
        private System.Windows.Forms.Label lblEstado3;
    }
}