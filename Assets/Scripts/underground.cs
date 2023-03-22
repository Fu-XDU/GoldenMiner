using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class underground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Canvas/time").GetComponent<Text>().text = "12";
		StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountDown()
    {
		int second = 60;
		// 注意这里的死循环只能放协程里，不能放到外面主线程，会卡死
        while (second >= 0)  
        {
            // 显示格式为 M分：S秒
            GameObject.Find("Canvas/time").GetComponent<Text>().text = string.Format("{0}", second);
            // 每一帧update后等待1秒延迟再继续下一帧
            yield return new WaitForSeconds(1);
            // 时间减去一秒
            second--;

            // 游戏结束
            if (second < 0)
            {
				int balance = int.Parse(GameObject.Find("Canvas/balance").GetComponent<Text>().text);
				int goal = int.Parse(GameObject.Find("Canvas/goal").GetComponent<Text>().text);
				if (balance<goal) {
					SceneManager.LoadScene(2);
				} else {
					SceneManager.LoadScene(4);
				}
            }
        }
    }
}
