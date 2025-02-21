using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public LevelScript levelScript;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        levelScript.Pass();
        // AdManager.Instance.ShowInterstitial();
    }

}
