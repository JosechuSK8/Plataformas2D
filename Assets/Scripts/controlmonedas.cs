using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlmonedas : MonoBehaviour {
	private int monedas = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
		resetear ();
		//suma_monedas (11);
	}

	public void suma_monedas(int cantidad){
		monedas = monedas + cantidad; //monedas += cantidad;

		if (monedas < 0) {
			monedas = 0;

		}

		texto.text = monedas.ToString ();

		Debug.Log ("Monedas: " + monedas);

	}

	public void resetear(){
		monedas = 0;
		texto.text = monedas.ToString ();

	}
}