using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Enemy : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float speed = 5;

        Vector3 dir;

        // Start is called before the first frame update
        private void Start()
        {
            int randValue = UnityEngine.Random.Range(0, 10);
            if (randValue < 3)
            {
                GameObject player = GameObject.Find("Player");

                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DestoryZone")) return;

            Destroy(other.gameObject);  // �浹�� ����� ���� ������.
            Destroy(gameObject);        // ���� ���� ������.
        }
    }
}
