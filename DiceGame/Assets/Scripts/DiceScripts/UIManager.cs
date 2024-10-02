using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject dice;
    public GameObject dice2;
    public Button rollButton;

    private void Start()
    {
        dice.SetActive(false);
        dice2.SetActive(false);
    }


    public void OnRollButtonClicked()
    {
        dice.SetActive(true);
        dice2.SetActive(true);
        rollButton.interactable = false;
        rollButton.gameObject.SetActive(false);
        DiceManager.Instance.SimulateThrow();

    }
}
