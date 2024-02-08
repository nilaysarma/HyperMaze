using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoutdownController : MonoBehaviour
{
    public int coutdownTimer = 60;
    public Text coutdownTimerDisplay;
    public GameObject youLoseScreen;
    
    void Start()
    {
        StartCoroutine(CoutdownToStart());
    }

    IEnumerator CoutdownToStart()
    {
        while(coutdownTimer > 0)
        {
            coutdownTimerDisplay.text = coutdownTimer.ToString();

            yield return new WaitForSeconds(1f);

            coutdownTimer--;
        }

        // coutdownTimerDisplay.text = "Time is UP!!";

        yield return new WaitForSeconds(1f);

        coutdownTimerDisplay.gameObject.SetActive(false);
        Debug.Log("Time is UP!!");
        youLoseScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
