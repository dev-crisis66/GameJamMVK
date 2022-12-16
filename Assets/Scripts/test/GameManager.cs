using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

        public GameObject prefabEntity;
    public Transform entitiesParent;
    
    public string[,] entitiesToBaise = new string[2,4];
    private GameObject ValueProperties;
    public void setSelectedEntitie()
    {

        var map = new Dictionary<string, TextMeshProUGUI>(); 
        foreach (var item in ValueProperties.GetComponentsInChildren<TextMeshProUGUI>())
            map.Add(item.transform.name, item);

        string propertiYeux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        string propertiPeau = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
        string propertiCheveux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[2].text;
        string propertiAge = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[3].text;
        if (entitiesToBaise[0,0] == null)
        {
            entitiesToBaise[0,0] = propertiYeux;
            entitiesToBaise[0,1] = propertiPeau;
            entitiesToBaise[0,2] = propertiCheveux;
            entitiesToBaise[0,3] = propertiAge;
        }else{
            entitiesToBaise[1,0] = propertiYeux;
            entitiesToBaise[1,1] = propertiPeau;
            entitiesToBaise[1,2] = propertiCheveux;
            entitiesToBaise[1,3] = propertiAge;
            AccoupleOn(entitiesToBaise);
        }
        toString();
    }






    void AccoupleOn(string[,] entitiesToBaise) 
    {
        Debug.Log("TEST ON PASSE ICI ?");
        // EntityPropertis proprieter = new EntityPropertis("Marron","NOIR","BLANCHE",0);
        Entity newEntity = new Entity();

        Debug.Log("TRAITEMENT DE LA BAISE");

    }





    public void Annuler(){
        entitiesToBaise = new string[2,4];
        toString();
    }





    
    // Start is called before the first frame update
    void Start()
    {
        ValueProperties = GameObject.FindWithTag("ValueProperties");
        // EntityPropertis proprieter = new EntityPropertis("Marron","NOIR","BLANCHE",0);
        // Entity newEntity = new Entity(proprieter, prefabEntity,entitiesParent);

    }

    





    // Update is called once per frame
    void Update()
    {
    }

    void toString(){
        Debug.Log("-----------------------------------------DEBUT DU TOSTRING-----------------------------------------");
        for (var i = 0; i < 2; i++)
        {
            int iedit=i+1;
            Debug.Log("#######Entity "+iedit+"########");
            for (int y = 0; y < 4; y++)
            {
                Debug.Log(entitiesToBaise[i,y]);
            }
        }
                Debug.Log("-----------------------------------------Fin DU TOSTRING-----------------------------------------");
    }
}