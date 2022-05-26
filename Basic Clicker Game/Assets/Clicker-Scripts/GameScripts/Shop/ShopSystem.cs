using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public ClickStorage clickStorage;
    public ClickingSystem clickingSystem;
    public int DoubleClickCost;
    public bool HasDoubleClicks = false;
    public int AutoClickCost;
    public bool HasAutoClicks = false;
    public void DoubleClicks()
    {
        if(clickStorage.amountOfClicks >= DoubleClickCost && HasDoubleClicks == false)
        {
            clickStorage.RemoveClick(DoubleClickCost);
            clickingSystem.amountPerClick = 2;
            HasDoubleClicks = true;
        }else{
            Debug.Log("Not Enough Clicks or you already have this power up");
        }
    }
    public void AutoClicks()
    {
        if(clickStorage.amountOfClicks >= AutoClickCost && HasAutoClicks == false)
        {
            clickStorage.RemoveClick(AutoClickCost);
            InvokeRepeating("AutoClickOn", 1f, 1f);
            HasAutoClicks = true;
        }
    }
    private void AutoClickOn()
    {
        if(HasDoubleClicks == false)
        {
            clickStorage.AddClick(1);
        }
        if(HasDoubleClicks == true)
        {
            clickStorage.AddClick(2);
        }
    }
}
