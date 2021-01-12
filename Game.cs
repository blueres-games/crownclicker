using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;
    public Text Prestige;
    public Text cost1;
    public Text cost2;
    public Text cost3;
    public Text cost4;
    public Text cost10;
    public Text cost11;
    public Text cost12;

    public void Increment()
    {
        GameManager.crowns += (GameManager.PrestigeM + GameManager.multiplier);
        PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
        PlayerPrefs.SetString("PrestigeC", GameManager.PrestigeC.ToString());
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.crowns >= GameManager.BuyPrice1)
        {
            GameManager.multiplier += 1;
            GameManager.crowns -= GameManager.BuyPrice1;
            GameManager.BuyPrice1 = (ulong)(GameManager.BuyPrice1 * 1.4f);
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("BuyPrice1", GameManager.BuyPrice1.ToString());
        }
        if(num == 2 && GameManager.crowns >= GameManager.BuyPrice2)
        {
            GameManager.multiplier += 10;
            GameManager.crowns -= GameManager.BuyPrice2;
            GameManager.BuyPrice2 = (ulong)(GameManager.BuyPrice2 * 1.4f);
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("BuyPrice2", GameManager.BuyPrice2.ToString());
        }
        if(num == 3 && GameManager.crowns >= GameManager.BuyPrice3)
        {
            GameManager.multiplier += 100;
            GameManager.crowns -= GameManager.BuyPrice3;
            GameManager.BuyPrice3 = (ulong)(GameManager.BuyPrice3 * 1.4f);
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("BuyPrice3", GameManager.BuyPrice3.ToString());
        }
        if(num == 4 && GameManager.crowns >= GameManager.BuyPrice4)
        {
            GameManager.multiplier += 1000;
            GameManager.crowns -= GameManager.BuyPrice4;
            GameManager.BuyPrice4 = (ulong)(GameManager.BuyPrice4 * 1.4f);
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("BuyPrice4", GameManager.BuyPrice4.ToString());
        }
        if(num == 10 && GameManager.crowns >= GameManager.BuyPrice10)
        {
            GameManager.multiplier = 0;
            GameManager.PrestigeM += 1000;
            GameManager.crowns = 10;
            GameManager.BuyPrice10 = (ulong)(GameManager.BuyPrice10 * 1.4f);
            GameManager.BuyPrice1 = 20;
            GameManager.BuyPrice2 = 200;
            GameManager.BuyPrice3 = 2000;
            GameManager.BuyPrice4 = 20000;
            GameManager.PrestigeC += 1;
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.PrestigeM.ToString());
            PlayerPrefs.SetString("BuyPrice10", GameManager.BuyPrice10.ToString());
            PlayerPrefs.SetString("PrestigeC", GameManager.PrestigeC.ToString());
        }
        if(num == 11 && GameManager.crowns >= GameManager.BuyPrice11)
        {
            GameManager.multiplier = 0;
            GameManager.PrestigeM += 10000;
            GameManager.crowns = 10;
            GameManager.BuyPrice11 = (ulong)(GameManager.BuyPrice11 * 1.4f);
            GameManager.BuyPrice1 = 20;
            GameManager.BuyPrice2 = 200;
            GameManager.BuyPrice3 = 2000;
            GameManager.BuyPrice4 = 20000;
            GameManager.PrestigeC += 10;
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.PrestigeM.ToString());
            PlayerPrefs.SetString("BuyPrice11", GameManager.BuyPrice11.ToString());
            PlayerPrefs.SetString("PrestigeC", GameManager.PrestigeC.ToString());
        }
        if(num == 12 && GameManager.crowns >= GameManager.BuyPrice12)
        {
            GameManager.multiplier = 0;
            GameManager.PrestigeM += 100000;
            GameManager.crowns = 10;
            GameManager.BuyPrice12 = (ulong)(GameManager.BuyPrice12 * 1.4f);
            GameManager.BuyPrice1 = 20;
            GameManager.BuyPrice2 = 200;
            GameManager.BuyPrice3 = 2000;
            GameManager.BuyPrice4 = 20000;
            GameManager.PrestigeC += 100;
            PlayerPrefs.SetString("crowns", GameManager.crowns.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.multiplier.ToString());
            PlayerPrefs.SetString("multiplier", GameManager.PrestigeM.ToString());
            PlayerPrefs.SetString("BuyPrice12", GameManager.BuyPrice12.ToString());
            PlayerPrefs.SetString("PrestigeC", GameManager.PrestigeC.ToString());
        }
    }

    void Update()
    {
        ui.text = " " + GameManager.crowns;
        Prestige.text = " " + GameManager.PrestigeC;
        cost1.text = " " + GameManager.BuyPrice1;
        cost2.text = " " + GameManager.BuyPrice2;
        cost3.text = " " + GameManager.BuyPrice3;
        cost4.text = " " + GameManager.BuyPrice4;
        cost10.text = " " + GameManager.BuyPrice10;
        cost11.text = " " + GameManager.BuyPrice11;
        cost12.text = " " + GameManager.BuyPrice12;
    }
}