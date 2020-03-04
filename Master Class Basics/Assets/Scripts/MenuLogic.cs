using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToRules()
    {
        SceneManager.LoadScene("ControlsMenu");
    }

    public void GoToGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
