using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    [SerializeField]
    int money;
    [SerializeField]
    Text moneyTxt;
    [SerializeField]
    Button A;
    [SerializeField]
    bool firstRun;
    [SerializeField]
    StartParticle SP;

    [SerializeField]
    GoggleManager GM;

    // Start is called before the first frame update
    void Start()
    {
        if (firstRun)
        {
            PlayerPrefs.SetInt("Money", 0);
        }
        else
        {
            money = PlayerPrefs.GetInt("Money");
        }
        DisplayMoney();
    }

    public void AddMoney()
    {
        money += 1;
        DisplayMoney();
    }

    public void BossMoneyVision(int _amount)
    {
        if (money - _amount < 0)
        {
            return;
        }
        money -= _amount;
        if (GM != null)
        {
            GM.ActicateGoggles();
        }
        DisplayMoney();
    }

    public void DeductMoney(int _amount)
    {
        if (money - _amount < 0)
        {
            return;
        }
        money -= _amount;
        if (SP != null)
        {
            SP.MaxAmmo = 5;
        }
        if (A != null)
        {
            A.interactable = false; ;
        }
        DisplayMoney();
    }

    void DisplayMoney()
    {
        moneyTxt.text = $"€{money}";
    }

    public void StoreMoney()
    {
        PlayerPrefs.SetInt("Money", money);
    }
}
