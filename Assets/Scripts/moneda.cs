using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject txt_moneda;
	controlmonedas ctrl_moneda;


	void Start () {
		Destroy (gameObject,3);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (-100, 100));
		txt_moneda = GameObject.Find ("texto_moneda");
		ctrl_moneda =txt_moneda.GetComponent<controlmonedas> ();

	}


		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			ctrl_moneda.suma_monedas (5);
			Destroy (gameObject);
		}
	}
		

}