using UnityEngine;
using System.Collections;

public class PickUpBossKey : MonoBehaviour {
	
	public PlayerStats current;
	private GameObject Player = null;
	
	void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			Player = collider.gameObject;
			Debug.Log (Player);
			current = Player.GetComponent<PlayerStats>();
			current.hasBossKey = true;
			Destroy(this.gameObject);
		}
	}
}
