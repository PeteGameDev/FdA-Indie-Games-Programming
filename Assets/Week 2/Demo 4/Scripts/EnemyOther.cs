using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOther : EnemyBase
{
    public Color enemyColor;

    public virtual void Start(){

        gameObject.GetComponent<Renderer>().material.color = enemyColor;
        delta = 0.3f;
        speed = 1f;
    }

    public virtual void Update(){

        Vector3 startYPos;
        startYPos = transform.localPosition;

        Vector3 w = startYPos;
        w.y += delta/10f * Mathf.Sin(Time.time * speed);
        transform.position = w;
    }
}
