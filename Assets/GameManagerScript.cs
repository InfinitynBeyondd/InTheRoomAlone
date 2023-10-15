using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Globalization;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    [Header("Reference to game objects")]
    public GameObject Door1;
    public DoorLogicScript doorLogic1;
    public GameObject Door2;
    public DoorLogicScript doorLogic2;
    public GameObject Door3;
    public DoorLogicScript doorLogic3;

    public Text TimerCountdownText;
    public Text MonsterLimitText;

    [Header("Important Numbers")]
    [SerializeField] float remainingtime;
    public int monsterRate = 0; //MonsterRate Determines how fast the monster bar fills up, it depends on how many doors are open and how many have been closed
    private float monsterMeter = 0;
    private int monsterMeterLimit = 20; 




    private void Awake()
    {
        instance = this;

        MonsterLimitText.text = "0" + "/" + monsterMeterLimit.ToString();

    }

    private void Update()
    {
        remainingtime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        TimerCountdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (TimerCountdownText.text == "01:50")
        {
            if (doorLogic1.doorIsOpenedAlready != true)
            {
                doorLogic1.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "01:40")
        {
            if (doorLogic2.doorIsOpenedAlready != true)
            {
                doorLogic2.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "01:30")
        {
            if (doorLogic3.doorIsOpenedAlready != true)
            {
                doorLogic3.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "01:20")
        {
            if (doorLogic1.doorIsOpenedAlready != true)
            {
                doorLogic1.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "01:10")
        {
            if (doorLogic2.doorIsOpenedAlready != true)
            {
                doorLogic2.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "01:00")
        {
            if (doorLogic3.doorIsOpenedAlready != true)
            {
                doorLogic3.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "00:50")
        {
            if (doorLogic1.doorIsOpenedAlready != true)
            {
                doorLogic1.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "00:40")
        {
            if (doorLogic2.doorIsOpenedAlready != true)
            {
                doorLogic2.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "00:30")
        {
            if (doorLogic3.doorIsOpenedAlready != true)
            {
                doorLogic3.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "00:20")
        {
            if (doorLogic1.doorIsOpenedAlready != true)
            {
                doorLogic1.OpenDoorFunction();

            }
        }
        if (TimerCountdownText.text == "00:10")
        {
            if (doorLogic2.doorIsOpenedAlready != true)
            {
                doorLogic2.OpenDoorFunction();

            }
        }



        if (remainingtime <= 1) //Once the countdown timer reaches 0 then you win
        {
            SceneManager.LoadScene("WINSCREEN");
        }


        if (monsterMeter >= monsterMeterLimit)
        {
            SceneManager.LoadScene("GAMEOVERSCREEN"); //Once the monster Rate has been complete filled up then the game is over
        }

            if (monsterRate >= 1 && monsterRate >= 0) //This if statement is called if
        {
            monsterMeter += Time.deltaTime * (float)(monsterRate * .75);
            int Monsterminutes = Mathf.FloorToInt(monsterMeter / 60);
            int Monsterseconds = Mathf.FloorToInt(monsterMeter % 60);
            MonsterLimitText.text = Monsterseconds.ToString() + "/" + monsterMeterLimit.ToString();
        }
        




    }

    private void PickRandomDoorToOpen(){

    }

}
