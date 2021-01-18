using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log($"Conectei no master (Server: {PhotonNetwork.CloudRegion} | Ping: {PhotonNetwork.GetPing()}), gente!");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Conectei a um lobby, gente!");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log($"Ih, caiu! A causa foi {cause}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
