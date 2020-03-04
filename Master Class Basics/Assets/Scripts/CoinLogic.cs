using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    AudioClip coinSound;

    new Collider collider;
    MeshRenderer meshRenderer;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //add the effect on the game object so that it gives the rotation-y look
        transform.Rotate(Vector3.forward, 1.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(audioSource && coinSound)
        {
            audioSource.PlayOneShot(coinSound);
            // Destroy(gameObject); --don't want to destroy the object or else there will not be any sound that's emitted
            collider.enabled = false;
            meshRenderer.enabled = false;
            gameManager.countCoin();
        }
    }
}
