using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {

    public float moneyAmount;
    public Text moneyText;
    
    public float computerBuy;
    public int computerAmount;
    public Text computerText;
    public Text computerBuyText;
  
    public float serverBuy;
    public int serverAmount;
    public Text serverText;
    public Text serverBuyText;
  
    public float cableBuy;
    public int cableAmount;
    public Text cableText;
    public Text cableBuyText;

    public void Start() {
      computerBuy = 100;
      serverBuy = 1500;
      cableBuy = 50;
      computerText.text = computerAmount.ToString();
      serverText.text = serverAmount.ToString();
      cableText.text = cableAmount.ToString();
      computerBuyText.text = computerBuy.ToString();
      serverBuyText.text = serverBuy.ToString();
      cableBuyText.text = cableBuy.ToString();
    }
  
    public void Update() {
        moneyText.text = moneyAmount.ToString();
        
        computerText.text = computerAmount.ToString();
        computerBuyText.text = CostCalculator(computerBuy, computerAmount).ToString();
        
        serverText.text = serverAmount.ToString();
        serverBuyText.text = CostCalculator(serverBuy, serverAmount).ToString();
        
        cableText.text = cableAmount.ToString();
        cableBuyText.text = CostCalculator(cableBuy, cableAmount).ToString();
    }

    public void BuyComputer() {
        if (moneyAmount >= CostCalculator(computerBuy, computerAmount))
        {
            moneyAmount -= CostCalculator(computerBuy, computerAmount);
            computerAmount++;
        }
    }

    public void BuyServer() {
        if (moneyAmount >= CostCalculator(serverBuy, serverAmount))
        {
            moneyAmount -= CostCalculator(serverBuy, serverAmount);
            serverAmount++;
        }
    }

    public void BuyCable()
    {
        if (moneyAmount >= CostCalculator(cableBuy, cableAmount))
        {
            moneyAmount -= CostCalculator(cableBuy, cableAmount);
            cableAmount++;
        }
    }

    public int CostCalculator(float baseprice, int owned)
    {
        int cost = Mathf.RoundToInt(baseprice);

        if (owned != 0)
        {
            for (int i = owned; i >= 0; i--)
            {
                cost += Mathf.RoundToInt(baseprice * 0.1f);
            }
        }
      
        return cost;
    }
}