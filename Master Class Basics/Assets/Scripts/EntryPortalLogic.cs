using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPortalLogic : MonoBehaviour
{
    [SerializeField]
    ExitPortalLogic portalExit;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        gameObject.SetActive(false);
        portalExit.transportPlayer(other.gameObject);
    }
}
