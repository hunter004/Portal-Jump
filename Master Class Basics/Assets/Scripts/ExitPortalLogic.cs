using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPortalLogic : MonoBehaviour
{
    public void transportPlayer(GameObject player)
    {
        player.transform.position = gameObject.transform.position;
        player.SetActive(true);
        gameObject.SetActive(false);
    }
}
