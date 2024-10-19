using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float createTime = 1;    // Ư�� �ð�
        private float currentTime;      // ���� �ð�
        public GameObject enemyFactory; // �� ����

        [Header("����")]
        float minTime = 1;
        float maxTime = 5;

        private void Start()
        {
            // ���� ���� �ð�
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime; // �ð��� �帣�ٰ�

            if (currentTime > createTime) // ���� �ð��� Ư�� �ð��� �Ǹ�
            {
                GameObject enemy = Instantiate(enemyFactory);  // �� ����
                enemy.transform.position = transform.position; // ��ġ�� EnemyManager�� ��ġ

                currentTime = 0; // ���� �ð� �ʱ�ȭ
                createTime = UnityEngine.Random.Range(minTime, maxTime);
            }
        }
    }
}
