using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRenderOrdering : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D _Other)
    {
        SpriteRenderer otherSpriteRenderer = _Other.gameObject.GetComponent<SpriteRenderer>();

        // ���� ������ SpriteRenderer�� null�� �ƴ϶�� (��, SpriteRenderer�� �����Ѵٸ�)
        if (otherSpriteRenderer != null)
        {
            // ���� ������Ʈ�� ��ġ
            Vector2 currentPosition = transform.position;

            // �浹�� ������Ʈ�� ��ġ
            Vector2 otherPosition = _Other.gameObject.transform.position;

            // ���� ������Ʈ�� �浹�� ������Ʈ�� Y��ǥ ���Ͽ� Sorting Order ����
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
