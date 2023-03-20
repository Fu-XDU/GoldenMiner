using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
