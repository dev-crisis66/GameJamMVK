using TMPro;
using UnityEngine;

public class EntityPropertis : MonoBehaviour
{
    
    public TextMeshProUGUI textYeux;
    public TextMeshProUGUI textPeau;
    public TextMeshProUGUI textCheveux;
    public TextMeshProUGUI textSexe;
    public TextMeshProUGUI textAge;
    public TextMeshProUGUI textId;
    public string CouleurYeux;
    public string CouleurPeau;
    public string CouleurCheveux;
    public int Sexe;
    public int Age;
    public string NomA;
    public int idEntity;

    public void ViewStats(){
        
        textYeux.text = CouleurYeux;
        textPeau.text = CouleurPeau;
        textCheveux.text = CouleurCheveux;
        textSexe.text = ""+Sexe;
        textAge.text = ""+Age;
        textId.text=""+idEntity;
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
