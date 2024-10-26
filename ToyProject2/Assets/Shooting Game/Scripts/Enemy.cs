using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Enemy : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;
        private Vector3 dir;

        [Header("이펙트")]
        public GameObject explosionFactory;

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

            if (other.CompareTag("Bullet"));

            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;

            Destroy(other.gameObject);  // 충돌한 대상을 없애 버린다.
            Destroy(gameObject);        // 나도 없애 버린다.
        }
    }
}
