using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmCircle : MonoBehaviour
{
    private float StartTime;
    private float LifeTime;
    private Sprite CircleSprite;

    public float mScale;

    public void Start()
    {
        StartTime = Time.time;
        CircleSprite = Resources.Load<Sprite>("Assets/Image/RondPlein.png");
        LifeTime = 1;
    }


    private void Update()
    {
        mScale = (LifeTime - (Time.time - StartTime)) / LifeTime;
        transform.localScale = new Vector3(mScale, mScale, 1);
    }
}
