using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingSystem : MonoBehaviour
{
    public ClickStorage clickStorage;
    public int amountPerClick;
    public void Clicked()
    {
        clickStorage.AddClick(amountPerClick);
        Debug.Log("Clicked!");
    }
}
