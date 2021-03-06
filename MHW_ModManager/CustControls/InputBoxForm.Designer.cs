﻿
    partial class InputBoxForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBoxForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.TitleLabel = new PassThroughLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.checkBoxGeneric1 = new System.Windows.Forms.CheckBox();
            this.trackBarGeneric = new System.Windows.Forms.TrackBar();
            this.labelGeneric = new System.Windows.Forms.Label();
            this.panelBG = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNoAll = new System.Windows.Forms.Button();
            this.buttonYesAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGeneric)).BeginInit();
            this.panelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 22);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Location = new System.Drawing.Point(505, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLabel.Location = new System.Drawing.Point(4, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 18);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Input";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonCancel.Location = new System.Drawing.Point(456, 89);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(52, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonOK.Location = new System.Drawing.Point(405, 89);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(45, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(55, 19);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(352, 20);
            this.textBoxInput.TabIndex = 5;
            this.textBoxInput.Visible = false;
            this.textBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyUp);
            // 
            // checkBoxGeneric1
            // 
            this.checkBoxGeneric1.AutoSize = true;
            this.checkBoxGeneric1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxGeneric1.Location = new System.Drawing.Point(389, 19);
            this.checkBoxGeneric1.Name = "checkBoxGeneric1";
            this.checkBoxGeneric1.Size = new System.Drawing.Size(80, 17);
            this.checkBoxGeneric1.TabIndex = 7;
            this.checkBoxGeneric1.Text = "checkBox1";
            this.checkBoxGeneric1.UseVisualStyleBackColor = true;
            this.checkBoxGeneric1.Visible = false;
            // 
            // trackBarGeneric
            // 
            this.trackBarGeneric.AutoSize = false;
            this.trackBarGeneric.Location = new System.Drawing.Point(90, 19);
            this.trackBarGeneric.MaximumSize = new System.Drawing.Size(9000, 1000);
            this.trackBarGeneric.Name = "trackBarGeneric";
            this.trackBarGeneric.Size = new System.Drawing.Size(360, 22);
            this.trackBarGeneric.TabIndex = 8;
            this.trackBarGeneric.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGeneric.Visible = false;
            this.trackBarGeneric.Scroll += new System.EventHandler(this.trackBarGeneric_Scroll);
            // 
            // labelGeneric
            // 
            this.labelGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneric.ForeColor = System.Drawing.Color.LightGray;
            this.labelGeneric.Location = new System.Drawing.Point(20, 2);
            this.labelGeneric.Name = "labelGeneric";
            this.labelGeneric.Size = new System.Drawing.Size(488, 84);
            this.labelGeneric.TabIndex = 9;
            this.labelGeneric.Text = "labelGeneric";
            this.labelGeneric.Visible = false;
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panelBG.Controls.Add(this.richTextBox1);
            this.panelBG.Controls.Add(this.buttonNoAll);
            this.panelBG.Controls.Add(this.buttonYesAll);
            this.panelBG.Controls.Add(this.checkBoxGeneric1);
            this.panelBG.Controls.Add(this.trackBarGeneric);
            this.panelBG.Controls.Add(this.buttonCancel);
            this.panelBG.Controls.Add(this.buttonOK);
            this.panelBG.Controls.Add(this.textBoxInput);
            this.panelBG.Controls.Add(this.labelGeneric);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Location = new System.Drawing.Point(0, 22);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(527, 119);
            this.panelBG.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(20, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(488, 80);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // buttonNoAll
            // 
            this.buttonNoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNoAll.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.buttonNoAll.Location = new System.Drawing.Point(90, 89);
            this.buttonNoAll.Name = "buttonNoAll";
            this.buttonNoAll.Size = new System.Drawing.Size(60, 23);
            this.buttonNoAll.TabIndex = 15;
            this.buttonNoAll.Text = "No to all";
            this.buttonNoAll.UseVisualStyleBackColor = true;
            // 
            // buttonYesAll
            // 
            this.buttonYesAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonYesAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonYesAll.Location = new System.Drawing.Point(20, 89);
            this.buttonYesAll.Name = "buttonYesAll";
            this.buttonYesAll.Size = new System.Drawing.Size(63, 23);
            this.buttonYesAll.TabIndex = 14;
            this.buttonYesAll.Text = "Yes to all";
            this.buttonYesAll.UseVisualStyleBackColor = true;
            // 
            // InputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(527, 141);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputBoxForm";
            this.Text = "Input Box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputBoxForm_FormClosing_1);
            this.Shown += new System.EventHandler(this.InputBoxForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGeneric)).EndInit();
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonClose;
        public PassThroughLabel TitleLabel;
        public System.Windows.Forms.TextBox textBoxInput;
        public System.Windows.Forms.CheckBox checkBoxGeneric1;
        public System.Windows.Forms.TrackBar trackBarGeneric;
        public System.Windows.Forms.Label labelGeneric;
    public System.Windows.Forms.RichTextBox richTextBox1;
    public System.Windows.Forms.Button buttonCancel;
    public System.Windows.Forms.Button buttonOK;
    public System.Windows.Forms.Button buttonNoAll;
    public System.Windows.Forms.Button buttonYesAll;
    public System.Windows.Forms.Panel panelBG;
}
