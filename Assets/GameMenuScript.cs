using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuScript : MonoBehaviour
{
    //dit laad de game
 public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    //dit quit de game
    public void QuitGame()
    {
        Application.Quit();
    }
}
