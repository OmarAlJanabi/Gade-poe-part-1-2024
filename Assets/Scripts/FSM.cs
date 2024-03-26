using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FSM : MonoBehaviour
{
    public enum State
    {
        Idle,
        FindFlag,
        ChaseOpponent, //different states for the fsm
        ReturnFlag,
    }
    public Transform RedFlag;
    public Transform BlueFlag;
    public Transform PlayerCharacter;
    private NavMeshAgent agent;
    public State state;
    public GrabFlagPlayer flagPickupScriptPl;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        state = State.FindFlag;
       
    }
    void Update() //checks the current state of the ai
         
    {

        if (state == State.FindFlag)
            FindFlag();
        if (state == State.ChaseOpponent)
            ChaseOpponent();
        if (state == State.ReturnFlag)
            ReturnFlag();
    }
    //sends the enemy ai to find the flag and chases the player only on its way to find the flag
    private void FindFlag()
    {
        agent.destination = RedFlag.position;
        if(GrabFlagOpp.instance.IsCarryingFlag() == true)
        {
            state = State.ReturnFlag;
          
        }
        else if (flagPickupScriptPl.IsCarryingFlag())
        {
            state = State.ChaseOpponent;
        }

    }

    //sets the enemy ai to chase the player if a flag is held
    private void ChaseOpponent()
    { 
        agent.destination = PlayerCharacter.position;
        if (!flagPickupScriptPl.IsCarryingFlag())
            {
            state = State.ReturnFlag;
            }
     
        
        
    }
    //returns to base to return the flag, will not chase opponent on return
    private void ReturnFlag()
    {
        agent.destination = BlueFlag.position;
        if (GrabFlagOpp.instance.IsCarryingFlag() == false)
        {
            state = State.FindFlag;
        }
       
    }
  
}
