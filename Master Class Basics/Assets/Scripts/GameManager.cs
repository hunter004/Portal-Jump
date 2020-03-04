using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject LevelEndPortal;
    [SerializeField]
    GameObject[] coins;

    int coinCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //disable the level end portal until all coins have been collected
        LevelEndPortal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(coinCounter == coins.Length)
        {
            LevelEndPortal.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            restartGame();
        }
    }

    public void countCoin()
    {
        coinCounter++;
    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
