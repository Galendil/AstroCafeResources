using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public double mLevelTimer;
    public MusicManager mMusicManager;
    public CircleGenerator mCircleGenerator;

    public GameObject[] ingrediants = new GameObject[4];

    public void Start()
    {
        mLevelTimer = 0.0;
        mMusicManager = GameObject.FindObjectOfType<MusicManager>();
        mCircleGenerator = GameObject.FindObjectOfType<CircleGenerator>();
    }

    public void Update()
    {
        mLevelTimer += Time.deltaTime;
        if (Input.GetKeyDown("s"))
        {
            //mCircleGenerator.HitCircleAtBeat(mMusicManager.GetBeat());
        }
        
        if (Input.GetKeyDown("d"))
        {
            //mCircleGenerator.HitCircleAtBeat(mMusicManager.GetBeat());
            Instantiate(ingrediants[0]);
        }

        if (Input.GetKeyDown("k"))
        {
            //mCircleGenerator.HitCircleAtBeat(mMusicManager.GetBeat());
            Instantiate(ingrediants[1]);
        }

        if (Input.GetKeyDown("l"))
        {
            //mCircleGenerator.HitCircleAtBeat(mMusicManager.GetBeat());
            Instantiate(ingrediants[3]);
        }

        if (Input.GetKeyDown("g"))
        {
            //GameObject.FindObjectOfType<CircleGenerator>().GenerateCircle();
            Instantiate(ingrediants[2]);
        }
    }
}