using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMissileScript : MonoBehaviour
{

    public float Speed;
    public Transform target;
    public float RotationDelta;

    [Space]
    public float Accelerator;
    [Space]
    public GameObject HitFX;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (HitFX != null)
        {
            Instantiate(HitFX, transform.position, transform.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion TargetQuaternion = new Quaternion();
        if (target)
        {
            GameObject TargetingHelper = new GameObject("TH");
            TargetingHelper.transform.parent = transform;
            TargetingHelper.transform.localPosition = new Vector3(0, 0, 0);
            TargetingHelper.transform.LookAt(target);
            TargetQuaternion = TargetingHelper.transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation, TargetingHelper.transform.rotation,RotationDelta);
            Destroy(TargetingHelper);
            
        }
        transform.Translate(0, 0, Speed);

        //Speed += Accelerator;
        if (transform.rotation == TargetQuaternion)
        {
            Speed += Accelerator;
        }

    }
}
