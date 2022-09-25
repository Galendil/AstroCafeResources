using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenerator : MonoBehaviour
{
    public GameObject CirclePrefab;

    private List<GameObject> CircleInstances;
    private int currentBeat;
    public MusicManager mMusicManager;

    private void Start()
    {
        currentBeat = 0;
        mMusicManager = GameObject.FindObjectOfType<MusicManager>();
        CircleInstances = new List<GameObject>();
    }

    public void GenerateCircle()
    {
        int beat = mMusicManager.GetCurrentBeat() % 4;
        GameObject obj;
        if ( beat == 0 )
            obj = GameObject.Find("1");
        else if( beat == 1 )
            obj = GameObject.Find("2");
        else if (beat == 2)
            obj = GameObject.Find("3");
        else
            obj = GameObject.Find("4");

        CircleInstances.Add((GameObject)Instantiate(CirclePrefab, obj.transform));
    }

    public void HitCircleAtBeat( float beat )
    {
        float circleScale = 100 - Mathf.Abs(100 - CircleInstances[0].transform.localScale.x * 200 );
        //Debug.Log(CircleInstances[0].transform.localScale.x);
        //Debug.Log("Score: " + circleScale + " / 100");
        Destroy(CircleInstances[0]);
        CircleInstances.RemoveAt(0);
    }

    private void Update()
    {
        if( currentBeat < mMusicManager.GetCurrentBeat() )
        {
            GenerateCircle();
            currentBeat++;
        }

        if (CircleInstances.Count != 0)
        {
            if (CircleInstances[0].transform.localScale.x < 0)
            {
                HitCircleAtBeat(-1);
            }
        }   
    }
}
