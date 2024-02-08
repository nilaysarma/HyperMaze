using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUpCountdown : MonoBehaviour
{
    public int coutdownTime = 3;
    public Text coutdownDisplay;
    public JoystickMovement joystickMovement;
    public PlayerMovement2 playerMovement2;
    
    void Start()
    {
        StartCoroutine(CoutdownToStart());
    }

    IEnumerator CoutdownToStart()
    {
        while(coutdownTime > 0)
        {
            coutdownDisplay.text = coutdownTime.ToString();

            yield return new WaitForSeconds(1f);

            coutdownTime--;
        }

        joystickMovement.enabled = true;
        playerMovement2.enabled = true;
        coutdownDisplay.text = "GO!!";

        yield return new WaitForSeconds(1f);

        coutdownDisplay.gameObject.SetActive(false);
    }
}
