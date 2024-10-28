namespace BodyHeath
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmaleBM = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOld = new System.Windows.Forms.TextBox();
            this.tbTall = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbfamaleBM = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbinputKj = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbeKcal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbeKgFat = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rtbRecord = new System.Windows.Forms.RichTextBox();
            this.lbInputCount = new System.Windows.Forms.Label();
            this.lbSumInput = new System.Windows.Forms.Label();
            this.btnConsume = new System.Windows.Forms.Button();
            this.lbSumConsume = new System.Windows.Forms.Label();
            this.lbConsumeCount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbfinalFatG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "男性BM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "女性BM:";
            // 
            // lbmaleBM
            // 
            this.lbmaleBM.AutoSize = true;
            this.lbmaleBM.Location = new System.Drawing.Point(69, 31);
            this.lbmaleBM.Name = "lbmaleBM";
            this.lbmaleBM.Size = new System.Drawing.Size(17, 12);
            this.lbmaleBM.TabIndex = 2;
            this.lbmaleBM.Text = "--";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(247, 42);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(49, 21);
            this.tbWeight.TabIndex = 3;
            this.tbWeight.Text = "60";
            this.tbWeight.TextChanged += new System.EventHandler(this.BMInputChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "(Kcal) = 66 + 13.7 x";
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(506, 42);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(48, 21);
            this.tbOld.TabIndex = 8;
            this.tbOld.Text = "25";
            this.tbOld.TextChanged += new System.EventHandler(this.BMInputChanged);
            // 
            // tbTall
            // 
            this.tbTall.Location = new System.Drawing.Point(377, 42);
            this.tbTall.Name = "tbTall";
            this.tbTall.Size = new System.Drawing.Size(47, 21);
            this.tbTall.TabIndex = 9;
            this.tbTall.Text = "170";
            this.tbTall.TextChanged += new System.EventHandler(this.BMInputChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "(Kg) + 5.0 x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "(cm) + 6.8 x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "(岁)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "(岁)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "(cm) + 4.7 x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "(Kg) + 1.8 x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "(Kcal) = 655 + 9.5 x";
            // 
            // lbfamaleBM
            // 
            this.lbfamaleBM.AutoSize = true;
            this.lbfamaleBM.Location = new System.Drawing.Point(69, 60);
            this.lbfamaleBM.Name = "lbfamaleBM";
            this.lbfamaleBM.Size = new System.Drawing.Size(17, 12);
            this.lbfamaleBM.TabIndex = 13;
            this.lbfamaleBM.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 72);
            this.label11.TabIndex = 21;
            this.label11.Text = "60Kg成年人一般运动消耗(Kcal/小时)\r\n慢走：255    爬楼梯：480\r\n快走：555    骑自行车：184\r\n慢跑：655    跳有氧运动：25" +
    "2\r\n快跑：700    游泳：1036\r\n跳绳：448";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "每天静息能量消耗计算器";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "1Kg脂肪 ≈ 7700Kcal ≈ 32200 KJ";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(377, 93);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 24;
            this.btnInput.Text = "摄入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbinputKj
            // 
            this.tbinputKj.Location = new System.Drawing.Point(80, 95);
            this.tbinputKj.Name = "tbinputKj";
            this.tbinputKj.Size = new System.Drawing.Size(57, 21);
            this.tbinputKj.TabIndex = 25;
            this.tbinputKj.Text = "500";
            this.tbinputKj.TextChanged += new System.EventHandler(this.BMInputChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "能量转换：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(136, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "KJ =";
            // 
            // lbeKcal
            // 
            this.lbeKcal.AutoSize = true;
            this.lbeKcal.Location = new System.Drawing.Point(166, 98);
            this.lbeKcal.Name = "lbeKcal";
            this.lbeKcal.Size = new System.Drawing.Size(11, 12);
            this.lbeKcal.TabIndex = 28;
            this.lbeKcal.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "Kcal =";
            // 
            // lbeKgFat
            // 
            this.lbeKgFat.AutoSize = true;
            this.lbeKgFat.Location = new System.Drawing.Point(263, 98);
            this.lbeKgFat.Name = "lbeKgFat";
            this.lbeKgFat.Size = new System.Drawing.Size(11, 12);
            this.lbeKgFat.TabIndex = 30;
            this.lbeKgFat.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(312, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 31;
            this.label19.Text = "Kg脂肪";
            // 
            // rtbRecord
            // 
            this.rtbRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecord.Location = new System.Drawing.Point(18, 122);
            this.rtbRecord.Name = "rtbRecord";
            this.rtbRecord.Size = new System.Drawing.Size(335, 293);
            this.rtbRecord.TabIndex = 32;
            this.rtbRecord.Text = "";
            // 
            // lbInputCount
            // 
            this.lbInputCount.AutoSize = true;
            this.lbInputCount.Location = new System.Drawing.Point(375, 245);
            this.lbInputCount.Name = "lbInputCount";
            this.lbInputCount.Size = new System.Drawing.Size(65, 12);
            this.lbInputCount.TabIndex = 33;
            this.lbInputCount.Text = "累计摄入：";
            // 
            // lbSumInput
            // 
            this.lbSumInput.AutoSize = true;
            this.lbSumInput.Location = new System.Drawing.Point(375, 260);
            this.lbSumInput.Name = "lbSumInput";
            this.lbSumInput.Size = new System.Drawing.Size(11, 12);
            this.lbSumInput.TabIndex = 34;
            this.lbSumInput.Text = "-";
            // 
            // btnConsume
            // 
            this.btnConsume.Location = new System.Drawing.Point(458, 93);
            this.btnConsume.Name = "btnConsume";
            this.btnConsume.Size = new System.Drawing.Size(75, 23);
            this.btnConsume.TabIndex = 35;
            this.btnConsume.Text = "消耗";
            this.btnConsume.UseVisualStyleBackColor = true;
            this.btnConsume.Click += new System.EventHandler(this.btnConsume_Click);
            // 
            // lbSumConsume
            // 
            this.lbSumConsume.AutoSize = true;
            this.lbSumConsume.Location = new System.Drawing.Point(375, 300);
            this.lbSumConsume.Name = "lbSumConsume";
            this.lbSumConsume.Size = new System.Drawing.Size(11, 12);
            this.lbSumConsume.TabIndex = 37;
            this.lbSumConsume.Text = "-";
            // 
            // lbConsumeCount
            // 
            this.lbConsumeCount.AutoSize = true;
            this.lbConsumeCount.Location = new System.Drawing.Point(375, 285);
            this.lbConsumeCount.Name = "lbConsumeCount";
            this.lbConsumeCount.Size = new System.Drawing.Size(65, 12);
            this.lbConsumeCount.TabIndex = 36;
            this.lbConsumeCount.Text = "累计消耗：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(485, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "今日脂肪：";
            // 
            // lbfinalFatG
            // 
            this.lbfinalFatG.AutoSize = true;
            this.lbfinalFatG.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbfinalFatG.Location = new System.Drawing.Point(483, 368);
            this.lbfinalFatG.Name = "lbfinalFatG";
            this.lbfinalFatG.Size = new System.Drawing.Size(58, 24);
            this.lbfinalFatG.TabIndex = 40;
            this.lbfinalFatG.Text = "-0 g";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(378, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbfinalFatG);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbSumConsume);
            this.Controls.Add(this.lbConsumeCount);
            this.Controls.Add(this.btnConsume);
            this.Controls.Add(this.lbSumInput);
            this.Controls.Add(this.lbInputCount);
            this.Controls.Add(this.rtbRecord);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbeKgFat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbeKcal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbinputKj);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbfamaleBM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTall);
            this.Controls.Add(this.tbOld);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbmaleBM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "健康管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmaleBM;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOld;
        private System.Windows.Forms.TextBox tbTall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbfamaleBM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbinputKj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbeKcal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbeKgFat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox rtbRecord;
        private System.Windows.Forms.Label lbInputCount;
        private System.Windows.Forms.Label lbSumInput;
        private System.Windows.Forms.Button btnConsume;
        private System.Windows.Forms.Label lbSumConsume;
        private System.Windows.Forms.Label lbConsumeCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbfinalFatG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

