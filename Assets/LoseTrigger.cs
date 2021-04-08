using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    public GameManager gManager;

   void OnTriggerEnter()
    {
        gManager.FellOff();
    }
}
