using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDress : MonoBehaviour {

	public Renderer target;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			rend.enabled = false;
			target.enabled = true; 
		}
	}
}
