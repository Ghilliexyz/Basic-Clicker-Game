using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStorage : MonoBehaviour
{
    public int amountOfClicks;
    public SaveSystem saveSystem;
    private void Start() {
        if(PlayerPrefs.HasKey("TotalClicks"))
        {
            int localClicks = PlayerPrefs.GetInt("TotalClicks");
            amountOfClicks = localClicks;
        }
    }
    public void AddClick(int amount) 
    {
        amountOfClicks += amount;
        saveSystem.SaveClicks(amountOfClicks);
        Debug.Log(amountOfClicks);
    }
}
