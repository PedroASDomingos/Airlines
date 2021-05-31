
namespace CinelAirlines
{
    partial class UC_Paises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Paises));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.PaisesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editarAeroporto = new System.Windows.Forms.Button();
            this.btn_apagarAeroporto = new System.Windows.Forms.Button();
            this.btn_addAeroporto = new System.Windows.Forms.Button();
            this.AeroportoslistBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nomePais = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_apagar);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 54);
            this.panel1.TabIndex = 13;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(540, 0);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(180, 54);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(360, 0);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(180, 54);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_apagar.Image")));
            this.btn_apagar.Location = new System.Drawing.Point(180, 0);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(180, 54);
            this.btn_apagar.TabIndex = 1;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Image = global::CinelAirlines.Properties.Resources.icons8_add_25px;
            this.btn_adicionar.Location = new System.Drawing.Point(0, 0);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(180, 54);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // PaisesListBox
            // 
            this.PaisesListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaisesListBox.FormattingEnabled = true;
            this.PaisesListBox.ItemHeight = 23;
            this.PaisesListBox.Location = new System.Drawing.Point(7, 111);
            this.PaisesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaisesListBox.Name = "PaisesListBox";
            this.PaisesListBox.Size = new System.Drawing.Size(397, 510);
            this.PaisesListBox.TabIndex = 10;
            this.PaisesListBox.SelectedIndexChanged += new System.EventHandler(this.PaisesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aeroporto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adicionar / Remover Vias Aéreas";
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
            this.panel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editarAeroporto);
            this.groupBox1.Controls.Add(this.btn_apagarAeroporto);
            this.groupBox1.Controls.Add(this.btn_addAeroporto);
            this.groupBox1.Controls.Add(this.AeroportoslistBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_nomePais);
            this.groupBox1.Location = new System.Drawing.Point(423, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 514);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // btn_editarAeroporto
            // 
            this.btn_editarAeroporto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_editarAeroporto.FlatAppearance.BorderSize = 0;
            this.btn_editarAeroporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarAeroporto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarAeroporto.ForeColor = System.Drawing.Color.White;
            this.btn_editarAeroporto.Image = global::CinelAirlines.Properties.Resources.icons8_edit_25px;
            this.btn_editarAeroporto.Location = new System.Drawing.Point(354, 445);
            this.btn_editarAeroporto.Name = "btn_editarAeroporto";
            this.btn_editarAeroporto.Size = new System.Drawing.Size(174, 63);
            this.btn_editarAeroporto.TabIndex = 2;
            this.btn_editarAeroporto.Text = "Editar Aeroporto";
            this.btn_editarAeroporto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editarAeroporto.UseVisualStyleBackColor = false;
            this.btn_editarAeroporto.Click += new System.EventHandler(this.btn_editarAeroporto_Click);
            // 
            // btn_apagarAeroporto
            // 
            this.btn_apagarAeroporto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_apagarAeroporto.FlatAppearance.BorderSize = 0;
            this.btn_apagarAeroporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarAeroporto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagarAeroporto.ForeColor = System.Drawing.Color.White;
            this.btn_apagarAeroporto.Image = global::CinelAirlines.Properties.Resources.icons8_delete_trash_25px;
            this.btn_apagarAeroporto.Location = new System.Drawing.Point(180, 445);
            this.btn_apagarAeroporto.Name = "btn_apagarAeroporto";
            this.btn_apagarAeroporto.Size = new System.Drawing.Size(174, 63);
            this.btn_apagarAeroporto.TabIndex = 1;
            this.btn_apagarAeroporto.Text = "Apagar Aeroporto";
            this.btn_apagarAeroporto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apagarAeroporto.UseVisualStyleBackColor = false;
            this.btn_apagarAeroporto.Click += new System.EventHandler(this.btn_apagarAeroporto_Click);
            // 
            // btn_addAeroporto
            // 
            this.btn_addAeroporto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btn_addAeroporto.FlatAppearance.BorderSize = 0;
            this.btn_addAeroporto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addAeroporto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAeroporto.ForeColor = System.Drawing.Color.White;
            this.btn_addAeroporto.Image = global::CinelAirlines.Properties.Resources.icons8_add_25px;
            this.btn_addAeroporto.Location = new System.Drawing.Point(6, 445);
            this.btn_addAeroporto.Name = "btn_addAeroporto";
            this.btn_addAeroporto.Size = new System.Drawing.Size(174, 63);
            this.btn_addAeroporto.TabIndex = 0;
            this.btn_addAeroporto.Text = "Adicionar Aeroporto";
            this.btn_addAeroporto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addAeroporto.UseVisualStyleBackColor = false;
            this.btn_addAeroporto.Click += new System.EventHandler(this.btn_addAeroporto_Click);
            // 
            // AeroportoslistBox
            // 
            this.AeroportoslistBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AeroportoslistBox.FormattingEnabled = true;
            this.AeroportoslistBox.ItemHeight = 23;
            this.AeroportoslistBox.Location = new System.Drawing.Point(6, 255);
            this.AeroportoslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AeroportoslistBox.Name = "AeroportoslistBox";
            this.AeroportoslistBox.Size = new System.Drawing.Size(523, 188);
            this.AeroportoslistBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CinelAirlines.Properties.Resources.BandeiraBranca;
            this.pictureBox1.Location = new System.Drawing.Point(141, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nomePais
            // 
            this.lbl_nomePais.AutoSize = true;
            this.lbl_nomePais.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomePais.Location = new System.Drawing.Point(23, 39);
            this.lbl_nomePais.Name = "lbl_nomePais";
            this.lbl_nomePais.Size = new System.Drawing.Size(99, 34);
            this.lbl_nomePais.TabIndex = 24;
            this.lbl_nomePais.Text = "label2";
            // 
            // UC_Paises
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PaisesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Name = "UC_Paises";
            this.Size = new System.Drawing.Size(966, 635);
            this.Load += new System.EventHandler(this.UC_Paises_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListBox PaisesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nomePais;
        private System.Windows.Forms.ListBox AeroportoslistBox;
        private System.Windows.Forms.Button btn_addAeroporto;
        private System.Windows.Forms.Button btn_editarAeroporto;
        private System.Windows.Forms.Button btn_apagarAeroporto;
    }
}
