namespace CentroHospitalario
{
    partial class questions_step4_Form
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
            this.question6 = new System.Windows.Forms.CheckedListBox();
            this.question5 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question6
            // 
            this.question6.FormattingEnabled = true;
            this.question6.Items.AddRange(new object[] {
            "a. Le hablaria y me aseguraria que no lo vuelva hacer.",
            "b. Comunico el caso inmediatamente a un superior",
            "c. Le explicaria como debe realizar la practica o aplicar el medicamenteo.",
            "d. Guardo silencio si considero que no es grave",
            "e. Guardo silencio porque no es mi area de paciente"});
            this.question6.Location = new System.Drawing.Point(49, 202);
            this.question6.Name = "question6";
            this.question6.Size = new System.Drawing.Size(382, 79);
            this.question6.TabIndex = 37;
            // 
            // question5
            // 
            this.question5.FormattingEnabled = true;
            this.question5.Items.AddRange(new object[] {
            "a. Si, me comporte amable y logre calmarlo",
            "b. Si, le explique a se exponia su salud",
            "c. Si, pero traslade el caso a un compañero",
            "d. No, pero seria tolerante"});
            this.question5.Location = new System.Drawing.Point(38, 63);
            this.question5.Name = "question5";
            this.question5.Size = new System.Drawing.Size(382, 49);
            this.question5.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "10. Si se diera el caso, donde observes que alguien esta aplicando medicamente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "9. Se ha presentado caso en los que lidio con pacientes dificiles, como lo resolv" +
    "io";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(395, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 32);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Regresar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnd.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnd.Location = new System.Drawing.Point(602, 392);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(186, 32);
            this.btnEnd.TabIndex = 32;
            this.btnEnd.Text = "Enviar resultado";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "o bien realizando practicas no recomendadas. ¿Que harias?";
            // 
            // questions_step4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.question6);
            this.Controls.Add(this.question5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnd);
            this.Name = "questions_step4_Form";
            this.Text = "Paso 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox question6;
        private System.Windows.Forms.CheckedListBox question5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label1;
    }
}