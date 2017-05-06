using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickMaterial : MonoBehaviour {

//	public Transform goTransform;

	// Use this for initialization
	void Start () {
//		goTransform = gameObject.GetComponents <Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GvrViewer.Instance.Triggered) {
			print ("Hello!!");
			transform.Rotate (new Vector3 (45, 45, 45));

		}	
	}
}
