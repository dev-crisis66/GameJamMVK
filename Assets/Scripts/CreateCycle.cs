using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class CreateCycle : MonoBehaviour
{


    public GameObject PreFabCycle;

    public string[,] entitiesToBaise = new string[2,4];

    public List<string[]> FetusProperties = new List<string[]>();
    private GameObject ValueProperties;

    private GameObject ValuePropertiesWin;

    private int nbCycle = 1;

    string[] propertiesWin = new string[3];

    //public Transform Parent;
    // Start is called before the first frame update
    private void CheckNbCycle(){
        if(nbCycle >4)
            SceneManager.LoadScene("Start");
            
            
        nbCycle++;


    }

    private void createWin(){

        string[] ListEyes = {"Marron", "Vert", "Bleu", "Colorer"};
        string[] ListHair = { "Blond", "Roux", "Chauve", "Artiste"};
        string[] ListSkin = {"Vert", "Bleu", "Blanc", "Rouge" };
        
        
        int rnd = Random.Range(0,4);
        propertiesWin[0] = ListEyes[rnd];

        rnd = Random.Range(0,4);
        propertiesWin[1] = ListHair[rnd];

        rnd = Random.Range(0,4);
        propertiesWin[2] = ListSkin[rnd];

        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[0].text = propertiesWin[0];
        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[1].text = propertiesWin[1];
        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[2].text = propertiesWin[2];


        //Pour les tests
/*
        propertiesWin[0] = "Marron";

        propertiesWin[1] = "Blond";

        propertiesWin[2] = "Vert";

        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[0].text = propertiesWin[0];
        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[1].text = propertiesWin[1];
        ValuePropertiesWin.GetComponentsInChildren<TextMeshProUGUI>()[2].text = propertiesWin[2];
*/
        //Fin du test FDP


    }



    void Start()
    {
        var newCycle = Instantiate(PreFabCycle,transform);
        newCycle.GetComponent<CreateEntity>().number = -1;
        ValueProperties = GameObject.FindWithTag("ValueProperties");
        ValuePropertiesWin = GameObject.FindWithTag("ValuePropertiesWin");

        createWin();

    }

    public void CreateNewCycle(){
        var newcycle = Instantiate(PreFabCycle,transform);
        // Debug.Log("Count Fetus CreateNewCycle : "+FetusProperties.Count);
        newcycle.GetComponent<CreateEntity>().fetusProperties = new List<string[]>(FetusProperties);
        newcycle.GetComponent<CreateEntity>().propertiesWin = propertiesWin;
        FetusProperties.Clear();
        CheckNbCycle();
    }



     public void setSelectedEntitie()
    {

        var map = new Dictionary<string, TextMeshProUGUI>(); 
        foreach (var item in ValueProperties.GetComponentsInChildren<TextMeshProUGUI>())
            map.Add(item.transform.name, item);

        string propertiYeux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        string propertiPeau = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
        string propertiCheveux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[2].text;
        if (entitiesToBaise[0,0] == null)
        {
            entitiesToBaise[0,0] = propertiYeux;
            entitiesToBaise[0,1] = propertiPeau;
            entitiesToBaise[0,2] = propertiCheveux;
        }else{
            entitiesToBaise[1,0] = propertiYeux;
            entitiesToBaise[1,1] = propertiPeau;
            entitiesToBaise[1,2] = propertiCheveux;
            AccoupleOn(entitiesToBaise);
        }
        //toString();
    }

    void AccoupleOn(string[,] entitiesToBaise) 
    {
        // toString();
        // Debug.Log("TRAITEMENT DE LA BAISE");
    
        string[] Prop = new string[4];
        for (int i = 0; i < 4; i++)
        {
            int rnd = Random.Range(0,2);
            Prop[i] = entitiesToBaise[rnd,i];
        }
        ClearEntityToBaise();
        FetusProperties.Add(Prop);
        // Debug.Log("Count Fetus  : "+FetusProperties.Count);
    }
    public void ClearEntityToBaise(){
        entitiesToBaise = new string[2,4];
        // toString();
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
