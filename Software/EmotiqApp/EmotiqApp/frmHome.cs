using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace EmotiqApp
{
    public partial class frmHome : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        Quote CurrentQuote = new Quote();
        Tip CurrentTip = new Tip();
        CalculateEmotion CalculateEmotion = new CalculateEmotion();

        private string lastEmotion;
        private string tip;
        private string quote;

        public frmHome()
        {
            InitializeComponent();

            myTimer.Tick += new EventHandler( TimeUp );
            myTimer.Interval = 10000;
            myTimer.Start();

            lastEmotion = CalculateEmotion.CalculationLastEmotion();

            tip = CurrentTip.SelectTip(lastEmotion);
            quote = CurrentQuote.SelectQuote(lastEmotion);

            LBemotion.Text = lastEmotion;
            LBtip.Text = "Tip: " + tip;
            LBquote.Text = "Quote: " + quote;
        }

        public void TimeUp(object source, EventArgs e)
        {
            lastEmotion = CalculateEmotion.CalculationLastEmotion();

            tip = CurrentTip.SelectTip(lastEmotion);
            quote = CurrentQuote.SelectQuote(lastEmotion);

            LBemotion.Text = lastEmotion;
            LBtip.Text = "Tip: " + tip;
            LBquote.Text = "Quote: " + quote;
        }
    }
}
