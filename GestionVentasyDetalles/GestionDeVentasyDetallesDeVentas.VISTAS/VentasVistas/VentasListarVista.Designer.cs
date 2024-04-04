﻿namespace GestionDeVentasyDetallesDeVentas.VISTAS.VentasVistas
{
    partial class VentasListarVista
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            buttonSeleccionar = new Button();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonInsertar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(246, 2);
            label1.Name = "label1";
            label1.Size = new Size(305, 54);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE VENTAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(buttonSeleccionar);
            panel2.Controls.Add(buttonEliminar);
            panel2.Controls.Add(buttonEditar);
            panel2.Controls.Add(buttonInsertar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 56);
            panel2.TabIndex = 1;
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.DialogResult = DialogResult.OK;
            buttonSeleccionar.Font = new Font("Impact", 12F);
            buttonSeleccionar.Location = new Point(640, 12);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(130, 32);
            buttonSeleccionar.TabIndex = 3;
            buttonSeleccionar.Text = "SELECCIONAR";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Impact", 12F);
            buttonEliminar.Location = new Point(442, 12);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(113, 32);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Font = new Font("Impact", 12F);
            buttonEditar.Location = new Point(244, 12);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(113, 32);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Font = new Font("Impact", 12F);
            buttonInsertar.Location = new Point(46, 12);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(113, 32);
            buttonInsertar.TabIndex = 0;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 341);
            dataGridView1.TabIndex = 2;
            // 
            // VentasListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VentasListarVista";
            Text = "VentasListarVista";
            Load += VentasListarVista_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button buttonSeleccionar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonInsertar;
        private DataGridView dataGridView1;
    }
}