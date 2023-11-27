using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whore : MonoBehaviour
{
    //                          int point
    private void OnTriggerEnter(Collider other)
    {  
        //get component of script
        Ball b = other.gameObject.GetComponent<Ball>();

        if (b != null)
        {
            //GameManger is skuleton can get component without variable
            GameManager.instance.PlayerScore += b.Point;
            GameManager.instance.UpdateScoreText();
            Destroy(b.gameObject);
        }
    }
}
