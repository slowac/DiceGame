using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSystem : MonoBehaviour
{
    //Kameralarý atmak için.
    public Camera[] cams;
    //Butonlara bunlarý atayýnca bu fonksiyon çalýþacak

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
