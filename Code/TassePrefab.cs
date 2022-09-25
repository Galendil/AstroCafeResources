using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TassePrefab : MonoBehaviour
{
    public Tasse model;
    public float aDeplacer = 0;
    public float vitesse = 0.1f;

    
    public void Deplacer(float distance)
    {
        aDeplacer = distance;
    }

    public void RemplirBulle()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(aDeplacer >= vitesse)
        {
           transform.Translate(Vector3.right * vitesse);
           aDeplacer -= vitesse;
        }
    }

    public void RecevoirIngrediant(int idIngrediant, int bonus)
    {
        model.RecevoirIngrediant(idIngrediant, bonus);
        RemplirBulle();
    }

}
