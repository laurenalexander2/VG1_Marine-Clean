using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapSystem : MonoBehaviour
{
    public int scrap;
    public int repairCost;
    public int upgradeJetCost;
    public int upgradeHullCost;
    // Start is called before the first frame update


    // Update is called once per frame
    public void addScrap(int scrapValue)
    {
        scrap += scrapValue;
    }
    void Update()
    {
        if (scrap >= repairCost)
        {
            repairShip();
        }
    }
    void repairShip()
    {
        if (scrap >= repairCost)
        {
            scrap = scrap - repairCost;
            repairCost = repairCost * 2;
            GameObject.Find("PC").GetComponent<SubmarineHealth>().repair();
           
        }
    }
    void upgradeHull()
    {
        if (scrap >= upgradeHullCost)
        {
            GameObject.Find("PC").GetComponent<SubmarineHealth>().upgradeHull();
            upgradeHullCost = upgradeHullCost * 2;
        }
    }
    void upgradeJets()
    {
        GameObject.Find("PC").GetComponent<SimpleMovement>().upgradeJets();
    }
}

