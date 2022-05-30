using UnityEngine;
using System.Collections;

public class Alphabetmgr : MonoBehaviour {

	Vector3 mypos;
	Quaternion myrot;
	// Use this for initialization
	void Start () {
		mypos = transform.localPosition;
		myrot = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "bulet") {
			gameObject.AddComponent<Rigidbody>();
			gameObject.GetComponent<Rigidbody>().AddRelativeForce(0,-10f,-300f);
			StartCoroutine("Repose");
		}
	}

	IEnumerator Repose(){
		yield return new WaitForSeconds (0.2f);
		if (PlayerPrefs.GetInt ("sound") == 0) {
			GameObject.Find ("Sounder").GetComponent<Soundmanager> ().gunshot.Play ();
		}
		yield return new WaitForSeconds (1.0f);
		Destroy (GetComponent<Rigidbody>());
		yield return new WaitForSeconds (1f);
		transform.localPosition = mypos;
		transform.localRotation = myrot;

	}
}
