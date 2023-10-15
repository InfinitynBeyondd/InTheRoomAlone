using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLogicScript : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator MonsterAnimator;
    public AudioSource doorOpenSFX;
    public AudioSource doorCloseSFX;

    public GameObject doorButton;
    public bool doorIsOpenedAlready;

    void Start()
    {
        if (doorButton != null)
        {
            doorButton.SetActive(false);
        }
        doorIsOpenedAlready = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("OpenDoorFunction")]
    public void OpenDoorFunction()
    {
        doorIsOpenedAlready = true;
        doorOpenSFX.Play();
        doorAnimator.Play("DoorOpen", 0, 0.0f);
        GameManagerScript.instance.monsterRate += 1;
        doorButton.SetActive(true);


    }

    [ContextMenu("CloseDoorFunction")]
    public void CloseDoorFunction()
    {
        doorIsOpenedAlready = false;
        doorCloseSFX.Play();
        doorAnimator.Play("DoorClose", 0, 0.0f);
        GameManagerScript.instance.monsterRate -= 1;
        doorButton.SetActive(false);

    }
}
