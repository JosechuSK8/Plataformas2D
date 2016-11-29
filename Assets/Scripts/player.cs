using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 1f;
	public float fuerza = 100f;
	public float Jump = 400f;
	public bool tocando_suelo = false;
	public GameObject particulas_muerte;
	private Animator animator;
	private Rigidbody2D rb;
	private GameControlScript gcs;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
				}
			

	void Update () {


		animator.SetFloat ("Velocidad", Mathf.Abs (rb.velocity.x));

	
		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocidad*power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}
		if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
				animator.SetBool ("Jump",true); //cuando presiones la tecla A, se activa
				rb.AddForce (transform.up*Jump) ;
				Debug.Log ("Salto");
			}
		if (Input.GetKeyUp (KeyCode.Space)) {
				animator.SetBool ("Jump",false); //cuando presiones la tecla A, se activa
			}
			

		}
		void OnTriggerStay2D(Collider2D objeto) {
			if (objeto.tag == "Suelo") {
			}
		}
		


		void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "muerte") {
			//gcs.respawn ();
			Instantiate(particulas_muerte, transform.position, transform.rotation);

		}

	}

}

