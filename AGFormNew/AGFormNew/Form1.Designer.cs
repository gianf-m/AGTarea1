namespace AGFormNew
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
            txt_Precision = new TextBox();
            txt_LimIzq = new TextBox();
            txt_LimDer = new TextBox();
            btn_AgregarVariable = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GV_Variables = new DataGridView();
            label5 = new Label();
            txt_NroBitsTotales = new TextBox();
            txt_CromosomaTotal = new TextBox();
            label6 = new Label();
            btn_Limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)GV_Variables).BeginInit();
            SuspendLayout();
            // 
            // txt_Precision
            // 
            txt_Precision.Location = new Point(51, 91);
            txt_Precision.Name = "txt_Precision";
            txt_Precision.Size = new Size(100, 23);
            txt_Precision.TabIndex = 0;
            txt_Precision.KeyPress += txt_Precision_KeyPress;
            // 
            // txt_LimIzq
            // 
            txt_LimIzq.Location = new Point(157, 91);
            txt_LimIzq.Name = "txt_LimIzq";
            txt_LimIzq.Size = new Size(100, 23);
            txt_LimIzq.TabIndex = 1;
            txt_LimIzq.KeyPress += textBoxDecimal_KeyPress;
            // 
            // txt_LimDer
            // 
            txt_LimDer.Location = new Point(263, 91);
            txt_LimDer.Name = "txt_LimDer";
            txt_LimDer.Size = new Size(100, 23);
            txt_LimDer.TabIndex = 2;
            txt_LimDer.KeyPress += textBoxDecimal_KeyPress;
            // 
            // btn_AgregarVariable
            // 
            btn_AgregarVariable.Location = new Point(369, 90);
            btn_AgregarVariable.Name = "btn_AgregarVariable";
            btn_AgregarVariable.Size = new Size(128, 23);
            btn_AgregarVariable.TabIndex = 3;
            btn_AgregarVariable.Text = "Agregar variable";
            btn_AgregarVariable.UseVisualStyleBackColor = true;
            btn_AgregarVariable.Click += btn_AgregarVariable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 4;
            label1.Text = "Tarea 1 Algoritmos Geneticos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Precisión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 73);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Limite Izquierdo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 73);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Limite Derecho";
            // 
            // GV_Variables
            // 
            GV_Variables.AllowUserToAddRows = false;
            GV_Variables.AllowUserToDeleteRows = false;
            GV_Variables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV_Variables.Location = new Point(51, 120);
            GV_Variables.Name = "GV_Variables";
            GV_Variables.ReadOnly = true;
            GV_Variables.Size = new Size(738, 175);
            GV_Variables.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 326);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 10;
            label5.Text = "Numero de bits totales";
            // 
            // txt_NroBitsTotales
            // 
            txt_NroBitsTotales.Enabled = false;
            txt_NroBitsTotales.Location = new Point(51, 344);
            txt_NroBitsTotales.Name = "txt_NroBitsTotales";
            txt_NroBitsTotales.Size = new Size(127, 23);
            txt_NroBitsTotales.TabIndex = 11;
            // 
            // txt_CromosomaTotal
            // 
            txt_CromosomaTotal.Enabled = false;
            txt_CromosomaTotal.Location = new Point(184, 344);
            txt_CromosomaTotal.Name = "txt_CromosomaTotal";
            txt_CromosomaTotal.Size = new Size(605, 23);
            txt_CromosomaTotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 326);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 12;
            label6.Text = "Cromosoma Total";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(679, 301);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(110, 23);
            btn_Limpiar.TabIndex = 14;
            btn_Limpiar.Text = "Limpiar Todo";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 398);
            Controls.Add(btn_Limpiar);
            Controls.Add(txt_CromosomaTotal);
            Controls.Add(label6);
            Controls.Add(txt_NroBitsTotales);
            Controls.Add(label5);
            Controls.Add(GV_Variables);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AgregarVariable);
            Controls.Add(txt_LimDer);
            Controls.Add(txt_LimIzq);
            Controls.Add(txt_Precision);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GV_Variables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Precision;
        private TextBox txt_LimIzq;
        private TextBox txt_LimDer;
        private Button btn_AgregarVariable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView GV_Variables;
        private Label label5;
        private TextBox txt_NroBitsTotales;
        private TextBox txt_CromosomaTotal;
        private Label label6;
        private Button btn_Limpiar;
    }
}
