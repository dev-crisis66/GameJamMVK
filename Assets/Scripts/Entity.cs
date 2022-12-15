using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public GameObject prefabEntity;
    public Transform entitiesParent;

    public TextMeshProUGUI nameProperty;
    public TextMeshProUGUI hairProperty;
    public TextMeshProUGUI sexProperty;
    public TextMeshProUGUI eyesProperty;
    public TextMeshProUGUI skinProperty;

    private void Start()
    {
        

        for (int i = 0; i < 4; i++)
        {
            Instantiate(prefabEntity, entitiesParent);
        }
        nameProperty.text = "NAME";
        hairProperty.text = "HAIR";
        sexProperty.text = "SEX";
        eyesProperty.text = "EYES";
        skinProperty.text = "SKIN";
    }
    
    public void AttributeValues(string name, string hair, string sex, string eyes, string skin)
    {
        nameProperty.text = name;
        hairProperty.text = hair;
        sexProperty.text = sex;
        eyesProperty.text = eyes;
        skinProperty.text = skin;
    }
}
