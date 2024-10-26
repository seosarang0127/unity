using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Background : MonoBehaviour
    {
        public Material bgMat; // 배경 머터리얼

        public float scrollSpeed = 0.2f; // 배경 이동속도

        void Update() // 살아 있는 동안 배경이 계속 움직이고 싶다.
        {
            // 이동 = 방향 * 속도 * 시간
            Vector2 direction = Vector2.up;
            bgMat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
        }
    }
}
