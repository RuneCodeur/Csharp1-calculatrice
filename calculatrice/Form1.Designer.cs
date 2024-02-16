namespace Calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private string resultat;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.egal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgule = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.soustraction = new System.Windows.Forms.Button();
            this.adition = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.resultatButon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // egal
            // 
            this.egal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.egal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.egal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.egal.Location = new System.Drawing.Point(26, 351);
            this.egal.Margin = new System.Windows.Forms.Padding(6);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(432, 87);
            this.egal.TabIndex = 0;
            this.egal.Text = " =";
            this.egal.UseVisualStyleBackColor = false;
            this.egal.Click += new System.EventHandler(this.ButtonCalcul);
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zero.Location = new System.Drawing.Point(26, 289);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(100, 53);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // virgule
            // 
            this.virgule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.virgule.Location = new System.Drawing.Point(132, 289);
            this.virgule.Name = "virgule";
            this.virgule.Size = new System.Drawing.Size(100, 53);
            this.virgule.TabIndex = 3;
            this.virgule.Text = ",";
            this.virgule.UseVisualStyleBackColor = true;
            this.virgule.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // one
            // 
            this.one.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.one.Location = new System.Drawing.Point(26, 230);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(100, 53);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // two
            // 
            this.two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.two.Location = new System.Drawing.Point(132, 230);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(100, 53);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(238, 230);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 53);
            this.tree.TabIndex = 6;
            this.tree.Text = "3";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // four
            // 
            this.four.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.four.Location = new System.Drawing.Point(26, 171);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(100, 53);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // five
            // 
            this.five.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.five.Location = new System.Drawing.Point(132, 171);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(100, 53);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // six
            // 
            this.six.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.six.Location = new System.Drawing.Point(238, 171);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(100, 53);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // seven
            // 
            this.seven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seven.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seven.Location = new System.Drawing.Point(26, 112);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(100, 53);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // height
            // 
            this.height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.height.Location = new System.Drawing.Point(132, 112);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 53);
            this.height.TabIndex = 11;
            this.height.Text = "8";
            this.height.UseVisualStyleBackColor = true;
            this.height.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // nine
            // 
            this.nine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nine.Location = new System.Drawing.Point(238, 112);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(100, 53);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // division
            // 
            this.division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.division.Location = new System.Drawing.Point(344, 112);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(114, 53);
            this.division.TabIndex = 13;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // multiplication
            // 
            this.multiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.multiplication.Location = new System.Drawing.Point(344, 171);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(114, 53);
            this.multiplication.TabIndex = 14;
            this.multiplication.Text = "×";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // soustraction
            // 
            this.soustraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soustraction.Location = new System.Drawing.Point(344, 230);
            this.soustraction.Name = "soustraction";
            this.soustraction.Size = new System.Drawing.Size(114, 53);
            this.soustraction.TabIndex = 15;
            this.soustraction.Text = "-";
            this.soustraction.UseVisualStyleBackColor = true;
            this.soustraction.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // adition
            // 
            this.adition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adition.Location = new System.Drawing.Point(344, 289);
            this.adition.Name = "adition";
            this.adition.Size = new System.Drawing.Size(114, 53);
            this.adition.TabIndex = 16;
            this.adition.Text = "+";
            this.adition.UseVisualStyleBackColor = true;
            this.adition.Click += new System.EventHandler(this.ButtonAddNumber);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete.Location = new System.Drawing.Point(238, 289);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 53);
            this.delete.TabIndex = 17;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.ButtonReinit);
            // 
            // resultatButon
            // 
            this.resultatButon.Location = new System.Drawing.Point(26, 12);
            this.resultatButon.Name = "resultatButon";
            this.resultatButon.ReadOnly = true;
            this.resultatButon.Size = new System.Drawing.Size(432, 31);
            this.resultatButon.TabIndex = 18;
            this.resultatButon.Text = "0";
            this.resultatButon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.resultatButon);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.adition);
            this.Controls.Add(this.soustraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.height);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.virgule);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.egal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgule;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button height;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button soustraction;
        private System.Windows.Forms.Button adition;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox resultatButon;
    }
}

