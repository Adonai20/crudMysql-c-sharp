namespace CapasN
{
    partial class cFrom
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
            this.userDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.NumericUpDown();
            this.userLink = new System.Windows.Forms.LinkLabel();
            this.userName = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.userDialog = new System.Windows.Forms.OpenFileDialog();
            this.userSave = new System.Windows.Forms.Button();
            this.userNew = new System.Windows.Forms.Button();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // userDelete
            // 
            this.userDelete.Location = new System.Drawing.Point(225, 396);
            this.userDelete.Name = "userDelete";
            this.userDelete.Size = new System.Drawing.Size(75, 23);
            this.userDelete.TabIndex = 1;
            this.userDelete.Text = "DELETE";
            this.userDelete.UseVisualStyleBackColor = true;
            this.userDelete.Click += new System.EventHandler(this.userDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Photo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userId
            // 
            this.userId.Enabled = false;
            this.userId.Location = new System.Drawing.Point(184, 40);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(138, 23);
            this.userId.TabIndex = 7;
            // 
            // userLink
            // 
            this.userLink.AutoSize = true;
            this.userLink.Location = new System.Drawing.Point(184, 332);
            this.userLink.Name = "userLink";
            this.userLink.Size = new System.Drawing.Size(60, 15);
            this.userLink.TabIndex = 8;
            this.userLink.TabStop = true;
            this.userLink.Text = "linkLabel1";
            this.userLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userLink_LinkClicked);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(184, 87);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(138, 23);
            this.userName.TabIndex = 9;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(184, 153);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(138, 23);
            this.userLastName.TabIndex = 10;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userImage.Location = new System.Drawing.Point(184, 218);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(189, 111);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 11;
            this.userImage.TabStop = false;
            this.userImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userDialog
            // 
            this.userDialog.FileName = "openFileDialog1";
            // 
            // userSave
            // 
            this.userSave.Location = new System.Drawing.Point(306, 398);
            this.userSave.Name = "userSave";
            this.userSave.Size = new System.Drawing.Size(75, 23);
            this.userSave.TabIndex = 12;
            this.userSave.Text = "SAVE";
            this.userSave.UseVisualStyleBackColor = true;
            this.userSave.Click += new System.EventHandler(this.userSave_Click);
            // 
            // userNew
            // 
            this.userNew.Location = new System.Drawing.Point(144, 396);
            this.userNew.Name = "userNew";
            this.userNew.Size = new System.Drawing.Size(75, 21);
            this.userNew.TabIndex = 13;
            this.userNew.Text = "NEW";
            this.userNew.UseVisualStyleBackColor = true;
            this.userNew.Click += new System.EventHandler(this.userNew_Click);
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(453, 29);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(523, 392);
            this.gridDatos.TabIndex = 14;
            this.gridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellDoubleClick);
            // 
            // cFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 591);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.userNew);
            this.Controls.Add(this.userSave);
            this.Controls.Add(this.userImage);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userLink);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDelete);
            this.Name = "cFrom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button userDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown userId;
        private LinkLabel userLink;
        private TextBox userName;
        private TextBox userLastName;
        private PictureBox userImage;
        private OpenFileDialog userDialog;
        private Button userSave;
        private Button userNew;
        private DataGridView gridDatos;
    }
}