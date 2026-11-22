namespace SEMANA4
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtAvisoKeyPress = new TextBox();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txtEstadoImagen = new TextBox();
            label3 = new Label();
            pnlImagen = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            lblEstadoClick = new Label();
            tmrContador = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            label4 = new Label();
            txtEstadoTimer = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Controls.Add(txtAvisoKeyPress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSoloNumeros);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 336);
            panel1.TabIndex = 0;
            // 
            // txtAvisoKeyPress
            // 
            txtAvisoKeyPress.BackColor = Color.Red;
            txtAvisoKeyPress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAvisoKeyPress.Location = new Point(48, 142);
            txtAvisoKeyPress.Multiline = true;
            txtAvisoKeyPress.Name = "txtAvisoKeyPress";
            txtAvisoKeyPress.Size = new Size(240, 36);
            txtAvisoKeyPress.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 46);
            label2.Name = "label2";
            label2.Size = new Size(235, 21);
            label2.TabIndex = 3;
            label2.Text = "Validador dígitos en KeyPress";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoloNumeros.Location = new Point(60, 90);
            txtSoloNumeros.Multiline = true;
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(209, 36);
            txtSoloNumeros.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(365, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 585);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.Controls.Add(txtEstadoImagen);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pnlImagen);
            panel3.Location = new Point(333, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 586);
            panel3.TabIndex = 1;
            // 
            // txtEstadoImagen
            // 
            txtEstadoImagen.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEstadoImagen.Location = new Point(68, 455);
            txtEstadoImagen.Multiline = true;
            txtEstadoImagen.Name = "txtEstadoImagen";
            txtEstadoImagen.Size = new Size(210, 36);
            txtEstadoImagen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(59, 48);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 1;
            label3.Text = "DragDrop de Imagenes";
            // 
            // pnlImagen
            // 
            pnlImagen.AllowDrop = true;
            pnlImagen.BackColor = Color.FromArgb(224, 224, 224);
            pnlImagen.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImagen.Location = new Point(0, 103);
            pnlImagen.Name = "pnlImagen";
            pnlImagen.Size = new Size(343, 335);
            pnlImagen.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lblEstadoClick);
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 243);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 1;
            label1.Text = "LABEL QUE CAMBIA AL CLICK";
            // 
            // lblEstadoClick
            // 
            lblEstadoClick.AutoSize = true;
            lblEstadoClick.BackColor = Color.FromArgb(128, 255, 128);
            lblEstadoClick.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoClick.Location = new Point(29, 126);
            lblEstadoClick.Name = "lblEstadoClick";
            lblEstadoClick.Size = new Size(271, 21);
            lblEstadoClick.TabIndex = 0;
            lblEstadoClick.Text = "Esperando interacción del Usuario";
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1000;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 192, 0);
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(682, 281);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(89, 47);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.FromArgb(255, 128, 128);
            btnDetener.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetener.Location = new Point(797, 281);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(89, 47);
            btnDetener.TabIndex = 5;
            btnDetener.Text = "DETENER";
            btnDetener.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(128, 255, 255);
            btnReiniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(903, 281);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(101, 47);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.Text = "REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(773, 127);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 7;
            label4.Text = "Temporizador";
            // 
            // txtEstadoTimer
            // 
            txtEstadoTimer.BackColor = Color.FromArgb(192, 255, 192);
            txtEstadoTimer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEstadoTimer.Location = new Point(726, 182);
            txtEstadoTimer.Multiline = true;
            txtEstadoTimer.Name = "txtEstadoTimer";
            txtEstadoTimer.Size = new Size(236, 72);
            txtEstadoTimer.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1006, 518);
            Controls.Add(txtEstadoTimer);
            Controls.Add(label4);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private TextBox txtSoloNumeros;
        private Panel pnlImagen;
        private Label lblEstadoClick;
        private System.Windows.Forms.Timer tmrContador;
        private Label label1;
        private Button btnIniciar;
        private Label label2;
        private Label label3;
        private Button btnDetener;
        private Button btnReiniciar;
        private Label label4;
        private TextBox txtAvisoKeyPress;
        private TextBox txtEstadoImagen;
        private TextBox txtEstadoTimer;
    }
}
