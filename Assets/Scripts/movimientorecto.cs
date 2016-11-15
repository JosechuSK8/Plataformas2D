using UnityEngine;
using System.Collections;

public class movimientorecto : MonoBehaviour {
	public GameObject plataforma;
	public Transform inicio;
	public Transform fin;
	public float velocidad = 10f;
	private Vector3 destino;





	void Start () {
		destino = fin.position;
	}
	

	void Update () {
		plataforma.transform.position = Vector3.MoveTowards (plataforma.transform.position,
			destino,
			velocidad * Time.deltaTime);
	}
}
