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
        DBemotion CurrentEmotion = new DBemotion();
        DBtipsquotes CurrentTipQuote = new DBtipsquotes();
        private string lastEmotion;
        private string tip;
        private string quote;

        //
        CalculateEmotion kaas = new CalculateEmotion();
        //

        public frmHome()
        {
            InitializeComponent();

            myTimer.Tick += new EventHandler( TimeUp );
            myTimer.Interval = 5000;
            myTimer.Start();

            lastEmotion = CurrentEmotion.SelectLastEmotion();
            tip = CurrentTipQuote.SelectTip(lastEmotion);
            quote = CurrentTipQuote.SelectQuote(lastEmotion);

            LBemotion.Text = lastEmotion;
            LBtip.Text = "Tip: " + tip;
            LBquote.Text = "Quote: " + quote;

            //
            kaas.CalculationLastEmotion();
            //
        }

        public void TimeUp(object source, EventArgs e)
        {
            lastEmotion = CurrentEmotion.SelectLastEmotion();
            tip = CurrentTipQuote.SelectTip(lastEmotion);
            quote = CurrentTipQuote.SelectQuote(lastEmotion);

            LBemotion.Text = lastEmotion;
            LBtip.Text = "Tip: " + tip;
            LBquote.Text = "Quote: " + quote;

            Console.WriteLine(lastEmotion);
            Console.WriteLine(tip);
            Console.WriteLine(quote);

            //
            kaas.CalculationLastEmotion();
            //
        }
    }
}
