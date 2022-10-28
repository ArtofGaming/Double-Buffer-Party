using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party
{
    public List<Lady> guests = new List<Lady>();
    public void update()
    {
        for(int i = 0; i < 3; i++)
        {
            guests[i].update();
            Debug.Log("Party updates lady " + i + guests[i].ladyName);
            
        }
        for (int i = 0; i < 3; i++)
        {
            guests[i].Swap();

        }
        for(int i = 0; i < 3; i++)
        {
            if (guests[i].currentTalking)
            {
                Debug.Log(guests[i].ladyName + " was talking to " + guests[i].facing.ladyName);
                Debug.Log(guests[i].facing.ladyName + "talks to" + guests[i].facing.facing.ladyName);
                Debug.Log(guests[i].facing.facing.ladyName + "talks to" + guests[i].facing.facing.facing.ladyName);
            }
        }
    }
}
