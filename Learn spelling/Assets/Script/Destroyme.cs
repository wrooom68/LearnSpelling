using UnityEngine;
using System.Collections;

public class Destroyme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Dme");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "alphabet") {
			GameObject.Find("Manager").GetComponent<Manager>().Display (col.gameObject.name);
			Destroy (gameObject);
		}
	}

	IEnumerator Dme(){
		yield return new WaitForSeconds (1.0f);
		GameObject.Find ("Manager").GetComponent<Manager> ().chancedecrease ();
		Destroy (gameObject);
	}
}
