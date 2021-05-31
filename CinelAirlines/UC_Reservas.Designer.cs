
namespace CinelAirlines
{
    partial class UC_Reservas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reservas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VoosListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPesquisaData = new System.Windows.Forms.Panel();
            this.dtp_dataPartida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pesquisaData = new System.Windows.Forms.Button();
            this.btn_alteraPesquisa = new System.Windows.Forms.Button();
            this.panelPesquisaPais = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pesquisaDestino = new System.Windows.Forms.Button();
            this.txt_pesquisaDestino = new System.Windows.Forms.TextBox();
            this.txt_pesquisaOrigem = new System.Windows.Forms.TextBox();
            this.btn_porVoo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_aviao = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPesquisaData.SuspendLayout();
            this.panelPesquisaPais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 33);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Selecione um voo";
            // 
            // VoosListBox
            // 
            this.VoosListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoosListBox.FormattingEnabled = true;
            this.VoosListBox.HorizontalScrollbar = true;
            this.VoosListBox.ItemHeight = 23;
            this.VoosListBox.Location = new System.Drawing.Point(8, 132);
            this.VoosListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VoosListBox.Name = "VoosListBox";
            this.VoosListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VoosListBox.Size = new System.Drawing.Size(439, 257);
            this.VoosListBox.TabIndex = 63;
            this.VoosListBox.SelectedIndexChanged += new System.EventHandler(this.VoosListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.panelPesquisaData);
            this.panel1.Controls.Add(this.btn_alteraPesquisa);
            this.panel1.Controls.Add(this.panelPesquisaPais);
            this.panel1.Controls.Add(this.btn_porVoo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 70);
            this.panel1.TabIndex = 64;
            // 
            // panelPesquisaData
            // 
            this.panelPesquisaData.Controls.Add(this.dtp_dataPartida);
            this.panelPesquisaData.Controls.Add(this.label8);
            this.panelPesquisaData.Controls.Add(this.btn_pesquisaData);
            this.panelPesquisaData.Location = new System.Drawing.Point(408, 5);
            this.panelPesquisaData.Name = "panelPesquisaData";
            this.panelPesquisaData.Size = new System.Drawing.Size(555, 62);
            this.panelPesquisaData.TabIndex = 22;
            this.panelPesquisaData.Visible = false;
            // 
            // dtp_dataPartida
            // 
            this.dtp_dataPartida.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataPartida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataPartida.Location = new System.Drawing.Point(5, 26);
            this.dtp_dataPartida.Name = "dtp_dataPartida";
            this.dtp_dataPartida.Size = new System.Drawing.Size(498, 32);
            this.dtp_dataPartida.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pesquisa por data partida";
            // 
            // btn_pesquisaData
            // 
            this.btn_pesquisaData.BackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisaData.FlatAppearance.BorderSize = 0;
            this.btn_pesquisaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisaData.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisaData.Image = global::CinelAirlines.Properties.Resources.icons8_search_25px;
            this.btn_pesquisaData.Location = new System.Drawing.Point(510, 26);
            this.btn_pesquisaData.Name = "btn_pesquisaData";
            this.btn_pesquisaData.Size = new System.Drawing.Size(36, 30);
            this.btn_pesquisaData.TabIndex = 1;
            this.btn_pesquisaData.UseVisualStyleBackColor = false;
            this.btn_pesquisaData.Click += new System.EventHandler(this.btn_pesquisaData_Click);
            // 
            // btn_alteraPesquisa
            // 
            this.btn_alteraPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alteraPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_alteraPesquisa.FlatAppearance.BorderSize = 0;
            this.btn_alteraPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btn_alteraPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alteraPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alteraPesquisa.ForeColor = System.Drawing.Color.White;
            this.btn_alteraPesquisa.Image = global::CinelAirlines.Properties.Resources.icons8_search_25px;
            this.btn_alteraPesquisa.Location = new System.Drawing.Point(212, 0);
            this.btn_alteraPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alteraPesquisa.Name = "btn_alteraPesquisa";
            this.btn_alteraPesquisa.Size = new System.Drawing.Size(162, 70);
            this.btn_alteraPesquisa.TabIndex = 1;
            this.btn_alteraPesquisa.Text = "Pesquisa por data";
            this.btn_alteraPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alteraPesquisa.UseVisualStyleBackColor = true;
            this.btn_alteraPesquisa.Click += new System.EventHandler(this.btn_alteraPesquisa_Click);
            // 
            // panelPesquisaPais
            // 
            this.panelPesquisaPais.Controls.Add(this.label5);
            this.panelPesquisaPais.Controls.Add(this.label2);
            this.panelPesquisaPais.Controls.Add(this.btn_pesquisaDestino);
            this.panelPesquisaPais.Controls.Add(this.txt_pesquisaDestino);
            this.panelPesquisaPais.Controls.Add(this.txt_pesquisaOrigem);
            this.panelPesquisaPais.Location = new System.Drawing.Point(408, 5);
            this.panelPesquisaPais.Name = "panelPesquisaPais";
            this.panelPesquisaPais.Size = new System.Drawing.Size(555, 62);
            this.panelPesquisaPais.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(258, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pesquisa por país destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pesquisa por país origem";
            // 
            // btn_pesquisaDestino
            // 
            this.btn_pesquisaDestino.BackColor = System.Drawing.Color.Transparent;
            this.btn_pesquisaDestino.FlatAppearance.BorderSize = 0;
            this.btn_pesquisaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisaDestino.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisaDestino.Image = global::CinelAirlines.Properties.Resources.icons8_search_25px;
            this.btn_pesquisaDestino.Location = new System.Drawing.Point(516, 26);
            this.btn_pesquisaDestino.Name = "btn_pesquisaDestino";
            this.btn_pesquisaDestino.Size = new System.Drawing.Size(36, 30);
            this.btn_pesquisaDestino.TabIndex = 17;
            this.btn_pesquisaDestino.UseVisualStyleBackColor = false;
            this.btn_pesquisaDestino.Click += new System.EventHandler(this.btn_pesquisaDestino_Click);
            // 
            // txt_pesquisaDestino
            // 
            this.txt_pesquisaDestino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisaDestino.Location = new System.Drawing.Point(262, 27);
            this.txt_pesquisaDestino.Name = "txt_pesquisaDestino";
            this.txt_pesquisaDestino.Size = new System.Drawing.Size(241, 32);
            this.txt_pesquisaDestino.TabIndex = 16;
            // 
            // txt_pesquisaOrigem
            // 
            this.txt_pesquisaOrigem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisaOrigem.Location = new System.Drawing.Point(5, 27);
            this.txt_pesquisaOrigem.Name = "txt_pesquisaOrigem";
            this.txt_pesquisaOrigem.Size = new System.Drawing.Size(241, 32);
            this.txt_pesquisaOrigem.TabIndex = 15;
            // 
            // btn_porVoo
            // 
            this.btn_porVoo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_porVoo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_porVoo.FlatAppearance.BorderSize = 0;
            this.btn_porVoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btn_porVoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_porVoo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porVoo.ForeColor = System.Drawing.Color.White;
            this.btn_porVoo.Image = ((System.Drawing.Image)(resources.GetObject("btn_porVoo.Image")));
            this.btn_porVoo.Location = new System.Drawing.Point(0, 0);
            this.btn_porVoo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_porVoo.Name = "btn_porVoo";
            this.btn_porVoo.Size = new System.Drawing.Size(212, 70);
            this.btn_porVoo.TabIndex = 0;
            this.btn_porVoo.Text = "Pesquisa por Voo";
            this.btn_porVoo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_porVoo.UseVisualStyleBackColor = true;
            this.btn_porVoo.Click += new System.EventHandler(this.btn_porVoo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(454, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 517);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(259, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(240, 458);
            this.flowLayoutPanel2.TabIndex = 66;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 458);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "Lugares em Executiva: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Lugares em Económica:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_aviao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_data);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbl_hora);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 174);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação de Voo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Avião da viagem:";
            // 
            // lbl_aviao
            // 
            this.lbl_aviao.AutoSize = true;
            this.lbl_aviao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviao.ForeColor = System.Drawing.Color.Black;
            this.lbl_aviao.Location = new System.Drawing.Point(19, 146);
            this.lbl_aviao.Name = "lbl_aviao";
            this.lbl_aviao.Size = new System.Drawing.Size(58, 23);
            this.lbl_aviao.TabIndex = 37;
            this.lbl_aviao.Text = "teste";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Data do voo:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.Black;
            this.lbl_data.Location = new System.Drawing.Point(19, 47);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(58, 23);
            this.lbl_data.TabIndex = 29;
            this.lbl_data.Text = "teste";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(19, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hora do voo:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(19, 97);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(58, 23);
            this.lbl_hora.TabIndex = 25;
            this.lbl_hora.Text = "teste";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_cancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarReserva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarReserva.Location = new System.Drawing.Point(289, 573);
            this.btn_cancelarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(158, 49);
            this.btn_cancelarReserva.TabIndex = 0;
            this.btn_cancelarReserva.Text = "Gerir reservas";
            this.btn_cancelarReserva.UseVisualStyleBackColor = false;
            this.btn_cancelarReserva.Visible = false;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
            // 
            // UC_Reservas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VoosListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Reservas";
            this.Size = new System.Drawing.Size(966, 635);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelPesquisaData.ResumeLayout(false);
            this.panelPesquisaData.PerformLayout();
            this.panelPesquisaPais.ResumeLayout(false);
            this.panelPesquisaPais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox VoosListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_porVoo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_aviao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Button btn_alteraPesquisa;
        private System.Windows.Forms.Panel panelPesquisaPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pesquisaDestino;
        private System.Windows.Forms.TextBox txt_pesquisaDestino;
        private System.Windows.Forms.TextBox txt_pesquisaOrigem;
        private System.Windows.Forms.Panel panelPesquisaData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pesquisaData;
        private System.Windows.Forms.DateTimePicker dtp_dataPartida;
    }
}
