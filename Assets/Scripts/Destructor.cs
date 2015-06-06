using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// .------------------------------------------------------------------------------------------------------------.

	void Start () {
	
	}

	// .------------------------------------------------------------------------------------------------------------.	
	
	void Update () {
	
	}

	// .------------------------------------------------------------------------------------------------------------.

	// Cuando entre en contacto con el objeto destructor se ejecutará este método.
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			// Se termina la ejecución del juego.
			Debug.Break();

			// AQUÍ VAN LAS COSAS QUE SUCEDERÁN DESPUÉS DE
			// QUE HAYA PERDIDO EL JUGADOR.
		
		}else{
			Destroy(other.gameObject);	
		}
	}

	// .------------------------------------------------------------------------------------------------------------.

}
