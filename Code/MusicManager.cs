using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public float bpm;
    public float bps;

    AudioSource MusicTest;
    // Start is called before the first frame update
    void Start()
    {
        bpm = 119.3f;
        bps = bpm / 60;
        MusicTest = GameObject.FindObjectOfType<AudioSource>(true);
        //MusicTest.SetActive(false);
    }

    public float GetBeat()
    {
        return MusicTest.time * bps;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
