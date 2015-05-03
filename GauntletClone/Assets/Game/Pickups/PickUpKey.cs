using UnityEngine;
using System.Collections;

public class PickUpKey : MonoBehaviour {

	public PlayerStats current;
	private GameObject Player = null;

	void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			Player = collider.gameObject;
			current = Player.GetComponent<PlayerStats>();
			current.numberOfKeys += 1;
			Destroy(this.gameObject);
		}
	}
}
