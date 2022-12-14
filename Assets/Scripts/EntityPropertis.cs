using TMPro;
using UnityEngine;

public class EntityPropertis : MonoBehaviour
{
    
    // public TextMeshProUGUI textYeux;
    // public TextMeshProUGUI textPeau;
    // public TextMeshProUGUI textCheveux;
    // public TextMeshProUGUI textSexe;
    // public TextMeshProUGUI textAge;
    // public TextMeshProUGUI textId;
    private GameObject ValueProperties;
    public string Eye;
    public string Skin;
    public string Hair;
    public int Sex;
    private int Age = 3;
    private string[] properties = new string[5];

    public void ViewStats(){

         int i = 0;
         foreach (var Value in ValueProperties.GetComponentsInChildren<TextMeshProUGUI>())
         {
            Value.text = properties[i];
            i++;
         }
        // textYeux.text = CouleurYeux;
        // textPeau.text = CouleurPeau;
        // textCheveux.text = CouleurCheveux;
        // textSexe.text = ""+Sexe;
        // textAge.text = ""+Age;
        // textId.text=""+idEntity;
    }
    // Start is called before the first frame update
    void Start()
    {
        ValueProperties = GameObject.FindWithTag("ValueProperties");
        properties[0] = Eye;
        properties[1] = Skin;
        properties[2] = Hair;
        properties[3] = ""+Sex;
        properties[4] = ""+Age;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
