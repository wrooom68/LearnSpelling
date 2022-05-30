using UnityEngine;
using System.Collections;

public class WordMgr : MonoBehaviour {

	string[] eE = {"MAN","GIRL","BOY","AND","BALL","BIG","BED","BAD","BOOK","BOX","BUT","CAR","CAT","BET","GAME",
		"FAT","FAN","GET","GOOD","HAT","DATE","HOME","HERE","HOT","COOL","LOOK","OLD","PET","EASY","PLAY","DARE",
		"RIDE","STOP","SUN","TOP","TOY","YES","NO","HELP","KIND","FULL","FOOL","FALL","LOVE","HATE","KISS","EYES",
		"NOSE","EAR","TAP"};

	string[] eM = {"WOMAN","UNCLE","AUNTY","FATHER","MOTHER","BROTHER","SISTER","CHILD","COUNT","SOCIAL","PRAYER",
		"FRIEND","ANIMAL","MOUTH","SHOULDER","MUSCLE","BICEPS","STOMACH","WEIGHT","GREAT","PEOPLE","AFTER","BEFORE",
		"CHANGE","VALUE","HAPPY","MONTH","FORCE","HOUSE","AIRPLANE","LUNCH","DINNER","SUPPER","POWER","LANGUAGE",
		"EARTH","PLANET","DRIVER","MISSION","WARRIOR","IDENTITY","CLOUD","FORGIVE","COLLEGE","PERFECT","MANNER",
		"BOUNCE","LABOUR","MONEY","TRUST"};

	string[] eH = {"DIFFICULT","ADVENTURE","CERTIFICATE","BREAKFAST","CHOCOLATE","CHARACTER","BRILLIANT","ENVIORNMENT",
		"ABSOULUTE","MARVELLOUS","WORLDWIDE","PERFORMANCE","EXPERIEMENT","GENERATION","VOCABULARY","EXPENDITURE",
		"SCIENTIFIC","ABBREVIATION","ATMOSPHERE","DOMINATION","GRANDMOTHER","GRANDFATHER","VACCINATION","ADMINISTRATION",
		"EDUCATION","CONTROVERSY","POPULATION","TEMPERATURE","ASSUMPTION","AGRICULTURE","STATISTICS","ECONOMICS",
		"MIGRATION","YESTERDAY","PRODUCTION","CONSTRUCTION","DEVELOPMENT","SALVATION","PROPRIETARY","THUNDERSTORM",
		"EMMIGRATION","HAZARDOUS","INTERNATIONAL","APPLICATION","DICTIONARY","CALCULATION","ACCELERATOR","ACCOMMODATION",
		"EMPOWERMENT","DEFINITION"};

	string[] eAnimal = {"LION","BEAR","DOG","CAT","TIGER","HORSE","DEER","WOLF","CATTLE","MONKEY","DONKEY","SQUIRREL",
		"PIG","LEOPARD","GOAT","HIPPOPOTAMUS","GIRAFFE","RHINOCEROS","CHEETAH","HYENA","BOAR","GORILLA","SHEEP","CAMEL",
		"CROCODILE","ALLIGATOR","HARE","TURTLE","ELEPHANT","JAGUAR","CHIMPANZEE","BISON","COUGAR","FOX","MANGOOSE","ZEBRA",
		"PANTHER","KANGAROO","BULL","RAT"};

	string[] eBird = {"PIGEON","CROW","PARROT","SPARROW","ROBIN","WAGTALL","PEACOCK","SWALLOW","NIGHTINGALE","WAXWING",
		"WOODPECKER","DUCK","DOVE","LAPWING","KITE","PHEASANT","MYNAH","KINGFISHER","CANARY","OWL","HOOPOE","PUFFIN",
		"QUAIL","EAGLE","VULTURE","TOUCAN","HORNBILL","GOLDFINCH","TAILOR","WEAVER","SKYLARK","STARLING","CRANE","SWAN",
		"OSTRICH","CUCKOO","GOOSE","DUCK","FLAMINGO","MACAW"};

	string[] eColor = {"GREEN","RED","PINK","BROWN","WHITE","ORANGE","PURPLE","YELLOW","GRAY","BLACK","BLUE","CYAN","PEACH",
		"SKYBLUE","GOLD","SILVER","IVORY","LAVENDER","MAROON","ORCHID","VIOLET","TAN","CREAM","APRICOT","AMBER","TURQUOISE",
		"EMERALD","PURPLE","SALMON","INDIGO"};

	string[] eCapital = {"BEIJING","DELHI","WASHINGTON","JAKARTA","BRASILIA","ISLAMABAD","MOSCOW","DHAKA","ABUJA","TOKYO",
		"MEXICO","HANOI","MANILA","BERLIN","CAIRO","ANKARA","TEHRAN","BANGKOK","PARIS","LONDON","ROME","KINSHASA","NAYPYIDAW",
		"SEOUL","BLOEMFONTEIN","KYIV","BOGOTA","MADRID","WARSAW","NAIROBI","OTTAWA","KABUL","KAMPALA","BAGHDAD","BUCHAREST",
		"KOTTE","CANBERRA","BUDAPEST","JERUSALEM","AMMAN","ABUDHABI","SINGAPORE","DUBLIN","WELLINGTON","MUSCAT","GEORGETOWN",
		"BRIDGETOWN","BERN","MONROVIA","TIRANA"};
	string[] eElements = {"HYDROGEN","HELIUM","LITHIUM","BERYLLIUM","BORON","CARBON","NITROGEN","OXYGEN","FLUORINE","NEON",
		"SODIUM","MAGNESIUM","ALUMINIUM","SILICON","PHOSPHORUS","SULFUR","CHLORINE","ARGON","POTASSIUM","CALCIUM","SCANDIUM",
		"TITANIUM","VANADIUM","CHROMIUM","MANAGANESE","IRON","COBALT","NICKEL","COPPER","ZINC","GALLIUM","GERMANIUM","ARSENIC",
		"SELENIUM","BROMINE","KRYPTON","THORIUM","PROTACTINIUM","URANIUM","NEPTUNIUM","PLUTONIUM","AMERICIUM","CURIUM",
		"BERKELIUM","CALIFORNIUM","EINSTEINIUM","FERMIUM","MENDELEVIUM","NOBELIUM","LAWRENCIUM"};
	// Use this for initialization

	static string newWord;
	int mode;

	void Awake(){
		mode = PlayerPrefs.GetInt ("mode");
	}

	public string Wordselection(){
		if (mode == 0) {
			newWord = eE [Random.Range (0, eE.Length)];
		} else if (mode == 1) {
			newWord = eM [Random.Range (0, eM.Length)];
		} else if (mode == 2) {
			newWord = eH [Random.Range (0, eH.Length)];
		} else if (mode == 3) {
			newWord = eAnimal [Random.Range (0, eAnimal.Length)];
		} else if (mode == 4) {
			newWord = eBird [Random.Range (0, eBird.Length)];
		} else if (mode == 5) {
			newWord = eColor [Random.Range (0, eColor.Length)];
		} else if (mode == 6) {
			newWord = eCapital [Random.Range (0, eCapital.Length)];
		} else if (mode == 7) {
			newWord = eElements [Random.Range (0, eElements.Length)];
		} else {
			int temp = Random.Range (0, 8);
			if (temp == 0) {
				newWord = eE [Random.Range (0, eE.Length)];
			} else if (temp == 1) {
				newWord = eM [Random.Range (0, eM.Length)];
			} else if (temp == 2) {
				newWord = eH [Random.Range (0, eH.Length)];
			} else if (temp == 3) {
				newWord = eAnimal [Random.Range (0, eAnimal.Length)];
			} else if (temp == 4) {
				newWord = eBird [Random.Range (0, eBird.Length)];
			} else if (temp == 5) {
				newWord = eColor [Random.Range (0, eColor.Length)];
			} else if (temp == 6) {
				newWord = eCapital [Random.Range (0, eCapital.Length)];
			} else {
				newWord = eElements [Random.Range (0, eElements.Length)];
			}
		}

		return newWord;
	}
}
