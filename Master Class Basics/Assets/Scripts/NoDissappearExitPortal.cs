using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDissappearExitPortal : MonoBehaviour
{
    public void transportPlayer(GameObject player)
    {
        player.transform.position = gameObject.transform.position;
        player.SetActive(true);
    }
}
