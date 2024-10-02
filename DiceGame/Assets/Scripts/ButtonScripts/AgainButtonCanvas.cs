using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgainButtonCanvas : MonoBehaviour
{
    public Button againButton;
    void Start()
    {
        againButton.gameObject.SetActive(false);
        againButton.GetComponent<AgainButton>();
    }
}
