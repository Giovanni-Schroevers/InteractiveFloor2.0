using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windows.Kinect;

public class Movement : MonoBehaviour {
    private Vector3 vel;
    private float Direction = 3;
    public float curTime = 0;

    JointType FootLeft = JointType.FootLeft;
    JointType FootRight = JointType.FootRight;

    void Start() {
        SetVel();
    }

    void Update() {
        if (curTime < Direction) {
            curTime += Time.deltaTime;
        }
        else
        {
            SetVel();
            if (Random.Range(0f, 1f) > 0.5f)
            {
                Direction += Random.Range(0f, 1f);
            }
            else {
                Direction -= Random.Range(0f, 1f);
            }
            if (Direction < 1) {
                Direction = 1 + Random.Range(0f, 1f);
            }
            curTime = 0;
        }

        if (transform.position.x > 9 || transform.position.x < -9 || transform.position.z > 9 || transform.position.z < -9)
        {
            SetVel();
        }

        GameObject[] bodies = GameObject.FindGameObjectsWithTag("Body");

        foreach (GameObject body in bodies) {
            
        }


    }

    private void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().velocity = vel;
    }

    private void SetVel()
    {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            if (transform.position.x < 9)
            {
                vel.x = 2 * Random.Range(0f, 1f);
            }
            else
            {
                vel.x = -2 * Random.Range(0f, 1f);
            }
        }
        else
        {
            if (transform.position.x > -9)
            {
                vel.x = -2 * Random.Range(0f, 1f);
            }
            else
            {
                vel.x = 2 * Random.Range(0f, 1f);
            }
        }

        if (Random.Range(0f, 1f) > 0.5f)
        {
            if (transform.position.z < 9)
            {
                vel.z = 2 * Random.Range(0f, 1f);
            }
            else
            {
                vel.z = -2 * Random.Range(0f, 1f);
            }
        }
        else
        {
            if (transform.position.z > -9)
            {
                vel.z = -2 * Random.Range(0f, 1f);
            }
            else {
                vel.z = 2 * Random.Range(0f, 1f);
            }
        }
    }
}
