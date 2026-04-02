namespace LoginScreen
{
    partial class lblAppName
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
            label1 = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 106);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(50, 145);
            txtID.Name = "txtID";
            txtID.Size = new Size(361, 70);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(50, 252);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(361, 70);
            txtPW.TabIndex = 2;
            txtPW.Text = "패스워드";
           
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.Navy;
            btnLogin.Location = new Point(104, 359);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(247, 91);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
         
            // 
            // lblAppName
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 478);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "lblAppName";
            Text = "Form1";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
