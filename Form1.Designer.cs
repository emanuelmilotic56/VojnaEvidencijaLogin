namespace AplikacijaZaVojnoNovacenje_EM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUnosNovaka = new System.Windows.Forms.Button();
            this.btnStatusNovaka = new System.Windows.Forms.Button();
            this.btnPregledNovaka = new System.Windows.Forms.Button();
            this.btnOtpustNovaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnosNovaka
            // 
            this.btnUnosNovaka.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnUnosNovaka.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosNovaka.ForeColor = System.Drawing.Color.Black;
            this.btnUnosNovaka.Location = new System.Drawing.Point(12, 12);
            this.btnUnosNovaka.Name = "btnUnosNovaka";
            this.btnUnosNovaka.Size = new System.Drawing.Size(380, 201);
            this.btnUnosNovaka.TabIndex = 0;
            this.btnUnosNovaka.Text = "UNOS NOVAKA";
            this.btnUnosNovaka.UseVisualStyleBackColor = false;
            this.btnUnosNovaka.Click += new System.EventHandler(this.btnUnosNovaka_Click);
            // 
            // btnStatusNovaka
            // 
            this.btnStatusNovaka.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnStatusNovaka.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusNovaka.Location = new System.Drawing.Point(398, 12);
            this.btnStatusNovaka.Name = "btnStatusNovaka";
            this.btnStatusNovaka.Size = new System.Drawing.Size(377, 201);
            this.btnStatusNovaka.TabIndex = 1;
            this.btnStatusNovaka.Text = "STATUS NOVAKA";
            this.btnStatusNovaka.UseVisualStyleBackColor = false;
            this.btnStatusNovaka.Click += new System.EventHandler(this.btnStatusNovaka_Click);
            // 
            // btnPregledNovaka
            // 
            this.btnPregledNovaka.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPregledNovaka.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledNovaka.Location = new System.Drawing.Point(12, 219);
            this.btnPregledNovaka.Name = "btnPregledNovaka";
            this.btnPregledNovaka.Size = new System.Drawing.Size(380, 193);
            this.btnPregledNovaka.TabIndex = 2;
            this.btnPregledNovaka.Text = "PREGLED NOVAKA";
            this.btnPregledNovaka.UseVisualStyleBackColor = false;
            this.btnPregledNovaka.Click += new System.EventHandler(this.btnPregledNovaka_Click);
            // 
            // btnOtpustNovaka
            // 
            this.btnOtpustNovaka.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOtpustNovaka.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpustNovaka.Location = new System.Drawing.Point(398, 219);
            this.btnOtpustNovaka.Name = "btnOtpustNovaka";
            this.btnOtpustNovaka.Size = new System.Drawing.Size(377, 193);
            this.btnOtpustNovaka.TabIndex = 3;
            this.btnOtpustNovaka.Text = "OTPUST NOVAKA";
            this.btnOtpustNovaka.UseVisualStyleBackColor = false;
            this.btnOtpustNovaka.Click += new System.EventHandler(this.btnOtpustNovaka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtpustNovaka);
            this.Controls.Add(this.btnPregledNovaka);
            this.Controls.Add(this.btnStatusNovaka);
            this.Controls.Add(this.btnUnosNovaka);
            this.Name = "Form1";
            this.Text = "Izbornik radnji";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnosNovaka;
        private System.Windows.Forms.Button btnStatusNovaka;
        private System.Windows.Forms.Button btnPregledNovaka;
        private System.Windows.Forms.Button btnOtpustNovaka;
    }
}

