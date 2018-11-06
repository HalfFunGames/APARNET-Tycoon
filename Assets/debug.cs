using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour {

    public void AddMoneySmall()
    {
        gameObject.GetComponent<money>().moneyAmount += 1;
    }

    public void AddMoneyLarge()
    {
        gameObject.GetComponent<money>().moneyAmount += 10000;
    }

    public void AddMoneyInfi()
    {
        gameObject.GetComponent<money>().moneyAmount = 9999999999999999;
    }

    public void MinusMoneySmall()
    {
        gameObject.GetComponent<money>().moneyAmount -= 1;
    }

    public void MinusMoneyLarge()
    {
        gameObject.GetComponent<money>().moneyAmount -= 10000;
    }

    public void MinusMoneyNone()
    {
        gameObject.GetComponent<money>().moneyAmount = 0;
    }

    public void SellEverything()
    {
        gameObject.GetComponent<money>().computerAmount = 0;
        gameObject.GetComponent<money>().serverAmount = 0;
        gameObject.GetComponent<money>().cableAmount = 0;
    }

    public void CancelAllContracts()
    {
        for (int i = 6; i != -1; i -= 1)
        {
            GameObject.Find("Dropdown").GetComponent<contractselect>().contractTaken[i] = 0;
        }
    }

    public void AddCustomerSmall()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers += 1;
    }

    public void AddCustomerMedium()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers += 100;
    }

    public void AddCustomerLarge()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers += 10000;
    }

    public void MinusCustomerSmall()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers -= 1;
    }

    public void MinusCustomerMedium()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers -= 100;
    }

    public void MinusCustomerLarge()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers -= 10000;
    }

    public void MinusCustomerNone()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().potentialCustomers = 0;
    }

    public void AddCustomerSatisfactionSmall()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction += 1;
    }

    public void AddCustomerSatisfactionLarge()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction += 10;
    }

    public void MinusCustomerSatisfactionSmall()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction -= 1;
    }

    public void MinusCustomerSatisfactionLarge()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction -= 10;
    }

    public void CustomerSatisfactionMin()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction = 0;
    }

    public void CustomerSatisfactionMax()
    {
        GameObject.Find("Dropdown").GetComponent<contractselect>().customerSatisfaction = 100;
    }

}
