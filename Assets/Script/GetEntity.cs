using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEntity : MonoBehaviour
{
    public GameObject targetChild;

    public void getEnt(){
        var text = GetComponent<TextMesh>().text;
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
