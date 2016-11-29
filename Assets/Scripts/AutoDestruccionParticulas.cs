using UnityEngine;
using System.Collections;

public class AutoDestruccionParticulas : MonoBehaviour {

	ParticleSystem sistema_particulas;

	void Start () {
		sistema_particulas  = GetComponent<ParticleSystem> ();
		Destroy (gameObject, sistema_particulas.duration);
	}
}
