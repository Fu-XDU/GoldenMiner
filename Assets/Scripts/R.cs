using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R : MonoBehaviour
{
    private float angle_step = 0.5F;
    float angle = 0;
    float angle2 = 0;
    private bool rotation_direction = true;
    Vector3 point = new Vector3(420, 367, -1);
    public float Speed = 0.01F;

    private Vector3 startedPoint;

    private int status = 0;

    private bool needCalDest = true;

    private Vector3 dest;

    private float Length = 156;
    private float LSpeed = 300;
    // Start is called before the first frame update
    void Start()
    {
        startedPoint = transform.localPosition;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (status == 0) {
            // Vector3 player_postion = transform.position;
            // Debug.Log(player_postion.ToString());
            // Transform.RotateAround(point: Vector3, axis: Vector3, angle: float)
            // point: 旋转中心点
            // axis: 旋转轴
            // angle: 旋转角度(以度为单位)
            if (angle == 80) {
                rotation_direction = !rotation_direction;
                angle = -80;
            }
            transform.RotateAround(point, rotation_direction?Vector3.forward:Vector3.back, angle_step);
            angle += angle_step;
            angle2 += angle_step*(rotation_direction?1F:-1F);
            if (Input.GetKeyDown (KeyCode.Space)) {
                status = 1;
                startedPoint = transform.localPosition;
            }
        }
        else if (status == 1)
        {
            if (needCalDest)
            {
                dest = new Vector3(420+352*(angle2==0?0:Mathf.Tan(angle2*Mathf.Deg2Rad)),0, -1);    
            }
            
            needCalDest = false;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, dest, Speed);

            // Length += Time.deltaTime * LSpeed;
            // transform.localScale = new Vector3(transform.localScale.x, Length, transform.localScale.z); 
            if (transform.localPosition == dest || transform.localPosition.x < 0 || transform.localPosition.x > 900 ||
                transform.localPosition.y < 0 || transform.localPosition.y > 500)
            {
                status = 2;
                needCalDest = true;
            }
        }
        else if (status == 2)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, startedPoint, Speed);
            if (transform.localPosition == startedPoint)
            {
                status = 0;
            }
        } 
    }
    
    void OnCollisionEnter(Collision collision) {
        // 销毁当前游戏物体
        Debug.Log("钩子抓到金块");
        status = 2;
        this.gameObject.SetActive(false);
        //Destroy(this.gameObject);
    }
}
