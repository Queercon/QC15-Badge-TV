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


        public static char[] encStr = new Char[2880];
        public static char[] dcrStr = new Char[2880];
        public static char[] keyStr = new Char[2880];


        public static String keyStrS = "cUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUccUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUcUc";


        public static String encStrS = "NOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXONXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXNOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXOXON";


        public static String dcrStrS = "+++++o+++oooosyyyhhdsohdddds++yyshhddyymmdmddhsysydNmNhdhyssoo++++++++++++oo++syyyyyyyyyyyyssssyhhdddho/sysshsdy+hNhddyshmmmNmmNNNmmmmdmmNmhyo+osohhmmmdhhyysoo+++oooooosyyyyyyyyyyyyhy+/oysohyhy+/yhyhmdNhyNNmNmhymMNNmNNNNNNNNNNNmdmmmdysoo+/sdNNNNmmdddhhyssooosyyyyyyyyyyyhshs//syysdymdysmmhddmmydMNmNNddNmmNNMNNNNNNNNmmddddmmmdddyo/yNNmNNNNNmmmmmmdhhhhhhyhyyyyyhyddhssddhdmdmhsyddymhmhsdhhysooosdMMNmNNNNNNNNmddddddddhdmmhsodNMNNMmNNNNNmmmmmdmdddddhyyhhyhyo+ooooo+o+/++++++++++++oooosmMMNNNNNNNNNNNmdhhhhhdhhdmNNNhohNMMMNMNNMNmNmNmmdhmmdNdyyoo++++/////////////++ooosoooossymMMNNNNNNNNNNmmmhhhhhhhhhhdmdNNhodNNNNMNMMNNNNmNmhymmhmhyyosso++++++++++++/+oosssssssssssdMMNNNNNNNNmmmddhyyyyyyyhhhhmdyyyhhydmNMNMMNNNNmNdsohhsdyyyoossooooo+++++++ossyyyssssssyyyNMNNNNMNNNmdhhdhyyyyyyyyyyyhdddhsydhhyhmNNNNNNNdmho/shodyyysssssooooooooossyyyysysssyyyhhdNMMMMMMNNmhsshhyyyssssyyyyssyhdho++oossshhddddmdmho/ydymyhysssssoooooosssyyyyyyyyyyyhhhddmMMMMMMMNdhy++syysyyysssyyysssysso+++++o++//++///////+ooyhyyhhyysssssssyyhhhhhhhhhhdddddddmNMMMMMNmhs+++oosssysssssossyhyoo+++++++o+//:::-----:-::://+dddhhhyhhhhdddddddddddddhyyyyhhmNMMMNdyso+ooossysssssssoooyyso++++++++++++++///:://///////dddddddddmddmdddhyyyhyyyssssossydmmmdhyssooooosoooooosoo+oyoooooo++++++o+++++++/////++////++oosssssyyyyyysssssssyhhhhhhhhsshdddhhyssssoo++ooooooo+++ooooooooooooosoooooooooooo+/////---::/:://oosyddhdhhhhssydhhysyy++ddddhyyyyhhhyysssooooooooooossssssssysssssoooosso///////+://///:/:---:+yhyhssys/+yhyhsyyyoyddddddmmmmdhhyssooooooossssssssssssysssssssssosso+/++++yo/:-..-.....-::shhhyyhssymdmdhddysossymdyyyhddhyysssssssyyysshdhyyyyyyyyyyyyso+oyhysoo+++yyssoo+/::-.-/:-:ddNdmmddmNmNmmho+osydmNdsssshdhhyyssssyyyyssyddddhhhhhyyhyyso++oyhyyssoo+hyysssssssooo+::+ymNdmmddmNdmys++oshdmmNNhooooyhhyyysssssssyymmmmdddhhdhhhyssoooossyyyyssohhhhyyyssysssossoshyyhhyhhyssyyyyhddmmmNNmhsyddhhyyssyyyyyyyhmmmmNmmdddhhhyyyysssssssyyysshhhhhyyyyyyssssssyyyssssssssssyhhddmmmmNNNNNNNNmdysoshhmmdhhddddmmmNmmdhhhhyyyyssyssssyysshhhhhhhhhhyyyyyyyyyysssssssyysssyhhhdmmNMNNmmmmdysoshmmNmmdhddhhdmNmmmdhhhhhhhhyyyssooossshhhhhhhhhhhyyhhhyyyyyyyyssssyysssyyhdddmNNNdhddhyyyhmmmmmdddhdhhhdNmmmdhhhdhddhhhhyysooooohhhhhhhhhhyyyyyyyyyyyyyyyyyyyyyssssyddmdddhyyhhhhddmmmmmmmddddddddmNNmddddddddhhhhyyysssoohhhhhhhhhyyyyyyyyyyssyyyyyyyyyysssyhddmmddhyyyhdmNmmmmmmmmmmmmdhddmNNmmddddhdhhhhhhyyysssohhhhhhhhyyyyysyyyssssyyyyyyyyysssssyyyyhhddhyyhdmNNmmmmmmmmmmmmdddmNNmmmmddhhhhhyhyyssossshhhhhhhhhyysssyyyyyyyyyyyysssssssssssssssyyyyhhyyhmNNmmmmmmmmmmmdhmNNNmmmddhhhhyyyssssssoohhhhhhhhhyyysyyyyyyyssssssssosssssssoooosssyyhhhyyhNMNNmmmmmmmmdmhdNNNmmmdddhhyyyysssssooohhhhhhhyyyyyyyyyhhhyssssssooooooooooosoossssyyhdhhhmMMNNNNmmNNNdmhdNMNNmmmdddhhhyyysssooss";

        public static String one = "X X X X X";
        public static String two = " 0 0 0 0 0";
        public bool draw = false;

        public StartFrame()
        {
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
                OnDraw(one, two);
            }
            
        }

        private void OnDraw(String one, String two)
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
            DrawText("X X X X X X", "Courier New", fontSize, FontStyle.Regular, Brushes.Lime, textPosition);
            DrawText(" 0 0 0 0 0 0", "Courier New", fontSize, FontStyle.Regular, Brushes.Lime, textPosition);
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

            OnDraw(one, two);

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

        }

        private void HeavyOperation()
        {
            // Example heavy operation
            for (int i = 0; i <= 999999; i++)
            {
                // Check if Stop button was clicked
                if (!this.stopProcess)
                {
                    // Show progress
                    this.Invoke(this.updateStatusDelegate);
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
            //this.baseDecLayer.Text += "*";
        }


        #region DrawText helper functions

        protected void DrawText(string text, Point position)
        {
            DrawingArea.DrawText(this.graphics, text, "Microsoft Sans Serif", 8.25f
                , FontStyle.Regular, Brushes.Black, position);
        }

        protected void DrawText(string text, Brush color, Point position)
        {
            DrawingArea.DrawText(this.graphics, text, "Microsoft Sans Serif", 8.25f
                , FontStyle.Regular, color, position);
        }

        protected void DrawText(string text, FontStyle style, Point position)
        {
            DrawingArea.DrawText(this.graphics, text, "Microsoft Sans Serif", 8.25f
                , style, Brushes.Black, position);
        }

        protected void DrawText(string text, FontStyle style, Brush color, Point position)
        {
            DrawingArea.DrawText(this.graphics, text, "Microsoft Sans Serif", 8.25f
                , style, color, position);
        }

        protected void DrawText(string text, float fontSize, FontStyle style, Brush color
            , Point position)
        {
            DrawingArea.DrawText(this.graphics, text, "Microsoft Sans Serif", fontSize
                , style, color, position);
        }

        protected void DrawText(string text, string fontFamily, float fontSize
            , FontStyle style, Brush color, Point position)
        {
            DrawingArea.DrawText(this.graphics, text, fontFamily, fontSize, style, color, position);
        }

        static public void DrawText(Graphics graphics, string text, string fontFamily
            , float fontSize, FontStyle style, Brush color, Point position)
        {
            Font font = new Font(fontFamily, fontSize, style);

            SizeF textSizeF = graphics.MeasureString(text, font);
            int width = (int)Math.Ceiling(textSizeF.Width);
            int height = (int)Math.Ceiling(textSizeF.Height);
            Size textSize = new Size(width, height);
            Rectangle rectangle = new Rectangle(position, textSize);

            graphics.DrawString(text, font, color, rectangle);
        }

        #endregion

    }
}
