using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    public void pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void home()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1.0f;

    }
    public void resume()
    {
        pausemenu?.SetActive(false);
        Time.timeScale = 1.0f;
        
    }
    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
   
}
