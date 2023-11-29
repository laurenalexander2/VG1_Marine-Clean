using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrapSystem : MonoBehaviour
{
    public int scrap;
    public int repairCost;
    public int upgradeJetCost;
    public int upgradeHullCost;
    public TMP_Text textRepair;
    public TMP_Text textJets;
    public TMP_Text textHull;
    public TMP_Text textScrap;
    
    // Start is called before the first frame update


    // Update is called once per frame
    public void addScrap(int scrapValue)
    {
        scrap += scrapValue;
        textScrap.text = scrap.ToString();
    }
    void Update()
    {

    }
    public void repairShip()
    {
        Debug.Log("pressed");
        if (scrap >= repairCost)
        {
            Debug.Log("sufficent funds");
            scrap = scrap - repairCost;
           
            GameObject.Find("PC").GetComponent<SubmarineHealth>().repair();
           
            textScrap.text = scrap.ToString();

        }
    }
   public void upgradeHull()
    {
        if (scrap >= upgradeHullCost)
        {
            scrap = scrap - upgradeHullCost;
            GameObject.Find("PC").GetComponent<SubmarineHealth>().upgradeHull();
            upgradeHullCost = upgradeHullCost * 2;
            textHull.text = "Upgrade Hull: " + upgradeHullCost.ToString();
            textScrap.text = scrap.ToString();
        }
    }
    public void upgradeJets()
    {
        if(scrap >= upgradeJetCost) {
        scrap = scrap - upgradeJetCost;
        upgradeJetCost = upgradeJetCost * 2;
        GameObject.Find("PC").GetComponent<SimpleMovement>().upgradeJets();
        textJets.text = "Upgrade Jets: " + upgradeJetCost.ToString();
        textScrap.text = scrap.ToString();
    }
    }
}

