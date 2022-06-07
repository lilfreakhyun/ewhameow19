using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{

    /*

    private float size = 2f;
    public float speed;
    public float time;

    private Vector2 originScale; //원래 크기

    private void Awake()
    {
        originScale = transform.localScale; //원래 크기 저장
    }   


    public void Size(){
        transform.localScale = originScale*(1+time);
        time += Time.deltaTime;
    }
    */
    Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    private GameObject selectedObject;
    public void Size(){
        selectedObject.transform.localScale += scaleChange;
    }

}
