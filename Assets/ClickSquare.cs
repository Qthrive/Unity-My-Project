using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickSquare : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print("hello,this is a square.");
    }

    // Start is called before the first frame update
    void Start()
    {
        //print("");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
