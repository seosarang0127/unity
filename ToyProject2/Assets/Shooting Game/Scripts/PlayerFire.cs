using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class PlayerFire : MonoBehaviour
    {
        [Header("속성")]
        public GameObject bulletFactory; // 총알을 생산할 공장
        public Transform bulletPos; // 총알이 생성할 위치

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
