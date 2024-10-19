using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class PlayerFire : MonoBehaviour
    {

        [Header("�Ӽ�")]
        public GameObject bulletFactory; // �Ѿ��� �����ϴ� ����
        public Transform firePosition;   // �Ѿ��� �߻�� ��ġ


        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                InstantBullet();
            }
        }

        void InstantBullet()
        {
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
        }
    }
}
