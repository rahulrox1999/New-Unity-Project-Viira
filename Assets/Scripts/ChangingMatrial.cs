using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMatrial : MonoBehaviour
{
    public Material[] material;
     Renderer item;

    // Start is called before the first frame update
    void Start()
    {
       item = GetComponent<Renderer>();
        item.enabled= true;
        item.sharedMaterial = material[1];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void material1()
    {
        item.sharedMaterial = material[0];
    }

    public void material2()
    {
        item.sharedMaterial = material[1];
    }

    public void material3()
    {
        item.sharedMaterial = material[3];
    }
}
