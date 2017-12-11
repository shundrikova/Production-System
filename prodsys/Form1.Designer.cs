namespace prodsys
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.factsLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rulesLB = new System.Windows.Forms.ListBox();
            this.trueFactsLB = new System.Windows.Forms.ListBox();
            this.knBaseButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.forChainButton = new System.Windows.Forms.Button();
            this.backChainButton = new System.Windows.Forms.Button();
            this.resFactsLB = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.procRulesLB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.conFactorBtton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.factsLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facts";
            // 
            // factsLB
            // 
            this.factsLB.FormattingEnabled = true;
            this.factsLB.Location = new System.Drawing.Point(6, 16);
            this.factsLB.Name = "factsLB";
            this.factsLB.Size = new System.Drawing.Size(193, 290);
            this.factsLB.TabIndex = 0;
            this.factsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.factsLB_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rulesLB);
            this.groupBox2.Location = new System.Drawing.Point(223, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 312);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules";
            // 
            // rulesLB
            // 
            this.rulesLB.FormattingEnabled = true;
            this.rulesLB.HorizontalScrollbar = true;
            this.rulesLB.Location = new System.Drawing.Point(6, 16);
            this.rulesLB.Name = "rulesLB";
            this.rulesLB.Size = new System.Drawing.Size(553, 290);
            this.rulesLB.TabIndex = 2;
            // 
            // trueFactsLB
            // 
            this.trueFactsLB.FormattingEnabled = true;
            this.trueFactsLB.Location = new System.Drawing.Point(6, 17);
            this.trueFactsLB.Name = "trueFactsLB";
            this.trueFactsLB.Size = new System.Drawing.Size(193, 95);
            this.trueFactsLB.TabIndex = 1;
            this.trueFactsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trueFactsLB_MouseDoubleClick);
            // 
            // knBaseButton
            // 
            this.knBaseButton.Location = new System.Drawing.Point(18, 459);
            this.knBaseButton.Name = "knBaseButton";
            this.knBaseButton.Size = new System.Drawing.Size(161, 23);
            this.knBaseButton.TabIndex = 1;
            this.knBaseButton.Text = "Select knowledge base";
            this.knBaseButton.UseVisualStyleBackColor = true;
            this.knBaseButton.Click += new System.EventHandler(this.KBbutton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(18, 488);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // forChainButton
            // 
            this.forChainButton.Location = new System.Drawing.Point(229, 488);
            this.forChainButton.Name = "forChainButton";
            this.forChainButton.Size = new System.Drawing.Size(161, 23);
            this.forChainButton.TabIndex = 3;
            this.forChainButton.Text = "Forward chaining";
            this.forChainButton.UseVisualStyleBackColor = true;
            this.forChainButton.Click += new System.EventHandler(this.forChainButton_Click);
            // 
            // backChainButton
            // 
            this.backChainButton.Location = new System.Drawing.Point(410, 488);
            this.backChainButton.Name = "backChainButton";
            this.backChainButton.Size = new System.Drawing.Size(161, 23);
            this.backChainButton.TabIndex = 4;
            this.backChainButton.Text = "Backward chaining";
            this.backChainButton.UseVisualStyleBackColor = true;
            this.backChainButton.Click += new System.EventHandler(this.backChainButton_Click);
            // 
            // resFactsLB
            // 
            this.resFactsLB.FormattingEnabled = true;
            this.resFactsLB.Location = new System.Drawing.Point(6, 16);
            this.resFactsLB.Name = "resFactsLB";
            this.resFactsLB.Size = new System.Drawing.Size(193, 95);
            this.resFactsLB.TabIndex = 5;
            // 
            // procRulesLB
            // 
            this.procRulesLB.FormattingEnabled = true;
            this.procRulesLB.HorizontalScrollbar = true;
            this.procRulesLB.Location = new System.Drawing.Point(6, 16);
            this.procRulesLB.Name = "procRulesLB";
            this.procRulesLB.Size = new System.Drawing.Size(342, 95);
            this.procRulesLB.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trueFactsLB);
            this.groupBox3.Location = new System.Drawing.Point(12, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 117);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected facts";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resFactsLB);
            this.groupBox4.Location = new System.Drawing.Point(583, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 117);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resulting facts";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.procRulesLB);
            this.groupBox5.Location = new System.Drawing.Point(223, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 117);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processed rules";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 459);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fact id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сertainty factor:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(673, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 10;
            // 
            // conFactorBtton
            // 
            this.conFactorBtton.Location = new System.Drawing.Point(621, 488);
            this.conFactorBtton.Name = "conFactorBtton";
            this.conFactorBtton.Size = new System.Drawing.Size(161, 23);
            this.conFactorBtton.TabIndex = 11;
            this.conFactorBtton.Text = "Add";
            this.conFactorBtton.UseVisualStyleBackColor = true;
            this.conFactorBtton.Click += new System.EventHandler(this.conFactorBtton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conFactorBtton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.knBaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.backChainButton);
            this.Controls.Add(this.forChainButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox resFactsLB;
        private System.Windows.Forms.ListBox trueFactsLB;
        private System.Windows.Forms.ListBox factsLB;
        private System.Windows.Forms.ListBox rulesLB;
        private System.Windows.Forms.Button knBaseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button forChainButton;
        private System.Windows.Forms.Button backChainButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox procRulesLB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button conFactorBtton;
        private System.Windows.Forms.Label label3;
    }
}

