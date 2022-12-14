using UnityEngine;
using TMPro;
public class Accouplement : MonoBehaviour
{
    public string[,] entitiesToBaise = new string[2,5];
    private GameObject ValueProperties;
    public void setSelectedEntitie()
    {
        
        //string propertiYeux = GameObject.Find("ProprieteCouleurYeux").GetComponent<TextMeshProUGUI>().text;
        //string propertiPeau = GameObject.Find("ProprieteCouleurPeau").GetComponent<TextMeshProUGUI>().text;
        //string propertiCheveux = GameObject.Find("ProprieteCouleurCheveux").GetComponent<TextMeshProUGUI>().text;
        //string propertiSexe = GameObject.Find("ProprieteSexe").GetComponent<TextMeshProUGUI>().text;
        //string propertiAge = GameObject.Find("ProprieteAge").GetComponent<TextMeshProUGUI>().text;
        //string propertiId = GameObject.Find("ProprieteId").GetComponent<TextMeshProUGUI>().text;


        string propertiYeux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[0].text;
        string propertiPeau = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[1].text;
        string propertiCheveux = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[2].text;
        string propertiSexe = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[3].text;
        string propertiAge = ValueProperties.GetComponentsInChildren<TextMeshProUGUI>()[4].text;
        if (entitiesToBaise[0,0] == null)
        {
            entitiesToBaise[0,0] = propertiYeux;
            entitiesToBaise[0,1] = propertiPeau;
            entitiesToBaise[0,2] = propertiCheveux;
            entitiesToBaise[0,3] = propertiSexe;
            entitiesToBaise[0,4] = propertiAge;
        }else{
            entitiesToBaise[1,0] = propertiYeux;
            entitiesToBaise[1,1] = propertiPeau;
            entitiesToBaise[1,2] = propertiCheveux;
            entitiesToBaise[1,3] = propertiSexe;
            entitiesToBaise[1,4] = propertiAge;
            AccoupleOn(entitiesToBaise);
        }
        toString();
    }

    void AccoupleOn(string[,] entitiesToBaise) 
    {
        Debug.Log("TRAITEMENT DE LA BAISE");
    }
    public void Annuler(){
        entitiesToBaise = new string[2,5];
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
            for (int y = 0; y < 5; y++)
            {
                Debug.Log(entitiesToBaise[i,y]);
            }
        }
                Debug.Log("-----------------------------------------Fin DU TOSTRING-----------------------------------------");
    }
}