using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Подключено к серверу");

        PhotonNetwork.JoinOrCreateRoom("Room1",
            new RoomOptions { MaxPlayers = 4 },
            TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Зашли в комнату");

        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
    }
}