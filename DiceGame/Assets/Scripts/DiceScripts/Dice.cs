using System;
using System.Collections.Generic;
using UnityEngine;


public class Dice : MonoBehaviour
{
    [SerializeField] public DiceRotationSo diceRotationData;
    public Transform dice;


    private void ResetDiceRotation()
    {
        dice.rotation = Quaternion.Euler(Vector3.zero);
    }

    public void RotateDice(int desiredValue)
    {
        //rotasyonu sýfýrla
        ResetDiceRotation(); 
        dice.rotation = Quaternion.Euler(diceRotationData.rotationsForIndexFaces[desiredValue]); 
    }


}