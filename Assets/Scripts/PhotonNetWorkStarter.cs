using UnityEngine;
using Mirror;

public class PhotonNetWorkStarter: MonoBehaviour
{
    [SerializeField] DecideHostorClient _DecideHostorClient;


    // ホストボタン押下時に呼ばれる
    public void OnHostStart()
    {
        GetComponent<NetworkManager>().StartHost();
    }

    // クライアントボタン押下時に呼ばれる
    public void OnClientStart()
    {
        GetComponent<NetworkManager>().networkAddress = "localhost"; // IP指定
        GetComponent<NetworkManager>().StartClient();
    }

    // セーバーボタン押下時に呼ばれる
    public void OnServerStart()
    {
        GetComponent<NetworkManager>().StartServer();
    }
}