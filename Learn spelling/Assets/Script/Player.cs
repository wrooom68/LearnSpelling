using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool shootY=true;
	public Transform bpoint; 
	public GameObject bullet;

	public void ShootAlphabet(){
		if (shootY == true) {
			StartCoroutine ("shooter");
		}
	}

	IEnumerator shooter(){
		shootY = false;
		gameObject.GetComponent<Animation> ().Play ("ah_gunplay");
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().gunshoot.Play ();
		}
		GetComponent<Animation>()["ah_gunplay"].speed = 0.3f;
		GameObject gg = Instantiate (bullet,bpoint.position,bpoint.rotation) as GameObject;
		gg.GetComponent<Rigidbody> ().AddRelativeForce (0,0,100f);

		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Animation> ().Stop ("ah_gunplay");
		yield return new WaitForSeconds (0.5f);
		shootY = true;
	}
}
