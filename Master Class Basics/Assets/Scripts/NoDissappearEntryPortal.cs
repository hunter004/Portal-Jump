using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDissappearEntryPortal : MonoBehaviour
{
    [SerializeField]
    NoDissappearExitPortal portalExit;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        portalExit.transportPlayer(other.gameObject);
    }
}
