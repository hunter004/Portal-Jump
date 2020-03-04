using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBoxLogic : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        //load next scene (level to play)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
