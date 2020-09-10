namespace WinAppDollySimulator
{
    partial class FormDollySimulator
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
            this.lbDollyOrientation = new System.Windows.Forms.Label();
            this.cbDollyOrientation = new System.Windows.Forms.ComboBox();
            this.lbLeftWheelSpeed = new System.Windows.Forms.Label();
            this.tbLeftWheelSpeed = new System.Windows.Forms.TextBox();
            this.lbRightWheelSpeed = new System.Windows.Forms.Label();
            this.tbRightWheelSpeed = new System.Windows.Forms.TextBox();
            this.pnlDollyView = new System.Windows.Forms.Panel();
            this.lbOrientationSymble = new System.Windows.Forms.Label();
            this.pnlRightWheel = new System.Windows.Forms.Panel();
            this.pnlLeftWheel = new System.Windows.Forms.Panel();
            this.lbLeftWheelDistance = new System.Windows.Forms.Label();
            this.tbLeftWheelDistance = new System.Windows.Forms.TextBox();
            this.lbRightWheelDistance = new System.Windows.Forms.Label();
            this.tbRightWheelDistance = new System.Windows.Forms.TextBox();
            this.lbDistanceAngle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbImuAngle = new System.Windows.Forms.Label();
            this.tbImuAngle = new System.Windows.Forms.TextBox();
            this.tbRadianMeasure = new System.Windows.Forms.TextBox();
            this.tbLeftDeviation = new System.Windows.Forms.TextBox();
            this.tbRightDeviation = new System.Windows.Forms.TextBox();
            this.btnStartRun = new System.Windows.Forms.Button();
            this.lbSumDistanceLeftWheel = new System.Windows.Forms.Label();
            this.lbSumDistanceRightWheel = new System.Windows.Forms.Label();
            this.tbSumDistanceLeftWheel = new System.Windows.Forms.TextBox();
            this.tbSumDistanceRightWheel = new System.Windows.Forms.TextBox();
            this.lbTips = new System.Windows.Forms.Label();
            this.tbRunTimes = new System.Windows.Forms.TextBox();
            this.lbRunTimes = new System.Windows.Forms.Label();
            this.lbLeftSpeed = new System.Windows.Forms.Label();
            this.lbRightSpeed = new System.Windows.Forms.Label();
            this.pnlDollyView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDollyOrientation
            // 
            this.lbDollyOrientation.AutoSize = true;
            this.lbDollyOrientation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDollyOrientation.Location = new System.Drawing.Point(107, 25);
            this.lbDollyOrientation.Name = "lbDollyOrientation";
            this.lbDollyOrientation.Size = new System.Drawing.Size(56, 17);
            this.lbDollyOrientation.TabIndex = 0;
            this.lbDollyOrientation.Text = "当前方向";
            // 
            // cbDollyOrientation
            // 
            this.cbDollyOrientation.FormattingEnabled = true;
            this.cbDollyOrientation.Items.AddRange(new object[] {
            "E",
            "S",
            "W",
            "N"});
            this.cbDollyOrientation.Location = new System.Drawing.Point(168, 21);
            this.cbDollyOrientation.Name = "cbDollyOrientation";
            this.cbDollyOrientation.Size = new System.Drawing.Size(76, 25);
            this.cbDollyOrientation.TabIndex = 1;
            // 
            // lbLeftWheelSpeed
            // 
            this.lbLeftWheelSpeed.AutoSize = true;
            this.lbLeftWheelSpeed.Location = new System.Drawing.Point(107, 70);
            this.lbLeftWheelSpeed.Name = "lbLeftWheelSpeed";
            this.lbLeftWheelSpeed.Size = new System.Drawing.Size(56, 17);
            this.lbLeftWheelSpeed.TabIndex = 0;
            this.lbLeftWheelSpeed.Text = "左轮速度";
            // 
            // tbLeftWheelSpeed
            // 
            this.tbLeftWheelSpeed.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbLeftWheelSpeed.Location = new System.Drawing.Point(168, 67);
            this.tbLeftWheelSpeed.MaxLength = 4;
            this.tbLeftWheelSpeed.Name = "tbLeftWheelSpeed";
            this.tbLeftWheelSpeed.Size = new System.Drawing.Size(76, 23);
            this.tbLeftWheelSpeed.TabIndex = 2;
            this.tbLeftWheelSpeed.Text = "20";
            this.tbLeftWheelSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRightWheelSpeed
            // 
            this.lbRightWheelSpeed.AutoSize = true;
            this.lbRightWheelSpeed.Location = new System.Drawing.Point(107, 139);
            this.lbRightWheelSpeed.Name = "lbRightWheelSpeed";
            this.lbRightWheelSpeed.Size = new System.Drawing.Size(56, 17);
            this.lbRightWheelSpeed.TabIndex = 0;
            this.lbRightWheelSpeed.Text = "左轮速度";
            // 
            // tbRightWheelSpeed
            // 
            this.tbRightWheelSpeed.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbRightWheelSpeed.Location = new System.Drawing.Point(168, 136);
            this.tbRightWheelSpeed.MaxLength = 4;
            this.tbRightWheelSpeed.Name = "tbRightWheelSpeed";
            this.tbRightWheelSpeed.Size = new System.Drawing.Size(76, 23);
            this.tbRightWheelSpeed.TabIndex = 2;
            this.tbRightWheelSpeed.Text = "20";
            this.tbRightWheelSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlDollyView
            // 
            this.pnlDollyView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlDollyView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDollyView.Controls.Add(this.lbOrientationSymble);
            this.pnlDollyView.Controls.Add(this.pnlRightWheel);
            this.pnlDollyView.Controls.Add(this.pnlLeftWheel);
            this.pnlDollyView.Location = new System.Drawing.Point(311, 63);
            this.pnlDollyView.Name = "pnlDollyView";
            this.pnlDollyView.Size = new System.Drawing.Size(100, 100);
            this.pnlDollyView.TabIndex = 3;
            // 
            // lbOrientationSymble
            // 
            this.lbOrientationSymble.AutoSize = true;
            this.lbOrientationSymble.Location = new System.Drawing.Point(48, 41);
            this.lbOrientationSymble.Name = "lbOrientationSymble";
            this.lbOrientationSymble.Size = new System.Drawing.Size(36, 17);
            this.lbOrientationSymble.TabIndex = 4;
            this.lbOrientationSymble.Text = "|-----";
            // 
            // pnlRightWheel
            // 
            this.pnlRightWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRightWheel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightWheel.Location = new System.Drawing.Point(24, 75);
            this.pnlRightWheel.Name = "pnlRightWheel";
            this.pnlRightWheel.Size = new System.Drawing.Size(50, 20);
            this.pnlRightWheel.TabIndex = 3;
            // 
            // pnlLeftWheel
            // 
            this.pnlLeftWheel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlLeftWheel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftWheel.Location = new System.Drawing.Point(24, 3);
            this.pnlLeftWheel.Name = "pnlLeftWheel";
            this.pnlLeftWheel.Size = new System.Drawing.Size(50, 20);
            this.pnlLeftWheel.TabIndex = 3;
            // 
            // lbLeftWheelDistance
            // 
            this.lbLeftWheelDistance.AutoSize = true;
            this.lbLeftWheelDistance.Location = new System.Drawing.Point(54, 253);
            this.lbLeftWheelDistance.Name = "lbLeftWheelDistance";
            this.lbLeftWheelDistance.Size = new System.Drawing.Size(109, 17);
            this.lbLeftWheelDistance.TabIndex = 0;
            this.lbLeftWheelDistance.Text = "左轮行走距离/误差";
            // 
            // tbLeftWheelDistance
            // 
            this.tbLeftWheelDistance.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbLeftWheelDistance.Location = new System.Drawing.Point(168, 250);
            this.tbLeftWheelDistance.MaxLength = 15;
            this.tbLeftWheelDistance.Name = "tbLeftWheelDistance";
            this.tbLeftWheelDistance.Size = new System.Drawing.Size(76, 23);
            this.tbLeftWheelDistance.TabIndex = 2;
            this.tbLeftWheelDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRightWheelDistance
            // 
            this.lbRightWheelDistance.AutoSize = true;
            this.lbRightWheelDistance.Location = new System.Drawing.Point(54, 282);
            this.lbRightWheelDistance.Name = "lbRightWheelDistance";
            this.lbRightWheelDistance.Size = new System.Drawing.Size(109, 17);
            this.lbRightWheelDistance.TabIndex = 0;
            this.lbRightWheelDistance.Text = "右轮行走距离/误差";
            // 
            // tbRightWheelDistance
            // 
            this.tbRightWheelDistance.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbRightWheelDistance.Location = new System.Drawing.Point(168, 279);
            this.tbRightWheelDistance.MaxLength = 15;
            this.tbRightWheelDistance.Name = "tbRightWheelDistance";
            this.tbRightWheelDistance.Size = new System.Drawing.Size(76, 23);
            this.tbRightWheelDistance.TabIndex = 2;
            this.tbRightWheelDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDistanceAngle
            // 
            this.lbDistanceAngle.AutoSize = true;
            this.lbDistanceAngle.Location = new System.Drawing.Point(66, 329);
            this.lbDistanceAngle.Name = "lbDistanceAngle";
            this.lbDistanceAngle.Size = new System.Drawing.Size(97, 17);
            this.lbDistanceAngle.TabIndex = 0;
            this.lbDistanceAngle.Text = "里程计角度/弧度";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textBox1.Location = new System.Drawing.Point(168, 326);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbImuAngle
            // 
            this.lbImuAngle.AutoSize = true;
            this.lbImuAngle.Location = new System.Drawing.Point(83, 358);
            this.lbImuAngle.Name = "lbImuAngle";
            this.lbImuAngle.Size = new System.Drawing.Size(80, 17);
            this.lbImuAngle.TabIndex = 0;
            this.lbImuAngle.Text = "惯性导航角度";
            // 
            // tbImuAngle
            // 
            this.tbImuAngle.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbImuAngle.Location = new System.Drawing.Point(168, 355);
            this.tbImuAngle.MaxLength = 15;
            this.tbImuAngle.Name = "tbImuAngle";
            this.tbImuAngle.Size = new System.Drawing.Size(76, 23);
            this.tbImuAngle.TabIndex = 2;
            this.tbImuAngle.Text = "0.00";
            this.tbImuAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRadianMeasure
            // 
            this.tbRadianMeasure.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbRadianMeasure.Location = new System.Drawing.Point(250, 326);
            this.tbRadianMeasure.MaxLength = 15;
            this.tbRadianMeasure.Name = "tbRadianMeasure";
            this.tbRadianMeasure.Size = new System.Drawing.Size(76, 23);
            this.tbRadianMeasure.TabIndex = 2;
            this.tbRadianMeasure.Text = "0.00";
            this.tbRadianMeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLeftDeviation
            // 
            this.tbLeftDeviation.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbLeftDeviation.Location = new System.Drawing.Point(250, 250);
            this.tbLeftDeviation.MaxLength = 15;
            this.tbLeftDeviation.Name = "tbLeftDeviation";
            this.tbLeftDeviation.Size = new System.Drawing.Size(76, 23);
            this.tbLeftDeviation.TabIndex = 2;
            this.tbLeftDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRightDeviation
            // 
            this.tbRightDeviation.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbRightDeviation.Location = new System.Drawing.Point(250, 279);
            this.tbRightDeviation.MaxLength = 15;
            this.tbRightDeviation.Name = "tbRightDeviation";
            this.tbRightDeviation.Size = new System.Drawing.Size(76, 23);
            this.tbRightDeviation.TabIndex = 2;
            this.tbRightDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStartRun
            // 
            this.btnStartRun.Location = new System.Drawing.Point(168, 198);
            this.btnStartRun.Name = "btnStartRun";
            this.btnStartRun.Size = new System.Drawing.Size(134, 35);
            this.btnStartRun.TabIndex = 4;
            this.btnStartRun.Text = "开始运行";
            this.btnStartRun.UseVisualStyleBackColor = true;
            this.btnStartRun.Click += new System.EventHandler(this.btnStartRun_Click);
            // 
            // lbSumDistanceLeftWheel
            // 
            this.lbSumDistanceLeftWheel.AutoSize = true;
            this.lbSumDistanceLeftWheel.Location = new System.Drawing.Point(399, 253);
            this.lbSumDistanceLeftWheel.Name = "lbSumDistanceLeftWheel";
            this.lbSumDistanceLeftWheel.Size = new System.Drawing.Size(68, 17);
            this.lbSumDistanceLeftWheel.TabIndex = 0;
            this.lbSumDistanceLeftWheel.Text = "左轮总里程";
            // 
            // lbSumDistanceRightWheel
            // 
            this.lbSumDistanceRightWheel.AutoSize = true;
            this.lbSumDistanceRightWheel.Location = new System.Drawing.Point(399, 282);
            this.lbSumDistanceRightWheel.Name = "lbSumDistanceRightWheel";
            this.lbSumDistanceRightWheel.Size = new System.Drawing.Size(68, 17);
            this.lbSumDistanceRightWheel.TabIndex = 0;
            this.lbSumDistanceRightWheel.Text = "右轮总里程";
            // 
            // tbSumDistanceLeftWheel
            // 
            this.tbSumDistanceLeftWheel.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbSumDistanceLeftWheel.Location = new System.Drawing.Point(473, 250);
            this.tbSumDistanceLeftWheel.MaxLength = 15;
            this.tbSumDistanceLeftWheel.Name = "tbSumDistanceLeftWheel";
            this.tbSumDistanceLeftWheel.Size = new System.Drawing.Size(76, 23);
            this.tbSumDistanceLeftWheel.TabIndex = 2;
            this.tbSumDistanceLeftWheel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumDistanceRightWheel
            // 
            this.tbSumDistanceRightWheel.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbSumDistanceRightWheel.Location = new System.Drawing.Point(473, 279);
            this.tbSumDistanceRightWheel.MaxLength = 15;
            this.tbSumDistanceRightWheel.Name = "tbSumDistanceRightWheel";
            this.tbSumDistanceRightWheel.Size = new System.Drawing.Size(76, 23);
            this.tbSumDistanceRightWheel.TabIndex = 2;
            this.tbSumDistanceRightWheel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTips.Location = new System.Drawing.Point(309, 207);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(99, 17);
            this.lbTips.TabIndex = 5;
            this.lbTips.Text = "每80ms一次循环";
            // 
            // tbRunTimes
            // 
            this.tbRunTimes.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbRunTimes.Location = new System.Drawing.Point(116, 204);
            this.tbRunTimes.MaxLength = 4;
            this.tbRunTimes.Name = "tbRunTimes";
            this.tbRunTimes.Size = new System.Drawing.Size(47, 23);
            this.tbRunTimes.TabIndex = 2;
            this.tbRunTimes.Text = "50";
            this.tbRunTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRunTimes
            // 
            this.lbRunTimes.AutoSize = true;
            this.lbRunTimes.Location = new System.Drawing.Point(54, 207);
            this.lbRunTimes.Name = "lbRunTimes";
            this.lbRunTimes.Size = new System.Drawing.Size(56, 17);
            this.lbRunTimes.TabIndex = 0;
            this.lbRunTimes.Text = "循环次数";
            // 
            // lbLeftSpeed
            // 
            this.lbLeftSpeed.AutoSize = true;
            this.lbLeftSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbLeftSpeed.Location = new System.Drawing.Point(13, 387);
            this.lbLeftSpeed.Name = "lbLeftSpeed";
            this.lbLeftSpeed.Size = new System.Drawing.Size(77, 17);
            this.lbLeftSpeed.TabIndex = 5;
            this.lbLeftSpeed.Text = "lbLeftSpeed";
            // 
            // lbRightSpeed
            // 
            this.lbRightSpeed.AutoSize = true;
            this.lbRightSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbRightSpeed.Location = new System.Drawing.Point(11, 406);
            this.lbRightSpeed.Name = "lbRightSpeed";
            this.lbRightSpeed.Size = new System.Drawing.Size(86, 17);
            this.lbRightSpeed.TabIndex = 5;
            this.lbRightSpeed.Text = "lbRightSpeed";
            // 
            // FormDollySimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lbRightSpeed);
            this.Controls.Add(this.lbLeftSpeed);
            this.Controls.Add(this.lbTips);
            this.Controls.Add(this.btnStartRun);
            this.Controls.Add(this.pnlDollyView);
            this.Controls.Add(this.tbImuAngle);
            this.Controls.Add(this.tbRadianMeasure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbImuAngle);
            this.Controls.Add(this.tbRightDeviation);
            this.Controls.Add(this.tbSumDistanceRightWheel);
            this.Controls.Add(this.tbRightWheelDistance);
            this.Controls.Add(this.lbDistanceAngle);
            this.Controls.Add(this.tbSumDistanceLeftWheel);
            this.Controls.Add(this.tbLeftDeviation);
            this.Controls.Add(this.lbSumDistanceRightWheel);
            this.Controls.Add(this.tbLeftWheelDistance);
            this.Controls.Add(this.lbRightWheelDistance);
            this.Controls.Add(this.lbSumDistanceLeftWheel);
            this.Controls.Add(this.tbRunTimes);
            this.Controls.Add(this.tbRightWheelSpeed);
            this.Controls.Add(this.lbLeftWheelDistance);
            this.Controls.Add(this.tbLeftWheelSpeed);
            this.Controls.Add(this.lbRunTimes);
            this.Controls.Add(this.lbRightWheelSpeed);
            this.Controls.Add(this.cbDollyOrientation);
            this.Controls.Add(this.lbLeftWheelSpeed);
            this.Controls.Add(this.lbDollyOrientation);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDollySimulator";
            this.Text = "DollySimulator";
            this.Load += new System.EventHandler(this.FormDollySimulator_Load);
            this.pnlDollyView.ResumeLayout(false);
            this.pnlDollyView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDollyOrientation;
        private System.Windows.Forms.ComboBox cbDollyOrientation;
        private System.Windows.Forms.Label lbLeftWheelSpeed;
        private System.Windows.Forms.TextBox tbLeftWheelSpeed;
        private System.Windows.Forms.Label lbRightWheelSpeed;
        private System.Windows.Forms.TextBox tbRightWheelSpeed;
        private System.Windows.Forms.Panel pnlDollyView;
        private System.Windows.Forms.Panel pnlRightWheel;
        private System.Windows.Forms.Panel pnlLeftWheel;
        private System.Windows.Forms.Label lbOrientationSymble;
        private System.Windows.Forms.Label lbLeftWheelDistance;
        private System.Windows.Forms.TextBox tbLeftWheelDistance;
        private System.Windows.Forms.Label lbRightWheelDistance;
        private System.Windows.Forms.TextBox tbRightWheelDistance;
        private System.Windows.Forms.Label lbDistanceAngle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbImuAngle;
        private System.Windows.Forms.TextBox tbImuAngle;
        private System.Windows.Forms.TextBox tbRadianMeasure;
        private System.Windows.Forms.TextBox tbLeftDeviation;
        private System.Windows.Forms.TextBox tbRightDeviation;
        private System.Windows.Forms.Button btnStartRun;
        private System.Windows.Forms.Label lbSumDistanceLeftWheel;
        private System.Windows.Forms.Label lbSumDistanceRightWheel;
        private System.Windows.Forms.TextBox tbSumDistanceLeftWheel;
        private System.Windows.Forms.TextBox tbSumDistanceRightWheel;
        private System.Windows.Forms.Label lbTips;
        private System.Windows.Forms.TextBox tbRunTimes;
        private System.Windows.Forms.Label lbRunTimes;
        private System.Windows.Forms.Label lbLeftSpeed;
        private System.Windows.Forms.Label lbRightSpeed;
    }
}

