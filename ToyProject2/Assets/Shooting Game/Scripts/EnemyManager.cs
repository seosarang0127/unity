using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("속성")]
        public GameObject EnemyFactory; // 몬스터를 생성하는 공장
        public float createTime = 1;
        public float currentTime;

        [Header("랜덤")]
        public int minTime = 1;
        public int maxTime = 4;
        // Start is called before the first frame update
        void Start()
        {
            // 랜덤 표현하는 방법
            createTime = UnityEngine.Random.Range(minTime, maxTime); // 1 ~ 3
        }

        // Update is called once per frame
        void Update()
        {
            // 시간을 측정
            currentTime += Time.deltaTime;

            if (currentTime >= createTime)
            {
                // 몬스터를 생성하라.

                InstantEnemy();
                currentTime = 0;
                createTime = UnityEngine.Random.Range(minTime, maxTime);

            }


            // 생성
        }
        void InstantEnemy()
        {
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
        }
    }
}
