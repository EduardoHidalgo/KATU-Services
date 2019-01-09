namespace Calculator
{
    partial class Calculator
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
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonConfig = new System.Windows.Forms.Button();
            this.ButtonExperimental = new System.Windows.Forms.Button();
            this.ButtonAvanzada = new System.Windows.Forms.Button();
            this.ButtonEstandar = new System.Windows.Forms.Button();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.Silver;
            this.PanelButtons.Controls.Add(this.ButtonSalir);
            this.PanelButtons.Controls.Add(this.ButtonConfig);
            this.PanelButtons.Controls.Add(this.ButtonExperimental);
            this.PanelButtons.Controls.Add(this.ButtonAvanzada);
            this.PanelButtons.Controls.Add(this.ButtonEstandar);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelButtons.Location = new System.Drawing.Point(0, 0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(800, 44);
            this.PanelButtons.TabIndex = 96;
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.BackColor = System.Drawing.Color.Red;
            this.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalir.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalir.Location = new System.Drawing.Point(647, 7);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(147, 30);
            this.ButtonSalir.TabIndex = 4;
            this.ButtonSalir.Text = "SALIR";
            this.ButtonSalir.UseVisualStyleBackColor = false;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfig.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfig.Location = new System.Drawing.Point(486, 7);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(147, 30);
            this.ButtonConfig.TabIndex = 3;
            this.ButtonConfig.Text = "CONFIGURACIONES";
            this.ButtonConfig.UseVisualStyleBackColor = false;
            this.ButtonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // ButtonExperimental
            // 
            this.ButtonExperimental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonExperimental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExperimental.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExperimental.Location = new System.Drawing.Point(326, 7);
            this.ButtonExperimental.Name = "ButtonExperimental";
            this.ButtonExperimental.Size = new System.Drawing.Size(147, 30);
            this.ButtonExperimental.TabIndex = 2;
            this.ButtonExperimental.Text = "EXPERIMENTAL";
            this.ButtonExperimental.UseVisualStyleBackColor = false;
            this.ButtonExperimental.Click += new System.EventHandler(this.ButtonExperimental_Click);
            // 
            // ButtonAvanzada
            // 
            this.ButtonAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAvanzada.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAvanzada.Location = new System.Drawing.Point(166, 7);
            this.ButtonAvanzada.Name = "ButtonAvanzada";
            this.ButtonAvanzada.Size = new System.Drawing.Size(147, 30);
            this.ButtonAvanzada.TabIndex = 1;
            this.ButtonAvanzada.Text = "AVANZADA";
            this.ButtonAvanzada.UseVisualStyleBackColor = false;
            this.ButtonAvanzada.Click += new System.EventHandler(this.ButtonAvanzada_Click);
            // 
            // ButtonEstandar
            // 
            this.ButtonEstandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonEstandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEstandar.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEstandar.Location = new System.Drawing.Point(6, 7);
            this.ButtonEstandar.Name = "ButtonEstandar";
            this.ButtonEstandar.Size = new System.Drawing.Size(147, 30);
            this.ButtonEstandar.TabIndex = 0;
            this.ButtonEstandar.Text = "ESTANDAR";
            this.ButtonEstandar.UseVisualStyleBackColor = false;
            this.ButtonEstandar.Click += new System.EventHandler(this.ButtonEstandar_Click);
            // 
            // PanelControls
            // 
            this.PanelControls.BackColor = System.Drawing.Color.Silver;
            this.PanelControls.Location = new System.Drawing.Point(5, 50);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(790, 545);
            this.PanelControls.TabIndex = 97;
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelControls);
            this.Controls.Add(this.PanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Button ButtonConfig;
        private System.Windows.Forms.Button ButtonExperimental;
        private System.Windows.Forms.Button ButtonAvanzada;
        private System.Windows.Forms.Button ButtonEstandar;
        private System.Windows.Forms.Panel PanelControls;
    }
}

