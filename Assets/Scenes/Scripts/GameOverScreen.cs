using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
 public void SetupGO()
    {
        gameObject.SetActive(true);//gameover screen popups
        Time.timeScale = 0;//pause time
    }

    public void BackToMainMenu()//Take back to main menu
    {
        SceneManager.LoadScene("Menu");//loads menu   
    }

    public void Restart()//Restarts game 
    {
        SceneManager.LoadScene("Game");//load game
        Time.timeScale = 1;//resume time
    }
}
