using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TassePrefab : MonoBehaviour
{
    public Tasse model;
    public float aDeplacer = 0;
    public float vitesse = (float)0.001;

    public void Deplacer(float distance)
    {
        aDeplacer = distance;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(aDeplacer > 0)
        {
           transform.Translate(Vector3.right * vitesse);
           aDeplacer -= vitesse;
        }
    }
}
