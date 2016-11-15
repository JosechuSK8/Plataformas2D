using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {
	private GameControlScript gcs;

	void Start (){
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}

	void OnTriggerEnter2D (Collider2D objeto)
	{
		if (objeto.tag == "Player") {
			gcs.checkpoint (transform.position);

		}
	}
}