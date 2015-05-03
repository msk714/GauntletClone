using UnityEngine;
using System.Collections;

public class NetworkClassSelect : MonoBehaviour {
	public GameObject Start;
	
	void OnMouseDown () 
	{
		Debug.Log("I'm clicking!");
		Start.SetActive( true );
	}
}
