namespace ZianLauncher2
{
    partial class LauncherForm2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm2));
            this.textBoxJava = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VersionBox = new System.Windows.Forms.ComboBox();
            this.RAMBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxJava
            // 
            this.textBoxJava.BackColor = System.Drawing.Color.White;
            this.textBoxJava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJava.Enabled = false;
            this.textBoxJava.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJava.Location = new System.Drawing.Point(8, 8);
            this.textBoxJava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJava.Multiline = true;
            this.textBoxJava.Name = "textBoxJava";
            this.textBoxJava.Size = new System.Drawing.Size(361, 51);
            this.textBoxJava.TabIndex = 0;
            this.textBoxJava.Text = "C:\\Program Files\\Java\\jre1.8.0_181\\bin\\javaw.exe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(375, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Java path";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxID.Location = new System.Drawing.Point(37, 66);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(97, 23);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.Text = "zian1";
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "RAM";
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.Location = new System.Drawing.Point(237, 98);
            this.buttonF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(233, 44);
            this.buttonF.TabIndex = 11;
            this.buttonF.Text = "Forge";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonO
            // 
            this.buttonO.BackColor = System.Drawing.Color.Khaki;
            this.buttonO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonO.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.Location = new System.Drawing.Point(8, 98);
            this.buttonO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(223, 44);
            this.buttonO.TabIndex = 18;
            this.buttonO.Text = "Origin";
            this.buttonO.UseVisualStyleBackColor = false;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Version";
            // 
            // VersionBox
            // 
            this.VersionBox.FormattingEnabled = true;
            this.VersionBox.Items.AddRange(new object[] {
            "1.16.1",
            "1.16.2"});
            this.VersionBox.Location = new System.Drawing.Point(357, 66);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(113, 23);
            this.VersionBox.Sorted = true;
            this.VersionBox.TabIndex = 21;
            // 
            // RAMBox
            // 
            this.RAMBox.FormattingEnabled = true;
            this.RAMBox.Items.AddRange(new object[] {
            "2048",
            "4096",
            "8192"});
            this.RAMBox.Location = new System.Drawing.Point(184, 66);
            this.RAMBox.Name = "RAMBox";
            this.RAMBox.Size = new System.Drawing.Size(103, 23);
            this.RAMBox.Sorted = true;
            this.RAMBox.TabIndex = 22;
            // 
            // LauncherForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 149);
            this.Controls.Add(this.RAMBox);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxJava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherForm2";
            this.Text = "MC 1.16.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VersionBox;
        private System.Windows.Forms.ComboBox RAMBox;
    }
}

