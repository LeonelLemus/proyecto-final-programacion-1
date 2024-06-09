namespace bookmedik_win
{
    partial class ReservationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.pacient = new System.Windows.Forms.ComboBox();
            this.medic = new System.Windows.Forms.ComboBox();
            this.date_at = new System.Windows.Forms.TextBox();
            this.time_at = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha(yyyy-mm-dd):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora(hh:mm:ss):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nota:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(224, 84);
            this.title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 22);
            this.title.TabIndex = 6;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(77, 33);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(119, 25);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Nueva Cita";
            // 
            // pacient
            // 
            this.pacient.FormattingEnabled = true;
            this.pacient.Location = new System.Drawing.Point(224, 116);
            this.pacient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pacient.Name = "pacient";
            this.pacient.Size = new System.Drawing.Size(263, 24);
            this.pacient.TabIndex = 8;
            // 
            // medic
            // 
            this.medic.FormattingEnabled = true;
            this.medic.Location = new System.Drawing.Point(224, 149);
            this.medic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.medic.Name = "medic";
            this.medic.Size = new System.Drawing.Size(263, 24);
            this.medic.TabIndex = 9;
            // 
            // date_at
            // 
            this.date_at.Location = new System.Drawing.Point(224, 182);
            this.date_at.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_at.Name = "date_at";
            this.date_at.Size = new System.Drawing.Size(263, 22);
            this.date_at.TabIndex = 10;
            // 
            // time_at
            // 
            this.time_at.Location = new System.Drawing.Point(224, 218);
            this.time_at.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time_at.Name = "time_at";
            this.time_at.Size = new System.Drawing.Size(263, 22);
            this.time_at.TabIndex = 11;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(224, 250);
            this.note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(263, 95);
            this.note.TabIndex = 12;
            this.note.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(388, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(83, 353);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 28);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 422);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.time_at);
            this.Controls.Add(this.date_at);
            this.Controls.Add(this.medic);
            this.Controls.Add(this.pacient);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Cita";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox pacient;
        private System.Windows.Forms.ComboBox medic;
        private System.Windows.Forms.TextBox date_at;
        private System.Windows.Forms.TextBox time_at;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_del;
    }
}