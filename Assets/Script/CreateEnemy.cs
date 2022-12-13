using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateEnemy : MonoBehaviour

{
    public GameObject EnemyPrefab;

    public GameObject EnemyParent;
    
    // Start is called before the first frame update
    void Start()
    {

        Create(0);

    }

    public void Create(int nbrEnemy)
    {
        // Instantiate(EnemyPrefab, new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity,EnemyParent.transform);
                
        // for (int i = 0; i < nbrEnemy; i++)
        // {
        //     var player =  Instantiate(EnemyPrefab, new Vector3(Random.Range(-5, 5),0,Random.Range(-5, 5)),Quaternion.identity,EnemyParent.transform);
        //     player.GetComponent<Moves>().name = i.ToString();
        // }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
