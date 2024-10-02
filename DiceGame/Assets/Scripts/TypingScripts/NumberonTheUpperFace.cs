using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Lumin;

public class NumberonTheUpperFace : MonoBehaviour
{
    public TMP_Text UpperSideTxt;
    public Vector3Int DirectionValues;
    private Vector3Int OpposingDirectionValues;

    readonly List<string> FaceRepresent = new List<string>() { "", "1", "2", "3", "4", "5", "6" };

    //readonly List<string> FaceRepresent = new List<string>() {"","One","Two","Three","Four","Five","Six"};
    //readonly List<string> FaceRepresent = new List<string>() {"","I","II","III","IV","V","VI"};
    void Start()
    {
        OpposingDirectionValues = 7 * Vector3Int.one - DirectionValues;
    }
   
    public void Update()
    {
        if (transform.hasChanged)
        {
            if (Vector3.Cross(Vector3.up, transform.right).magnitude < 0.5f) //x axis a.b.sin theta <45
                                                                             //if ((int) Vector3.Cross(Vector3.up, transform.right).magnitude == 0) //Previously
            {
                if (Vector3.Dot(Vector3.up, transform.right) > 0)
                {
                    UpperSideTxt.text = FaceRepresent[DirectionValues.x];
                }
                else
                {
                    UpperSideTxt.text = FaceRepresent[OpposingDirectionValues.x];
                }
            }
            else if (Vector3.Cross(Vector3.up, transform.up).magnitude < 0.5f) //y axis
            {
                if (Vector3.Dot(Vector3.up, transform.up) > 0)
                {
                    UpperSideTxt.text = FaceRepresent[DirectionValues.y];
                }
                else
                {
                    UpperSideTxt.text = FaceRepresent[OpposingDirectionValues.y];
                }
            }
            else if (Vector3.Cross(Vector3.up, transform.forward).magnitude < 0.5f) //z axis
            {
                if (Vector3.Dot(Vector3.up, transform.forward) > 0)
                {
                    UpperSideTxt.text = FaceRepresent[DirectionValues.z];
                }
                else
                {
                    UpperSideTxt.text = FaceRepresent[OpposingDirectionValues.z];
                }
            }


            transform.hasChanged = false;
        }
    }
}
