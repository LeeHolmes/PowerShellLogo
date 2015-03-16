namespace PowerShellLogo
{
    partial class PowerShellHost
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
            this.display = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.actions = new System.Windows.Forms.TabPage();
            this.clear = new System.Windows.Forms.LinkLabel();
            this.penDown = new System.Windows.Forms.LinkLabel();
            this.penUp = new System.Windows.Forms.LinkLabel();
            this.left10 = new System.Windows.Forms.LinkLabel();
            this.left1 = new System.Windows.Forms.LinkLabel();
            this.right10 = new System.Windows.Forms.LinkLabel();
            this.right1 = new System.Windows.Forms.LinkLabel();
            this.backward10 = new System.Windows.Forms.LinkLabel();
            this.forward10 = new System.Windows.Forms.LinkLabel();
            this.backward1 = new System.Windows.Forms.LinkLabel();
            this.forward1 = new System.Windows.Forms.LinkLabel();
            this.script = new System.Windows.Forms.TabPage();
            this.run = new System.Windows.Forms.Button();
            this.scriptText = new System.Windows.Forms.TextBox();
            this.display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.actions.SuspendLayout();
            this.script.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BackColor = System.Drawing.Color.Black;
            this.display.Controls.Add(this.pictureBox);
            this.display.Location = new System.Drawing.Point(13, 13);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(411, 249);
            this.display.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox.Location = new System.Drawing.Point(4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(403, 243);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.actions);
            this.tabControl.Controls.Add(this.script);
            this.tabControl.Location = new System.Drawing.Point(13, 268);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(411, 188);
            this.tabControl.TabIndex = 3;
            // 
            // actions
            // 
            this.actions.Controls.Add(this.clear);
            this.actions.Controls.Add(this.penDown);
            this.actions.Controls.Add(this.penUp);
            this.actions.Controls.Add(this.left10);
            this.actions.Controls.Add(this.left1);
            this.actions.Controls.Add(this.right10);
            this.actions.Controls.Add(this.right1);
            this.actions.Controls.Add(this.backward10);
            this.actions.Controls.Add(this.forward10);
            this.actions.Controls.Add(this.backward1);
            this.actions.Controls.Add(this.forward1);
            this.actions.Location = new System.Drawing.Point(4, 22);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(403, 162);
            this.actions.TabIndex = 2;
            this.actions.Text = "Actions";
            this.actions.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(4, 134);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(31, 13);
            this.clear.TabIndex = 10;
            this.clear.TabStop = true;
            this.clear.Text = "Clear";
            this.clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clear_LinkClicked);
            // 
            // penDown
            // 
            this.penDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penDown.AutoSize = true;
            this.penDown.Location = new System.Drawing.Point(4, 119);
            this.penDown.Name = "penDown";
            this.penDown.Size = new System.Drawing.Size(57, 13);
            this.penDown.TabIndex = 9;
            this.penDown.TabStop = true;
            this.penDown.Text = "Pen Down";
            this.penDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.penDown_LinkClicked);
            // 
            // penUp
            // 
            this.penUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penUp.AutoSize = true;
            this.penUp.Location = new System.Drawing.Point(4, 101);
            this.penUp.Name = "penUp";
            this.penUp.Size = new System.Drawing.Size(43, 13);
            this.penUp.TabIndex = 8;
            this.penUp.TabStop = true;
            this.penUp.Text = "Pen Up";
            this.penUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.penUp_LinkClicked);
            // 
            // left10
            // 
            this.left10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.left10.AutoSize = true;
            this.left10.Location = new System.Drawing.Point(154, 62);
            this.left10.Name = "left10";
            this.left10.Size = new System.Drawing.Size(40, 13);
            this.left10.TabIndex = 7;
            this.left10.TabStop = true;
            this.left10.Text = "Left 10";
            this.left10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.left10_LinkClicked);
            // 
            // left1
            // 
            this.left1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.left1.AutoSize = true;
            this.left1.Location = new System.Drawing.Point(157, 44);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(34, 13);
            this.left1.TabIndex = 6;
            this.left1.TabStop = true;
            this.left1.Text = "Left 1";
            this.left1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.left1_LinkClicked);
            // 
            // right10
            // 
            this.right10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.right10.AutoSize = true;
            this.right10.Location = new System.Drawing.Point(310, 62);
            this.right10.Name = "right10";
            this.right10.Size = new System.Drawing.Size(47, 13);
            this.right10.TabIndex = 5;
            this.right10.TabStop = true;
            this.right10.Text = "Right 10";
            this.right10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.right10_LinkClicked);
            // 
            // right1
            // 
            this.right1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.right1.AutoSize = true;
            this.right1.Location = new System.Drawing.Point(312, 44);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(41, 13);
            this.right1.TabIndex = 4;
            this.right1.TabStop = true;
            this.right1.Text = "Right 1";
            this.right1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.right1_LinkClicked);
            // 
            // backward10
            // 
            this.backward10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backward10.AutoSize = true;
            this.backward10.Location = new System.Drawing.Point(216, 98);
            this.backward10.Name = "backward10";
            this.backward10.Size = new System.Drawing.Size(70, 13);
            this.backward10.TabIndex = 3;
            this.backward10.TabStop = true;
            this.backward10.Text = "Backward 10";
            this.backward10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backward10_LinkClicked);
            // 
            // forward10
            // 
            this.forward10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.forward10.AutoSize = true;
            this.forward10.Location = new System.Drawing.Point(219, 17);
            this.forward10.Name = "forward10";
            this.forward10.Size = new System.Drawing.Size(60, 13);
            this.forward10.TabIndex = 2;
            this.forward10.TabStop = true;
            this.forward10.Text = "Forward 10";
            this.forward10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forward10_LinkClicked);
            // 
            // backward1
            // 
            this.backward1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backward1.AutoSize = true;
            this.backward1.Location = new System.Drawing.Point(219, 81);
            this.backward1.Name = "backward1";
            this.backward1.Size = new System.Drawing.Size(64, 13);
            this.backward1.TabIndex = 1;
            this.backward1.TabStop = true;
            this.backward1.Text = "Backward 1";
            this.backward1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backward1_LinkClicked);
            // 
            // forward1
            // 
            this.forward1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.forward1.AutoSize = true;
            this.forward1.Location = new System.Drawing.Point(222, 33);
            this.forward1.Name = "forward1";
            this.forward1.Size = new System.Drawing.Size(54, 13);
            this.forward1.TabIndex = 0;
            this.forward1.TabStop = true;
            this.forward1.Text = "Forward 1";
            this.forward1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forward1_LinkClicked);
            // 
            // script
            // 
            this.script.Controls.Add(this.run);
            this.script.Controls.Add(this.scriptText);
            this.script.Location = new System.Drawing.Point(4, 22);
            this.script.Name = "script";
            this.script.Size = new System.Drawing.Size(403, 162);
            this.script.TabIndex = 3;
            this.script.Text = "Script";
            this.script.UseVisualStyleBackColor = true;
            // 
            // run
            // 
            this.run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.run.Location = new System.Drawing.Point(324, 136);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 1;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // scriptText
            // 
            this.scriptText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptText.Location = new System.Drawing.Point(4, 4);
            this.scriptText.Multiline = true;
            this.scriptText.Name = "scriptText";
            this.scriptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scriptText.Size = new System.Drawing.Size(396, 126);
            this.scriptText.TabIndex = 0;
            // 
            // PowerShellHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 497);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.display);
            this.Name = "PowerShell";
            this.Text = "PowerShell Logo and Hosting Demo";
            this.ResizeEnd += new System.EventHandler(this.PowerShellHost_ResizeEnd);
            this.display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.actions.ResumeLayout(false);
            this.actions.PerformLayout();
            this.script.ResumeLayout(false);
            this.script.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabPage actions;
        private System.Windows.Forms.LinkLabel right1;
        private System.Windows.Forms.LinkLabel backward10;
        private System.Windows.Forms.LinkLabel forward10;
        private System.Windows.Forms.LinkLabel backward1;
        private System.Windows.Forms.LinkLabel forward1;
        private System.Windows.Forms.LinkLabel clear;
        private System.Windows.Forms.LinkLabel penDown;
        private System.Windows.Forms.LinkLabel penUp;
        private System.Windows.Forms.LinkLabel left10;
        private System.Windows.Forms.LinkLabel left1;
        private System.Windows.Forms.LinkLabel right10;
        private System.Windows.Forms.TabPage script;
        private System.Windows.Forms.TextBox scriptText;
        private System.Windows.Forms.Button run;
    }
}

