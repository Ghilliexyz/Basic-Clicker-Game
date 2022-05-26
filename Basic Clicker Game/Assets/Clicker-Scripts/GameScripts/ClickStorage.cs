using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStorage : MonoBehaviour
{
    public int amountOfClicks;
    public void AddClick(int amount) 
    {
        amountOfClicks += amount;
        Debug.Log(amountOfClicks);
    }
}
