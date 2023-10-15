using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
using UnityEngine.UI;
using System.Globalization;

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

    private void FixedUpdate()
    {
        remainingtime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        TimerCountdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);



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
