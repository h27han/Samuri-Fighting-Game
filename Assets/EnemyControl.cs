using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	private Transform player;               // Reference to the player's position.
	private NavMeshAgent nav;               // Reference to the nav mesh agent.
	private Animation an;
	private double nextAction;
	private double EnemyHealth;


	// Use this for initialization
	void Start () {
		EnemyHealth = 10;
		nextAction = Time.time;
		an = GetComponent<Animation>();
	
		an.CrossFade ("run");
	}

	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {

		nav.SetDestination (player.position);

		Vector3 distance = transform.position - player.position;

		if (Time.time + 1 == nextAction) {


		}

		if (Time.time > nextAction) {

			if (distance.magnitude <= 2) {

				nav.speed = 1;
				nav.angularSpeed = 50 ;
				an.CrossFade ("punch");
				nextAction = Time.time+ 2;
			}else
			if (distance.magnitude <= 7) {
				nav.speed = 3;
				nav.angularSpeed = 200 ;
				an.CrossFade ("walk");

			} else {
				nav.speed = 5;
				nav.angularSpeed = 200 ;
				an.CrossFade ("run");
			}
		}

	}
}


	