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

using se.nightri.QC15_TV_Badge;

namespace se.nightri.QC15_TV_Badge
{
    public partial class StartFrame : Form
    {

        protected Graphics graphics;

        FormState formState = new FormState();
        private Thread workerThread = null;
        private bool stopProcess = false;

        // Declare a delegate used to communicate with the UI thread
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;



        public char[] encStr = new Char[2880];
        public char[] dcrStr = new Char[2880];
        public char[] keyStr = new Char[2880];

        public char[] layerZero = new Char[2880];
        public char[] layerOne = new Char[2880];
        public char[] layerTwo = new Char[2880];
        public char[] layerThree = new Char[2880];
        public char[] layerFour = new Char[2880];
        public char[] layerFive = new Char[2880];
        public char[] layerSix = new Char[2880];

        public bool[] badgeFeed = new bool[2880];

        public bool[] stateSix = new bool[2880];



        public static String keyStrS = "CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC⊕";


        public static String encStrS = "XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX#XOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOX⊕";


        public static String dcrStrS = "+++++o+++oooosyyyhhdsohdddds++yyshhddyymmdmddhsysydNmNhdhyssoo++++++++++++oo++syyyyyyyyyy#yssssyhhdddho/sysshsdy+hNhddyshmmmNmmNNNmmmmdmmNmhyo+osohhmmmdhhyysoo+++oooooosyyyyyyyyyy#yhy+/oysohyhy+/yhyhmdNhyNNmNmhymMNNmNNNNNNNNNNNmdmmmdysoo+/sdNNNNmmdddhhyssooosyyyyyyyyyy#hshs//syysdymdysmmhddmmydMNmNNddNmmNNMNNNNNNNNmmddddmmmdddyo/yNNmNNNNNmmmmmmdhhhhhhyhyyyy#hyddhssddhdmdmhsyddymhmhsdhhysooosdMMNmNNNNNNNNmddddddddhdmmhsodNMNNMmNNNNNmmmmmdmdddddhy#hhyhyo+ooooo+o+/++++++++++++oooosmMMNNNNNNNNNNNmdhhhhhdhhdmNNNhohNMMMNMNNMNmNmNmmdhmmdNdy#oo++++/////////////++ooosoooossymMMNNNNNNNNNNmmmhhhhhhhhhhdmdNNhodNNNNMNMMNNNNmNmhymmhmhy#osso++++++++++++/+oosssssssssssdMMNNNNNNNNmmmddhyyyyyyyhhhhmdyyyhhydmNMNMMNNNNmNdsohhsdyy#oossooooo+++++++ossyyyssssssyyyNMNNNNMNNNmdhhdhyyyyyyyyyyyhdddhsydhhyhmNNNNNNNdmho/shodyy#sssssooooooooossyyyysysssyyyhhdNMMMMM#NNmhsshhyyyssssyyyyssyhdho++oossshhddddmdmho/ydymyh#sssssoooooosssyyyyyyyyyyyhhhddmMMMMMMMNdhy++syysyyysssyyysssysso+++++o++//++///////+ooyhy#hhyysssssssyyhhhhhhhhhhdddddddmNMMMMMNmhs+++oosssysssssossyhyoo+++++++o+//:::~~~~~:~::://#dddhhhyhhhhdddddddddddddhyyyyhhmNMMMNdyso+ooossysssssssoooyyso++++++++++++++///::////////#dddddddddmddmdddhyyyhyyyssssossydmmmdhyssooooosoooooosoo+oyoooooo++++++o+++++++/////++///#++oosssssyyyyyysssssssyhhhhhhhhsshdddhhyssssoo++ooooooo+++ooooooooooooosoooooooooooo+////#~~~::/:://oosyddhdhhhhssydhhysyy++ddddhyyyyhhhyysssooooooooooossssssssysssssoooosso//////#+://///:/:~~~:+yhyhssys/+yhyhsyyyoyddddddmmmmdhhyssooooooossssssssssssysssssssssosso+/+++#yo/:~..~.....~::shhhyyhssymdmdhddysossymdyyyhddhyysssssssyyysshdhyyyyyyyyyyyyso+oyhysoo++#yyssoo+/::~.~/:~:ddNdmmddmNmNmmho+osydmNdsssshdhhyyssssyyyyssyddddhhhhhyyhyyso++oyhyyssoo#hyysssssssooo+::+ymNdmmddmNdmys++oshdmmNNhooooyhhyyysssssssyymmmmdddhhdhhhyssoooossyyyyss#hhhhyyyssysssossoshyyhhyhhyssyyyyhddmmmNNmhsyddhhyyssyyyyyyyhmmmmNmmdddhhhyyyysssssssyyys#hhhhhyyyyyyssssssyyyssssssssssyhhddmmmmNNNNNNNNmdysoshhmmdhhddddmmmNmmdhhhhyyyyssyssssyys#hhhhhhhhhhyyyyyyyyyysssssssyysssyhhhdmmNMNNmmmmdysoshmmNmmdhddhhdmNmmmdhhhhhhhhyyyssoooss#hhhhhhhhhhhyyhhhyyyyyyyyssssyysssyyhdddmNNNdhddhyyyhmmmmmdddhdhhhdNmmmdhhhdhddhhhhyysoooo#hhhhhhhhhhyyyyyyyyyyyyyyyyyyyyyssssyddmdddhyyhhhhddmmmmmmmddddddddmNNmddddddddhhhhyyyssso#hhhhhhhhhyyyyyyyyyyssyyyyyyyyyysssyhddmmddhyyyhdmNmmmmmmmmmmmmdhddmNNmmddddhdhhhhhhyyysss#hhhhhhhhyyyyysyyyssssyyyyyyyyysssssyyyyhhddhyyhdmNNmmmmmmmmmmmmdddmNNmmmmddhhhhhyhyyssoss#hhhhhhhhhyysssyyyyyyyyyyyysssssssssssssssyyyyhhyyhmNNmmmmmmmmmmmdhmNNNmmmddhhhhyyysssssso#hhhhhhhhhyyysyyyyyyyssssssssosssssssoooosssyyhhhyyhNMNNmmmmmmmmdmhdNNNmmmdddhhyyyysssssoo#hhhhhhhyyyyyyyyyhhhyssssssooooooooooosoossssyyhdhhhmMMNNNNmmNNNdmhdNMNNmmmdddhhhyyysssoos#hhhhhhhyyyyyyyyyhhhyssssssooooooooooosoossssyyhdhhhmMMNNNNmmNNNdmhdNMNNmmmdddhhhyyysssoos#hhhhhhhyyyyyyyyyhhhyssssssooooooooooosoossssyyhdhhhmMMNNNNmmNNNdmhdNMNNmmmdddhhhyyysssoos⊕";

        public bool draw = false;

        public String tmp = "";

        public StartFrame()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            //init arrays


            encStr = encStrS.ToCharArray();
            dcrStr = dcrStrS.ToCharArray();
            keyStr = keyStrS.ToCharArray();

            Random gen = new Random();

            for (int i = 0; i < badgeFeed.Length; i++)
            {
                badgeFeed[i] = (gen.NextDouble() < 0.2); //20% random
            }


            //baseEncLayer.Text = encStrS;

            // Initialise the delegate
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.
            this.graphics = e.Graphics;

            // Set the best settings possible (quality-wise)
            this.graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (draw)
            {
                OnDraw();
            }

        }

        private void OnDraw()
        {
            float fontSize = 16f;
            Point textPosition = new Point(50, 100);
            DrawText(new string(layerZero), "Courier New", fontSize, FontStyle.Regular, Brushes.Lime, textPosition, 1200, 1000); //Encrypted
            DrawText(new string(layerOne), "Courier New", fontSize, FontStyle.Regular, Brushes.Red, textPosition, 1200, 1000); //Decyrpted - non transition
            DrawText(new string(layerTwo), "Courier New", fontSize, FontStyle.Regular, Brushes.OrangeRed, textPosition, 1200, 1000); // code + transition forth
            DrawText(new string(layerThree), "Courier New", fontSize, FontStyle.Regular, Brushes.Orange, textPosition, 1200, 1000); // code + transition third
            DrawText(new string(layerFour), "Courier New", fontSize, FontStyle.Regular, Brushes.YellowGreen, textPosition, 1200, 1000); // code + transition second
            DrawText(new string(layerFive), "Courier New", fontSize, FontStyle.Regular, Brushes.Yellow, textPosition, 1200, 1000); // code + transition first
            DrawText(new string(layerSix), "Courier New", fontSize, FontStyle.Regular, Brushes.AliceBlue, textPosition, 1200, 1000); //xor 
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT 

                return cp;
            }
        }

        //protected override void OnPaintBackground(PaintEventArgs pevent)
        //{
            // Don't paint background
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formState.Maximize(this);
            btnFullScreen.Hide();
            btnRestore.Hide();
            
            draw = true;

            this.stopProcess = false;

            // Initialise and start worker thread
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperation));
            this.workerThread.Start();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.stopProcess = true;
            formState.Restore(this);
            btnFullScreen.Show();
            btnRestore.Show();

            

            draw = true;

        }

        private void HeavyOperation()
        {
            // Example heavy operation
            while(true)
            {
                // Check if Stop button was clicked
                if (!this.stopProcess)
                {
                    // Show progress

                    for(int i = 0; i < layerZero.Length; i++)
                    {
                        layerZero[i] = encStr[i];
                    }


                    Thread.Sleep(1000);
                    //this.Invoke(this.updateStatusDelegate);
                    Invalidate();
                }
                else
                {
                    // Stop heavy operation
                    this.workerThread.Abort();
                }
            }
        }

        private void UpdateStatus()
        {
            //one += "*";
        }



        protected void DrawText(string text, string fontFamily, float fontSize
            , FontStyle style, Brush color, Point position)
        {
            Font font = new Font(fontFamily, fontSize, style);
            SizeF textSizeF = graphics.MeasureString(text, font);
            int width = (int)Math.Ceiling(textSizeF.Width);
            int height = (int)Math.Ceiling(textSizeF.Height);
            Size textSize = new Size(width, height);
            Rectangle rectangle = new Rectangle(position, textSize);


            DrawText(this.graphics, text, color, rectangle, font);
        }

        protected void DrawText(string text, string fontFamily, float fontSize
            , FontStyle style, Brush color, Point position, int width, int height)
        {
            Font font = new Font(fontFamily, fontSize, style);
            SizeF textSizeF = graphics.MeasureString(text, font);
            //int width = (int)Math.Ceiling(textSizeF.Width);
            //int height = (int)Math.Ceiling(textSizeF.Height);
            Size textSize = new Size(width, height);
            Rectangle rectangle = new Rectangle(position, textSize);


            DrawText(this.graphics, text, color, rectangle, font);
        }

        static public void DrawText(Graphics graphics, string text, Brush color, Rectangle rectangle, Font font)
        {
            graphics.DrawString(text, font, color, rectangle);
        }



    }
}
