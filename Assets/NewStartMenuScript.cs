using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStartMenuScript : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Credits;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadStartGame()
    {
        SceneManager.LoadScene("TheRoomLighted");
    }

    public void QuitFromGame()
    {
        Application.Quit();
    }

    public void LoadCredits()
    {
        Menu.SetActive(false);
        Credits.SetActive(true);
    }

    public void ExitCredits()
    {
        Credits.SetActive(false);
        Menu.SetActive(true);
        



    }
}
