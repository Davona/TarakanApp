using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarakanApp
{
    public partial class TarakanForm : Form
    {
        public TarakanForm()
        {
            InitializeComponent();

        }
        Random random = new Random();
        Thread threadTarakan;
        Thread threadTarakan1;
        Thread threadTarakan2;

        Point tarakanpoint;
        Point tarakan1point;
        Point tarakan2point;

        private void startbutton_Click(object sender, EventArgs e)
        {
            tarakanpoint = new Point(tarakan.Location.X, tarakan.Location.Y);
            tarakan1point = new Point(tarakan1.Location.X, tarakan1.Location.Y);
            tarakan2point = new Point(tarakan2.Location.X, tarakan2.Location.Y);
            threadTarakan = new Thread(TarakanMove);
            threadTarakan.Start();
            threadTarakan1 = new Thread(Tarakan1Move);
            threadTarakan1.Start();
            threadTarakan2 = new Thread(Tarakan2Move);
            threadTarakan2.Start();
        }
        private void TarakanMove()
        {
            while (tarakan.Location.X <= pictureBox1.Location.X - tarakan.Width + 1)
            {
                Thread.Sleep(random.Next(10, 50));

                this.Invoke((MethodInvoker)delegate
                {
                    tarakan.Location = new Point(tarakan.Location.X + random.Next(1, 5), tarakan.Location.Y);
                });
            }
           TarakanFinish();
        }
        private void Tarakan1Move()
        {
            while (tarakan1.Location.X <= pictureBox1.Location.X - tarakan1.Width + 1)
            {
                Thread.Sleep(random.Next(10, 50));
                this.Invoke((MethodInvoker)delegate
                {
                    tarakan1.Location = new Point(tarakan1.Location.X + random.Next(1, 5), tarakan1.Location.Y);
                });
            }
            Tarakan1Finish();
        }

        private void Tarakan2Move()
        {
            while (tarakan2.Location.X <= pictureBox1.Location.X - tarakan2.Width + 1)
            {
                Thread.Sleep(random.Next(10, 50));
                this.Invoke((MethodInvoker)delegate
                {
                    tarakan2.Location = new Point(tarakan2.Location.X + random.Next(1, 5), tarakan2.Location.Y);
                });
            }
            Tarakan2Finish();
        }

        private void TarakanFinish()
        {

            this.Invoke((MethodInvoker)delegate
            {
                tarakan.Location = tarakanpoint;
            });
            threadTarakan1.Abort();
            threadTarakan2.Abort();
            this.Invoke((MethodInvoker)delegate
            {
                tarakan1.Location = tarakan1point;
                tarakan2.Location = tarakan2point;
            });
            MessageBox.Show($"{tarakan.Name} win");
        }
        private void Tarakan1Finish()
        {

            this.Invoke((MethodInvoker)delegate
            {
                tarakan1.Location = tarakan1point;
            });
            threadTarakan.Abort();
            threadTarakan2.Abort();
            this.Invoke((MethodInvoker)delegate
            {
                tarakan.Location = tarakanpoint;
                tarakan2.Location = tarakan2point;
            });
            MessageBox.Show($"{tarakan1.Name} win");
        }
        private void Tarakan2Finish()
        {

            this.Invoke((MethodInvoker)delegate
            {
                tarakan2.Location = tarakan2point;
            });
            threadTarakan.Abort();
            threadTarakan1.Abort();
            this.Invoke((MethodInvoker)delegate
            {
                tarakan.Location = tarakanpoint;
                tarakan1.Location = tarakan1point;
            });
            MessageBox.Show($"{tarakan2.Name} win");
        }
    }
}
