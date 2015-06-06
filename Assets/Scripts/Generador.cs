using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 1.5f;
	public float tiempoMax = 3f;

	// .------------------------------------------------------------------------------------------------------------.

	// Se llmará una sola vez.
	void Start () {
		// Cuando el personaje comience a correr es que se generarán los bloques 
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
	}

	// .------------------------------------------------------------------------------------------------------------.

	// Función que se llamará cuando haya una notificación (que se está moviendo el personaje).
	void PersonajeEmpiezaACorrer(Notification notificacion){
		Generar();
	}
	
	// .------------------------------------------------------------------------------------------------------------.	

	void Update () {
	
	}

	// .------------------------------------------------------------------------------------------------------------.

	void Generar(){

		// Se eligirá aleatoriamente uno de los tres objetos (bloque corto, mediano y largo).
		Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
	}

	// .------------------------------------------------------------------------------------------------------------.

}
