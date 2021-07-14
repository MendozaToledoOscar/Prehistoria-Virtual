using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoRotation : MonoBehaviour
{
    //public Transform target;
    //public float distance = 3;
    //public float speed = 30;
    //public float angSpeed = 20;

    //double sinA, cosA;
    //float3 pos;
    //float t = 0.0f;
	//float speed = 10f;
	//float radio = 50.0f;
    // Start is called before the first frame update

    public GameObject dino;
    public float speed = 1.0f;
    public float radiomin = 15;
    public float radiomax = 20;
    public float amplitudVertical = 3;
    public float deltaTimer = 0.001f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Tercera propuesta
        dino.transform.position = new Vector3(radiomin*Mathf.Cos(speed), amplitudVertical*Mathf.Sin(speed) + amplitudVertical, radiomax*Mathf.Sin(speed));
        Vector3 P = dino.transform.position;
        Vector3 V0 = Vector3.Cross(P, -dino.transform.up);
        dino.transform.forward = V0 + P;
        speed += deltaTimer;
    }
}
