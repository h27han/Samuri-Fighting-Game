using UnityEngine;
using System.Collections;

public class HitControl : MonoBehaviour {
	GameObject Player;

	// Use this for initialization
	void Start () {
		GameObject thePlayer = GameObject.Find("Player");
//		Script playerScript = thePlayer.GetComponent<PlayerScript>();
//		playerScript.Health -= 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "MAX") {
			//if (this.transform.paren)
		}
		print("Touched!");
	}
}
