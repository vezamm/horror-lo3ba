using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UIscript : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    [SerializeField] GameObject pauseButton;
    public void pause()
    {
        pausemenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pause();
            Cursor.lockState = CursorLockMode.None;
        }
    }

}