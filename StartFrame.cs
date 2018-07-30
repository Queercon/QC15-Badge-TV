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
using System.IO.Ports;

using se.nightri.QC15_TV_Badge;


namespace se.nightri.QC15_TV_Badge
{
    public partial class StartFrame : Form
    {



        protected Graphics graphics;

        FormState formState = new FormState();
        private Thread workerThread = null;
        private bool stopProcess = false;

        private bool demoMode = false;

        // Declare a delegate used to communicate with the UI thread
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;

        private String sqlcon = "server=103.47.62.133;database=badge;UID=tv;password=2az8wA4LxuQRIIH9";

        public char[] encStr = new Char[7680];
        public char[] dcrStr = new Char[7680];

        public char[] layerZero = new Char[7680];
        public char[] layerOne = new Char[7680];
        public char[] layerTwo = new Char[7680];
        public char[] layerThree = new Char[7680];
        public char[] layerFour = new Char[7680];
        public char[] layerFive = new Char[7680];
        public char[] layerSix = new Char[7680];

        public bool[] badgeFeed = new bool[7680];

        public bool[] stateSix = new bool[7680];
        public bool[] stateFive = new bool[7680];
        public bool[] stateFour = new bool[7680];
        public bool[] stateThree = new bool[7680];
        public bool[] stateTwo = new bool[7680];
        public bool[] stateOne = new bool[7680];
        public bool[] stateZero = new bool[7680];

        public float percentDecrypted = 0;



        public static String encStrS = "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";


        public static String dcrStrS = "sssys+/++//:~~~~:++~::~/+~~:/:::/+++//://+/://:/::+::/+o++/+++++///sssooosssssoysyysyyyhhyhhhyhhhddddddmmmmmmNNNNNNNNNNNsoss+/+//::~://:://~::~~::.\u00A0'~/o+++//+/::/::/:/+//+o/+ssoo++///+ooyoosooooososysyysyyyssssssssssyhhhdddddhhhhhhhhdNNNNNNsooo+o+/s+~:~::://:~~:~~::::~:~.......:+//:/::o....s/+o+.../+/:/:/o...........soosssoo...........shddddms.........~+dNNNssoo+o++/::~~::////::~/~~~:/:...~~~:....+/::::o....o:/++...//:/://+...~+//////sooooooo....+++++++yhhhhhdo....sss:...:NNNoso+o+++///+/.'''\u00A0'''.....~o..../\u00A0\u00A0'/...~o:::~o....o~:/+...//:/://+...~//////so++o+ooo....++++++yhhhhyhdo....yyy/....mNNoooos/:~''\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/..../\u00A0\u00A0\u00A0+...~s:~~~o....+~~:+...//~~:::+..........o/++++ooo..........sdhhhhhhs..........~yNNN+oooo+//:~.'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/..../..~:...::+:~~+~...////:...+:~~:::+...~so+oooo+/+++++o...~ssossyhhhhhhhho....os~...oNNNNoo++o++/://:~~'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'/~.........~/\u00A0'o~~~+~...~~....:+~~~:~:+....~~~~~~~+/+//+/o....~~~~~~~+hhhhhho....mmy....smmmooooo+/:::~~:~/:~'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.~~~~~:.../.\u00A0\u00A0~o~~~//:::::::/:~:~~~~~+:::::::::::o/+++//o:::::::////ohhhyhhy////mmds////dmNoo++////:~:::+:.'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'''..:~~~:\u00A0'\u00A0++~~::::~~~~~.~~~~.~~~~:::~:/:::////+////+//+oossyyyyyyyyhhhhdddddmmmdmdddmm//:://::~~.''''\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:.....~://~'\u00A0'+~:o:~~:~~::::~~~~~~~.~.~..~~::://~:/://::/:/+/+ssyhyhyyyyyhhhhhdddddddddddmmm+/::::~:::::.'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'''./\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.:+::+':y:~~~~:~~~~:::~~~~~~:::://///////:::::::/+++++++ooyyyyyyhhhyooshhddhsssdmmm+//::::~:~~:~/~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.:'''.\u00A0'''\u00A0\u00A0\u00A0\u00A0\u00A0':o:\u00A0'o~~~~~~~~~~.~...~~~~:+/~.......~:+:::~:/o:~.......~/yyyyhhh+...:hdd+...ymmm///:::~~~~~~~::'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0'/\u00A0\u00A0\u00A0\u00A0.//:/~'\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0'+~~~~~~~~~~~~.~~~~~~//...~///:~~~:o:::/+:...:ooo:.../hyyyyy+....~smo...ydmm///:~~~~......~:'\u00A0\u00A0\u00A0\u00A0':.'.~\u00A0\u00A0\u00A0'\u00A0.~:..::.''./+s/:~~~.~~~~~~~~~~~~~+....+~~~/////+//++y....ooooo....hysysh+......+/...ydmm:/:~~~~~~~~.....:.\u00A0\u00A0\u00A0\u00A0~\u00A0~.~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0''.'~/oso/:~~~~~~~.~~~~~~~~~~o....+~~~:://::://:s....ooooo....hyysyy+.../~......ymmm:::~~~::~~~......~~'\u00A0\u00A0:\u00A0.:'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'./o:~.~..~~~~~~~~~~~~~~/:...:/:/:~~~:+:++:+:...:soo:...:yyyhhh+...hh:.....yddm~~~:~~::~~~........~~'..'\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~//s/~....~~~.~~~~~~~~~~~~/:~...~...~:+:://::o:....~...~:sosyyyh+...ydh+....yddm~::~:~~..~....~......~::.:~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~~.~:+o..~~.~~~~~~~~~~~~~~:~~~/////://///::/::/:/++//////+oo+ossssss+++hdhds++ohddm~~:~~~...............:/:~/o/'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''~:+:::////++~~~:~~~.~~~~~~~~://::::::::/:~~/:///+//+/+++++soossyyyhhhhhdhhhhhddm~:~~~............''......~:s+/:.''\u00A0\u00A0'.~:://:~~~~~~~:+o:~~~~~~~~~~~~~:://::/:::/::://///+//o++++++oyssssysyhhhhhhhhyyhddd~~~~~~......'...'.........~/::/:.~:/:~~~''\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:o+~.~....~~~~://:::::+//::~:///o:::oo++o///ssysysyo++/+//+osyyhhdd~~~~~......''''....'.....~++.'//:~.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'.s/...~....~~~+......~o::~~/+/++...~o++o...osssssy/....~~...~/hhdd~~.........~..........~:++s:...'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s/.~~~...~~~/:...o...//~~:/++/+...../oo...ossssoy/.../yys:...+ddd~~......''...~......:/oo:+~.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0's/.~~......~+...+:/...o:~////++......:/...ossossy/...ohhho...~mmd.~.......''.......:++:.'.'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'o+.~.......+~.../:/...~o~~:///+...+:......ossosss/...odhho...~ddd......'....''..~//~'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.so..~.....~/...........+:~/::/+...oo/.....oooosss/.../oo+~...oddd...........'''./:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0o/'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'':y+.~~...~~+...~/::/+~..~o/:/:/+...o+oo~...ooossyy/.........:odddd~~~~.......'''~+'\u00A0\u00A0\u00A0\u00A0\u00A0'.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~s:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'.ss~.~~...../:::/~~~~~/://+~:~:/o///o+oos+++s+ooosysooooossyhdddhdd~.~~~.....~...://\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0+y~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''/s:~~......~...~~~~~::~::~~::://+//+++oo+ooooooosoossyyyhhhhddddddm~~~~........''~s~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~y~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'.~y+~~..~...~...~~~.~~:///~:~:////+/+++oosooo+oso+soososssyyyhdhhdddd~~~~.....'...~/s.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/+'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'.:s~~........~...~~.~~:/::/:~//////o//::~::/+oooosooso:::sysss:::yddd::~:~....'.~~/y:'.'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'..o::~..~~.~~...~::~:////////:///+o.....~....~sooooss+....+yy+...sddd:~:~.~~~.~../yo.\u00A0'+.\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/+'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''.o::~~~~~.~~~.~~~~:/://++o++//++s~...+sos/...~ysos+o+...../h+...sddd:::::~::::~/yo:'\u00A0\u00A0.o:\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''.s+:~:::~:::~.~~::~~//++oo+o++o/s....oo+so....hoooos+......~:...sddd:~://::::/+oo+'\u00A0\u00A0\u00A0'.s/~.\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'':y/:~~~~~~~~.~~::~::/oo+osoooso+y....o+o++....yooooo+...s/......shdd:~/++//::++oo.\u00A0\u00A0\u00A0''\u00A0:ss/\u00A0\u00A0\u00A0''\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'o:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''.oy:::~~::~~..~::::::+osoossso+++s/...~///....+s+ooss+...sho.....shdd:::++//~~++++\u00A0\u00A0\u00A0'\u00A0''':ss\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0+/'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'.:so~:::~~:~~~::::://+++oooooss++++s+:~.....~:+sssssos+...yyhy:...sddd//+++:/::+s+.\u00A0\u00A0\u00A0.'\u00A0'\u00A0'sy:\u00A0\u00A0\u00A0'.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0':o'\u00A0\u00A0\u00A0\u00A0\u00A0'.:os/:::~~::::/:~::/+/+/+oo+++os++++o+sssooooss+o++ooosysssyyhyyyyhdmdd///++///~+s:\u00A0\u00A0'''~\u00A0\u00A0\u00A0+sss~\u00A0\u00A0\u00A0:'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.'s.'\u00A0\u00A0\u00A0'..::/+/::~~::::://:/+o++++o++++++++++o/+ooos+ososo+soooossyyyyyhhhdddmdd///:::://os'\u00A0\u00A0'''.\u00A0'+o~~o+\u00A0\u00A0\u00A0./'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0:+\u00A0'\u00A0''\u00A0\u00A0\u00A0'~~://~~:/~~~~://///+/+++o+/+++o++o/o+so+oooosoossoosooyhyyyhyhdhdddm//::~:~::s+'\u00A0\u00A0'''''oo~..+o.\u00A0\u00A0\u00A0::\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0~o\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0\u00A0\u00A0.'.:+/::+/+++//+++//+ooo++o++o+oo+o/osossosooossssssosyyyhhhhhddddm/:/::~~:/s~.'\u00A0''''.:o+~~/s/'\u00A0\u00A0'o'\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0~+~'\u00A0\u00A0\u00A0''''\u00A0\u00A0\u00A0''~+//s~.+oo+/o+//+ooo++oo+o+oo///soosss+ossooysyyyyyhhhhdddddddm::://:~/+o:~''\u00A0'''''.+o/:y+:'\u00A0\u00A0o.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''~//:..'.'\u00A0''\u00A0\u00A0\u00A0'./os~'':+/::so::++osooooooos/:ossysssosssoyyssyyyyhhhhddddddmm:/::/+:://os+.''''.'\u00A0.~:ohs.'\u00A0~+'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0.../ss+.''\u00A0\u00A0\u00A0'\u00A0\u00A0\u00A0':+:.\u00A0\u00A0'~~'so~:++o++osossss/oosssosossssyyyyyyhyhhhhdddmdddmm///+/+/:::/+ss:\u00A0'.~'\u00A0\u00A0.~+s~''~/.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0''':.~ohhsoo:~.''\u00A0'\u00A0\u00A0''''''\u00A0\u00A0\u00A0'y+:/+++oososyoss+o+sssysosoosyyyhhyyyhdhddddmdmmmN:/++//::::::++s+~~..++/yo.\u00A0\u00A0'''\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0'''..'~ohhysoo+oo+//::::~~..'..:hso/++ooooosyosyossyssssyossssshhhhhyyyyyhdmmmmmNNo/:://::/:::::+oo+~/hysyo:.''''\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0'..~oyysys+::/+sssoosso+/:::+sso+//+oo+oossosyossoosyo:~~..~~/sh+:~...~~/hNmmmmN+/::::::://~/////+oyso//::::::::///////+/ossyo:+syss:///+///++osss+++++++://o++ossssssssyssy/..........~..........oNmmNN//::://///:::::/:/ss/::/+~~//:~~~~~:::::~~:/s+:os+~y++::/:////:///++/o//+++oo+ossosssysooyy+....:oo~......./oo~....hmmNN/:::/:///:::::::/oyo/://o+'.....~~~~~~::~~~~/o..o'\u00A0/s/~~:://::::////+++//+o+o+oosoyosy+o+yd:~~~:yyhy~~~~~~+mmmy~~~~smmmN::://://+///////+s/./oso+s+++//::~:::::::::::/o:s:+oo/:::/://:+////+++oo+ooss+oooosoyhos+sysoooosssyhhhhhdddyyyoooohNNNN:/+++/:~..........~~/++/~~~o:..~~~/+::~.........~::+o/////++//+/......./o+oo~......:shysyyyy.......:dddmmmm~.......hNNNN//+/~.................~/'\u00A0'/\u00A0\u00A0'\u00A0'/~.................~/+o++/++/:++~....../s+......./syyysyyhh+.......oddmmmo.......oNNmNN/+/.......~:~:/:~.......+'..\u00A0\u00A0\u00A0\u00A0/.......~:~~~:~......./o//+/++///o:......~......~oyyyhysssyhy:.......hdmmh.......:NNmNNN/s........y.\u00A0:.'/.......::~...'::......./'\u00A0\u00A0\u00A0'/::://///s/os++++/++o/...........:yyyhyyyhshyhyy~....../dmm/......~dNNmNNN/s........s.~~\u00A0\u00A0/.......~+::://y~......./\u00A0\u00A0\u00A0\u00A0\u00A0.'.~/+//+++syo++//o+soo.........+yyyyhyyyyyyhyyys.......yms.......yNNNNNNN+s........+.'\u00A0\u00A0\u00A0+.......~/.....y~......./'\u00A0\u00A0\u00A0\u00A0''.~//++o+//++++oo+oss~.........:yyhhhyyysyyyyyyh+......~d~......+NNNNNNNN+s......../''.:/o.......:~\u00A0\u00A0\u00A0''/:......./'\u00A0\u00A0\u00A0'::~:::///s/+/:/+/++o/............~ohhhhysyyhhyhyhh:.............:mNNNmNNNN++/.......~:++/:......../\u00A0\u00A0\u00A0\u00A0''.o........:~~~:~......./+++/++++oo:.......:.......+hhdyyhshdhhhhdh............~dNNNNNNNNNooo+..................~+'\u00A0\u00A0\u00A0''''+s~.................~+o/+//oo++o~......~sso~......:yddddyhddhdddhs...........yNNNNNNNNNNssos+/:~..............+/\u00A0\u00A0\u00A0''\u00A0''+do+:~...........~//s+/+/+oo+o/......./ysosy:......~shhddhdddddmdd+.........+NNNNNNNNNNNsyy+.\u00A0:sssoooooo~....../~''''\u00A0.+hdy/''.~~~~~~~~~..::s+/+ossoohooo++oosyyyhyhyyyssssyydddmdddddmmdmmhhhhhhhhdNNNMMNNNNNNNshh~\u00A0'oosysyssoooo/os:+~~'''''/hdhdo'\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0'\u00A0\u00A0/:oo+++osoyss+oosssyyyyyhhyyhhhyhdhddhdddddmmmddmNNNNNNNNNNNNMNNNMNMMM";

        public bool draw = false;

        public String tmp = "";

        public StartFrame()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            //init arrays


            encStr = encStrS.ToCharArray();
            dcrStr = dcrStrS.ToCharArray();

            

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
            //this.graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //this.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            //this.graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            //this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            this.graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (draw)
            {
                OnDraw();
            }

        }

        private void OnDraw()
        {
            float fontSize = 9.5f;
            int fWidth = 950;
            int fHight = 2000;
            Point textPosition = new Point(50, 100);
            DrawText(new string(layerZero), "Courier New", fontSize, FontStyle.Regular, Brushes.DimGray, textPosition, fWidth, fHight); //Encrypted
            //textPosition = new Point(50, 200);
            DrawText(new string(layerOne), "Courier New", fontSize, FontStyle.Regular, Brushes.Gold, textPosition, fWidth, fHight); //Decyrpted - non transition
            //textPosition = new Point(50, 300);
            DrawText(new string(layerTwo), "Courier New", fontSize, FontStyle.Regular, Brushes.Black, textPosition, fWidth, fHight); // code + transition forth
            //textPosition = new Point(50, 400);
            DrawText(new string(layerThree), "Courier New", fontSize, FontStyle.Regular, Brushes.DimGray, textPosition, fWidth, fHight); // code + transition third
            //textPosition = new Point(50, 500);
            DrawText(new string(layerFour), "Courier New", fontSize, FontStyle.Regular, Brushes.LightSlateGray, textPosition, fWidth, fHight); // code + transition second
            //textPosition = new Point(50, 600);
            DrawText(new string(layerFive), "Courier New", fontSize, FontStyle.Regular, Brushes.LightBlue, textPosition, fWidth, fHight); // code + transition first
            //textPosition = new Point(50, 700);
            DrawText(new string(layerSix), "Courier New", fontSize, FontStyle.Regular, Brushes.White, textPosition, fWidth, fHight); //xor 
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
            demoSelect.Hide();

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
            demoSelect.Show();



            draw = true;

        }

        private void button1_Click_2(object sender, EventArgs e) //start windowed
        {
            btnFullScreen.Hide();
            btnRestore.Hide();
            btnWindow.Hide();
            btnSql.Hide();
            demoSelect.Hide();

            draw = true;

            this.stopProcess = false;

            // Initialise and start worker thread
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperationAsync));
            this.workerThread.Start();


        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public void BadgeFeed(String hex)
        {
            char[] hexArray = hex.ToCharArray();
            int b = 0;

            for(int i = 0; i<hexArray.Length; i++)
            {
                if(hexArray[i] == '0')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '1')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '2')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '3')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '4')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '5')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '6')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '7')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                }
                else if (hexArray[i] == '8')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == '9')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'A')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'B')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'C')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'D')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'E')
                {
                    badgeFeed[b] = false;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
                else if (hexArray[i] == 'F')
                {
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                    badgeFeed[b] = true;
                    b++;
                }
            }
        }


        private async void HeavyOperationAsync()
        {
            while(true)
            {
                if (!this.stopProcess)
                {
                    // Show progress

                    if (demoMode)
                    {
                        Random gen = new Random();
                        for (int i = 0; i < badgeFeed.Length; i++)
                        {
                            if (gen.NextDouble() < 0.02) //0.02
                                if (badgeFeed[i] == true)
                                {
                                    badgeFeed[i] = false; //false
                                }
                                else
                                {
                                    badgeFeed[i] = true;
                                }
                            //Console.WriteLine(badgeFeed[i]);      
                        }
                    }
                    else
                    {
                        BadgeFeed(rtnData());
                    }

                    float decryptCount = 0;

                    for (int i = 0; i < badgeFeed.Length; i++)
                    {
                        if(badgeFeed[i])
                        {
                            decryptCount++;
                        }
                        // LAYER SIX FOR BRAND NEW CHARACTERS
                        if (badgeFeed[i] == true && stateZero[i] == true)
                        {
                            // Character previously off, now turned on.
                            // TODO: Set stateZero[i] to false
                            // TODO: Set stateSix[i] to true
                            layerSix[i] = encStr[i];
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
                            layerFive[i] = encStr[i];
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
                            layerFour[i] = encStr[i];
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
                            layerThree[i] = encStr[i];
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
                            layerTwo[i] = encStr[i];
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
                            layerOne[i] = dcrStr[i];
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

                    percentDecrypted = (decryptCount / 7680) * 100;

                    //Console.WriteLine(percentDecrypted);

                    this.Invoke(this.updateStatusDelegate);
                    Invalidate();
                    await Task.Delay(200);

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

            decryptValue.Text = percentDecrypted.ToString("000.0000");

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

        private void getOr()
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "dbo.getOr";
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //MessageBox.Show(rtnData());

                    }

                    con.Close();
                }


                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private String rtnData()
        {
            getOr();
            string rtnDataFile = null;
            string sqlQuery = "SELECT [data] FROM [badge].[dbo].[file] WHERE ID = 1";

            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rtnDataFile = (string)reader["data"];
                        }
                    }
                }
            }

            return rtnDataFile;
        }

        private void sql_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Badge Feed: " + rtnData());
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(demoSelect.Text == "Demo On")
            {
                demoMode = true;
            }
            if (demoSelect.Text == "Demo Off")
            {
                demoMode = false;
            }
            //MessageBox.Show(demoMode.ToString());
        }


    }
}
