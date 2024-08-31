using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play()//start game
    {
        Time.timeScale = 1;//resume time
        SceneManager.LoadSceneAsync("Game");//load game
    }

    public void Exit()//exit button
    {
    Application.Quit();//close app
    }

}
