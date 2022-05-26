using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ClickStorage : MonoBehaviour
{
    public int amountOfClicks;
    public TextMeshProUGUI ClickTotalAmountText;
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
        Debug.Log("Added: " + amountOfClicks);
    }

    public void RemoveClick(int amount)
    {
        amountOfClicks -= amount;
        saveSystem.SaveClicks(amountOfClicks);
        Debug.Log("Removed: " + amountOfClicks);
    }

    private void Update() {
        UpdateUI();
    }
    
    private void UpdateUI()
    {
        ClickTotalAmountText.SetText(string.Format("{0:n0}", amountOfClicks));
    }
}
