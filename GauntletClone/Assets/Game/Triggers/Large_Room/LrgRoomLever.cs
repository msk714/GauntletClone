using UnityEngine;
using System.Collections;

public class LrgRoomLever : MonoBehaviour {
	private bool hasSwitched = false;


	void OnTriggerEnter(Collider collider)
	{


		if (collider.gameObject.tag == "Player")
		{
				if(hasSwitched == false)
				{
				this.gameObject.GetComponent<Animation>().Play("left");
				hasSwitched = true;
				}

		}

	}
	

}
