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
                OnDraw(tmp,null,null,null,null,null,null);
            }

        }

        private void OnDraw(String layerZero, String layerOne, String layerTwo, String layerThree, String layerFour, String layerFive, String layerSix)
        {
            // Gets the image from the global resources
            //Image broculoImage = global::WindowsApplication1.Properties.Resources.broculo;

            // Sets the images' sizes and positions
            //int width = broculoImage.Size.Width;
            //int height = broculoImage.Size.Height;
            //Rectangle big = new Rectangle(0, 0, width, height);
            //Rectangle small = new Rectangle(50, 50, (int)(0.75 * width), (int)(0.75 * height));

            // Draws the two images
            //this.graphics.DrawImage(broculoImage, big);
            //this.graphics.DrawImage(broculoImage, small);

            // Sets the text's font and style and draws it
            float fontSize = 16f;
            Point textPosition = new Point(50, 100);
            DrawText(layerZero, "Courier New", fontSize, FontStyle.Regular, Brushes.Lime, textPosition, 1200, 1000); //Encrypted
            DrawText(layerOne, "Courier New", fontSize, FontStyle.Regular, Brushes.Red, textPosition, 1200, 1000); //Decyrpted - non transition
            DrawText(layerTwo, "Courier New", fontSize, FontStyle.Regular, Brushes.OrangeRed, textPosition, 1200, 1000); // code + transition forth
            DrawText(layerThree, "Courier New", fontSize, FontStyle.Regular, Brushes.Orange, textPosition, 1200, 1000); // code + transition third
            DrawText(layerFour, "Courier New", fontSize, FontStyle.Regular, Brushes.YellowGreen, textPosition, 1200, 1000); // code + transition second
            DrawText(layerFive, "Courier New", fontSize, FontStyle.Regular, Brushes.Yellow, textPosition, 1200, 1000); // code + transition first
            DrawText(layerSix, "Courier New", fontSize, FontStyle.Regular, Brushes.AliceBlue, textPosition, 1200, 1000); //xor 
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
            for (int i = 0; i <=3; i++)
            {
                // Check if Stop button was clicked
                if (!this.stopProcess)
                {
                    // Show progress
                    if(i == 3)
                    {
                        tmp = dcrStrS + i;
                        i = 0;
                    } else
                    if(i == 2)
                    {
                        tmp = keyStrS + i;
                    } else
                    if (i == 1)
                    {
                        tmp = encStrS + i;
                    }
                    else
                    {
                        tmp = i.ToString();
                    }

                    Thread.Sleep(2000);
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
