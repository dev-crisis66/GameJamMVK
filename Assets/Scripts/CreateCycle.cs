using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class CreateCycle : MonoBehaviour
{


    public GameObject PreFabCycle;

    public string[,] entitiesToBaise = new string[2,4];
    public string[,] entityFetus= new string[30,4];

    public List<string[]> FetusProperties = new List<string[]>();
    private GameObject ValueProperties;

    private int nbCycle = 1;

    //public Transform Parent;
    // Start is called before the first frame update
    private void CheckNbCycle(){
        if(nbCycle >4)
            SceneManager.LoadScene("Start");
        nbCycle++;
    }



    void Start()
    {
        var newCycle = Instantiate(PreFabCycle,transform);
        newCycle.GetComponent<CreateEntity>().number = -1;
        ValueProperties = GameObject.FindWithTag("ValueProperties");
    }

    public void CreateNewCycle(){
        var newcycle = Instantiate(PreFabCycle,transform);
        // Debug.Log("Count Fetus CreateNewCycle : "+FetusProperties.Count);
        newcycle.GetComponent<CreateEntity>().fetusProperties = new List<string[]>(FetusProperties);
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
        // toString();
        // Debug.Log("TRAITEMENT DE LA BAISE");
    
        // Debug.Log("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH"+entitiesToBaise[0,0]);
        string[] Prop = new string[4];
        for (int i = 0; i < 4; i++)
        {
            int blabla = Random.Range(0,2);
            // Debug.Log("Hasard : "+blabla);
            Prop[i] = entitiesToBaise[blabla,i];
        }
        ClearEntityToBaise();
        FetusProperties.Add(Prop);
        // Debug.Log("Count Fetus CONNARK : "+FetusProperties.Count);
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
