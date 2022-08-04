namespace CentroHospitalario
{
    partial class questions_step2_Form
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question1 = new System.Windows.Forms.CheckedListBox();
            this.question2 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.question3 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.question4 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(498, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Regresar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(657, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 32);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Continuar";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cuestionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "1. ¿Que le motivo a ser enfermero (a)?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "2. ¿Que es lo mas gratificante que encuentra en esta profesion?";
            // 
            // question1
            // 
            this.question1.FormattingEnabled = true;
            this.question1.Items.AddRange(new object[] {
            "a. Ayudar a los pacientes",
            "b. Me interesa la salud de los pacientes",
            "c. Amplias posibilidates de empleo",
            "d. Es algo que me apasiona"});
            this.question1.Location = new System.Drawing.Point(38, 94);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(382, 64);
            this.question1.TabIndex = 16;
            // 
            // question2
            // 
            this.question2.FormattingEnabled = true;
            this.question2.Items.AddRange(new object[] {
            "a. Conocer a muchas pacientes que te lo agradecen",
            "b. Acceso a convenios de salud y atenicon particular",
            "c. Me encanta ayudar a la gente"});
            this.question2.Location = new System.Drawing.Point(38, 201);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(382, 49);
            this.question2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "3. ¿Como trataria con alguien que no esta satisfecho con su atencion al paciente?" +
    "";
            // 
            // question3
            // 
            this.question3.FormattingEnabled = true;
            this.question3.Items.AddRange(new object[] {
            "a. Guardar el respeto y la amabilidad",
            "b. Persuadirla, y demostrarle que esta equivocada",
            "c. Defenderme, brindar una respuesta adecuada a sus insultos",
            "d. Ignorando, dar la vuelta"});
            this.question3.Location = new System.Drawing.Point(38, 302);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(382, 64);
            this.question3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "4. ¿Que habilieds considera que tiene como enfermero (a)?";
            // 
            // question4
            // 
            this.question4.FormattingEnabled = true;
            this.question4.Items.AddRange(new object[] {
            "a. Me considero tolerante con los pacientes",
            "b. Me gusta escuchar a los pacientes",
            "c. Soy directo y sincero con los pacientes",
            "d. Me interesa apoyar a los pacientes en sus enfermedades"});
            this.question4.Location = new System.Drawing.Point(38, 406);
            this.question4.Name = "question4";
            this.question4.Size = new System.Drawing.Size(382, 64);
            this.question4.TabIndex = 21;
            // 
            // questions_step2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.question4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.question3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Name = "questions_step2_Form";
            this.Text = "Paso 2";
            this.Load += new System.EventHandler(this.questions_step2_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox question1;
        private System.Windows.Forms.CheckedListBox question2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox question3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox question4;
    }
}