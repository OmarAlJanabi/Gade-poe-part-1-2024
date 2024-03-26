using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpponentPoint : MonoBehaviour
{

    public GameObject homeBase;
    public Text oppPoint;
    public int points = 0;
    public GrabFlagOpp flagPickupScriptOp;
    //counts points when touching base with flag
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy" && flagPickupScriptOp.IsCarryingFlag())
        {
            points++;
            oppPoint.text = points.ToString();
            flagPickupScriptOp.RemoveFlag();

        }
    }
}