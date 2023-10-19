using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenExample : MonoBehaviour
{
    float timeScale = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            PlayAnim();
        }
    }

    void PlayAnim(){
        transform.DOMove(new Vector3(5, 500, 0), timeScale);
        transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.5f);
    }
}
