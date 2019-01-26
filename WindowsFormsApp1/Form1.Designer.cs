namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btnArroz = new System.Windows.Forms.Button();
            this.btnCarneMoida = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnFrango = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tckPotencia = new System.Windows.Forms.TrackBar();
            this.lblPotencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tckPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplay.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.Location = new System.Drawing.Point(34, 36);
            this.lblDisplay.MaximumSize = new System.Drawing.Size(0, 150);
            this.lblDisplay.MinimumSize = new System.Drawing.Size(170, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(170, 40);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "00:00";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(386, 254);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 43);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPipoca
            // 
            this.btnPipoca.Location = new System.Drawing.Point(386, 114);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(99, 43);
            this.btnPipoca.TabIndex = 2;
            this.btnPipoca.Text = "Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = true;
            this.btnPipoca.Click += new System.EventHandler(this.btnPipoca_Click);
            // 
            // btnArroz
            // 
            this.btnArroz.Location = new System.Drawing.Point(281, 163);
            this.btnArroz.Name = "btnArroz";
            this.btnArroz.Size = new System.Drawing.Size(99, 43);
            this.btnArroz.TabIndex = 3;
            this.btnArroz.Text = "Arroz";
            this.btnArroz.UseVisualStyleBackColor = true;
            this.btnArroz.Click += new System.EventHandler(this.btnArroz_Click);
            // 
            // btnCarneMoida
            // 
            this.btnCarneMoida.Location = new System.Drawing.Point(386, 163);
            this.btnCarneMoida.Name = "btnCarneMoida";
            this.btnCarneMoida.Size = new System.Drawing.Size(99, 43);
            this.btnCarneMoida.TabIndex = 4;
            this.btnCarneMoida.Text = "Carne Moida";
            this.btnCarneMoida.UseVisualStyleBackColor = true;
            this.btnCarneMoida.Click += new System.EventHandler(this.btnCarneMoida_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(281, 254);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(99, 43);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(92, 254);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 48);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(151, 92);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 48);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(92, 92);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 48);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(33, 92);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 48);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(151, 146);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 48);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(92, 146);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 48);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(33, 146);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 48);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(151, 200);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 48);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(92, 200);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 48);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(33, 200);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 48);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnFrango
            // 
            this.btnFrango.Location = new System.Drawing.Point(281, 114);
            this.btnFrango.Name = "btnFrango";
            this.btnFrango.Size = new System.Drawing.Size(99, 43);
            this.btnFrango.TabIndex = 17;
            this.btnFrango.Text = "Frango";
            this.btnFrango.UseVisualStyleBackColor = true;
            this.btnFrango.Click += new System.EventHandler(this.btnFrango_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tckPotencia
            // 
            this.tckPotencia.Location = new System.Drawing.Point(281, 31);
            this.tckPotencia.Name = "tckPotencia";
            this.tckPotencia.Size = new System.Drawing.Size(204, 45);
            this.tckPotencia.TabIndex = 18;
            this.tckPotencia.TabStop = false;
            this.tckPotencia.TickFrequency = 0;
            this.tckPotencia.Scroll += new System.EventHandler(this.tckPotencia_Scroll);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencia.Location = new System.Drawing.Point(290, 79);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(106, 18);
            this.lblPotencia.TabIndex = 19;
            this.lblPotencia.Text = "Potência: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 352);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.tckPotencia);
            this.Controls.Add(this.btnFrango);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCarneMoida);
            this.Controls.Add(this.btnArroz);
            this.Controls.Add(this.btnPipoca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tckPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btnArroz;
        private System.Windows.Forms.Button btnCarneMoida;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnFrango;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tckPotencia;
        private System.Windows.Forms.Label lblPotencia;
    }
}

