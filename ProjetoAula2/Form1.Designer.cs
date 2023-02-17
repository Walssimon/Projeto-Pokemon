
namespace ProjetoAula2
{
    partial class FormPokémon
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbtCharmander = new System.Windows.Forms.RadioButton();
            this.rbtSquartle = new System.Windows.Forms.RadioButton();
            this.rbtBubassauro = new System.Windows.Forms.RadioButton();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Crimson;
            this.lblDescricao.Location = new System.Drawing.Point(407, 9);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(333, 42);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Escolha seu Pokémon";
            this.lblDescricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtCharmander
            // 
            this.rbtCharmander.AutoSize = true;
            this.rbtCharmander.Checked = true;
            this.rbtCharmander.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharmander.ForeColor = System.Drawing.Color.DarkRed;
            this.rbtCharmander.Location = new System.Drawing.Point(54, 114);
            this.rbtCharmander.Name = "rbtCharmander";
            this.rbtCharmander.Size = new System.Drawing.Size(144, 29);
            this.rbtCharmander.TabIndex = 1;
            this.rbtCharmander.TabStop = true;
            this.rbtCharmander.Text = "Charmander";
            this.rbtCharmander.UseVisualStyleBackColor = true;
            this.rbtCharmander.CheckedChanged += new System.EventHandler(this.rbtCharmander_CheckedChanged);
            // 
            // rbtSquartle
            // 
            this.rbtSquartle.AutoSize = true;
            this.rbtSquartle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.rbtSquartle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbtSquartle.Location = new System.Drawing.Point(54, 163);
            this.rbtSquartle.Name = "rbtSquartle";
            this.rbtSquartle.Size = new System.Drawing.Size(100, 29);
            this.rbtSquartle.TabIndex = 2;
            this.rbtSquartle.Text = "Squirtle";
            this.rbtSquartle.UseVisualStyleBackColor = true;
            this.rbtSquartle.CheckedChanged += new System.EventHandler(this.rbtSquartle_CheckedChanged);
            // 
            // rbtBubassauro
            // 
            this.rbtBubassauro.AutoSize = true;
            this.rbtBubassauro.BackColor = System.Drawing.SystemColors.Control;
            this.rbtBubassauro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.rbtBubassauro.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.rbtBubassauro.Location = new System.Drawing.Point(54, 209);
            this.rbtBubassauro.Name = "rbtBubassauro";
            this.rbtBubassauro.Size = new System.Drawing.Size(121, 29);
            this.rbtBubassauro.TabIndex = 3;
            this.rbtBubassauro.Text = "Bulbasaur";
            this.rbtBubassauro.UseVisualStyleBackColor = false;
            this.rbtBubassauro.CheckedChanged += new System.EventHandler(this.rbtBubassauro_CheckedChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Image = global::ProjetoAula2.Properties.Resources.zvu0wzu39r88dsds;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(504, 54);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(675, 611);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPokemon.TabIndex = 4;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // FormPokémon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1210, 701);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.rbtBubassauro);
            this.Controls.Add(this.rbtSquartle);
            this.Controls.Add(this.rbtCharmander);
            this.Controls.Add(this.lblDescricao);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormPokémon";
            this.Text = "O Programa Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtCharmander;
        private System.Windows.Forms.RadioButton rbtSquartle;
        private System.Windows.Forms.RadioButton rbtBubassauro;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
    }
}

