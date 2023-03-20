using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenBlock : MonoBehaviour
{
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("超大金子");
        go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void OnCollisionEnter(Collision collision) {
        // 销毁当前游戏物体
        Debug.Log("销毁当前游戏物体");
        Destroy(this.gameObject);
    }
    
    void collect(float angle)
    {
        go.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        go.SetActive(true);
        go.SendMessage("collect");
    }
}
