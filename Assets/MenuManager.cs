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
    public GameObject debugPanel;

    public Text tycoonSign;

    private void Start()
    {
        buyMenu.SetActive(true);
        sellMenu.SetActive(true);
        researchMenu.SetActive(true);
        marketingMenu.SetActive(true);
        debugPanel.SetActive(false);
    }

    public Animator buyAnim;
    public Animator sellAnim;
    public Animator marketAnim;
    public bool buyScreen = false;
    public bool sellScreen = false;
    public bool marketScreen = false;
    public bool debugScreen = false;

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
	if (!debugScreen)
        {
            debugButton.SetActive(false);
            debugPanel.SetActive(true);
            tycoonSign.text = "Debug";
	    debugScreen = true;
        }
        else
        {
            debugButton.SetActive(true);
            debugPanel.SetActive(false);
            debugScreen = false;
        }
    }
}
