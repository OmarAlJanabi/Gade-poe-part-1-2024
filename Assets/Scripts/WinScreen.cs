using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreenPanel; // Reference to the win screen panel GameObject
    public PlayPoint player;
    public OpponentPoint opp;
    public Text winner;
  
    void Start()
    {
        //hide win screen panel on start
        winScreenPanel.SetActive(false);
    }
    void Update()
    {
        // Check if any player has reached 5 points
        if (player.points >= 5)
        {
            // Show the win screen panel
            winScreenPanel.SetActive(true);
            winner.text = "You Win!";
            
        }
        else if (opp.points >= 5)
        {
            // show the win screen panel
            winScreenPanel.SetActive(true);
            winner.text = "You lose!";
        }
    }
}

