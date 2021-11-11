using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ShopHandler : MonoBehaviour
{
    [SerializeField]
    GameObject shopPanel;
    [SerializeField]
    MoneyHandler MH;
    [SerializeField]
    StartParticle SP;
    [SerializeField]
    FirstPersonController FPC;

    bool inArea;
    public bool InArea
    {
        get { return inArea; }
        set { inArea = value; }
    }

    private void Start()
    {
        shopPanel.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && InArea)
        {
            shopPanel.SetActive(true);
            SP.enabled = false;
            FPC.m_MouseLook.SetCursorLock(false);
            FPC.m_MouseLook.UpdateCursorLock();
            Cursor.visible = true;
        }
        else if(!inArea)
        {
            Hide();
        }
    }

    public void Hide()
    {
        shopPanel.SetActive(false);
        SP.enabled=true;
        FPC.m_MouseLook.SetCursorLock(true);
        FPC.m_MouseLook.UpdateCursorLock();
        Cursor.visible = false;
    }
}
