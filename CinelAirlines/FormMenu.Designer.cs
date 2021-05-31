
namespace CinelAirlines
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.btn_suporte = new System.Windows.Forms.Button();
            this.btn_reservas = new System.Windows.Forms.Button();
            this.btn_voos = new System.Windows.Forms.Button();
            this.btn_aparelhos = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_paises = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 85);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_tempo);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(549, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 43);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(65, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lisboa";
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.lbl_tempo.Location = new System.Drawing.Point(247, 12);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(106, 23);
            this.lbl_tempo.TabIndex = 0;
            this.lbl_tempo.Text = "HH:MM:SS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "CINEL AIRLINES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistema de gestão de conteúdos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btn_sobre);
            this.panel1.Controls.Add(this.btn_suporte);
            this.panel1.Controls.Add(this.btn_reservas);
            this.panel1.Controls.Add(this.btn_voos);
            this.panel1.Controls.Add(this.btn_aparelhos);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.btn_info);
            this.panel1.Controls.Add(this.btn_paises);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 720);
            this.panel1.TabIndex = 3;
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(234, 85);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(966, 635);
            this.panelControls.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CinelAirlines.Properties.Resources.icons8_location_40px;
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::CinelAirlines.Properties.Resources.icons8_shutdown_26px_1;
            this.btn_exit.Location = new System.Drawing.Point(901, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(42, 40);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_sobre.FlatAppearance.BorderSize = 0;
            this.btn_sobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.ForeColor = System.Drawing.Color.White;
            this.btn_sobre.Image = global::CinelAirlines.Properties.Resources.icons8_info_50px;
            this.btn_sobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sobre.Location = new System.Drawing.Point(12, 657);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(238, 54);
            this.btn_sobre.TabIndex = 8;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.UseVisualStyleBackColor = false;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // btn_suporte
            // 
            this.btn_suporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_suporte.FlatAppearance.BorderSize = 0;
            this.btn_suporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_suporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suporte.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suporte.ForeColor = System.Drawing.Color.White;
            this.btn_suporte.Image = global::CinelAirlines.Properties.Resources.icons8_customer_support_50px;
            this.btn_suporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suporte.Location = new System.Drawing.Point(12, 474);
            this.btn_suporte.Name = "btn_suporte";
            this.btn_suporte.Size = new System.Drawing.Size(238, 55);
            this.btn_suporte.TabIndex = 5;
            this.btn_suporte.Text = "Suporte";
            this.btn_suporte.UseVisualStyleBackColor = false;
            this.btn_suporte.Click += new System.EventHandler(this.btn_suporte_Click);
            // 
            // btn_reservas
            // 
            this.btn_reservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_reservas.FlatAppearance.BorderSize = 0;
            this.btn_reservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservas.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservas.ForeColor = System.Drawing.Color.White;
            this.btn_reservas.Image = global::CinelAirlines.Properties.Resources.icons8_ticket_50px;
            this.btn_reservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservas.Location = new System.Drawing.Point(12, 413);
            this.btn_reservas.Name = "btn_reservas";
            this.btn_reservas.Size = new System.Drawing.Size(238, 55);
            this.btn_reservas.TabIndex = 4;
            this.btn_reservas.Text = "Reservas";
            this.btn_reservas.UseVisualStyleBackColor = false;
            this.btn_reservas.Click += new System.EventHandler(this.btn_reservas_Click);
            // 
            // btn_voos
            // 
            this.btn_voos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_voos.FlatAppearance.BorderSize = 0;
            this.btn_voos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_voos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voos.ForeColor = System.Drawing.Color.White;
            this.btn_voos.Image = ((System.Drawing.Image)(resources.GetObject("btn_voos.Image")));
            this.btn_voos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voos.Location = new System.Drawing.Point(12, 352);
            this.btn_voos.Name = "btn_voos";
            this.btn_voos.Size = new System.Drawing.Size(238, 55);
            this.btn_voos.TabIndex = 3;
            this.btn_voos.Text = "Voos";
            this.btn_voos.UseVisualStyleBackColor = false;
            this.btn_voos.Click += new System.EventHandler(this.btn_voos_Click);
            // 
            // btn_aparelhos
            // 
            this.btn_aparelhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_aparelhos.FlatAppearance.BorderSize = 0;
            this.btn_aparelhos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_aparelhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aparelhos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aparelhos.ForeColor = System.Drawing.Color.White;
            this.btn_aparelhos.Image = global::CinelAirlines.Properties.Resources.icons8_airplane_50px_1;
            this.btn_aparelhos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aparelhos.Location = new System.Drawing.Point(12, 238);
            this.btn_aparelhos.Name = "btn_aparelhos";
            this.btn_aparelhos.Size = new System.Drawing.Size(238, 47);
            this.btn_aparelhos.TabIndex = 1;
            this.btn_aparelhos.Text = "Aparelhos";
            this.btn_aparelhos.UseVisualStyleBackColor = false;
            this.btn_aparelhos.Click += new System.EventHandler(this.btn_aparelhos_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_users.FlatAppearance.BorderSize = 0;
            this.btn_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Image = global::CinelAirlines.Properties.Resources.icons8_add_male_user_50px;
            this.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_users.Location = new System.Drawing.Point(12, 596);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(238, 55);
            this.btn_users.TabIndex = 7;
            this.btn_users.Text = "Utilizadores";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Visible = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Image = global::CinelAirlines.Properties.Resources.icons8_align_text_left_35px;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_info.Location = new System.Drawing.Point(12, 535);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(238, 55);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "Conteúdo ";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Visible = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_paises
            // 
            this.btn_paises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_paises.FlatAppearance.BorderSize = 0;
            this.btn_paises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_paises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paises.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paises.ForeColor = System.Drawing.Color.White;
            this.btn_paises.Image = global::CinelAirlines.Properties.Resources.icons8_runway_50px;
            this.btn_paises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paises.Location = new System.Drawing.Point(12, 291);
            this.btn_paises.Name = "btn_paises";
            this.btn_paises.Size = new System.Drawing.Size(238, 55);
            this.btn_paises.TabIndex = 2;
            this.btn_paises.Text = "Vias aéreas";
            this.btn_paises.UseVisualStyleBackColor = false;
            this.btn_paises.Click += new System.EventHandler(this.btn_paises_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::CinelAirlines.Properties.Resources.CinelAirlines2;
            this.pictureBox1.Image = global::CinelAirlines.Properties.Resources.CinelAirlines2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(12, 177);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(238, 55);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_aparelhos;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_reservas;
        private System.Windows.Forms.Button btn_paises;
        private System.Windows.Forms.Button btn_voos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_suporte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sobre;
    }
}