using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSfxManager : MonoBehaviour
{
    public AudioSource btnSfx1;

    public void btnSfxPlay()
    {
        btnSfx1.Play();
    }
}
