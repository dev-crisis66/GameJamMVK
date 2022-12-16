using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Random = UnityEngine.Random;
public class Accouplement : MonoBehaviour
{
    public string[,] entitiesToBaise = new string[2,4];
    public string[,] entityFetus= new string[30,4];
    private GameObject ValueProperties;
    private int nbEnfant = 0;
    public void setSelectedEntitie()
    {

        //entity.InitialisationEntity();
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
        //toString();
    }

    void AccoupleOn(string[,] entitiesToBaise) 
    {
        toString();
        Debug.Log("TRAITEMENT DE LA BAISE");
    
        Debug.Log("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH"+entitiesToBaise[0,0]);
        Debug.Log("JBKVEDKUBHVDSB   "+nbEnfant);
        entityFetus[nbEnfant,0] = entitiesToBaise[Random.Range(0,2),0];
        entityFetus[nbEnfant,1] = entitiesToBaise[Random.Range(0,2),1];
        entityFetus[nbEnfant,2] = entitiesToBaise[Random.Range(0,2),2];
        entityFetus[nbEnfant,3] = entitiesToBaise[Random.Range(0,2),3];
        nbEnfant++;

    }
    public void Annuler(){
        entitiesToBaise = new string[2,4];
        toString();
    }
    // Start is called before the first frame update
    void Start()
    {



        ValueProperties = GameObject.FindWithTag("ValueProperties");
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