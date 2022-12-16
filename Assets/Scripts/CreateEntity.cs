using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
public class CreateEntity : MonoBehaviour
{

    public GameObject PrefabEntity;
    public GameObject PrefabProperties;

    

    public string[] propertiesWin = new string[3];

    string[] Names = {"Aaren"
,
"Aarika"
,
"Abagael"
,
"Abagail"
,
"Abbe"
,
"Abbey"
,
"Abbi"
,
"Abbie"
,
"Abby"
,
"Abbye"
,
"Abigael"
,
"Abigail"
,
"Abigale"
,
"Abra"
,
"Ada"
,
"Adah"
,
"Adaline"
,
"Adan"
,
"Adara"
,
"Adda"
,
"Addi"
,
"Addia"
,
"Addie"
,
"Addy"
,
"Adel"
,
"Adela"
,
"Adelaida"
,
"Adelaide"
,
"Adele"
,
"Adelheid"
,
"Adelice"
,
"Adelina"
,
"Adelind"
,
"Adeline"
,
"Adella"
,
"Adelle"
,
"Adena"
,
"Adey"
,
"Adi"
,
"Adiana"
,
"Adina"
};
    private string[] ListEyes = {"Marron", "Vert", "Bleu", "Colorer"};
    private string[] ListHair = { "Blond", "Roux", "Chauve", "Artiste"};
    private string[] ListSkin = {"Vert", "Bleu", "Blanc", "Rouge" };



    public List<string[]> fetusProperties = new List<string[]>();
//Nombre rentrer dans CreateCycle
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        if(number == -1){
                        //premiere entiter
            var newEntity = Instantiate(PrefabEntity,transform);
            newEntity.GetComponent<EntityPropertis>().SetProperties(ListEyes[0],ListHair[0],ListSkin[0],Names[0]);

                        //Seconde entiter
            var newEntity2 = Instantiate(PrefabEntity,transform);
            newEntity2.GetComponent<EntityPropertis>().SetProperties(ListEyes[1],ListHair[1],ListSkin[2],Names[10]);

                        //Troisieme entiter
            var newEntity3 = Instantiate(PrefabEntity,transform);
            newEntity3.GetComponent<EntityPropertis>().SetProperties(ListEyes[2],ListHair[2],ListSkin[3],Names[6]);

                        //Quatrieme entiter
            var newEntity4 = Instantiate(PrefabEntity,transform);
            newEntity4.GetComponent<EntityPropertis>().SetProperties(ListEyes[3],ListHair[3],ListSkin[1],Names[8]);

                        //Cinquieme entiter
            var newEntity5 = Instantiate(PrefabEntity,transform);
            newEntity5.GetComponent<EntityPropertis>().SetProperties(ListEyes[2],ListHair[3],ListSkin[0],Names[4]);

            //Cinquieme entiter
            var newEntity6 = Instantiate(PrefabEntity,transform);
            newEntity6.GetComponent<EntityPropertis>().SetProperties(ListEyes[3],ListHair[2],ListSkin[2],Names[5]);
        }else{
            // Debug.Log("Count de fetus : "+fetusProperties.Count);
            for (int i = 0; i < fetusProperties.Count; i++)
            {

                var newEntity = Instantiate(PrefabEntity,transform);
                string[] Prop = fetusProperties[i];
                // Debug.Log("Prop de 0 : "+Prop[0]);
                string eyes = Prop[0];
                string hair = Prop[1];
                string skin = Prop[2];
                string name = Names[Random.Range(0,Names.Length)];
                newEntity.GetComponent<EntityPropertis>().SetProperties(eyes,hair,skin,name);

                // Debug.Log(newEntity.GetComponent<EntityPropertis>().Hair);
                Debug.Log("CA PASSE ?");
                if (Prop[0] == propertiesWin[0] && Prop[1] == propertiesWin[1] && Prop[2] == propertiesWin[2])
                {
                    Debug.Log("BITE");
                    float timeLeft = 40;
                    Debug.Log(timeLeft);
                while ( timeLeft > 0 )
                    {
                        Debug.Log(timeLeft);
                        if ((int)timeLeft == 0)
                        {
                            SceneManager.LoadScene("Win");
                        }
                        timeLeft -= Time.deltaTime;
                    }
                    
                    
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
