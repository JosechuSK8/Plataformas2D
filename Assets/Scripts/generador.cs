using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {
		public GameObject moneda;

	void OnTriggerEnter2D(Collider2D Objeto){
		if (Objeto.tag == "Player") {
			Instantiate (moneda, transform.position, transform.rotation);


		}
	}
}