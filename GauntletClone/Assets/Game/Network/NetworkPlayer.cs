using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.Characters.ThirdPerson
{

public class NetworkPlayer :Photon.MonoBehaviour {
	public GameObject My_Camera;


	void Awake () {
		if( photonView.isMine){
			My_Camera.SetActive ( true );
			GetComponent<PlayerControl>().enabled = true;
			GetComponent<ThirdPersonUserControl>().enabled = true;
			GetComponent<ThirdPersonCharacter>().enabled = true;
		}
		else if (!photonView.isMine){
				My_Camera.SetActive ( false);
		}
	}
	

}
}
