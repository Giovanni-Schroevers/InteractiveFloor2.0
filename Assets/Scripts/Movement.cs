using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Transform vis;
    private Vector3 vel;
    private float Direction = 3;
    public float curTime = 0;

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
            if (Random.Range(0, 1) > 0.5f)
            {
                Direction += Random.Range(0, 1);
            }
            else {

            }
        }
    }

    private void SetVel(){
        if (Random.Range(0, 1) > 0.5f)
        {
            vel.x = 10 * 10 * Random.Range(0, 1);
        }
        else {
            vel.x = -10 * -10 * Random.Range(0, 1);
        }

        if (Random.Range(0, 1) > 0.5f)
        {
            vel.z = 10 * 10 * Random.Range(0, 1);
        }
        else
        {
            vel.z = -10 * -10 * Random.Range(0, 1);
        }
    }
}
