using UnityEngine;
using System.Collections;

public class Rotategiant : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround (transform.position,speed);
	}
}
