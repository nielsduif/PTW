﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    [SerializeField]
    int money;
    [SerializeField]
    Text moneyTxt;

    // Start is called before the first frame update
    void Start()
    {
        DisplayMoney();
    }

    public void AddMoney()
    {
        money++;
        DisplayMoney();
    }

    public void DeductMoney(int _amount)
    {
        if (money - _amount < 0)
        {
            return;
        }
        money -= _amount;
        DisableButton DB = GameObject.FindObjectOfType<DisableButton>();
        if (DB != null)
        {
            DB.DisableThisButton();
        }
        DisplayMoney();
    }

    void DisplayMoney()
    {
        moneyTxt.text = $"€{money}";
    }
}
