using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class PlayerMove : MonoBehaviour
    {
        // ��ǥ
        // �÷��̾ �����δ�.
        // ���� : ��, �Ʒ�, ����, ������
        // �ӵ� : ���� x �ӷ�

        [Header("�Ӽ�")]
        public float speed = 5; // �̵� �ӷ�

        // Start is called before the first frame update
        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dif = new Vector3(horizontal, vertical, 0);
            dif.Normalize();

            transform.position = transform.position + dif * speed * Time.deltaTime;
        }
    }
}
