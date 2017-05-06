using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineController : MonoBehaviour {

	public static SubmarineController Instance;

	public Transform submarineHolderTransform;
	public Transform cameraTransform;
	public Transform firePointTransform;

	public GameObject torpedoPrefab;

	public float speed = 5;
	public float rotationSpeed = 5f;

	protected bool moving = true;

	void Awake(){
		Instance = this;
	}



	
	// Update is called once per frame
	void Update () {
		if (moving) {
			if (GvrViewer.Instance.Triggered) {
				Instantiate (torpedoPrefab, firePointTransform.position, submarineHolderTransform.rotation);
			}
			//Move gameObject forward
			gameObject.transform.position += submarineHolderTransform.forward * speed * Time.deltaTime;

			//Rotate submarine art to match camera roation, but at a slower rate
			submarineHolderTransform.rotation = Quaternion.Lerp (submarineHolderTransform.rotation, cameraTransform.rotation, rotationSpeed * Time.deltaTime);
		}
		
	}
	void OnTriggerEnter(Collider collider){
		UIHelper_Example.ChangeText ("You Lose!!");
		StopMoving ();
	}

	public void CheckDestructables(){
		int count = GameObject.FindGameObjectsWithTag("Destroy").Length - 1;


		if (count <= 0) {
			//Game ended
			UIHelper_Example.ChangeText ("You Win!");
			StopMoving ();

		} else {
			UIHelper_Example.ChangeText (count + "mines remain!");
		}
	}

	public void StopMoving() {
		moving = false;
	}
}
