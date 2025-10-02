namespace Actividad8._1
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
            lbNombre = new Label();
            lbDNI = new Label();
            lbImporte = new Label();
            listBox1 = new ListBox();
            btnConfirmar = new Button();
            btnActualizar = new Button();
            tbNombre = new TextBox();
            tbImporte = new TextBox();
            tbDNI = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportar = new Button();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(12, 9);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Location = new Point(12, 39);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(27, 15);
            lbDNI.TabIndex = 1;
            lbDNI.Text = "DNI";
            // 
            // lbImporte
            // 
            lbImporte.AutoSize = true;
            lbImporte.Location = new Point(12, 72);
            lbImporte.Name = "lbImporte";
            lbImporte.Size = new Size(49, 15);
            lbImporte.TabIndex = 2;
            lbImporte.Text = "Importe";
            lbImporte.Click += label3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 139);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(236, 34);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(236, 160);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(113, 6);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 6;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(113, 64);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 7;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(113, 35);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(100, 23);
            tbDNI.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(236, 102);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 262);
            Controls.Add(btnImportar);
            Controls.Add(tbDNI);
            Controls.Add(tbImporte);
            Controls.Add(tbNombre);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(listBox1);
            Controls.Add(lbImporte);
            Controls.Add(lbDNI);
            Controls.Add(lbNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbDNI;
        private Label lbImporte;
        private ListBox listBox1;
        private Button btnConfirmar;
        private Button btnActualizar;
        private TextBox tbNombre;
        private TextBox tbImporte;
        private TextBox tbDNI;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnImportar;
    }
}
