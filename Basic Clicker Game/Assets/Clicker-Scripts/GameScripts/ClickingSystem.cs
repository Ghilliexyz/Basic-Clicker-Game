using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingSystem : MonoBehaviour
{
    public ClickStorage clickStorage;
    public int amountPerClick = 1;
    public void Clicked()
    {
        clickStorage.AddClick(amountPerClick);
        Debug.Log("Clicked!");
    }
}
