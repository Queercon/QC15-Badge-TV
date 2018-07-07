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


        public StartFrame()
        {
            InitializeComponent();

            //init arrays


            encStr = encStrS.ToCharArray();
            dcrStr = dcrStrS.ToCharArray();
            keyStr = keyStrS.ToCharArray();

            displayFile.Text = encStrS;

            // Initialise the delegate
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // headingCenter.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formState.Maximize(this);
            btnFullScreen.Hide();
            btnRestore.Hide();
            //headingCenter.Show();


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
            //headingCenter.Hide();

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
            this.displayFile.Text += "*";
        }


    }
}
