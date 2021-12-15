namespace SharedMemoryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFModule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSModule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTModule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxControler = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelReadValue = new System.Windows.Forms.Label();
            this.buttonSaveConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonControlerStart = new System.Windows.Forms.Button();
            this.numericUpDownSave = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSave)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartRead
            // 
            this.buttonStartRead.Location = new System.Drawing.Point(11, 18);
            this.buttonStartRead.Name = "buttonStartRead";
            this.buttonStartRead.Size = new System.Drawing.Size(82, 23);
            this.buttonStartRead.TabIndex = 0;
            this.buttonStartRead.Text = "Start reading";
            this.buttonStartRead.UseVisualStyleBackColor = true;
            this.buttonStartRead.Click += new System.EventHandler(this.buttonStartRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Read the variable";
            // 
            // textBoxFModule
            // 
            this.textBoxFModule.Location = new System.Drawing.Point(11, 99);
            this.textBoxFModule.Name = "textBoxFModule";
            this.textBoxFModule.Size = new System.Drawing.Size(459, 23);
            this.textBoxFModule.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "First module";
            // 
            // textBoxSModule
            // 
            this.textBoxSModule.Location = new System.Drawing.Point(11, 143);
            this.textBoxSModule.Name = "textBoxSModule";
            this.textBoxSModule.Size = new System.Drawing.Size(459, 23);
            this.textBoxSModule.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Second module";
            // 
            // textBoxTModule
            // 
            this.textBoxTModule.Location = new System.Drawing.Point(11, 187);
            this.textBoxTModule.Name = "textBoxTModule";
            this.textBoxTModule.Size = new System.Drawing.Size(459, 23);
            this.textBoxTModule.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Third module";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Choosen by Controler:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxControler
            // 
            this.textBoxControler.Location = new System.Drawing.Point(11, 260);
            this.textBoxControler.Name = "textBoxControler";
            this.textBoxControler.Size = new System.Drawing.Size(459, 23);
            this.textBoxControler.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Variable (int):";
            // 
            // labelReadValue
            // 
            this.labelReadValue.AutoSize = true;
            this.labelReadValue.Location = new System.Drawing.Point(93, 44);
            this.labelReadValue.Name = "labelReadValue";
            this.labelReadValue.Size = new System.Drawing.Size(0, 15);
            this.labelReadValue.TabIndex = 17;
            // 
            // buttonSaveConvert
            // 
            this.buttonSaveConvert.Location = new System.Drawing.Point(11, 55);
            this.buttonSaveConvert.Name = "buttonSaveConvert";
            this.buttonSaveConvert.Size = new System.Drawing.Size(108, 23);
            this.buttonSaveConvert.TabIndex = 0;
            this.buttonSaveConvert.Text = "Load to modules";
            this.buttonSaveConvert.UseVisualStyleBackColor = true;
            this.buttonSaveConvert.Click += new System.EventHandler(this.buttonSaveConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save variable (int)";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(11, 289);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save variable";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonControlerStart);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxControler);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveConvert);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTModule);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxFModule);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSModule);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelReadValue);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStartRead);
            this.splitContainer1.Size = new System.Drawing.Size(485, 478);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonControlerStart
            // 
            this.buttonControlerStart.Location = new System.Drawing.Point(11, 216);
            this.buttonControlerStart.Name = "buttonControlerStart";
            this.buttonControlerStart.Size = new System.Drawing.Size(97, 23);
            this.buttonControlerStart.TabIndex = 18;
            this.buttonControlerStart.Text = "Start controler";
            this.buttonControlerStart.UseVisualStyleBackColor = true;
            this.buttonControlerStart.Click += new System.EventHandler(this.buttonControlerStart_Click);
            // 
            // numericUpDownSave
            // 
            this.numericUpDownSave.Location = new System.Drawing.Point(11, 26);
            this.numericUpDownSave.Maximum = new decimal(new int[] {
            -1294967296,
            0,
            0,
            0});
            this.numericUpDownSave.Name = "numericUpDownSave";
            this.numericUpDownSave.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSave.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonStartRead;
        private Label label2;
        private TextBox textBoxFModule;
        private Label label3;
        private TextBox textBoxSModule;
        private Label label4;
        private TextBox textBoxTModule;
        private Label label5;
        private Label label6;
        private TextBox textBoxControler;
        private Label label7;
        private Label labelReadValue;
        private Button buttonSaveConvert;
        private Label label1;
        private Button buttonSave;
        private SplitContainer splitContainer1;
        private Button buttonControlerStart;
        private NumericUpDown numericUpDownSave;
    }
}