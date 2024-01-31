using UnityEngine;
using Mirror;

public class PhotonNetWorkStarter: MonoBehaviour
{
    [SerializeField] DecideHostorClient _DecideHostorClient;
    private NetworkManager _networkManager;
    private void Start()
    {
        _networkManager = GetComponent<NetworkManager>();
    }

    // ホストボタン押下時に呼ばれる
    public void OnHostStart()
    {
        _networkManager.StartHost();
    }

    // クライアントボタン押下時に呼ばれる
    public void OnClientStart()
    {
        _networkManager.networkAddress = "localhost"; // IP指定
        _networkManager.StartClient();
    }

    // セーバーボタン押下時に呼ばれる
    public void OnServerStart()
    {
        _networkManager.StartServer();
    }
}