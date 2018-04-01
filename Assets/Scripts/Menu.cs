using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;

public class Menu : MonoBehaviour {

	//OnClick listener for UI
	public void ChangeScene(string scene)
	{
 		Application.LoadLevel(scene);

	}
}
