using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoController : MonoBehaviour 
{
	public float speed = 10f;
	public GameObject explosionPrefab;

	void Start(){
		Destroy (gameObject, 15f);
	}


	
	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.forward * speed * Time.deltaTime; 
	}
		
	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Destroy") 
		{
			Destroy (collider.gameObject);
			SubmarineController.Instance.CheckDestructables ();
		}

		DestroyMissle();
		
	}
		public void DestroyMissle(){
		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}

}
