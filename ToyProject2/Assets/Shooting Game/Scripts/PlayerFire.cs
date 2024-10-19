using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class PlayerFire : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public GameObject bulletFactory; // �Ѿ��� ������ ����
        public Transform bulletPos; // �Ѿ��� ������ ��ġ

        // Update is called once per frame
        void Update()
        {
           if(Input.GetButtonDown("Fire1"))
            {
                InstantBullet();
            }
        }

        void InstantBullet()
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = bulletPos.position;
        }
    }
}
