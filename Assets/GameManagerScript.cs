using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
using UnityEngine.UI;

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

    [Header("Important Numbers")]
    [SerializeField] float remainingtime;
    public int monsterRate = 0; //MonsterRate Determines how fast the monster bar fills up, it depends on how many doors are open and how many have been closed
    private float monsterMeter = 0;




    private void Awake()
    {
        instance = this;

    }

    private void FixedUpdate()
    {
        remainingtime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        TimerCountdownText.text = string.Format("{0:00}:{1:00}",minutes,seconds);

        //If (monsterRate > 0){
        // monsterRate = Time.deltaTime * monsterRate;
        //}

        //If (monsterRate > 20){
        // GameOver();
        //}
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
