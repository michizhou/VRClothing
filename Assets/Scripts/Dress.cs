using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using UnityEngine.UI;


public class Dress : MonoBehaviour {

	public Renderer rend;


	void Start()
	{
		rend = GetComponent<Renderer>();
		rend.enabled = false;
 	}

	 
}
