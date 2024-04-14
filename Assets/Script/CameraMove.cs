using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target; // 플레이어의 Transform을 저장할 변수
    public float moveSpeed;
    public float setY;
    public float setX;
    void LateUpdate()
    {
        target.transform.position.Set(target.transform.position.x + setX, target.transform.position.y + setY, -10);

        transform.position = Vector3.Lerp(transform.position, target.transform.position, moveSpeed * Time.deltaTime);

    }
}
