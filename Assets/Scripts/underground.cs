using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class underground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
String o = GameObject.Find("Canvas/time").GetComponent<Text>().text;
        GameObject.Find("Canvas/time").GetComponent<Text>().text = "12";

		//time.text = "12";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
