using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Accouplement : MonoBehaviour
{

    public string[] entitiesToBaise;
    public GameObject selectedEntities;
    public string propertiId;

    public void setSelectedEntitie()
    {

    }
    Accouplement() {
        entitiesToBaise = new string[2];
    }
    public void AccoupleOn() 
    {

        propertiId = GameObject.Find("ProprieteId").GetComponent<TextMeshProUGUI>().text;
        Debug.Log(propertiId);
        entitiesToBaise[0] = propertiId;
        // entities = GameObject.FindWithTag("Entities").GetComponentsInChildren<GameObject>();
        // var jose = GameObject.FindWithTag("Entities").GetComponentsInChildren<EntityPropertis>();
          
        // foreach (var item in jose)
        // {
        //     Debug.Log(item.GetComponent<EntityPropertis>().idEntity);
        // }
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
