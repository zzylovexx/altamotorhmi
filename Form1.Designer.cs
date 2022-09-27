namespace EtherCat
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按鈕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hprPanel1 = new EtherCat.HPRPanel();
            this.csppanel1 = new EtherCat.SingleMotorCT();
            this.statuspanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.statuswordtext = new System.Windows.Forms.TextBox();
            this.motiontext = new System.Windows.Forms.TextBox();
            this.currentspeedtext = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mutiMotorCT1 = new EtherCat.MutiMotorCT();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statuspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(206, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 105);
            this.button3.TabIndex = 5;
            this.button3.Text = "Mutiple Motor Control";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(206, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 105);
            this.button2.TabIndex = 4;
            this.button2.Text = "Single Motor Control";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(206, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 110);
            this.button1.TabIndex = 3;
            this.button1.Text = "initial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Red;
            this.sidepanel.ForeColor = System.Drawing.Color.Red;
            this.sidepanel.Location = new System.Drawing.Point(190, 15);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 106);
            this.sidepanel.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-178, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 497);
            this.panel1.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(206, 389);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(228, 105);
            this.button8.TabIndex = 19;
            this.button8.Text = "HPR Control";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按鈕ToolStripMenuItem,
            this.背景ToolStripMenuItem});
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.顏色ToolStripMenuItem.Text = "顏色";
            // 
            // 按鈕ToolStripMenuItem
            // 
            this.按鈕ToolStripMenuItem.Name = "按鈕ToolStripMenuItem";
            this.按鈕ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.按鈕ToolStripMenuItem.Text = "按鈕";
            this.按鈕ToolStripMenuItem.Click += new System.EventHandler(this.按鈕ToolStripMenuItem_Click);
            // 
            // 背景ToolStripMenuItem
            // 
            this.背景ToolStripMenuItem.Name = "背景ToolStripMenuItem";
            this.背景ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.背景ToolStripMenuItem.Text = "背景";
            this.背景ToolStripMenuItem.Click += new System.EventHandler(this.背景ToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(90, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Initial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(90, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "OPEN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(90, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Find Slave";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(242, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 30);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(242, 168);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 30);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(242, 228);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 30);
            this.textBox10.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.hprPanel1);
            this.groupBox2.Controls.Add(this.csppanel1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(295, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 396);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INITIAL";
            // 
            // hprPanel1
            // 
            this.hprPanel1.Location = new System.Drawing.Point(0, -66);
            this.hprPanel1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.hprPanel1.Name = "hprPanel1";
            this.hprPanel1.Size = new System.Drawing.Size(993, 1058);
            this.hprPanel1.TabIndex = 10;
            // 
            // csppanel1
            // 
            this.csppanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.csppanel1.Location = new System.Drawing.Point(-19, -43);
            this.csppanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.csppanel1.Name = "csppanel1";
            this.csppanel1.Size = new System.Drawing.Size(518, 560);
            this.csppanel1.TabIndex = 11;
            // 
            // statuspanel
            // 
            this.statuspanel.Controls.Add(this.comboBox1);
            this.statuspanel.Controls.Add(this.button7);
            this.statuspanel.Controls.Add(this.statuswordtext);
            this.statuspanel.Controls.Add(this.motiontext);
            this.statuspanel.Controls.Add(this.currentspeedtext);
            this.statuspanel.Controls.Add(this.textBox3);
            this.statuspanel.Controls.Add(this.textBox2);
            this.statuspanel.Controls.Add(this.label6);
            this.statuspanel.Controls.Add(this.label4);
            this.statuspanel.Controls.Add(this.label3);
            this.statuspanel.Controls.Add(this.label2);
            this.statuspanel.Controls.Add(this.label1);
            this.statuspanel.Location = new System.Drawing.Point(758, 45);
            this.statuspanel.Name = "statuspanel";
            this.statuspanel.Size = new System.Drawing.Size(480, 520);
            this.statuspanel.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NO.1 MOTOR",
            "NO.2 MOTOR",
            "NO.3 MOTOR",
            "CENTER MOTOR"});
            this.comboBox1.Location = new System.Drawing.Point(185, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(32, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 32);
            this.button7.TabIndex = 24;
            this.button7.Text = "Open timer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // statuswordtext
            // 
            this.statuswordtext.Location = new System.Drawing.Point(253, 327);
            this.statuswordtext.Name = "statuswordtext";
            this.statuswordtext.Size = new System.Drawing.Size(176, 27);
            this.statuswordtext.TabIndex = 23;
            // 
            // motiontext
            // 
            this.motiontext.Location = new System.Drawing.Point(253, 280);
            this.motiontext.Name = "motiontext";
            this.motiontext.Size = new System.Drawing.Size(176, 27);
            this.motiontext.TabIndex = 22;
            // 
            // currentspeedtext
            // 
            this.currentspeedtext.Location = new System.Drawing.Point(253, 236);
            this.currentspeedtext.Name = "currentspeedtext";
            this.currentspeedtext.Size = new System.Drawing.Size(176, 27);
            this.currentspeedtext.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 27);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 27);
            this.textBox2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Status Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "MOTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Feedback POS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Commamd POS";
            // 
            // mutiMotorCT1
            // 
            this.mutiMotorCT1.Location = new System.Drawing.Point(267, 30);
            this.mutiMotorCT1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mutiMotorCT1.Name = "mutiMotorCT1";
            this.mutiMotorCT1.Size = new System.Drawing.Size(454, 595);
            this.mutiMotorCT1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1277, 637);
            this.Controls.Add(this.statuspanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mutiMotorCT1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "EtherCat Card Initial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statuspanel.ResumeLayout(false);
            this.statuspanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按鈕ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private HPRPanel hprPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private MutiMotorCT mutiMotorCT1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox groupBox2;
        private SingleMotorCT csppanel1;
        private System.Windows.Forms.Panel statuspanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox statuswordtext;
        private System.Windows.Forms.TextBox motiontext;
        private System.Windows.Forms.TextBox currentspeedtext;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

