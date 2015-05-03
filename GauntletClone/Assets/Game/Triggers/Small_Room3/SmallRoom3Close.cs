using UnityEngine;
using System.Collections;

public class SmallRoom3Close : MonoBehaviour {
	public GameObject movingBars;
	public float newYPos;
	private bool doesMove = false;
	public float moveSpeed;
	public float secondsBeforeActivate;
	public float secondsBeforeDestroy;
	public bool doesDestroy = true;
	
	void OnTriggerEnter(Collider other)
	{
		//Debug.Log("You Hit!");
		
		if (other.gameObject.tag == "Player")
		{
			StartCoroutine (CloseGate());
		}
	}
	
	IEnumerator CloseGate()
	{
		yield return new WaitForSeconds(secondsBeforeActivate);
		doesMove = true;
		StartCoroutine (KillYourself ());
	}
	
	IEnumerator KillYourself()
	{
		yield return new WaitForSeconds(secondsBeforeDestroy);
		if(doesDestroy == true){
			Destroy(this.gameObject);
		}
		
	}
	
	
	void Update(){
		if (doesMove == true){
			Vector3 posA = new Vector3(movingBars.transform.position.x,movingBars.transform.position.y,movingBars.transform.position.z);
			Vector3 posB = new Vector3(movingBars.transform.position.x,newYPos,movingBars.transform.position.z);
			movingBars.transform.position = Vector3.Lerp (posA, posB, moveSpeed);
		}
	}
}
