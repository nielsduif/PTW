using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    Button b;

    // Start is called before the first frame update
    void Start()
    {
        b = GetComponent<Button>();
    }

    public void DisableThisButton()
    {
        b.interactable = false;
    }
}
