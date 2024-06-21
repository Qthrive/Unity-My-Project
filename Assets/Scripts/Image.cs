using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Image : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print("hello,this is a image button.");
    }

    private void OnMouseDown()
    {
        //print("hello");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("hello,world");
    }

    // Update is called once per frame----ÿ֡
    void Update()
    {
        
    }
}
