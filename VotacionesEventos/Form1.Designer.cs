
namespace VotacionesEventos
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
            this.btnIniciarVotacion = new System.Windows.Forms.Button();
            this.grpVotacion = new System.Windows.Forms.GroupBox();
            this.btnCandidato1 = new System.Windows.Forms.Button();
            this.btnCandidato2 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grpVotacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarVotacion
            // 
            this.btnIniciarVotacion.Location = new System.Drawing.Point(26, 15);
            this.btnIniciarVotacion.Name = "btnIniciarVotacion";
            this.btnIniciarVotacion.Size = new System.Drawing.Size(270, 23);
            this.btnIniciarVotacion.TabIndex = 0;
            this.btnIniciarVotacion.Text = "Iniciar votación";
            this.btnIniciarVotacion.UseVisualStyleBackColor = true;
            this.btnIniciarVotacion.Click += new System.EventHandler(this.btnIniciarVotacion_Click);
            // 
            // grpVotacion
            // 
            this.grpVotacion.Controls.Add(this.lblMensaje);
            this.grpVotacion.Controls.Add(this.btnCandidato2);
            this.grpVotacion.Controls.Add(this.btnCandidato1);
            this.grpVotacion.Enabled = false;
            this.grpVotacion.Location = new System.Drawing.Point(26, 44);
            this.grpVotacion.Name = "grpVotacion";
            this.grpVotacion.Size = new System.Drawing.Size(270, 109);
            this.grpVotacion.TabIndex = 1;
            this.grpVotacion.TabStop = false;
            this.grpVotacion.Text = "Votación";
            // 
            // btnCandidato1
            // 
            this.btnCandidato1.Location = new System.Drawing.Point(6, 22);
            this.btnCandidato1.Name = "btnCandidato1";
            this.btnCandidato1.Size = new System.Drawing.Size(106, 41);
            this.btnCandidato1.TabIndex = 0;
            this.btnCandidato1.Text = "Votar por candidato 1";
            this.btnCandidato1.UseVisualStyleBackColor = true;
            this.btnCandidato1.Click += new System.EventHandler(this.btnCandidato1_Click);
            // 
            // btnCandidato2
            // 
            this.btnCandidato2.Location = new System.Drawing.Point(158, 22);
            this.btnCandidato2.Name = "btnCandidato2";
            this.btnCandidato2.Size = new System.Drawing.Size(106, 41);
            this.btnCandidato2.TabIndex = 1;
            this.btnCandidato2.Text = "Votar por candidato 2";
            this.btnCandidato2.UseVisualStyleBackColor = true;
            this.btnCandidato2.Click += new System.EventHandler(this.btnCandidato2_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(5, 83);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(259, 23);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 165);
            this.Controls.Add(this.grpVotacion);
            this.Controls.Add(this.btnIniciarVotacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpVotacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarVotacion;
        private System.Windows.Forms.GroupBox grpVotacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCandidato2;
        private System.Windows.Forms.Button btnCandidato1;
    }
}

