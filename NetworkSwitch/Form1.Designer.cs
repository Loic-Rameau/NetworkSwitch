namespace NetworkSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.ProfilecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusIPLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusIPLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMaskLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusNetworkLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusGatewayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GateWaytextBox1 = new System.Windows.Forms.TextBox();
            this.AddresstextBox1 = new System.Windows.Forms.TextBox();
            this.ProfiletextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GateWaylabel9 = new System.Windows.Forms.Label();
            this.Masklabel7 = new System.Windows.Forms.Label();
            this.Reseauxlabel9 = new System.Windows.Forms.Label();
            this.Addresslabel5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.NICcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(260, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Changer IP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProfilecomboBox
            // 
            this.ProfilecomboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ProfilecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfilecomboBox.FormattingEnabled = true;
            this.ProfilecomboBox.Location = new System.Drawing.Point(60, 6);
            this.ProfilecomboBox.Name = "ProfilecomboBox";
            this.ProfilecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ProfilecomboBox.TabIndex = 2;
            this.ProfilecomboBox.SelectedIndexChanged += new System.EventHandler(this.ProfilecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profil(s) :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusIPLabel,
            this.StatusIPLabel2,
            this.toolStripStatusLabel1,
            this.StatusMaskLabel,
            this.toolStripStatusLabel2,
            this.StatusNetworkLabel,
            this.toolStripStatusLabel3,
            this.StatusGatewayLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusIPLabel
            // 
            this.StatusIPLabel.Name = "StatusIPLabel";
            this.StatusIPLabel.Size = new System.Drawing.Size(71, 17);
            this.StatusIPLabel.Text = "IP Address : ";
            this.StatusIPLabel.Click += new System.EventHandler(this.StatusIPLabel_Click);
            // 
            // StatusIPLabel2
            // 
            this.StatusIPLabel2.Name = "StatusIPLabel2";
            this.StatusIPLabel2.Size = new System.Drawing.Size(82, 17);
            this.StatusIPLabel2.Text = "192.168.31.175";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Mask :";
            // 
            // StatusMaskLabel
            // 
            this.StatusMaskLabel.Name = "StatusMaskLabel";
            this.StatusMaskLabel.Size = new System.Drawing.Size(76, 17);
            this.StatusMaskLabel.Text = "255.255.255.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel2.Text = "Network :";
            // 
            // StatusNetworkLabel
            // 
            this.StatusNetworkLabel.Name = "StatusNetworkLabel";
            this.StatusNetworkLabel.Size = new System.Drawing.Size(87, 17);
            this.StatusNetworkLabel.Text = "192.168.31.0/24";
            this.StatusNetworkLabel.Click += new System.EventHandler(this.StatusNetworkLabel_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel3.Text = "Gateway :";
            // 
            // StatusGatewayLabel
            // 
            this.StatusGatewayLabel.Name = "StatusGatewayLabel";
            this.StatusGatewayLabel.Size = new System.Drawing.Size(82, 17);
            this.StatusGatewayLabel.Text = "192.168.31.254";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(136, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Appliquer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GateWaytextBox1);
            this.groupBox1.Controls.Add(this.AddresstextBox1);
            this.groupBox1.Controls.Add(this.ProfiletextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau Profil";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GateWaytextBox1
            // 
            this.GateWaytextBox1.Location = new System.Drawing.Point(248, 44);
            this.GateWaytextBox1.Name = "GateWaytextBox1";
            this.GateWaytextBox1.Size = new System.Drawing.Size(100, 20);
            this.GateWaytextBox1.TabIndex = 2;
            this.GateWaytextBox1.TextChanged += new System.EventHandler(this.MasktextBox1_TextChanged);
            // 
            // AddresstextBox1
            // 
            this.AddresstextBox1.Location = new System.Drawing.Point(75, 45);
            this.AddresstextBox1.Name = "AddresstextBox1";
            this.AddresstextBox1.Size = new System.Drawing.Size(100, 20);
            this.AddresstextBox1.TabIndex = 2;
            this.AddresstextBox1.TextChanged += new System.EventHandler(this.MasktextBox1_TextChanged);
            // 
            // ProfiletextBox
            // 
            this.ProfiletextBox.Location = new System.Drawing.Point(75, 19);
            this.ProfiletextBox.Name = "ProfiletextBox";
            this.ProfiletextBox.Size = new System.Drawing.Size(100, 20);
            this.ProfiletextBox.TabIndex = 2;
            this.ProfiletextBox.TextChanged += new System.EventHandler(this.ProfiletextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Passerelle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profil :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GateWaylabel9);
            this.groupBox2.Controls.Add(this.Masklabel7);
            this.groupBox2.Controls.Add(this.Reseauxlabel9);
            this.groupBox2.Controls.Add(this.Addresslabel5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previsualisation";
            // 
            // GateWaylabel9
            // 
            this.GateWaylabel9.AutoSize = true;
            this.GateWaylabel9.Location = new System.Drawing.Point(226, 71);
            this.GateWaylabel9.Name = "GateWaylabel9";
            this.GateWaylabel9.Size = new System.Drawing.Size(0, 13);
            this.GateWaylabel9.TabIndex = 0;
            // 
            // Masklabel7
            // 
            this.Masklabel7.AutoSize = true;
            this.Masklabel7.Location = new System.Drawing.Point(226, 45);
            this.Masklabel7.Name = "Masklabel7";
            this.Masklabel7.Size = new System.Drawing.Size(0, 13);
            this.Masklabel7.TabIndex = 0;
            this.Masklabel7.Click += new System.EventHandler(this.Masklabel7_Click);
            // 
            // Reseauxlabel9
            // 
            this.Reseauxlabel9.AutoSize = true;
            this.Reseauxlabel9.Location = new System.Drawing.Point(63, 71);
            this.Reseauxlabel9.Name = "Reseauxlabel9";
            this.Reseauxlabel9.Size = new System.Drawing.Size(0, 13);
            this.Reseauxlabel9.TabIndex = 0;
            // 
            // Addresslabel5
            // 
            this.Addresslabel5.AutoSize = true;
            this.Addresslabel5.Location = new System.Drawing.Point(63, 45);
            this.Addresslabel5.Name = "Addresslabel5";
            this.Addresslabel5.Size = new System.Drawing.Size(0, 13);
            this.Addresslabel5.TabIndex = 0;
            this.Addresslabel5.Click += new System.EventHandler(this.Addresslabel5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Réseau :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Passerelle :";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(12, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sauvegarder et appliquer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NICcomboBox1
            // 
            this.NICcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NICcomboBox1.FormattingEnabled = true;
            this.NICcomboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NICcomboBox1.Location = new System.Drawing.Point(12, 64);
            this.NICcomboBox1.Name = "NICcomboBox1";
            this.NICcomboBox1.Size = new System.Drawing.Size(492, 21);
            this.NICcomboBox1.TabIndex = 2;
            this.NICcomboBox1.SelectedIndexChanged += new System.EventHandler(this.NICcomboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Interface(s) :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(187, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(386, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Mode Auto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NICcomboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProfilecomboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(594, 400);
            this.Name = "Form1";
            this.Text = "NetworkSwitching";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ProfilecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusIPLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusIPLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusMaskLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel StatusNetworkLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ProfiletextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddresstextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Masklabel7;
        private System.Windows.Forms.Label Addresslabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Reseauxlabel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StatusGatewayLabel;
        private System.Windows.Forms.TextBox GateWaytextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label GateWaylabel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NICcomboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

