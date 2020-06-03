using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunScript : MonoBehaviour
{
    public bool Trigger;
    [Space]
    public Transform BulletSpawnPoint;
    public Transform RotateBarrel;
    public Vector3 BarrelRotateSpeed;
    [Space]
    public float FireRate;
    public float ReloadProcess;
    public GameObject Shell;
    //public Vector3 ShellForce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Trigger)
        {
            if (RotateBarrel)
            {
                RotateBarrel.Rotate(BarrelRotateSpeed);
            }

            if (ReloadProcess <= 0)
            {
                Instantiate(Shell, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
                //Shell.GetComponent<Rigidbody>().AddRelativeForce(ShellForce);
                ReloadProcess = FireRate;
            }
            if (ReloadProcess > 0)
            {
                ReloadProcess -= 1;
            }
        }
    }
}
