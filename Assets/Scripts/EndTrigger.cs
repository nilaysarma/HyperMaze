using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // public Text winnerName;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player1")
        {
            // winnerName.text = "Player1";
            gameManager.CompleteLevel();
        }

        // if(collisionInfo.collider.tag == "Player2")
        // {
        //     winnerName.text = "Player2";
        //     gameManager.CompleteLevel();
        // }
    }

    // void OnTriggerEnter()
    // {
    //     gameManager.CompleteLevel();
    // }

}
