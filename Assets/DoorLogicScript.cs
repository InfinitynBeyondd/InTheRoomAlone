using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogicScript : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator MonsterAnimator;
    public AudioSource doorOpenSFX;
    public AudioSource doorCloseSFX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("OpenDoorFunction")]
    public void OpenDoorFunction()
    {
        doorOpenSFX.Play();
        doorAnimator.Play("DoorOpen", 0, 0.0f);
        GameManagerScript.instance.monsterRate += 1;
        
        
    }

    [ContextMenu("CloseDoorFunction")]
    public void CloseDoorFunction()
    {
        doorCloseSFX.Play();
        doorAnimator.Play("DoorClose", 0, 0.0f);
        GameManagerScript.instance.monsterRate -= 1;

    }
}
