using TMPro;
using UnityEngine;

public class EntityPropertis : MonoBehaviour
{
    private GameObject ValueProperties;
    public string Name;
    public string Eye;
    public string Skin;
    public string Hair;
    public int Age;
    public string[] properties;


    public void SetProperties(string eyes, string hair, string skin, string name){
        Eye = eyes;
        Hair = hair;
        Skin = skin;
        Name = name;
        properties = new string[4];
        properties[0] = Eye;
        properties[1] = Hair;
        properties[2] = Skin;
        properties[3] = name;
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = name;
    }




     public void ViewStats(){

          int i = 0;
          foreach (var Value in ValueProperties.GetComponentsInChildren<TextMeshProUGUI>())
          {
             Value.text = properties[i];
             i++;
            }
     }


    // Start is called before the first frame update
    void Start()
    {
        ValueProperties = GameObject.FindWithTag("ValueProperties");
    }
}
