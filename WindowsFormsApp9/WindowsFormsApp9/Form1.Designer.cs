﻿namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uc1 = new WindowsFormsApp9.UserControl1();
            this.uc2 = new WindowsFormsApp9.UserControl1();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uc1
            // 
            this.uc1.Label1Text = "sdfg";
            this.uc1.Location = new System.Drawing.Point(61, 66);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(565, 150);
            this.uc1.TabIndex = 1;
            // 
            // uc2
            // 
            this.uc2.Label1Text = "sdfg";
            this.uc2.Location = new System.Drawing.Point(61, 252);
            this.uc2.Name = "uc2";
            this.uc2.Size = new System.Drawing.Size(565, 150);
            this.uc2.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uc2);
            this.Controls.Add(this.uc1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserControl1 uc1;
        private UserControl1 uc2;
    }
}

