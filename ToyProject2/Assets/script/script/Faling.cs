using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Faling : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            // tag가 NonDisable이면 충돌하지 말라, 이 코드를 작성하지 마세요.
            if (collision.collider.CompareTag("NonDisable"))
            {
                return;
            }

            Debug.Log(collision.gameObject.name);  // 충돌한 오브젝트의 이름 출력
            collision.gameObject.SetActive(false); // 충돌한 오브젝트를 비활성화

        }

        private void OnCollisionExit(Collision collision)
        {
            
        }

        private void OnCollisionStay(Collision collision)
        {
            
        }
    }
}
