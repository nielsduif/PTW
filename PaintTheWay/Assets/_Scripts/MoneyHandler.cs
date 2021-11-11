using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
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

    void DisplayMoney()
    {
        moneyTxt.text = $"€{money}";
    }
}
