using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public int TotalClicksSaved;
    private void Start() {
        if(PlayerPrefs.HasKey("TotalClicks"))
        {
            int localClicks = PlayerPrefs.GetInt("TotalClicks");
            TotalClicksSaved = localClicks;
        }
    }
    public void SaveClicks(int clickAmountsToSave)
    {
        PlayerPrefs.SetInt("TotalClicks", clickAmountsToSave);
        TotalClicksSaved = clickAmountsToSave;
    }
}
