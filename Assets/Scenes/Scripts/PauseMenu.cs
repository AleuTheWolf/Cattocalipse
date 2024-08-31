using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    GameObject pauseButton;
    [SerializeField] GameObject pauseMenu;
    public void Pause() //pause the game
    {
        Time.timeScale = 0;//pause time
        pauseMenu.SetActive(true);//enable pause menu
        pauseButton.SetActive(false);//disables pause button
    }
    public void BackToMainMenu()//Take back to main menu
    {
        SceneManager.LoadScene("Menu");//load menu
    }

    public void Restart()//Restarts game 
    {
        SceneManager.LoadScene("Game");//load game
        Time.timeScale = 1;//resumes time
        pauseMenu.SetActive(false);//disables pause menu
       pauseButton.SetActive(true);//enables pause button
    }

    public void Resume()//Resume game
    {   
        Time.timeScale = 1;//resume time
        pauseButton.SetActive(true);//enables pause button
        pauseMenu.SetActive(false);//disables pause menu
        
    }
}
