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
using System.Data.SqlClient;

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

        private String sqlcon = "server=103.47.62.133;database=badge;UID=tv;password=2az8wA4LxuQRIIH9";



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
        public bool[] stateFive = new bool[2880];
        public bool[] stateFour = new bool[2880];
        public bool[] stateThree = new bool[2880];
        public bool[] stateTwo = new bool[2880];
        public bool[] stateOne = new bool[2880];
        public bool[] stateZero = new bool[2880];



        public static String keyStrS = "CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC#CcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcCcC⊕";


        public static String encStrS = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCXCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCX";


        public static String dcrStrS = "                                                                `                                               `.````                                    `````   `` `..                              ``..`   ``````   `.~`                          ``.``               ~~.                              .~`              :`                         .....       ```..:~`:~/                            ..     .``.    .:/`/                             .`  `... `:::.```.:`                             ..  .~.   ``..~/o~                                .`..`       .:+`                                 `:./.    `.:+~....                                 `+/~..~:::....~:~                              `::::~```       `::                          `~///.`             ~/                        `~~.```       ..      ~+                        :`  ```       ::     ./:                       `+`  .`        `o.   .:/                        .+   ``        `+`   ./.                       .o~.. `         ::    ./~                      .o/``/:~         +`   `./~                     `+o.`../o` .      +.   .~o`                     .o:``...s: ..     /:  `~//                      `+`..~.:.+. :.   ``/``...::.                    ~/`.../: :/``/   ` /.`````.~:`::/~``            .::...~:::o~`/   ``~:/:~.` `.:+~~/:/.            `~/~~~.:+:`:~  ``.~~os/:~~...~..`.+.              .://so+~...``...:/sss~..~~:///:::`                .o+/+:::::////+o++o+`     `..`                  ///++:::::::::::/:/:~                         `:.:+/~:/~~~~://::/o+~                        .~/.`:/.`~.`````.```:~/:                       `/.. `+/.~::://:::.``.~:+                     `~:..`.:~o:...~+/.```` `.:/.                   .:.~:.`` .o~```.~+`     ``~/~                   /~:/`    :o:``.`:s/`    ``./~                  ~/`/     `++~...~o:+.`  ````/:                   ~::     :o:~.`.+/ ~:``  `.`/:                    `:    `+/:.``:+` `/``` ``~/:                          :+~~```+~   :``` ``~/~                         .+:~```:+    :`.````.+~                        `/:.````+~    /`..````+~                        :+.` ``~o`    +``.`` `/~                       `+:`  ``/+    `+```.`` ::                       .+.`   .+:    `/```~`  ~/`                      /:.``  ~+.    `/`  ..  `/.                      +:`````:+.    `/`  `.`  ::                     `/~`````:+:.`  `/`   ``  ./`                    ./~ ````:/:.:   :~     `  /:                    .o.` ```~+:.`   ~:       `~/.                    ~:.`..~:~`     `/        `:/`                    `~~~.          /.       `.//                                   ::        `/+.                                  ~+`     ``~++++.``~~                            `+.    ``~..~/:`` `:~                           `:~    `~..~:~...~::.                            :+` ``..~:~.~~::~.                              ./+:~~:/+//:~~`                                 `..~~~.``                                                              ";

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

            for (int i = 0; i < stateZero.Length; i++)
            {
                stateZero[i] = true;
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
            DrawText(new string(layerZero), "Courier New", fontSize, FontStyle.Regular, Brushes.Lime, textPosition, 650, 2000); //Encrypted
            //textPosition = new Point(50, 200);
            DrawText(new string(layerOne), "Courier New", fontSize, FontStyle.Regular, Brushes.Red, textPosition, 650, 2000); //Decyrpted - non transition
            //textPosition = new Point(50, 300);
            DrawText(new string(layerTwo), "Courier New", fontSize, FontStyle.Regular, Brushes.OrangeRed, textPosition, 650, 2000); // code + transition forth
            //textPosition = new Point(50, 400);
            DrawText(new string(layerThree), "Courier New", fontSize, FontStyle.Regular, Brushes.Orange, textPosition, 650, 2000); // code + transition third
            //textPosition = new Point(50, 500);
            DrawText(new string(layerFour), "Courier New", fontSize, FontStyle.Regular, Brushes.YellowGreen, textPosition, 650, 2000); // code + transition second
            //textPosition = new Point(50, 600);
            DrawText(new string(layerFive), "Courier New", fontSize, FontStyle.Regular, Brushes.Yellow, textPosition, 650, 2000); // code + transition first
            //textPosition = new Point(50, 700);
            DrawText(new string(layerSix), "Courier New", fontSize, FontStyle.Regular, Brushes.White, textPosition, 650, 2000); //xor 
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

        private void button1_Click(object sender, EventArgs e) //start full
        {
            formState.Maximize(this);
            btnFullScreen.Hide();
            //btnRestore.Hide();
            btnWindow.Hide();
            btnSql.Hide();

            draw = true;

            this.stopProcess = false;

            // Initialise and start worker thread
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperationAsync));
            this.workerThread.Start();

        }

        private void button1_Click_1(object sender, EventArgs e) //restore
        {
            this.stopProcess = true;
            formState.Restore(this);
            btnFullScreen.Show();
            btnRestore.Show();
            btnWindow.Show();
            btnSql.Show();



            draw = true;

        }

        private void button1_Click_2(object sender, EventArgs e) //start windowed
        {
            btnFullScreen.Hide();
            btnRestore.Hide();
            btnWindow.Hide();
            btnSql.Hide();

            draw = true;

            this.stopProcess = false;

            // Initialise and start worker thread
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperationAsync));
            this.workerThread.Start();

        }

        private async void HeavyOperationAsync()
        {
            // Example heavy operation
            while (true)
            {

                Random gen = new Random();
                for (int i = 0; i < badgeFeed.Length; i++)
                {
                    if (gen.NextDouble() < 1.00)
                        if (badgeFeed[i] == true)
                        {
                            badgeFeed[i] = true;
                        }
                        else
                        {
                            badgeFeed[i] = true;
                        }
                    //Console.WriteLine(badgeFeed[i]);      
                }



                // Check if Stop button was clicked
                if (!this.stopProcess)
                {
                    // Show progress

                    for (int i = 0; i < badgeFeed.Length; i++)
                    {
                        // LAYER SIX FOR BRAND NEW CHARACTERS
                        if (badgeFeed[i] == true && stateZero[i] == true)
                        {
                            // Character previously off, now turned on.
                            // TODO: Set stateZero[i] to false
                            // TODO: Set stateSix[i] to true
                            layerSix[i] = 'X';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = '\u00A0';
                            layerZero[i] = '\u00A0';
                        }
                        else if (stateSix[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = keyStr[i];
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = '\u00A0';
                            layerZero[i] = '\u00A0';
                        }
                        else if (stateFive[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = keyStr[i];
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = '\u00A0';
                            layerZero[i] = '\u00A0';
                        }
                        else if (stateFour[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = keyStr[i];
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = '\u00A0';
                            layerZero[i] = '\u00A0';
                        }
                        else if (stateThree[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = keyStr[i];
                            layerOne[i] = '\u00A0';
                            layerZero[i] = '\u00A0';
                        }
                        else if (stateTwo[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = keyStr[i];
                            layerZero[i] = '\u00A0';
                        }
                        // LAYER ONE FOR ALL ENABLED CHARACTERS NOT ELSEWHERE SHOWN
                        else if (stateOne[i] == true && badgeFeed[i] == true)
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = dcrStr[i];
                            layerZero[i] = '\u00A0';
                        }
                        else
                        {
                            layerSix[i] = '\u00A0';
                            layerFive[i] = '\u00A0';
                            layerFour[i] = '\u00A0';
                            layerThree[i] = '\u00A0';
                            layerTwo[i] = '\u00A0';
                            layerOne[i] = '\u00A0';
                            layerZero[i] = encStr[i];
                        }
                    }// All done with display, now we need to catch up all our states
                    for (int i = 0; i < badgeFeed.Length; i++)
                    {
                        if (stateSix[i] == true)
                        {
                            stateSix[i] = false;
                            stateFive[i] = true;
                        }
                        else if (stateFive[i] == true)
                        {
                            stateFive[i] = false;
                            stateFour[i] = true;
                        }
                        else if (stateFour[i] == true)
                        {
                            stateFour[i] = false;
                            stateThree[i] = true;
                        }
                        else if (stateThree[i] == true)
                        {
                            stateThree[i] = false;
                            stateTwo[i] = true;
                        }
                        else if (stateTwo[i] == true)
                        {
                            stateTwo[i] = false;
                            stateOne[i] = true;
                        }
                        else if (badgeFeed[i] == true && stateZero[i] == true)
                        {
                            stateSix[i] = true;
                            stateZero[i] = false;
                        }
                        else if (badgeFeed[i] == false && stateOne[i] == true) // Finished the loop but character turned off
                        {
                            stateOne[i] = false;
                            stateZero[i] = true;
                        }
                    }

                    //this.Invoke(this.updateStatusDelegate);
                    Invalidate();
                    await Task.Delay(200);

                    
                    
                }
                else
                {
                    // Stop heavy operation
                    this.workerThread.Abort();
                }
                //Console.WriteLine("-------------------------");
            }
        }

        private void UpdateStatus()
        {
            
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

        private void sql_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from badges";
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("connected with sql server");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
        }
    }
}
