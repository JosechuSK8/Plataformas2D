using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Animator))]
	public class MenuScript : MonoBehaviour {
	Animator anim;


	void Start () {
		anim = GetComponent<Animator> ();
	}
	

		void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pausa ();
		}
		}

		public void Pausa (){
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", true);
		}

		public void Salir(){
		Application.Quit ();
		Debug.Log ("Saliendo");


		}

		public void Opciones (){
		anim.SetBool ("opciones", true);
		anim.SetBool ("pausa", true);
		}

	public void continuar (){
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", false);
	}
}
