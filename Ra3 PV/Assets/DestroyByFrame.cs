using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByFrame : MonoBehaviour
{
    public int FrameTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FrameTime -= 1;
        if (FrameTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
