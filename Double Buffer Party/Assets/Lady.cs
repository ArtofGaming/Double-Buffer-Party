using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lady : Guest
{
    public Lady facing;
    
    public void Face(Lady guest)
    {
        facing = guest;
    }

    void update()
    {
        if (nextTalking)
        {
            facing.Talk();
        }
    }
}
