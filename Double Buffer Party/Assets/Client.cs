using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    Party table;
    
    //Guest sue = new Guest();

    public void OnButtonClick()
    {
        Debug.Log("button pressed");

        Lady liz = new Lady();
        liz.ladyName = "liz";
        Lady beth = new Lady();
        beth.ladyName = "beth";
        Lady sue = new Lady();
        sue.ladyName = "sue";

        table.guests.Add(sue);
        table.guests.Add(beth);
        table.guests.Add(liz);

        liz.Face(beth);
        beth.Face(sue);
        sue.Face(liz);

        liz.Talk();
        table.update();
    }

    // Start is called before the first frame update
    void Start()
    {
        table = new Party();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
