
namespace CinelAirlines
{
    partial class UC_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Info));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NoticiasListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refreshFuncionario = new System.Windows.Forms.Button();
            this.btn_editarFuncionario = new System.Windows.Forms.Button();
            this.btn_apagaFuncionarios = new System.Windows.Forms.Button();
            this.btn_addFuncionarios = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FuncionarioslistBox = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adicionar / Remover Noticias";
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
            this.panel1.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Título Notícias  // Data Notícias";
            // 
            // NoticiasListBox
            // 
            this.NoticiasListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoticiasListBox.FormattingEnabled = true;
            this.NoticiasListBox.ItemHeight = 23;
            this.NoticiasListBox.Location = new System.Drawing.Point(6, 114);
            this.NoticiasListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoticiasListBox.Name = "NoticiasListBox";
            this.NoticiasListBox.Size = new System.Drawing.Size(954, 188);
            this.NoticiasListBox.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 33);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adicionar / Remover Funcionários ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel4.Controls.Add(this.btn_refreshFuncionario);
            this.panel4.Controls.Add(this.btn_editarFuncionario);
            this.panel4.Controls.Add(this.btn_apagaFuncionarios);
            this.panel4.Controls.Add(this.btn_addFuncionarios);
            this.panel4.Location = new System.Drawing.Point(0, 349);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 54);
            this.panel4.TabIndex = 22;
            // 
            // btn_refreshFuncionario
            // 
            this.btn_refreshFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreshFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_refreshFuncionario.FlatAppearance.BorderSize = 0;
            this.btn_refreshFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btn_refreshFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshFuncionario.ForeColor = System.Drawing.Color.White;
            this.btn_refreshFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btn_refreshFuncionario.Image")));
            this.btn_refreshFuncionario.Location = new System.Drawing.Point(540, 0);
            this.btn_refreshFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refreshFuncionario.Name = "btn_refreshFuncionario";
            this.btn_refreshFuncionario.Size = new System.Drawing.Size(180, 54);
            this.btn_refreshFuncionario.TabIndex = 3;
            this.btn_refreshFuncionario.Text = "Refresh";
            this.btn_refreshFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_refreshFuncionario.UseVisualStyleBackColor = true;
            this.btn_refreshFuncionario.Click += new System.EventHandler(this.btn_refreshFuncionario_Click);
            // 
            // btn_editarFuncionario
            // 
            this.btn_editarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarFuncionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editarFuncionario.FlatAppearance.BorderSize = 0;
            this.btn_editarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_editarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btn_editarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btn_editarFuncionario.Image")));
            this.btn_editarFuncionario.Location = new System.Drawing.Point(360, 0);
            this.btn_editarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarFuncionario.Name = "btn_editarFuncionario";
            this.btn_editarFuncionario.Size = new System.Drawing.Size(180, 54);
            this.btn_editarFuncionario.TabIndex = 2;
            this.btn_editarFuncionario.Text = "Editar";
            this.btn_editarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editarFuncionario.UseVisualStyleBackColor = true;
            this.btn_editarFuncionario.Click += new System.EventHandler(this.btn_editarFuncionario_Click);
            // 
            // btn_apagaFuncionarios
            // 
            this.btn_apagaFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagaFuncionarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_apagaFuncionarios.FlatAppearance.BorderSize = 0;
            this.btn_apagaFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_apagaFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagaFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagaFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btn_apagaFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_apagaFuncionarios.Image")));
            this.btn_apagaFuncionarios.Location = new System.Drawing.Point(180, 0);
            this.btn_apagaFuncionarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_apagaFuncionarios.Name = "btn_apagaFuncionarios";
            this.btn_apagaFuncionarios.Size = new System.Drawing.Size(180, 54);
            this.btn_apagaFuncionarios.TabIndex = 1;
            this.btn_apagaFuncionarios.Text = "Apagar";
            this.btn_apagaFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apagaFuncionarios.UseVisualStyleBackColor = true;
            this.btn_apagaFuncionarios.Click += new System.EventHandler(this.btn_apagaFuncionarios_Click);
            // 
            // btn_addFuncionarios
            // 
            this.btn_addFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addFuncionarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addFuncionarios.FlatAppearance.BorderSize = 0;
            this.btn_addFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_addFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btn_addFuncionarios.Image = global::CinelAirlines.Properties.Resources.icons8_add_25px;
            this.btn_addFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.btn_addFuncionarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addFuncionarios.Name = "btn_addFuncionarios";
            this.btn_addFuncionarios.Size = new System.Drawing.Size(180, 54);
            this.btn_addFuncionarios.TabIndex = 0;
            this.btn_addFuncionarios.Text = "Adicionar";
            this.btn_addFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addFuncionarios.UseVisualStyleBackColor = true;
            this.btn_addFuncionarios.Click += new System.EventHandler(this.btn_addFuncionarios_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Título Notícias  // Data Notícias";
            // 
            // FuncionarioslistBox
            // 
            this.FuncionarioslistBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncionarioslistBox.FormattingEnabled = true;
            this.FuncionarioslistBox.ItemHeight = 23;
            this.FuncionarioslistBox.Location = new System.Drawing.Point(6, 430);
            this.FuncionarioslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FuncionarioslistBox.Name = "FuncionarioslistBox";
            this.FuncionarioslistBox.Size = new System.Drawing.Size(954, 188);
            this.FuncionarioslistBox.TabIndex = 23;
            // 
            // UC_Info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FuncionarioslistBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoticiasListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Info";
            this.Size = new System.Drawing.Size(966, 635);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NoticiasListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refreshFuncionario;
        private System.Windows.Forms.Button btn_editarFuncionario;
        private System.Windows.Forms.Button btn_apagaFuncionarios;
        private System.Windows.Forms.Button btn_addFuncionarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox FuncionarioslistBox;
    }
}
