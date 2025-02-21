using UnityEngine;
using UnityEngine.UI;

public class FpsScript : MonoBehaviour
{
    private float fps;
    public Text FpsCounterText;

    void Start()
    {
        InvokeRepeating("GetFps", 1, 1);
    }

    void GetFps()
    {
        fps = (int)(1f / Time.unscaledDeltaTime);
        FpsCounterText.text = "FPS: " + fps.ToString();
    }
}
