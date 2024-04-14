using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRenderOrdering : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D _Other)
    {
        SpriteRenderer otherSpriteRenderer = _Other.gameObject.GetComponent<SpriteRenderer>();

        // 만약 가져온 SpriteRenderer가 null이 아니라면 (즉, SpriteRenderer가 존재한다면)
        if (otherSpriteRenderer != null)
        {
            // 현재 오브젝트의 위치
            Vector2 currentPosition = transform.position;

            // 충돌한 오브젝트의 위치
            Vector2 otherPosition = _Other.gameObject.transform.position;

            // 현재 오브젝트와 충돌한 오브젝트의 Y좌표 비교하여 Sorting Order 설정
            if (currentPosition.y > otherPosition.y)
            {
                otherSpriteRenderer.sortingOrder = 3;
            }
            else
            {
                otherSpriteRenderer.sortingOrder = 1;
            }
        }
    }

}
