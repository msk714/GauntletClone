using UnityEngine;
using System.Collections;

public class BossGateUnlock : MonoBehaviour {
	public float animationTime = 5.0f;
	private float startTime = 0.0f;
	private bool wasRun = false;
	public PlayerStats current;

	void OnCollisionEnter(Collision collider)
	{
		if(collider.gameObject.tag == "Player")
		{
			GameObject Player = collider.gameObject;
			current = Player.GetComponent<PlayerStats>();
			if(current.hasBossKey == true)
			{
				this.gameObject.GetComponent<Animation>().Play("Take 001");
				this.gameObject.GetComponent<Collider>().enabled = false;
				current.hasBossKey = false;
				startTime = Time.realtimeSinceStartup;
			}
		}
	}

	void Update()
	{
		if(Time.realtimeSinceStartup >= startTime + animationTime)
		{
			GetComponent<Animation>().Stop();
			wasRun = true;
		}
	
	}
}