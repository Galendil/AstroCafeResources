using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasse
{
    public static int idCounter = 0;
    public int idTasse;
    public int[] recette;
    public int ScoreBonus = 0;
    public bool isActive = true;

    public Tasse(int NbIngrediants)
    {
        recette = new int[NbIngrediants];
        idTasse = idCounter++;
    }

    public Tasse()
    {
        isActive = false;
    }

    public void RecevoirIngrediant(int idIngrediant, int bonus)
    {
        recette[idIngrediant]--;
        ScoreBonus += bonus;
    }

    public int Score()
    {
        return 10 + ScoreBonus;
    }

}



public class TasseManager : MonoBehaviour
{
    public GameObject tassePrefab;


    public int NbIngrediants = 4;
    public int NbTassesTotal = 100;

    public GameObject[] tasses;
    public Tasse[] toutesLesTasses;

    // Start is called before the first frame update
    void Start()
    {
        tasses = new GameObject[NbIngrediants + 2];
        for(int i = 0; i < NbIngrediants + 2; i++)
        {
            tasses[i] = Instantiate(tassePrefab, transform.position, Quaternion.identity);
            tasses[i].GetComponent<TassePrefab>().model = new Tasse();
            tasses[i].SetActive(false);
        }

        toutesLesTasses = new Tasse[NbTassesTotal];
        GenererTasses(100);
    }

    void GenererTasses(int NbTassesAGenerer)
    {
        for (int i = 0; i < NbTassesAGenerer; i++)
        {
            toutesLesTasses[i] = new Tasse(NbIngrediants);
            for(int j = 0; j < 3; j++)
            {
                toutesLesTasses[i].recette[Random.Range(0,NbIngrediants)]++;
            }
        }
    }


    void AjouterTasseSurTapis(int index)
    {
        tasses[0] = Instantiate(tassePrefab, transform.position, Quaternion.identity);
        tasses[0].GetComponent<TassePrefab>().model = toutesLesTasses[index];
    }

    void FaireRoulerTapis()
    {
        EvaluerTasse(tasses[NbIngrediants + 1]);
        for (int i = NbIngrediants + 1; i > 0; i--)
        {
            tasses[i] = tasses[i - 1];
            tasses[i-1].GetComponent<TassePrefab>().Deplacer((float) 3);
        }
    }

    void BalancerIngrediant(int idIngrediant, int bonus)
    {
        if (tasses[idIngrediant].GetComponent<TassePrefab>().model.isActive)
        {
            tasses[idIngrediant].GetComponent<TassePrefab>().model.RecevoirIngrediant(idIngrediant, bonus);
        }
    }

    void EvaluerTasse(GameObject aEvaluer)
    {
        if (!aEvaluer.GetComponent<TassePrefab>().model.isActive)
        {
            Destroy(aEvaluer);
        }
        else
        {
            Destroy(aEvaluer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            FaireRoulerTapis();
            AjouterTasseSurTapis(1);
        }
        
    }

    void End()
    {
    }
}
