using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.8f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject, 0.1f);
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
