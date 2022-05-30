using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Splash : MonoBehaviour {


	public GameObject load;
	public Canvas setting;
	public Dropdown mode;

	public RawImage soundImg;
	public Texture sOn;
	public Texture sOff;

	// Use this for initialization
	void Start () {
		load.SetActive(false);
		setting.enabled = false;
		mode.value = PlayerPrefs.GetInt("mode");
		if (PlayerPrefs.GetInt ("sound") == 0) {
			soundImg.texture = sOn;
		} else {
			soundImg.texture = sOff;
		}
		GameObject ad = GameObject.Find("AdMob");
		// ad.GetComponent<GoogleMobileAdScript> ().ShowBanner ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPlayClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		load.SetActive(true);
		load.GetComponent<Fading>().go=true;
		GameObject.Find ("Fader").GetComponent<Fading> ().StartCoroutine ("fader");
	//	Application.LoadLevel ("Main");

	}

	public void OnSettingClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		setting.enabled = true;
	}

	public void OnSettingCloseClick(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		setting.enabled = false;
	}

	public void OnModeValueChange(){
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
		}
		PlayerPrefs.SetInt ("mode",mode.value);
	}

	public void OnSoundClick(){
		int sss = PlayerPrefs.GetInt ("sound");
		Debug.Log (sss);
		if (sss == 0) {
			PlayerPrefs.SetInt ("sound", 1);
			soundImg.texture = sOff;
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().bg.Stop ();
			Debug.Log ("1   "+sss);
		} else {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().btclick.Play ();
			PlayerPrefs.SetInt ("sound", 0);
			soundImg.texture = sOn;
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().bg.Play ();
			Debug.Log ("2   "+sss);
		}
	}
}
