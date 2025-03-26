namespace Presentacion
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
            dataGridVehiculo = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMatricula = new TextBox();
            textBoxMarca = new TextBox();
            textBoxAño = new TextBox();
            textBoxKilometraje = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonAñadir = new Button();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridVehiculo
            // 
            dataGridVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehiculo.Location = new Point(50, 26);
            dataGridVehiculo.Name = "dataGridVehiculo";
            dataGridVehiculo.RowHeadersWidth = 51;
            dataGridVehiculo.Size = new Size(551, 426);
            dataGridVehiculo.TabIndex = 0;
            dataGridVehiculo.SelectionChanged += dataGridVehiculo_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridVehiculo);
            groupBox1.Location = new Point(592, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 472);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 139);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 5;
            label4.Text = "Kilometraje";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(98, 33);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(125, 27);
            textBoxMatricula.TabIndex = 6;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(98, 66);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(125, 27);
            textBoxMarca.TabIndex = 7;
            // 
            // textBoxAño
            // 
            textBoxAño.Location = new Point(98, 99);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new Size(125, 27);
            textBoxAño.TabIndex = 8;
            // 
            // textBoxKilometraje
            // 
            textBoxKilometraje.Location = new Point(98, 132);
            textBoxKilometraje.Name = "textBoxKilometraje";
            textBoxKilometraje.Size = new Size(125, 27);
            textBoxKilometraje.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxMatricula);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxKilometraje);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxMarca);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxAño);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(80, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 184);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonModificar);
            groupBox3.Controls.Add(buttonEliminar);
            groupBox3.Controls.Add(buttonAñadir);
            groupBox3.Location = new Point(329, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(145, 184);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(6, 130);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(128, 29);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(6, 83);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(128, 29);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(6, 33);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(128, 29);
            buttonAñadir.TabIndex = 0;
            buttonAñadir.Text = "AÑADIR";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(574, 472);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 496);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Automotora";
            ((System.ComponentModel.ISupportInitialize)dataGridVehiculo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridVehiculo;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMatricula;
        private TextBox textBoxMarca;
        private TextBox textBoxAño;
        private TextBox textBoxKilometraje;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonAñadir;
        private GroupBox groupBox4;
    }
}
