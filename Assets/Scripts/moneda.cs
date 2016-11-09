using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {
	private Rigidbody2D rb;



	void start () {
		Destroy (gameObject,3);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (-100, 100));
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("Ha tocado");
		Destroy (gameObject);

	}

		void OnTriggerExit2D(Collider2D col){
			Debug.Log ("Han dejado de tocarme");
		}

		void OnTriggerStay2D(Collider2D col ){
		Debug.Log ("me estan tocando me siento incomodo");
		}
		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}