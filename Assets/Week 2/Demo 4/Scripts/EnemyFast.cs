using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFast : EnemyBase
{
    public Color enemyColor;

    public virtual void Start() {
        
        gameObject.GetComponent<Renderer>().material.color = enemyColor;
        delta = 0.2f;
        speed = 5f;
    }
}
