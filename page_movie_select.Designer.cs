﻿namespace ticket
{
    partial class page_movie_select
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_movie_select = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_date = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listBox_time = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.movie_select_prev = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.movie_select_next = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_movie_select);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 400);
            this.panel1.TabIndex = 0;
            // 
            // listBox_movie_select
            // 
            this.listBox_movie_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.listBox_movie_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_movie_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_movie_select.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_movie_select.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_movie_select.ForeColor = System.Drawing.Color.White;
            this.listBox_movie_select.FormattingEnabled = true;
            this.listBox_movie_select.ItemHeight = 21;
            this.listBox_movie_select.Location = new System.Drawing.Point(0, 35);
            this.listBox_movie_select.Name = "listBox_movie_select";
            this.listBox_movie_select.Size = new System.Drawing.Size(196, 365);
            this.listBox_movie_select.TabIndex = 1;
            this.listBox_movie_select.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox_movie_select.SelectedIndexChanged += new System.EventHandler(this.listBox_movie_select_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 35);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "영화";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox_date);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(217, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 400);
            this.panel3.TabIndex = 2;
            // 
            // listBox_date
            // 
            this.listBox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.listBox_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_date.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_date.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_date.ForeColor = System.Drawing.Color.White;
            this.listBox_date.FormattingEnabled = true;
            this.listBox_date.ItemHeight = 21;
            this.listBox_date.Location = new System.Drawing.Point(0, 34);
            this.listBox_date.Name = "listBox_date";
            this.listBox_date.Size = new System.Drawing.Size(118, 366);
            this.listBox_date.TabIndex = 1;
            this.listBox_date.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_date_DrawItem);
            this.listBox_date.SelectedIndexChanged += new System.EventHandler(this.listBox_date_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 34);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 35);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "날짜";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listBox_time);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(356, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 400);
            this.panel7.TabIndex = 2;
            // 
            // listBox_time
            // 
            this.listBox_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(61)))));
            this.listBox_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_time.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_time.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox_time.ForeColor = System.Drawing.Color.White;
            this.listBox_time.FormattingEnabled = true;
            this.listBox_time.ItemHeight = 21;
            this.listBox_time.Location = new System.Drawing.Point(0, 35);
            this.listBox_time.Name = "listBox_time";
            this.listBox_time.Size = new System.Drawing.Size(196, 365);
            this.listBox_time.TabIndex = 1;
            this.listBox_time.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_time_DrawItem);
            this.listBox_time.SelectedIndexChanged += new System.EventHandler(this.listBox_time_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(196, 35);
            this.panel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "시간";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel5.Controls.Add(this.movie_select_prev);
            this.panel5.Location = new System.Drawing.Point(563, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 35);
            this.panel5.TabIndex = 3;
            // 
            // movie_select_prev
            // 
            this.movie_select_prev.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movie_select_prev.ForeColor = System.Drawing.Color.White;
            this.movie_select_prev.Location = new System.Drawing.Point(-1, 1);
            this.movie_select_prev.Name = "movie_select_prev";
            this.movie_select_prev.Size = new System.Drawing.Size(82, 31);
            this.movie_select_prev.TabIndex = 0;
            this.movie_select_prev.Text = "이전";
            this.movie_select_prev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movie_select_prev.Click += new System.EventHandler(this.button_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.panel9.Controls.Add(this.movie_select_next);
            this.panel9.Location = new System.Drawing.Point(650, 367);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(80, 35);
            this.panel9.TabIndex = 4;
            // 
            // movie_select_next
            // 
            this.movie_select_next.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.movie_select_next.ForeColor = System.Drawing.Color.White;
            this.movie_select_next.Location = new System.Drawing.Point(-1, 1);
            this.movie_select_next.Name = "movie_select_next";
            this.movie_select_next.Size = new System.Drawing.Size(81, 31);
            this.movie_select_next.TabIndex = 0;
            this.movie_select_next.Text = "좌석선택";
            this.movie_select_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movie_select_next.Click += new System.EventHandler(this.button_Click);
            // 
            // page_movie_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "page_movie_select";
            this.Size = new System.Drawing.Size(775, 488);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_movie_select;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_date;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox listBox_time;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label movie_select_prev;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label movie_select_next;
    }
}
