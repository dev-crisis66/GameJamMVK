using TMPro;
using UnityEngine;

public class EntityPropertis : MonoBehaviour
{
    
    public TextMeshProUGUI textProprieteYeux;
    public TextMeshProUGUI textProprietePeau;
    public TextMeshProUGUI textProprieteCheveux;
    public TextMeshProUGUI textProprietesexe;
    public TextMeshProUGUI textProprieteAge;
    public TextMeshProUGUI texProprietetId;
    public string Propriete;
    public string CouleurYeux;
    public string CouleurPeau;
    public string CouleurCheveux;
    public int Sexe;
    public int Age;
    public string NomA;
    public int idEntity;

    public void ViewStats(){
        textProprieteYeux.text = CouleurYeux;
        textProprietePeau.text = CouleurPeau;
        textProprieteCheveux.text = CouleurCheveux;
        textProprietesexe.text = ""+Sexe;
        textProprieteAge.text = ""+Age;
        texProprietetId.text=""+idEntity;
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
