using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Bullet : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float speed = 5;

        // ��ǥ
        // �÷��̾ ���� �Ѿ��� �߻��Ѵ�.
        // �̵� : ���� ��ġ + �ӵ� x �ð�
        // ���� : ��
        // �ӵ� : ���� x �ӷ�

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            // ����
            Vector3 dif = Vector3.up;
            transform.position = transform.position + dif * speed * Time.deltaTime;

        }

    }
}
