using UnityEngine;
using System.Collections;

public class LeverBarControl : MonoBehaviour {
	public GameObject movingBars1;
	public GameObject movingBars2;
	public GameObject movingBars3;
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
		if(doesDestroy == true)
		{
			Destroy(this.gameObject);
		}
		else
		{
		}
		
	}
	
	
	void Update(){
		if (doesMove == true){
			//movingbars1
			Vector3 posA = new Vector3(movingBars1.transform.position.x,movingBars1.transform.position.y,movingBars1.transform.position.z);
			Vector3 posB = new Vector3(movingBars1.transform.position.x,newYPos,movingBars1.transform.position.z);
			movingBars1.transform.position = Vector3.Lerp (posA, posB, moveSpeed);
			//movingbars2
			Vector3 posC = new Vector3(movingBars2.transform.position.x,movingBars2.transform.position.y,movingBars2.transform.position.z);
			Vector3 posD = new Vector3(movingBars2.transform.position.x,newYPos,movingBars2.transform.position.z);
			movingBars2.transform.position = Vector3.Lerp (posC, posD, moveSpeed);
			//movingbars3
			Vector3 posE = new Vector3(movingBars3.transform.position.x,movingBars3.transform.position.y,movingBars3.transform.position.z);
			Vector3 posF = new Vector3(movingBars3.transform.position.x,newYPos,movingBars3.transform.position.z);
			movingBars3.transform.position = Vector3.Lerp (posE, posF, moveSpeed);
		}
	}
}
