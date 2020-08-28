namespace wfValidou
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnValida = new System.Windows.Forms.Button();
            this.LTerminal = new System.Windows.Forms.Label();
            this.LbMensagens = new System.Windows.Forms.ListBox();
            this.LMensagens = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbTerminal = new System.Windows.Forms.ListBox();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.TbTempo = new System.Windows.Forms.TextBox();
            this.TbLinha2 = new System.Windows.Forms.TextBox();
            this.TbLinha1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TmTerminal = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnValida
            // 
            this.BtnValida.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnValida.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValida.ForeColor = System.Drawing.Color.Blue;
            this.BtnValida.Location = new System.Drawing.Point(12, 513);
            this.BtnValida.Name = "BtnValida";
            this.BtnValida.Size = new System.Drawing.Size(136, 39);
            this.BtnValida.TabIndex = 0;
            this.BtnValida.Text = "Valide a DLL";
            this.BtnValida.UseVisualStyleBackColor = false;
            this.BtnValida.Click += new System.EventHandler(this.BtnValida_Click);
            // 
            // LTerminal
            // 
            this.LTerminal.AutoSize = true;
            this.LTerminal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LTerminal.Location = new System.Drawing.Point(11, 26);
            this.LTerminal.Name = "LTerminal";
            this.LTerminal.Size = new System.Drawing.Size(62, 13);
            this.LTerminal.TabIndex = 2;
            this.LTerminal.Text = "TERMINAL";
            // 
            // LbMensagens
            // 
            this.LbMensagens.FormattingEnabled = true;
            this.LbMensagens.Location = new System.Drawing.Point(415, 43);
            this.LbMensagens.Name = "LbMensagens";
            this.LbMensagens.Size = new System.Drawing.Size(278, 238);
            this.LbMensagens.TabIndex = 1;
            // 
            // LMensagens
            // 
            this.LMensagens.AutoSize = true;
            this.LMensagens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LMensagens.Location = new System.Drawing.Point(486, 15);
            this.LMensagens.Name = "LMensagens";
            this.LMensagens.Size = new System.Drawing.Size(133, 13);
            this.LMensagens.TabIndex = 2;
            this.LMensagens.Text = "MENSAGENS INTERNAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbTerminal);
            this.groupBox1.Controls.Add(this.BtEnviar);
            this.groupBox1.Controls.Add(this.TbTempo);
            this.groupBox1.Controls.Add(this.TbLinha2);
            this.groupBox1.Controls.Add(this.TbLinha1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LTerminal);
            this.groupBox1.Location = new System.Drawing.Point(424, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LbTerminal
            // 
            this.LbTerminal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LbTerminal.Enabled = false;
            this.LbTerminal.FormattingEnabled = true;
            this.LbTerminal.Location = new System.Drawing.Point(14, 45);
            this.LbTerminal.Name = "LbTerminal";
            this.LbTerminal.Size = new System.Drawing.Size(228, 17);
            this.LbTerminal.TabIndex = 5;
            // 
            // BtEnviar
            // 
            this.BtEnviar.Location = new System.Drawing.Point(81, 198);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(92, 39);
            this.BtEnviar.TabIndex = 4;
            this.BtEnviar.Text = "ENVIAR";
            this.BtEnviar.UseVisualStyleBackColor = true;
            this.BtEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // TbTempo
            // 
            this.TbTempo.Location = new System.Drawing.Point(14, 159);
            this.TbTempo.MaxLength = 255;
            this.TbTempo.Name = "TbTempo";
            this.TbTempo.Size = new System.Drawing.Size(228, 20);
            this.TbTempo.TabIndex = 3;
            this.TbTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTempo_KeyPress);
            // 
            // TbLinha2
            // 
            this.TbLinha2.Location = new System.Drawing.Point(14, 119);
            this.TbLinha2.MaxLength = 50;
            this.TbLinha2.Name = "TbLinha2";
            this.TbLinha2.Size = new System.Drawing.Size(228, 20);
            this.TbLinha2.TabIndex = 3;
            // 
            // TbLinha1
            // 
            this.TbLinha1.Location = new System.Drawing.Point(14, 82);
            this.TbLinha1.MaxLength = 50;
            this.TbLinha1.Name = "TbLinha1";
            this.TbLinha1.Size = new System.Drawing.Size(228, 20);
            this.TbLinha1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TEMPO DE APRESENTAÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIÁLOGO COM O TERMINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LINHA 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LINHA 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::wfValidou.Properties.Resources.vp_640wsitepng5ea1a4d1d5aca;
            this.ClientSize = new System.Drawing.Size(705, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LMensagens);
            this.Controls.Add(this.LbMensagens);
            this.Controls.Add(this.BtnValida);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Validou! - Exemplo C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValida;
        private System.Windows.Forms.Label LTerminal;
        private System.Windows.Forms.ListBox LbMensagens;
        private System.Windows.Forms.Label LMensagens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.TextBox TbTempo;
        private System.Windows.Forms.TextBox TbLinha2;
        private System.Windows.Forms.TextBox TbLinha1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer TmTerminal;
        private System.Windows.Forms.ListBox LbTerminal;
    }
}

