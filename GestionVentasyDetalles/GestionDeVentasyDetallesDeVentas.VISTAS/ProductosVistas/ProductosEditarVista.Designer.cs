﻿namespace GestionDeVentasyDetallesDeVentas.VISTAS.ProductosVistas
{
    partial class ProductosEditarVista
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
            textBox2 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 56);
            panel2.TabIndex = 23;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(234, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 0;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 27);
            textBox1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(58, 188);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 21;
            label2.Text = "Precio Unitario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(26, 117);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 20;
            label1.Text = "Nombre Del Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 56);
            panel1.TabIndex = 19;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(575, 56);
            label3.TabIndex = 0;
            label3.Text = "EDITAR PRODUCTO";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProductosEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 313);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ProductosEditarVista";
            Text = "ProductosEditarVista";
            Load += ProductosEditarVista_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}