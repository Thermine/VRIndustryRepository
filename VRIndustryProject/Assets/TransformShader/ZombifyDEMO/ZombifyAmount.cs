using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombifyAmount : MonoBehaviour {
	public Material[] _skinMaterials;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Zombify(float z){
	
		foreach (Material  mats in _skinMaterials) {

			mats.SetFloat ("_DissolveAmount", z);

		}

	}
}
