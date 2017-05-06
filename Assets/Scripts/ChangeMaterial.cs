using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

	public Material material1;
	public Material material2;
	public MeshRenderer meshRenderer;

	protected bool materialSwapped = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SwitchMaterial(){
		if (materialSwapped) {
			meshRenderer.material = material1;
		} else {
			meshRenderer.material = material2;
		}
		materialSwapped = !materialSwapped;
	}
}
