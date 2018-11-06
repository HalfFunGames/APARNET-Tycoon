using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public GameObject buyMenu;
    public GameObject sellMenu;
    public GameObject researchMenu;
    public GameObject marketingMenu;
    public GameObject debugButton;
    public GameObject debugScreen;

    public Text tycoonSign;

    private void Start()
    {
        buyMenu.SetActive(true);
        sellMenu.SetActive(true);
        researchMenu.SetActive(true);
        marketingMenu.SetActive(true);
        debugScreen.SetActive(false);
    }

    public Animator buyAnim;
    public Animator sellAnim;
    public Animator marketAnim;
    public bool buyScreen = false;
    public bool sellScreen = false;
    public bool marketScreen = false;

    public void BuyMenu ()
    {
        if (!buyScreen)
        {
            buyAnim.SetTrigger("Open");
            buyScreen = true;
        }
        else
        {
            buyAnim.ResetTrigger("Open");
            buyScreen = false;
        }
    }

    public void SellMenu()
    {
        if (!sellScreen)
        {
            sellAnim.SetTrigger("Open");
            sellScreen = true;
        }
        else
        {
            sellAnim.ResetTrigger("Open");
            sellScreen = false;
        }
    }

    public void MarketMenu()
    {
        if (!marketScreen)
        {
            marketAnim.SetTrigger("Open");
            marketScreen = true;
        }
        else
        {
            marketAnim.ResetTrigger("Open");
            marketScreen = false;
        }
    }

    public void DebugMenu()
    {
        debugButton.SetActive(false);
        debugScreen.SetActive(true);
        tycoonSign.text = "Dev-Mode";
    }
}
