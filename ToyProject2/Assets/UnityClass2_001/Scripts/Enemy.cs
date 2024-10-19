using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class Enemy : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float speed = 5;
        private Vector3 dir;   // ���Ͱ� �̵��� ����
        private void Start()
        {
            // ������ ������ �����ϰ� �����ִ� ����
            GetDirectionPattern();
        }

        private void GetDirectionPattern()
        {
            int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 ������ ���� �������� �����´�.

            if (randValue < 3)
            {
                GameObject target = GameObject.Find("Player");
                dir = target.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }

        private void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject); // �� �װ�
            Destroy(gameObject);       // �� ����
        }
    }
}
