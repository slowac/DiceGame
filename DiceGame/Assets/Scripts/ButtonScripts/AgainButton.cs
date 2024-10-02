using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class AgainButton : MonoBehaviour
{
    public Button againButton;
    private Rigidbody force;

    void Start()
    {
        force = GetComponent<Rigidbody>();
        againButton.gameObject.SetActive(false);
    }

    void Update()
    {
        if (force.velocity != Vector3.zero)
        {
            againButton.gameObject.SetActive(false);
        }
        else
        {
            againButton.gameObject.SetActive(true);
        }
    }
}
