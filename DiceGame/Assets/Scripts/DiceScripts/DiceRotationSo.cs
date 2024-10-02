using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Dice Rotation Data", menuName = "DiceRotationData")]
public class DiceRotationSo : ScriptableObject
{
    public List<Vector3> rotationsForIndexFaces = new List<Vector3>(7); //Index numbers here represent membrane surface values, do not use index 0.
}

