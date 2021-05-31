
namespace CinelAirlines
{
    partial class frmAddVoos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.txt_nomeVoo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listboxPaisOrigem = new System.Windows.Forms.ComboBox();
            this.listboxAeroportoOrigem = new System.Windows.Forms.ComboBox();
            this.listboxPaisDestino = new System.Windows.Forms.ComboBox();
            this.listboxAeroportoDestino = new System.Windows.Forms.ComboBox();
            this.listboxAparelhos = new System.Windows.Forms.ComboBox();
            this.txt_minutos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 48);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar um Voo";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(25, 204);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(75, 32);
            this.txt_hora.TabIndex = 2;
            this.txt_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hora_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Introduza a hora de partida do Voo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Escolha a data do Voo";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(333, 576);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(245, 54);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancel";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_Adicionar.Location = new System.Drawing.Point(79, 576);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(245, 54);
            this.btn_Adicionar.TabIndex = 9;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // txt_nomeVoo
            // 
            this.txt_nomeVoo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeVoo.Location = new System.Drawing.Point(25, 77);
            this.txt_nomeVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeVoo.Name = "txt_nomeVoo";
            this.txt_nomeVoo.Size = new System.Drawing.Size(617, 32);
            this.txt_nomeVoo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Introduza o nome do Voo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(617, 32);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Introduza o Aeroporto de origem do Voo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Introduza Pais de origem do Voo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Introduza Pais de destino do Voo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 436);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Introduza o Aeroporto de destino do Voo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Introduza o Aparelho do Voo";
            // 
            // listboxPaisOrigem
            // 
            this.listboxPaisOrigem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPaisOrigem.FormattingEnabled = true;
            this.listboxPaisOrigem.Location = new System.Drawing.Point(25, 269);
            this.listboxPaisOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.listboxPaisOrigem.Name = "listboxPaisOrigem";
            this.listboxPaisOrigem.Size = new System.Drawing.Size(617, 31);
            this.listboxPaisOrigem.TabIndex = 4;
            this.listboxPaisOrigem.SelectedIndexChanged += new System.EventHandler(this.listboxPaisOrigem_SelectedIndexChanged);
            // 
            // listboxAeroportoOrigem
            // 
            this.listboxAeroportoOrigem.Enabled = false;
            this.listboxAeroportoOrigem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxAeroportoOrigem.FormattingEnabled = true;
            this.listboxAeroportoOrigem.Location = new System.Drawing.Point(25, 333);
            this.listboxAeroportoOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.listboxAeroportoOrigem.Name = "listboxAeroportoOrigem";
            this.listboxAeroportoOrigem.Size = new System.Drawing.Size(617, 31);
            this.listboxAeroportoOrigem.TabIndex = 5;
            // 
            // listboxPaisDestino
            // 
            this.listboxPaisDestino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPaisDestino.FormattingEnabled = true;
            this.listboxPaisDestino.Location = new System.Drawing.Point(25, 397);
            this.listboxPaisDestino.Margin = new System.Windows.Forms.Padding(4);
            this.listboxPaisDestino.Name = "listboxPaisDestino";
            this.listboxPaisDestino.Size = new System.Drawing.Size(617, 31);
            this.listboxPaisDestino.TabIndex = 6;
            this.listboxPaisDestino.SelectedIndexChanged += new System.EventHandler(this.listboxPaisDestino_SelectedIndexChanged);
            // 
            // listboxAeroportoDestino
            // 
            this.listboxAeroportoDestino.Enabled = false;
            this.listboxAeroportoDestino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxAeroportoDestino.FormattingEnabled = true;
            this.listboxAeroportoDestino.Location = new System.Drawing.Point(25, 461);
            this.listboxAeroportoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.listboxAeroportoDestino.Name = "listboxAeroportoDestino";
            this.listboxAeroportoDestino.Size = new System.Drawing.Size(617, 31);
            this.listboxAeroportoDestino.TabIndex = 7;
            // 
            // listboxAparelhos
            // 
            this.listboxAparelhos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxAparelhos.FormattingEnabled = true;
            this.listboxAparelhos.Location = new System.Drawing.Point(25, 526);
            this.listboxAparelhos.Margin = new System.Windows.Forms.Padding(4);
            this.listboxAparelhos.Name = "listboxAparelhos";
            this.listboxAparelhos.Size = new System.Drawing.Size(617, 31);
            this.listboxAparelhos.TabIndex = 8;
            // 
            // txt_minutos
            // 
            this.txt_minutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos.Location = new System.Drawing.Point(117, 204);
            this.txt_minutos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_minutos.Name = "txt_minutos";
            this.txt_minutos.Size = new System.Drawing.Size(75, 32);
            this.txt_minutos.TabIndex = 3;
            this.txt_minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_minutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minutos_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(101, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 23);
            this.label10.TabIndex = 51;
            this.label10.Text = ":";
            // 
            // frmAddVoos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_minutos);
            this.Controls.Add(this.listboxAparelhos);
            this.Controls.Add(this.listboxAeroportoDestino);
            this.Controls.Add(this.listboxPaisDestino);
            this.Controls.Add(this.listboxAeroportoOrigem);
            this.Controls.Add(this.listboxPaisOrigem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_nomeVoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddVoos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddVoos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox txt_nomeVoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox listboxPaisOrigem;
        private System.Windows.Forms.ComboBox listboxAeroportoOrigem;
        private System.Windows.Forms.ComboBox listboxPaisDestino;
        private System.Windows.Forms.ComboBox listboxAeroportoDestino;
        private System.Windows.Forms.ComboBox listboxAparelhos;
        private System.Windows.Forms.TextBox txt_minutos;
        private System.Windows.Forms.Label label10;
    }
}