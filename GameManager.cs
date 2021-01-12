using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static ulong crowns;
    public static ulong multiplier;
    public static ulong PrestigeC;
    public static ulong PrestigeM;
    public static ulong BuyPrice1;
    public static ulong BuyPrice2;
    public static ulong BuyPrice3;
    public static ulong BuyPrice4;
    public static ulong BuyPrice10;
    public static ulong BuyPrice11;
    public static ulong BuyPrice12;
    void Start()
    {
        multiplier = System.Convert.ToUInt64(PlayerPrefs.GetString("multiplier", "1"));
        crowns = System.Convert.ToUInt64(PlayerPrefs.GetString("crowns", "10"));
        BuyPrice1 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice1", "20"));
        BuyPrice2 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice2", "200"));
        BuyPrice3 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice3", "2000"));
        BuyPrice4 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice4", "20000"));
        BuyPrice10 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice10", "2000000"));
        BuyPrice11 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice11", "20000000"));
        BuyPrice12 = System.Convert.ToUInt64(PlayerPrefs.GetString("BuyPrice12", "200000000"));
        PrestigeC = System.Convert.ToUInt64(PlayerPrefs.GetString("PrestigeC", "0"));
        PrestigeM = System.Convert.ToUInt64(PlayerPrefs.GetString("PrestigeM", "0"));
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
