using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contractselect : MonoBehaviour {
    
    public Dropdown contractSelect;
    public Text customerText;
    public Text computingText;
    public Text cableText;
    public Text potentialCustomersText;
    public Text customerSatisfactionText;
    public Text dayCounter;
    public Text incomeCounter;
    public Text computingNeedText;
    public Text cableNeedText;
    public Text computingHaveText;
    public Text cableHaveText;


    public int[] customer;
    public int[] computing;
    public int[] cable;
    public int[] income;
    int currentContract = 0;
    public int[] contractTaken;

    public int contractMoney;
    //public bool ContractActive;
    //public int ContractDay;
    public int dayNumber = 0;

    public int customerSatisfaction = 100;
    public int potentialCustomers = 1;

    public void SelectNewContract()
    {
        customerText.text = customer[contractSelect.value].ToString();
        computingText.text = computing[contractSelect.value].ToString() + "Hz";
        cableText.text = cable[contractSelect.value].ToString();
        currentContract = contractSelect.value;
    }

    //Add contract
    public void AcceptNewContract()
    {
        if (potentialCustomers >= customer[currentContract] && customerSatisfaction > 49)
        {
            contractTaken[currentContract]++;
            potentialCustomers -= customer[currentContract];
        }
    }

    //Add the money

    public void Start()
    {
        InvokeRepeating("UpdateMoney", 1, 1);
        InvokeRepeating("CheckIfLoseCustomer", 1, 1);
    }

    public void Update()
    {
        customerSatisfactionText.text = customerSatisfaction.ToString();
        potentialCustomersText.text = potentialCustomers.ToString();
        dayCounter.text = dayNumber.ToString();
        incomeCounter.text = contractMoney.ToString();
        computingNeedText.text = contractComputing.ToString() + "Hz";
        cableNeedText.text = contractCable.ToString();
        computingHaveText.text = CalculateComputingPower.ToString() + "Hz";
        cableHaveText.text = GameObject.Find("Canvas").GetComponent<money>().cableAmount.ToString();
        //Calculate how much money to get
        contractMoney = 0;
        for (int i = 6; i != -1; i -= 1)
        {
            contractMoney += contractTaken[i] * income[i];
        }
    }

    public void UpdateMoney() 
    {
        /*if (ContractActive == true) {
            ContractDay -= 1;
            MoneyPerSecond;
            if (ContractDay == 0) {
               ContractActive = false;
            }
        }*/
        MoneyPerSecond();
        dayNumber++;
    }

    public void MoneyPerSecond() 
    {
        GameObject.Find("Canvas").GetComponent<money>().moneyAmount += contractMoney;
    }
    
    public int contractComputing;
    public int contractCable;


    public int CalculateComputingPower
    {
        get
        {
            int i = 0;
            i = GameObject.Find("Canvas").GetComponent<money>().computerAmount * 1 * 1;//Replace with link to research script and calculate efficency upgrade
            i += GameObject.Find("Canvas").GetComponent<money>().serverAmount * 10 * 1;//Replace with link to research script and calculate efficency upgrade
            return i;
        }
    }

    public void CheckIfLoseCustomer()
    {
        contractComputing = 0;
        for (int i = 6; i != -1; i -= 1)
        {
            contractComputing += contractTaken[i] * computing[i];
        }
        contractCable = 0;
        for (int i = 6; i != -1; i -= 1)
        {
            contractCable += contractTaken[i] * cable[i];
        }
        if (contractComputing > CalculateComputingPower|| contractCable > GameObject.Find("Canvas").GetComponent<money>().cableAmount)
        {
            for (int i = 6; i != -1; i -= 1)
            {
                if (contractTaken[i] != 0)
                {
                    contractTaken[i] -= 1;
                    customerSatisfaction /= 3;
                    i = 0;
                }
            }
        }
        else if (customerSatisfaction < 100)
        {
            customerSatisfaction += 1;
        }
        else if (customerSatisfaction > 100)
        {
            customerSatisfaction = 100;
        }
    }

    public void PosterAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 500)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 500;
            potentialCustomers += 3;
        }
    }

    public void NewspaperAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 1000)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 1000;
            potentialCustomers += 10;
        }
    }

    public void BillboardAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 2000)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 2000;
            potentialCustomers += 25;
        }
    }

    public void RadiorAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 5000)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 5000;
            potentialCustomers += 75;
        }
    }

    public void TVAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 10000)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 1000;
            potentialCustomers += 200;
        }
    }

    public void AlienAd()
    {
        if (GameObject.Find("Canvas").GetComponent<money>().moneyAmount >= 9999999999999999999)
        {
            GameObject.Find("Canvas").GetComponent<money>().moneyAmount -= 9999999999999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
            potentialCustomers += 999999999;
        }
    }

}
