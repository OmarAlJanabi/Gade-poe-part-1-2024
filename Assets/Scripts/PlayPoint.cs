using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPoint : MonoBehaviour
{

    public GameObject homeBase;
    public Text playPoint;
    public int points = 0;
    public GrabFlagPlayer flagPickupScriptPl;
    //counts points when touching base with flag
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerCharacter" &&  flagPickupScriptPl.IsCarryingFlag())
        {
            points++;
            playPoint.text = points.ToString();
            flagPickupScriptPl.RemoveFlag();

        }
    }
}
