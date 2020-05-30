using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirovController : MonoBehaviour
{
    public Transform[] UpPropellers;
    public Transform[] FrontPropellers;
    public float RotateSpeed;
    [Space]
    public Transform[] RocketTransforms;
    public Transform[] OriginalRocketTransforms;
    public Transform[] LoadedRocketTransforms;
    public float ReloadSpeed;
    public float ReloadProcess;
    public GameObject Rocket;
    public GameObject LauchFX;
    public int Number = 1;
    public Transform Target;
    [Space]
    public float MovingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        for (int I = 0; I < RocketTransforms.Length; I++)
        {
            RocketTransforms[I].position= LoadedRocketTransforms[I].position;
            //print("A");
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int Iu = 0; Iu < UpPropellers.Length; Iu++)
        {
            UpPropellers[Iu].Rotate(0, 0, RotateSpeed);
            //print("A");
        }
        for (int If = 0; If < FrontPropellers.Length; If++)
        {
            FrontPropellers[If].Rotate(RotateSpeed, 0, 0);
            //print("B");
        }

        if (ReloadProcess <= 0)
        {
            RocketTransforms[Number-1].position = OriginalRocketTransforms[Number-1].position;
            Instantiate(LauchFX, LoadedRocketTransforms[Number - 1].position, LoadedRocketTransforms[Number - 1].rotation);
            Instantiate(Rocket, LoadedRocketTransforms[Number-1].position, LoadedRocketTransforms[Number-1].rotation);
            Rocket.GetComponent<GuideMissileScript>().target = Target;
            ReloadProcess = ReloadSpeed;
            Number += 1;
            if (Number > RocketTransforms.Length)
            {
                Number = 1;
            }
        }

        if (ReloadProcess > 0)
        {
            ReloadProcess -= 1;
        }

        for (int I = 0; I < RocketTransforms.Length; I++)
        {
            if(RocketTransforms[I].position!= LoadedRocketTransforms[I].position)
            RocketTransforms[I].position = Vector3.Lerp(RocketTransforms[I].position, LoadedRocketTransforms[I].position, 0.05f);
            //print("A");
        }

    }
}
