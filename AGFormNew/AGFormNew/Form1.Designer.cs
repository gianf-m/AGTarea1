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
        private void InitializeComponent() {
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
            txt_SubStringDecimal = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)GV_Variables).BeginInit();
            SuspendLayout();
            // 
            // txt_Precision
            // 
            txt_Precision.Location = new Point(58, 121);
            txt_Precision.Margin = new Padding(3, 4, 3, 4);
            txt_Precision.Name = "txt_Precision";
            txt_Precision.Size = new Size(114, 27);
            txt_Precision.TabIndex = 0;
            txt_Precision.KeyPress += txt_Precision_KeyPress;
            // 
            // txt_LimIzq
            // 
            txt_LimIzq.Location = new Point(179, 121);
            txt_LimIzq.Margin = new Padding(3, 4, 3, 4);
            txt_LimIzq.Name = "txt_LimIzq";
            txt_LimIzq.Size = new Size(114, 27);
            txt_LimIzq.TabIndex = 1;
            txt_LimIzq.KeyPress += textBoxDecimal_KeyPress;
            // 
            // txt_LimDer
            // 
            txt_LimDer.Location = new Point(301, 121);
            txt_LimDer.Margin = new Padding(3, 4, 3, 4);
            txt_LimDer.Name = "txt_LimDer";
            txt_LimDer.Size = new Size(114, 27);
            txt_LimDer.TabIndex = 2;
            txt_LimDer.KeyPress += textBoxDecimal_KeyPress;
            // 
            // btn_AgregarVariable
            // 
            btn_AgregarVariable.Location = new Point(422, 120);
            btn_AgregarVariable.Margin = new Padding(3, 4, 3, 4);
            btn_AgregarVariable.Name = "btn_AgregarVariable";
            btn_AgregarVariable.Size = new Size(146, 31);
            btn_AgregarVariable.TabIndex = 3;
            btn_AgregarVariable.Text = "Agregar variable";
            btn_AgregarVariable.UseVisualStyleBackColor = true;
            btn_AgregarVariable.Click += btn_AgregarVariable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 4;
            label1.Text = "Tarea 1 Algoritmos Geneticos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Precisión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 97);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 6;
            label3.Text = "Limite Izquierdo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 97);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "Limite Derecho";
            // 
            // GV_Variables
            // 
            GV_Variables.AllowUserToAddRows = false;
            GV_Variables.AllowUserToDeleteRows = false;
            GV_Variables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV_Variables.Location = new Point(58, 160);
            GV_Variables.Margin = new Padding(3, 4, 3, 4);
            GV_Variables.Name = "GV_Variables";
            GV_Variables.ReadOnly = true;
            GV_Variables.RowHeadersWidth = 51;
            GV_Variables.Size = new Size(843, 233);
            GV_Variables.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 435);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 10;
            label5.Text = "Numero de bits totales";
            // 
            // txt_NroBitsTotales
            // 
            txt_NroBitsTotales.Enabled = false;
            txt_NroBitsTotales.Location = new Point(58, 459);
            txt_NroBitsTotales.Margin = new Padding(3, 4, 3, 4);
            txt_NroBitsTotales.Name = "txt_NroBitsTotales";
            txt_NroBitsTotales.Size = new Size(161, 27);
            txt_NroBitsTotales.TabIndex = 11;
            // 
            // txt_CromosomaTotal
            // 
            txt_CromosomaTotal.Enabled = false;
            txt_CromosomaTotal.Location = new Point(58, 521);
            txt_CromosomaTotal.Margin = new Padding(3, 4, 3, 4);
            txt_CromosomaTotal.Name = "txt_CromosomaTotal";
            txt_CromosomaTotal.Size = new Size(843, 27);
            txt_CromosomaTotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 497);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 12;
            label6.Text = "Cromosoma Total";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(776, 401);
            btn_Limpiar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(126, 31);
            btn_Limpiar.TabIndex = 14;
            btn_Limpiar.Text = "Limpiar Todo";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // txt_SubStringDecimal
            // 
            txt_SubStringDecimal.Enabled = false;
            txt_SubStringDecimal.Location = new Point(250, 459);
            txt_SubStringDecimal.Margin = new Padding(3, 4, 3, 4);
            txt_SubStringDecimal.Name = "txt_SubStringDecimal";
            txt_SubStringDecimal.Size = new Size(161, 27);
            txt_SubStringDecimal.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 435);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 15;
            label7.Text = "Substring Decimal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 561);
            Controls.Add(txt_SubStringDecimal);
            Controls.Add(label7);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txt_SubStringDecimal;
        private Label label7;
    }
}
