using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Bullet : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;

        // 목표
        // 플레이어가 위로 총알을 발사한다.
        // 이동 : 현재 위치 + 속도 x 시간
        // 방향 : 위
        // 속도 : 방향 x 속력

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            // 방향
            Vector3 dif = Vector3.up;
            transform.position = transform.position + dif * speed * Time.deltaTime;

        }

    }
}
