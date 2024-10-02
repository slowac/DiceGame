using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSystem : MonoBehaviour
{
    //Kameralar� atmak i�in.
    public Camera[] cams;
    //Butonlara bunlar� atay�nca bu fonksiyon �al��acak

    public void Cam1()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
    }
    public void Cam2()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
    }
    public void Cam3()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
    }
    public void Cam4()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
    }
}
