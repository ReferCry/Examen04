﻿namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRegion = new DataGridView();
            btnListar = new Button();
            btnInsertar = new Button();
            txtRegionName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            SuspendLayout();
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new Point(38, 206);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.Size = new Size(698, 221);
            dgvRegion.TabIndex = 0;
            dgvRegion.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(311, 37);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(421, 37);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtRegionName
            // 
            txtRegionName.Location = new Point(536, 37);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(100, 23);
            txtRegionName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRegionName);
            Controls.Add(btnInsertar);
            Controls.Add(btnListar);
            Controls.Add(dgvRegion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRegion;
        private Button btnListar;
        private Button btnInsertar;
        private TextBox txtRegionName;
    }
}
