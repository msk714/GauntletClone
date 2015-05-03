using UnityEngine;
using System.Collections;

public class SmallRoomGateUnlock : MonoBehaviour {
	public PlayerStats current;
	
	void OnCollisionEnter(Collision collider)
	{
		if(collider.gameObject.tag == "Player")
		{
			GameObject Player = collider.gameObject;
			current = Player.GetComponent<PlayerStats>();
			
			if(current.numberOfKeys >= 1)
			{
				this.gameObject.GetComponent<Animation>().Play("Take 001");
				this.gameObject.GetComponent<Collider>().enabled = false;
				current.numberOfKeys -= 1;
				Debug.Log(current.numberOfKeys);
			}
		}
	}
	
	
}
