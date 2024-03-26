using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiUpdate : MonoBehaviour
{
    public GrabFlagPlayer flagPickupScriptPl;
    public GrabFlagOpp flagPickupScriptOp;

    // Reference to the UI Text element
    public Text Player;
    public Text Opponent;

    private void Update()
    {
        // Check if the player is carrying the flag
        if (flagPickupScriptPl.IsCarryingFlag())
        {
            // Update UI text to indicate that the player is carrying the flag
            Player.text = "Carrying Flag";
        }
        else
        {
            // Update UI text to indicate that the player is not carrying the flag
            Player.text = "Not Carrying Flag";
        }
        if (flagPickupScriptOp.IsCarryingFlag())
        // Update UI text to indicate that the opponent is carrying the flag

        {
            Opponent.text = "Carrying Flag";
        }
        // Update UI text to indicate that the opponent is not carrying the flag

        else
        {
            Opponent.text = "Not Carrying Flag";
        }
    }
}
