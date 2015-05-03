using UnityEngine;
using System.Collections;

public class Update_Position : Photon.MonoBehaviour {

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting){
			stream.SendNext (GetComponent<Rigidbody>().position);
		}
		else{
			GetComponent<Rigidbody>().position = (Vector3)stream.ReceiveNext();
		}
	}

}
