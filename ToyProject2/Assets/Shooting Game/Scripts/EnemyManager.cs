using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public GameObject EnemyFactory; // ���͸� �����ϴ� ����
        public float createTime = 1;
        public float currentTime;

        [Header("����")]
        public int minTime = 1;
        public int maxTime = 4;
        // Start is called before the first frame update
        void Start()
        {
            // ���� ǥ���ϴ� ���
            createTime = UnityEngine.Random.Range(minTime, maxTime); // 1 ~ 3
        }

        // Update is called once per frame
        void Update()
        {
            // �ð��� ����
            currentTime += Time.deltaTime;

            if (currentTime >= createTime)
            {
                // ���͸� �����϶�.

                InstantEnemy();
                currentTime = 0;
                createTime = UnityEngine.Random.Range(minTime, maxTime);

            }


            // ����
        }
        void InstantEnemy()
        {
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
        }
    }
}
