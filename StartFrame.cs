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



        public static String encStrS = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222";


        public static String dcrStrS = "sssys+/++//:~~~~:++~::~/+~~:/:::/+++//://+/://:/::+::/+o++/+++++///sssooosssssoysyysyyyhhyhhhyhhhddddddmmmmmmNNNNNNNNNNNsoss+/+//::~://:://~::~~::.\u00A0`~/o+++//+/::/::/:/+//+o/+ssoo++///+ooyoosooooososysyysyyyssssssssssyhhhdddddhhhhhhhhdNNNNNNsooo+o+/s+~:~::://:~~:~~::::~:~.......:+//:/::o....s/+o+.../+/:/:/o...........soosssoo...........shddddms.........~+dNNNssoo+o++/::~~::////::~/~~~:/:...~~~:....+/::::o....o:/++...//:/://+...~+//////sooooooo....+++++++yhhhhhdo....sss:...:NNNoso+o+++///+/.```\u00A0```.....~o..../\u00A0\u00A0`/...~o:::~o....o~:/+...//:/://+...~//////so++o+ooo....++++++yhhhhyhdo....yyy/....mNNoooos/:~``\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/..../\u00A0\u00A0\u00A0+...~s:~~~o....+~~:+...//~~:::+..........o/++++ooo..........sdhhhhhhs..........~yNNN+oooo+//:~.`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/..../..~:...::+:~~+~...////:...+:~~:::+...~so+oooo+/+++++o...~ssossyhhhhhhhho....os~...oNNNNoo++o++/://:~~`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`/~.........~/\u00A0`o~~~+~...~~....:+~~~:~:+....~~~~~~~+/+//+/o....~~~~~~~+hhhhhho....mmy....smmmooooo+/:::~~:~/:~`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.~~~~~:.../.\u00A0\u00A0~o~~~//:::::::/:~:~~~~~+:::::::::::o/+++//o:::::::////ohhhyhhy////mmds////dmNoo++////:~:::+:.`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0```..:~~~:\u00A0`\u00A0++~~::::~~~~~.~~~~.~~~~:::~:/:::////+////+//+oossyyyyyyyyhhhhdddddmmmdmdddmm//:://::~~.````\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:.....~://~`\u00A0`+~:o:~~:~~::::~~~~~~~.~.~..~~::://~:/://::/:/+/+ssyhyhyyyyyhhhhhdddddddddddmmm+/::::~:::::.`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0```./\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.:+::+`:y:~~~~:~~~~:::~~~~~~:::://///////:::::::/+++++++ooyyyyyyhhhyooshhddhsssdmmm+//::::~:~~:~/~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.:```.\u00A0```\u00A0\u00A0\u00A0\u00A0\u00A0`:o:\u00A0`o~~~~~~~~~~.~...~~~~:+/~.......~:+:::~:/o:~.......~/yyyyhhh+...:hdd+...ymmm///:::~~~~~~~::`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0`/\u00A0\u00A0\u00A0\u00A0.//:/~`\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0`+~~~~~~~~~~~~.~~~~~~//...~///:~~~:o:::/+:...:ooo:.../hyyyyy+....~smo...ydmm///:~~~~......~:`\u00A0\u00A0\u00A0\u00A0`:.`.~\u00A0\u00A0\u00A0`\u00A0.~:..::.``./+s/:~~~.~~~~~~~~~~~~~+....+~~~/////+//++y....ooooo....hysysh+......+/...ydmm:/:~~~~~~~~.....:.\u00A0\u00A0\u00A0\u00A0~\u00A0~.~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0``.`~/oso/:~~~~~~~.~~~~~~~~~~o....+~~~:://::://:s....ooooo....hyysyy+.../~......ymmm:::~~~::~~~......~~`\u00A0\u00A0:\u00A0.:`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`./o:~.~..~~~~~~~~~~~~~~/:...:/:/:~~~:+:++:+:...:soo:...:yyyhhh+...hh:.....yddm~~~:~~::~~~........~~`..`\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~//s/~....~~~.~~~~~~~~~~~~/:~...~...~:+:://::o:....~...~:sosyyyh+...ydh+....yddm~::~:~~..~....~......~::.:~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~~.~:+o..~~.~~~~~~~~~~~~~~:~~~/////://///::/::/:/++//////+oo+ossssss+++hdhds++ohddm~~:~~~...............:/:~/o/`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``~:+:::////++~~~:~~~.~~~~~~~~://::::::::/:~~/:///+//+/+++++soossyyyhhhhhdhhhhhddm~:~~~............``......~:s+/:.``\u00A0\u00A0`.~:://:~~~~~~~:+o:~~~~~~~~~~~~~:://::/:::/::://///+//o++++++oyssssysyhhhhhhhhyyhddd~~~~~~......`...`.........~/::/:.~:/:~~~``\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:o+~.~....~~~~://:::::+//::~:///o:::oo++o///ssysysyo++/+//+osyyhhdd~~~~~......````....`.....~++.`//:~.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`.s/...~....~~~+......~o::~~/+/++...~o++o...osssssy/....~~...~/hhdd~~.........~..........~:++s:...`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s/.~~~...~~~/:...o...//~~:/++/+...../oo...ossssoy/.../yys:...+ddd~~......``...~......:/oo:+~.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`s/.~~......~+...+:/...o:~////++......:/...ossossy/...ohhho...~mmd.~.......``.......:++:.`.`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`o+.~.......+~.../:/...~o~~:///+...+:......ossosss/...odhho...~ddd......`....``..~//~`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0:~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.so..~.....~/...........+:~/::/+...oo/.....oooosss/.../oo+~...oddd...........```./:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0o/`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``:y+.~~...~~+...~/::/+~..~o/:/:/+...o+oo~...ooossyy/.........:odddd~~~~.......```~+`\u00A0\u00A0\u00A0\u00A0\u00A0`.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~s:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`.ss~.~~...../:::/~~~~~/://+~:~:/o///o+oos+++s+ooosysooooossyhdddhdd~.~~~.....~...://\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0+y~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``/s:~~......~...~~~~~::~::~~::://+//+++oo+ooooooosoossyyyhhhhddddddm~~~~........``~s~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0~y~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`.~y+~~..~...~...~~~.~~:///~:~:////+/+++oosooo+oso+soososssyyyhdhhdddd~~~~.....`...~/s.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/+`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`.:s~~........~...~~.~~:/::/:~//////o//::~::/+oooosooso:::sysss:::yddd::~:~....`.~~/y:`.`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`..o::~..~~.~~...~::~:////////:///+o.....~....~sooooss+....+yy+...sddd:~:~.~~~.~../yo.\u00A0`+.\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0/+`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``.o::~~~~~.~~~.~~~~:/://++o++//++s~...+sos/...~ysos+o+...../h+...sddd:::::~::::~/yo:`\u00A0\u00A0.o:\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``.s+:~:::~:::~.~~::~~//++oo+o++o/s....oo+so....hoooos+......~:...sddd:~://::::/+oo+`\u00A0\u00A0\u00A0`.s/~.\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.s~\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``:y/:~~~~~~~~.~~::~::/oo+osoooso+y....o+o++....yooooo+...s/......shdd:~/++//::++oo.\u00A0\u00A0\u00A0``\u00A0:ss/\u00A0\u00A0\u00A0``\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`o:\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``.oy:::~~::~~..~::::::+osoossso+++s/...~///....+s+ooss+...sho.....shdd:::++//~~++++\u00A0\u00A0\u00A0`\u00A0```:ss\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0+/`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`.:so~:::~~:~~~::::://+++oooooss++++s+:~.....~:+sssssos+...yyhy:...sddd//+++:/::+s+.\u00A0\u00A0\u00A0.`\u00A0`\u00A0`sy:\u00A0\u00A0\u00A0`.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`:o`\u00A0\u00A0\u00A0\u00A0\u00A0`.:os/:::~~::::/:~::/+/+/+oo+++os++++o+sssooooss+o++ooosysssyyhyyyyhdmdd///++///~+s:\u00A0\u00A0```~\u00A0\u00A0\u00A0+sss~\u00A0\u00A0\u00A0:`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.`s.`\u00A0\u00A0\u00A0`..::/+/::~~::::://:/+o++++o++++++++++o/+ooos+ososo+soooossyyyyyhhhdddmdd///:::://os`\u00A0\u00A0```.\u00A0`+o~~o+\u00A0\u00A0\u00A0./`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0:+\u00A0`\u00A0``\u00A0\u00A0\u00A0`~~://~~:/~~~~://///+/+++o+/+++o++o/o+so+oooosoossoosooyhyyyhyhdhdddm//::~:~::s+`\u00A0\u00A0`````oo~..+o.\u00A0\u00A0\u00A0::\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0.\u00A0\u00A0~o\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0\u00A0\u00A0.`.:+/::+/+++//+++//+ooo++o++o+oo+o/osossosooossssssosyyyhhhhhddddm/:/::~~:/s~.`\u00A0````.:o+~~/s/`\u00A0\u00A0`o`\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0~+~`\u00A0\u00A0\u00A0````\u00A0\u00A0\u00A0``~+//s~.+oo+/o+//+ooo++oo+o+oo///soosss+ossooysyyyyyhhhhdddddddm::://:~/+o:~``\u00A0`````.+o/:y+:`\u00A0\u00A0o.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0``~//:..`.`\u00A0``\u00A0\u00A0\u00A0`./os~``:+/::so::++osooooooos/:ossysssosssoyyssyyyyhhhhddddddmm:/::/+:://os+.````.`\u00A0.~:ohs.`\u00A0~+`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0.../ss+.``\u00A0\u00A0\u00A0`\u00A0\u00A0\u00A0`:+:.\u00A0\u00A0`~~`so~:++o++osossss/oosssosossssyyyyyyhyhhhhdddmdddmm///+/+/:::/+ss:\u00A0`.~`\u00A0\u00A0.~+s~``~/.\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0```:.~ohhsoo:~.``\u00A0`\u00A0\u00A0``````\u00A0\u00A0\u00A0`y+:/+++oososyoss+o+sssysosoosyyyhhyyyhdhddddmdmmmN:/++//::::::++s+~~..++/yo.\u00A0\u00A0```\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0```..`~ohhysoo+oo+//::::~~..`..:hso/++ooooosyosyossyssssyossssshhhhhyyyyyhdmmmmmNNo/:://::/:::::+oo+~/hysyo:.````\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0`..~oyysys+::/+sssoosso+/:::+sso+//+oo+oossosyossoosyo:~~..~~/sh+:~...~~/hNmmmmN+/::::::://~/////+oyso//::::::::///////+/ossyo:+syss:///+///++osss+++++++://o++ossssssssyssy/..........~..........oNmmNN//::://///:::::/:/ss/::/+~~//:~~~~~:::::~~:/s+:os+~y++::/:////:///++/o//+++oo+ossosssysooyy+....:oo~......./oo~....hmmNN/:::/:///:::::::/oyo/://o+`.....~~~~~~::~~~~/o..o`\u00A0/s/~~:://::::////+++//+o+o+oosoyosy+o+yd:~~~:yyhy~~~~~~+mmmy~~~~smmmN::://://+///////+s/./oso+s+++//::~:::::::::::/o:s:+oo/:::/://:+////+++oo+ooss+oooosoyhos+sysoooosssyhhhhhdddyyyoooohNNNN:/+++/:~..........~~/++/~~~o:..~~~/+::~.........~::+o/////++//+/......./o+oo~......:shysyyyy.......:dddmmmm~.......hNNNN//+/~.................~/`\u00A0`/\u00A0\u00A0`\u00A0`/~.................~/+o++/++/:++~....../s+......./syyysyyhh+.......oddmmmo.......oNNmNN/+/.......~:~:/:~.......+`..\u00A0\u00A0\u00A0\u00A0/.......~:~~~:~......./o//+/++///o:......~......~oyyyhysssyhy:.......hdmmh.......:NNmNNN/s........y.\u00A0:.`/.......::~...`::......./`\u00A0\u00A0\u00A0`/::://///s/os++++/++o/...........:yyyhyyyhshyhyy~....../dmm/......~dNNmNNN/s........s.~~\u00A0\u00A0/.......~+::://y~......./\u00A0\u00A0\u00A0\u00A0\u00A0.`.~/+//+++syo++//o+soo.........+yyyyhyyyyyyhyyys.......yms.......yNNNNNNN+s........+.`\u00A0\u00A0\u00A0+.......~/.....y~......./`\u00A0\u00A0\u00A0\u00A0``.~//++o+//++++oo+oss~.........:yyhhhyyysyyyyyyh+......~d~......+NNNNNNNN+s......../``.:/o.......:~\u00A0\u00A0\u00A0``/:......./`\u00A0\u00A0\u00A0`::~:::///s/+/:/+/++o/............~ohhhhysyyhhyhyhh:.............:mNNNmNNNN++/.......~:++/:......../\u00A0\u00A0\u00A0\u00A0``.o........:~~~:~......./+++/++++oo:.......:.......+hhdyyhshdhhhhdh............~dNNNNNNNNNooo+..................~+`\u00A0\u00A0\u00A0````+s~.................~+o/+//oo++o~......~sso~......:yddddyhddhdddhs...........yNNNNNNNNNNssos+/:~..............+/\u00A0\u00A0\u00A0``\u00A0``+do+:~...........~//s+/+/+oo+o/......./ysosy:......~shhddhdddddmdd+.........+NNNNNNNNNNNsyy+.\u00A0:sssoooooo~....../~````\u00A0.+hdy/``.~~~~~~~~~..::s+/+ossoohooo++oosyyyhyhyyyssssyydddmdddddmmdmmhhhhhhhhdNNNMMNNNNNNNshh~\u00A0`oosysyssoooo/os:+~~`````/hdhdo`\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0`\u00A0\u00A0/:oo+++osoyss+oosssyyyyyhhyyhhhyhdhddhdddddmmmddmNNNNNNNNNNNNMNNNMNMMM";

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

                    //this.Invoke(this.updateStatusDelegate);
                    Invalidate();
                    await Task.Delay(1000);

                    
                    
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
