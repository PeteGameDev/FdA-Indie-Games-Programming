using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float delta;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos;
        startPos = transform.localPosition;

        Vector3 v = startPos;
        v.x += delta/10f * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
