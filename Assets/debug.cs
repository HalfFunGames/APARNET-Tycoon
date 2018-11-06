using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debug : MonoBehaviour {

    public InputField moneyField;
    public InputField customerField;
    public Slider customerSatisfaction;

    public GameObject Dropdown;

    public void addMoney()
    {
        gameObject.GetComponent<money>().moneyAmount += int.Parse(moneyField.text);
    }

    public void minusMoney()
    {
        gameObject.GetComponent<money>().moneyAmount -= int.Parse(moneyField.text);
    }

    public void addCustomer()
    {
        Dropdown.GetComponent<contractselect>().potentialCustomers += int.Parse(customerField.text);
    }

    public void minusCustomer()
    {
        Dropdown.GetComponent<contractselect>().potentialCustomers -= int.Parse(customerField.text);
    }

    public void setCustomerSatisfaction()
    {
	Dropdown.GetComponent<contractselect>().customerSatisfaction = int.Parse(customerSatisfaction.value.ToString());
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

}
