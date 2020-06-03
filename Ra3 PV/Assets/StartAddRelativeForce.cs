using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAddRelativeForce : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 Force;
    public float Rotationf;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 CF = Force += new Vector3(Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)), Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)), Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)));
        rigidbody.AddRelativeForce(CF);
        //rigidbody.AddRelativeTorque(Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)), Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)), Random.Range(Mathf.Abs(Rotationf), -Mathf.Abs(Rotationf)));
        //GetComponent<StartAddRelativeForce>()
        Destroy(GetComponent<StartAddRelativeForce>());
    }

    
}
