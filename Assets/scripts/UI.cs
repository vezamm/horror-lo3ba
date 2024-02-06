using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UIscript : MonoBehaviour
{
    public GameObject codemenu;  
    [SerializeField] GameObject pausemenu;
    [SerializeField] GameObject pauseButton;
    [SerializeField] playermove playermovescript;
    [SerializeField] GameObject Inventory;
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playermovescript.Togglecamrot(false);
            pause();
            Cursor.lockState = CursorLockMode.None;
            codemenu.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Tab))
            Inventoryonoroff();
    }
    private void Inventoryonoroff()
    {
        if (Inventory != null)
        {
            Inventory.SetActive(!Inventory.activeSelf);
        }
    }

}