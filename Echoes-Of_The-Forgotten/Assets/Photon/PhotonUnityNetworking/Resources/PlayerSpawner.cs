using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3)), Quaternion.identity);
    }
}
