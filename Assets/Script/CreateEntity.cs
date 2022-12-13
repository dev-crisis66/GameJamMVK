using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateEntity : MonoBehaviour

{
    public GameObject EntityPrefab;

    public GameObject EntityParent;
    
    // Start is called before the first frame update
    void Start(){}

    public void Create(int nbrEntity)
    {
        // Instantiate(EntityPrefab, new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity,EntityParent.transform);
                
        // for (int i = 0; i < nbrEntity; i++)
        // {
        //     var player =  Instantiate(EntityPrefab, new Vector3(Random.Range(-5, 5),0,Random.Range(-5, 5)),Quaternion.identity,EntityParent.transform);
        //     player.GetComponent<Moves>().name = i.ToString();
        // }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
