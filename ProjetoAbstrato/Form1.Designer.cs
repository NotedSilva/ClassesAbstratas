namespace ProjetoAbstrato
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
            Nome = new Label();
            Salario = new Label();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            rbDesigner = new RadioButton();
            rbProgramador = new RadioButton();
            rbDesenvolvedorWeb = new RadioButton();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(34, 40);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            // 
            // Salario
            // 
            Salario.AutoSize = true;
            Salario.Location = new Point(34, 119);
            Salario.Name = "Salario";
            Salario.Size = new Size(45, 15);
            Salario.TabIndex = 1;
            Salario.Text = "Salário:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(485, 23);
            txtNome.TabIndex = 2;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(34, 153);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(232, 23);
            txtSalario.TabIndex = 3;
            // 
            // rbDesigner
            // 
            rbDesigner.AutoSize = true;
            rbDesigner.Location = new Point(34, 217);
            rbDesigner.Name = "rbDesigner";
            rbDesigner.Size = new Size(71, 19);
            rbDesigner.TabIndex = 4;
            rbDesigner.TabStop = true;
            rbDesigner.Text = "Designer";
            rbDesigner.UseVisualStyleBackColor = true;
            // 
            // rbProgramador
            // 
            rbProgramador.AutoSize = true;
            rbProgramador.Location = new Point(34, 277);
            rbProgramador.Name = "rbProgramador";
            rbProgramador.Size = new Size(95, 19);
            rbProgramador.TabIndex = 5;
            rbProgramador.TabStop = true;
            rbProgramador.Text = "Programador";
            rbProgramador.UseVisualStyleBackColor = true;
            // 
            // rbDesenvolvedorWeb
            // 
            rbDesenvolvedorWeb.AutoSize = true;
            rbDesenvolvedorWeb.Location = new Point(34, 341);
            rbDesenvolvedorWeb.Name = "rbDesenvolvedorWeb";
            rbDesenvolvedorWeb.Size = new Size(130, 19);
            rbDesenvolvedorWeb.TabIndex = 6;
            rbDesenvolvedorWeb.TabStop = true;
            rbDesenvolvedorWeb.Text = "Desenvolvedor Web";
            rbDesenvolvedorWeb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 393);
            button1.Name = "button1";
            button1.Size = new Size(106, 30);
            button1.TabIndex = 7;
            button1.Text = "Reajustar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(34, 460);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 21);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 509);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(rbDesenvolvedorWeb);
            Controls.Add(rbProgramador);
            Controls.Add(rbDesigner);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(Salario);
            Controls.Add(Nome);
            Name = "Form1";
            Text = "Reajuste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Salario;
        private TextBox txtNome;
        private TextBox txtSalario;
        private RadioButton rbDesigner;
        private RadioButton rbProgramador;
        private RadioButton rbDesenvolvedorWeb;
        private Button button1;
        private Label lblResultado;
    }
}