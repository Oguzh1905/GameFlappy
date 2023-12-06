using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    //playerscore
    public int playerscore;

    public Text scoretext;
    //als je dood gaat
    public GameObject gameOverScreen;

    //methode om score te verhogen
    [ContextMenu("Increase Score")]
    public void addscore(int scoreToAdd)
    {
        //verhoogt de score 
        playerscore = playerscore + scoreToAdd;
        //dit laat de score in de tekst zien
        scoretext.text = playerscore.ToString();
    }

    //restert de game
    public void restartGame()
    {
        //reload de huidige scene om het te restarten
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //gameoverscherm activeren
    public void gameOver()
    {
        //dit activeert de gameover scherm
        gameOverScreen.SetActive(true);
    }
}
