using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenerator : MonoBehaviour
{
    public GameObject CirclePrefab;

    private List<GameObject> CircleInstances;

    private void Start()
    {
        CircleInstances = new List<GameObject>();
    }

    public void GenerateCircle()
    {
        CircleInstances.Add((GameObject)Instantiate(CirclePrefab));
    }

    public void HitCircleAtBeat( float beat )
    {
        float circleScale = 100 - Mathf.Abs(100 - CircleInstances[0].transform.localScale.x * 200 );
        Debug.Log(CircleInstances[0].transform.localScale.x);
        Debug.Log("Score: " + circleScale + " / 100");
        Destroy(CircleInstances[0]);
        CircleInstances.RemoveAt(0);
    }

    private void Update()
    {
        if (CircleInstances.Count != 0)
        {
            if (CircleInstances[0].transform.localScale.x < 0)
            {
                HitCircleAtBeat(-1);
            }
        }   
    }
}
