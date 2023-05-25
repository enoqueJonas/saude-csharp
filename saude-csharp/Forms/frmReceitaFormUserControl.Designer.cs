namespace pcsharp_saude.Views
{
    partial class ReceitasForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Label lblReceitas;
        private System.Windows.Forms.Label lblConsultaId;
        private System.Windows.Forms.TextBox txtConsultaId;
        private System.Windows.Forms.Label lblCreatedByUtilizadorId;
        private System.Windows.Forms.TextBox txtCreatedByUtilizadorId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Label lblReceitaId;
        private System.Windows.Forms.TextBox txtReceitaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByUtilizadorId;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.lblConsultaId = new System.Windows.Forms.Label();
            this.txtConsultaId = new System.Windows.Forms.TextBox();
            this.lblCreatedByUtilizadorId = new System.Windows.Forms.Label();
            this.txtCreatedByUtilizadorId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.lblReceitaId = new System.Windows.Forms.Label();
            this.txtReceitaId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByUtilizadorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            // dgvReceitas
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Id,
                this.ConsultaId,
                this.CreatedAt,
                this.CreatedByUtilizadorId
            });
            this.dgvReceitas.Location = new System.Drawing.Point(12, 30);
            this.dgvReceitas.MultiSelect = false;
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceitas.Size = new System.Drawing.Size(550, 200);
            this.dgvReceitas.TabIndex = 0;
            this.dgvReceitas.SelectionChanged += new System.EventHandler(this.dgvReceitas_SelectionChanged);

            // lblReceitas
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Location = new System.Drawing.Point(12, 9);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(50, 13);
            this.lblReceitas.TabIndex = 1;
            this.lblReceitas.Text = "Receitas:";

            // lblConsultaId
            this.lblConsultaId.AutoSize = true;
            this.lblConsultaId.Location = new System.Drawing.Point(12, 250);
            this.lblConsultaId.Name = "lblConsultaId";
            this.lblConsultaId.Size = new System.Drawing.Size(62, 13);
            this.lblConsultaId.TabIndex = 2;
            this.lblConsultaId.Text = "Consulta ID:";

            // txtConsultaId
            this.txtConsultaId.Location = new System.Drawing.Point(80, 247);
            this.txtConsultaId.Name = "txtConsultaId";
            this.txtConsultaId.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaId.TabIndex = 3;

            // lblCreatedByUtilizadorId
            this.lblCreatedByUtilizadorId.AutoSize = true;
            this.lblCreatedByUtilizadorId.Location = new System.Drawing.Point(12, 280);
            this.lblCreatedByUtilizadorId.Name = "lblCreatedByUtilizadorId";
            this.lblCreatedByUtilizadorId.Size = new System.Drawing.Size(119, 13);
            this.lblCreatedByUtilizadorId.TabIndex = 4;
            this.lblCreatedByUtilizadorId.Text = "Created By Utilizador ID:";

            // txtCreatedByUtilizadorId
            this.txtCreatedByUtilizadorId.Location = new System.Drawing.Point(137, 277);
            this.txtCreatedByUtilizadorId.Name = "txtCreatedByUtilizadorId";
            this.txtCreatedByUtilizadorId.Size = new System.Drawing.Size(100, 20);
            this.txtCreatedByUtilizadorId.TabIndex = 5;

            // btnCreate
            this.btnCreate.Location = new System.Drawing.Point(12, 310);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(93, 310);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(174, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // lblMedicamento
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(12, 340);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(74, 13);
            this.lblMedicamento.TabIndex = 9;
            this.lblMedicamento.Text = "Medicamento:";

            // cmbMedicamento
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Location = new System.Drawing.Point(92, 337);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(145, 21);
            this.cmbMedicamento.TabIndex = 10;

            // lblReceitaId
            this.lblReceitaId.AutoSize = true;
            this.lblReceitaId.Location = new System.Drawing.Point(12, 370);
            this.lblReceitaId.Name = "lblReceitaId";
            this.lblReceitaId.Size = new System.Drawing.Size(57, 13);
            this.lblReceitaId.TabIndex = 11;
            this.lblReceitaId.Text = "Receita ID:";

            // txtReceitaId
            this.txtReceitaId.Location = new System.Drawing.Point(75, 367);
            this.txtReceitaId.Name = "txtReceitaId";
            this.txtReceitaId.Size = new System.Drawing.Size(100, 20);
            this.txtReceitaId.TabIndex = 12;

            // Id
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;

            // ConsultaId
            this.ConsultaId.HeaderText = "Consulta ID";
            this.ConsultaId.Name = "ConsultaId";
            this.ConsultaId.ReadOnly = true;

            // CreatedAt
            this.CreatedAt.HeaderText = "Created At";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;

            // CreatedByUtilizadorId
            this.CreatedByUtilizadorId.HeaderText = "Created By Utilizador ID";
            this.CreatedByUtilizadorId.Name = "CreatedByUtilizadorId";
            this.CreatedByUtilizadorId.ReadOnly = true;

            // ReceitasForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 403);
            this.Controls.Add(this.txtReceitaId);
            this.Controls.Add(this.lblReceitaId);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCreatedByUtilizadorId);
            this.Controls.Add(this.lblCreatedByUtilizadorId);
            this.Controls.Add(this.txtConsultaId);
            this.Controls.Add(this.lblConsultaId);
            this.Controls.Add(this.lblReceitas);
            this.Controls.Add(this.dgvReceitas);
            this.Name = "ReceitasForm";
            this.Text = "ReceitasForm";
            this.Load += new System.EventHandler(this.ReceitasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
