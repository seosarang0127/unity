using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Background : MonoBehaviour
    {
        public Material bgMat; // ��� ���͸���

        public float scrollSpeed = 0.2f; // ��� �̵��ӵ�

        void Update() // ��� �ִ� ���� ����� ��� �����̰� �ʹ�.
        {
            // �̵� = ���� * �ӵ� * �ð�
            Vector2 direction = Vector2.up;
            bgMat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
        }
    }
}
