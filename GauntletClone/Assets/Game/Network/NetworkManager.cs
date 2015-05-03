using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	const string VERSION = "v0.0.1";
	public string roomName = "GAUNTLET";
	public string playerPrefabName = "ThirdPersonController";
	public string cameraPrefabName = "Main Camera";
	public Transform Player1_Spawnpoint;
	public GameObject Menu;

	void Start () {
		Destroy (Menu);
		PhotonNetwork.ConnectUsingSettings(VERSION);	
	}

	void OnJoinedLobby(){
		RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4};
		PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
	}

	void OnJoinedRoom(){
		//PhotonNetwork.Instantiate(cameraPrefabName, Player1_Spawnpoint.position, Player1_Spawnpoint.rotation, 0);
		PhotonNetwork.Instantiate(playerPrefabName, Player1_Spawnpoint.position, Player1_Spawnpoint.rotation, 0);

	}
}