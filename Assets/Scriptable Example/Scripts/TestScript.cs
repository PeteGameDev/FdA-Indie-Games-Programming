using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestScript : MonoBehaviour
{
    public TestScriptableObject testScriptable;
    
    public Material myMaterial;
    void Start()
    {
        string example = testScriptable.myString;
        
        Debug.Log(example);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            playAnimation();
        }
    }

    void playAnimation()
    {
        transform.DOMove(new Vector3(-5, 1, 0), 0.5f).SetEase(Ease.OutElastic);
        transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        transform.DOScale(new Vector3(3, 3, 3), 0.5f).SetDelay(0.5f).SetLoops(-1, LoopType.Yoyo);

        myMaterial.DOColor(Color.green, 2f);
        


    }
}
