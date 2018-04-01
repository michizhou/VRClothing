using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PrintInfo()
	{
		print (this);
	}

	public void DestroyWrapper()
	{
		Destroy (this.gameObject);
	}

	//function called by OnGraspend
	public void StartDestroyCountdown()
	{
		Invoke ("DestroyWrapper", 3);
	}


}
