using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour {

	public float speed = 0.01f;


	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.gameObject.tag == "Coins") {
			ScoreScript.scoreValue += 1;
			Destroy (col.collider.gameObject);


		}

		if (col.collider.gameObject.tag == "Hearts") {
			Destroy (col.collider.gameObject);

		}

		if (col.collider.gameObject.tag == "Stars") {
			Destroy (col.collider.gameObject);

		}
			
	}


	public void ClicEnElBoton() {

			// Le agregp una fuerza hacia arriba 
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 5, ForceMode2D.Impulse);

	}

	// Use this for initialization
	void Start () {
		
	}

	//Esta funcion es invocada cuando el collider 
	// agregado a este gameObject toca otro collider
		
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {

			this.transform.Translate (speed, 0, 0);
		
		}

		if(Input.GetKey (KeyCode.LeftArrow)) {

			this.transform.Translate (-speed, 0, 0);

		}

		// Salto
		//Si la tecla Barra Espaciadora es presionada
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			// Le agregp una fuerza hacia arriba 
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 8, ForceMode2D.Impulse);
		}


	}

}	
