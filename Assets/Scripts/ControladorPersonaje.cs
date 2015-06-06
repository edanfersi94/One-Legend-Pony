using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

	public float fuerzaSalto = 7f; 			// Fuerza con la que saltará el personaje.
	public Transform comprobadorSuelo; 		// Me permite obtener los datos que corresponden a la posición.
	public LayerMask mascaraSuelo; 			// Se utilizará para indicar con que capa colisionará.
	public float velocidad = 2f;

	private bool enElSuelo = true; 			// Para saber si el personaje está tocando el suelo.
	private float comprobarRadio = 0.02f; 		
	private bool dobleSalto = false;		// Me permite verificar si el personaje ha saltado dos veces.
	private bool corriendo = false; 		// Me permite saber si el personaje está en movimiento.

	// .------------------------------------------------------------------------------------------------------------.

	void Start () {
	
	}

	// .------------------------------------------------------------------------------------------------------------.

	// Función que se llamará cada cierto tiempo.
	void FixedUpdate(){
		if (corriendo){
			GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, GetComponent<Rigidbody2D>().velocity.y);
		}

		// Verifico si el personaje está tocando el suelo.
		enElSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobarRadio, mascaraSuelo);
		if (enElSuelo){
			dobleSalto = false;
		}

	}
	
	// .------------------------------------------------------------------------------------------------------------.
	
	// Función que se ejecutará en cada frame.
	void Update (){
		if(Input.GetMouseButtonDown(0)){
			corriendo = true;
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaACorrer");
		}
		// Esto se hace porque es un infinity runner.
		if (Input.GetKey(KeyCode.Space)){
			if (corriendo){

				// Se hace que salte si es que puede saltar.
				if (enElSuelo || !dobleSalto){
					GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, fuerzaSalto);
				
					if (!dobleSalto && !enElSuelo){
						dobleSalto = true;
					}
				}
			}
		}		
	}

	// .------------------------------------------------------------------------------------------------------------.

}