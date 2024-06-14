using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Agregar variable que establezca la cantiad de 
//veces que se instancia en un alimento
//cuanod se inatancien esa cantidad e alimentos
//no deben instanciarse mas
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement RNG;
    public int maxClones;
    public int clonCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (clonCount < maxClones) { 
        clonCount++;
        RNG.SetRandomPosition();
        GameObject prefab = alimentos[Random.Range(0,alimentos.Length)];
        Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
    }
}
