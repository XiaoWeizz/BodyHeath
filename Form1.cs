using System;
using System.Threading;
using System.Windows.Forms;

namespace BodyHeath
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private bool needCalculate = true;
        private double sumInputKj = 0;
        private double sumconsumeKj = 0;
        private int inputCount = 0;
        private int consumeCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleCalculate()
        {
            while (true)
            {
                if(needCalculate)
                {
                    double maleBM = 0;
                    double famaleBM = 0;
                    double inputKj = 0;
                    double eKcal = 0;
                    double eKgFat = 0;

                    double weight, tall, old;
                    weight = TryConvert(tbWeight.Text);
                    tall = TryConvert(tbTall.Text);
                    old = TryConvert(tbOld.Text);
                    inputKj = TryConvert(tbinputKj.Text);

                    maleBM = 66 + 13.7 * weight + 5.0 * tall - 6.8 * old;
                    famaleBM = 655 + 9.5 * weight + 1.8 * tall - 4.7 * old;
                    eKcal = inputKj / 4.184;
                    eKgFat = eKcal / 7700;

                    this.Invoke(new EventHandler(delegate
                    {
                        lbmaleBM.Text = string.Format($"{maleBM}");
                        lbfamaleBM.Text = string.Format($"{famaleBM}");
                        lbeKcal.Text = string.Format("{0:F3}", eKcal);
                        lbeKgFat.Text = string.Format("{0:F6}", eKgFat);
                    }));
                    
                    needCalculate = false;
                }
                Thread.Sleep(1000);
            }
        }

        private void BMInputChanged(object sender, EventArgs e)
        {
            needCalculate = true;
        }

        private double TryConvert(string numStr)
        {
            double dResult = 0;
            try
            {
                dResult = Convert.ToDouble(numStr);
            }
            catch (Exception)
            {
            }
            return dResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置窗体的边框样式为固定单线边框，用户无法调整大小
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // 设置滚动显示窗口最大条目数
            rtbRecord.MaxLength = 30;
            pictureBox1.Image = Resource1.happy1;

            thread = new Thread(new ThreadStart(HandleCalculate));
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            // 计算当前转换值
            double inputKj = TryConvert(tbinputKj.Text);
            double eKcal = inputKj / 4.184;
            double eKgFat = eKcal / 7700;
            string record = string.Format($"时间:{DateTime.Now}:\r\n");
            record += string.Format("摄入{0:F3}KJ≈{1:F6}Kcal≈{2:F9}Kg脂肪\r\n", inputKj, eKcal, eKgFat);
            rtbRecord.AppendText(record);
            rtbRecord.ScrollToCaret();

            inputCount++;
            sumInputKj += inputKj;
            eKcal = sumInputKj / 4.184;
            eKgFat = eKcal / 7700;
            lbInputCount.Text = string.Format($"累计摄入({inputCount}次)：");
            lbSumInput.Text = string.Format("{0:F1}KJ≈{1:F2}Kcal≈{2:F4}Kg脂肪\r\n", sumInputKj, eKcal, eKgFat);

            CalculateSum();
        }

        private void btnConsume_Click(object sender, EventArgs e)
        {
            // 计算当前转换值
            double consumeKj = TryConvert(tbinputKj.Text);
            double eKcal = consumeKj / 4.184;
            double eKgFat = eKcal / 7700;
            string record = string.Format($"时间:{DateTime.Now}:\r\n");
            record += string.Format("消耗{0:F3}KJ≈{1:F6}Kcal≈{2:F9}Kg脂肪\r\n", consumeKj, eKcal, eKgFat);
            rtbRecord.AppendText(record);
            rtbRecord.ScrollToCaret();

            consumeCount++;
            sumconsumeKj += consumeKj;
            eKcal = sumInputKj / 4.184;
            eKgFat = eKcal / 7700;
            lbConsumeCount.Text = string.Format($"累计消耗({consumeCount}次)：");
            lbSumConsume.Text = string.Format("{0:F1}KJ≈{1:F2}Kcal≈{2:F4}Kg脂肪\r\n", sumconsumeKj, eKcal, eKgFat);

            CalculateSum();
        }

        /// <summary>
        /// 计算能量平衡值
        /// </summary>
        private void CalculateSum()
        {
            double diffKj = sumInputKj - sumconsumeKj;
            double eKcal = diffKj / 4.184;
            double eKgFat = eKcal / 7700;
            
            if(diffKj > 0)
            {
                pictureBox1.Image = Resource1.sad1;
                lbfinalFatG.Text = string.Format("+{0:F1} g", 1000 * eKgFat);
            }
            else
            {
                pictureBox1.Image = Resource1.happy1;
                lbfinalFatG.Text = string.Format("{0:F1} g", 1000 * eKgFat);
            }
        }
    }
}
