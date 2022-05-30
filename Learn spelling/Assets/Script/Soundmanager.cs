using UnityEngine;
using System.Collections;

public class Soundmanager : MonoBehaviour {
	 
	public AudioSource bg;
	public AudioSource cakemove;
	public AudioSource cakemeet;
	public AudioSource btclick;
	public AudioSource gunshoot;
	public AudioSource gunshot;




	private static Soundmanager _instance ;
	int backClick;

	void Awake()
	{
		//if we don't have an [_instance] set yet
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject) ;
		
		
		DontDestroyOnLoad(this.gameObject) ;

		backClick = 0;
	}

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("sound") == 0) {
			bg.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			backClick++;
			StartCoroutine("BackExit");
		}
	}

	IEnumerator BackExit(){
		if (backClick >= 2) {
			Application.Quit();
		}
		yield return new WaitForSeconds (1.5f);
		backClick = 0;
	}


}
