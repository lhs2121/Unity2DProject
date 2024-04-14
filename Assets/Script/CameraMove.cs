using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Target; // 플레이어의 Transform을 저장할 변수
    public float moveSpeed;
    public float setY;
    public float setX;
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.transform.position, moveSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
