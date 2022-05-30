using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {

	string alphabets="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	string word="PLAYER";

	public Transform parentObj;
	public GameObject characterObj;
	public Texture[] abcd;

	static int wordshoot;
	static int score;
	public RawImage Acake;
	public Text scoretxt;

	public Text scoretext;
	public Canvas surrender;

	public Text chancesText;
	public static int chances;

	public float time;
	public int seconds;

	public Text timeText;

	void Awake(){
		chances = 10;
		score = 0;
		scoretxt.text = score.ToString ();
		surrender.enabled = false;
	}

	// Use this for initialization
	void Start () {
		word = gameObject.GetComponent<WordMgr> ().Wordselection ();
		worddisplay ();
		wordshoot = 0;
		chancesText.text = "" + chances.ToString ();
		time= word.Length * 5;
	}

	void ReWord(){
		for (int i = 0; i<word.Length; i++) {
			Destroy (GameObject.Find("wordObj"+i));
		}
	}

	void Update(){
		time = time - Time.deltaTime;
		seconds = (int)time % 60;
		timeText.text = "" + seconds.ToString ();
		if (seconds <= 0 && seconds > -1) {
			chancedecrease();
			ReWord();
			Start();
		}
	}

	public void Display(string s){
			if (word [wordshoot].ToString () == s) {
			GameObject.Find ("wordObj" + wordshoot).GetComponent<RawImage> ().color = Color.red;
			if (wordshoot < word.Length - 1) {
				wordshoot++;
			} else {
				StartCoroutine ("Reloadscene");
			}

		} else {
			chancedecrease();
		}

	}

	IEnumerator Reloadscene(){
		Acake.GetComponent<Animation> ().Play ();
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().cakemove.Play ();
		}
		yield return new WaitForSeconds (1f);
		for (int i = 0; i<word.Length; i++) {
			Destroy (GameObject.Find("wordObj"+i));
		}
		score = score + 1;
		scoretxt.text = score.ToString ();
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().cakemeet.Play ();
		}
		yield return new WaitForSeconds (1f);
		Start ();
	}

	public void worddisplay(){
		for (int i = 0; i<word.Length; i++) {
			char temp = word[i];
			int tempIndex=alphabets.IndexOf(temp);
			GameObject wordObj= Instantiate(characterObj)as GameObject;
			wordObj.GetComponent<RawImage>().texture=abcd[tempIndex];
			wordObj.transform.SetParent(parentObj);
			if(tempIndex == 22){
				wordObj.transform.localScale=new Vector3(1.3f,1.3f,1.3f);
			}else{
			wordObj.transform.localScale=new Vector3(1,1,1);
			}
			wordObj.name = "wordObj"+i;
		}
	}

	public void chancedecrease(){
		chances--;
		chancesText.text = "" + chances.ToString ();
		if(chances <= 0){
			OnSurrenderClick();
			chancesText.text = "0";
		}
	} 

	public void OnSurrenderClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		surrender.enabled = true;
		scoretext.text = ""+score.ToString ();
		GameObject ad = GameObject.Find("AdMob");
		// ad.GetComponent<GoogleMobileAdScript> ().ShowInterstial();
		InterstitialAdExample._instance.ShowAd();
	}

	public void OnHomeClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		Application.LoadLevel (0);
	}

	public void OnRestartClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		Application.LoadLevel (Application.loadedLevel);
	}

	public void OnRateUsClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		Application.OpenURL ("https://play.google.com/store/search?q=wrooom68&hl=en");
	}

	public void OnWordClick(){
		int temp = PlayerPrefs.GetInt ("mode");
		if (temp <= 2) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+word+meaning&*");
		
		} else if (temp == 3) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+animal&*");

		} else if (temp == 4) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+bird&*");

		} else if (temp == 5) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+color&*");

		} else if (temp == 6) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+capital&*");

		} else if (temp == 7) {
			Application.OpenURL ("https://www.google.co.in/webhp?sourceid=chrome-instant&rlz=1C1PRFE_enIN711IN711&ion=1&espv=2&ie=UTF-8#q=" + word + "+element&*");

		} else {
			return;
		}
	}
}
