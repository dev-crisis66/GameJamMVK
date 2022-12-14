using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Accouplement : MonoBehaviour
{

    public string[,] entitiesToBaise = new string[2,5];
    public GameObject selectedEntities;

    public void setSelectedEntitie()
    {

    }
    Accouplement() {
        //entitiesToBaise = new string[2];
    }
    public void AccoupleOn() 
    {
        string propertiYeux = GameObject.Find("ProprieteCouleurYeux").GetComponent<TextMeshProUGUI>().text;
        string propertiPeau = GameObject.Find("ProprieteCouleurPeau").GetComponent<TextMeshProUGUI>().text;
        string propertiCheveux = GameObject.Find("ProprieteCouleurCheveux").GetComponent<TextMeshProUGUI>().text;
        string propertiSexe = GameObject.Find("ProprieteSexe").GetComponent<TextMeshProUGUI>().text;
        string propertiAge = GameObject.Find("ProprieteAge").GetComponent<TextMeshProUGUI>().text;
        string propertiId = GameObject.Find("ProprieteId").GetComponent<TextMeshProUGUI>().text;
        Debug.Log(propertiId);
        //entitiesToBaise[].

        entitiesToBaise[0,0] = propertiId;
        Debug.Log(entitiesToBaise);
        // entities = GameObject.FindWithTag("Entities").GetComponentsInChildren<GameObject>();
        // var jose = GameObject.FindWithTag("Entities").GetComponentsInChildren<EntityPropertis>();
          
        // foreach (var item in jose)
        // {
        //     Debug.Log(item.GetComponent<EntityPropertis>().idEntity);
        // }
    }


    public void Annuler(){
        entitiesToBaise = new string[2,5];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
