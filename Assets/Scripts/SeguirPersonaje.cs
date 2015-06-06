using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {

	public Transform personaje;
	public float separacion = 6f;

	void Start () {
	
	}
	
	// Función que se ejecutará en cada frame.
	void Update () {
		transform.position = new Vector3(personaje.position.x + separacion, transform.position.y, transform.position.z);
	}
}
