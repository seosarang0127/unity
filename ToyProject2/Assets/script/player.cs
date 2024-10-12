using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Player : MonoBehaviour
    {
        #region 총 설명

        // 게임이 시작이 된 후 한 번만 실행이 된다.
        // Start is called before the first frame update

        public int gauge = 0;

        void Start()
        {
            //Debug.Log("저의 이름은 player입니다.");

            // 플레이어의 위치 z : 40으로 이동한다.
            // 너의 Transform의 position의 z를 40으로 바꿔라
            // 1. 위치 이동
            transform.position = new Vector3(4.4f, 0.43f, 3.62f);

            // 2. 회전
            // -> transform.Rotate(new Vector3(0, 90, 0));
        }
        // 반복되는 로직을 처리할 수 있습니다.
        // Frame : 1초에 60Frame FPS : Frame Per second
        // 1Frame을 생성할 때 update가 한 번만 실행된다.
        // Update is called once per frame

        #endregion


        public int maxHealth;
        public int currentHealth;
        // #region에는 무조건 #endregion 가 함께 붙는다. = 정리용

        public int speed = 10;
        public bool isDash = false;
        public bool isgrounded;

        void Update()
        { 
            // 플레이어의 입력을 구현해보자.
            // 키보드 입력 : 

            #region 플레이어의 D키 입력

            if (Input.GetKey(KeyCode.LeftShift))
            {
                isDash = true;
            }

            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                isDash = false;
            }

            if(isDash)
            {
                speed = 30;
            }
            else if (!isDash)
            {
                speed = 10;
            }

            if (Input.GetKey(KeyCode.D))
            {
                //Debug.Log("D키를 입력 했습니다."); // 앞으로 움직인다.

                transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);

            }

   

            if (Input.GetKeyUp(KeyCode.D))
            {
                //Debug.Log("D키를 떼었습니다.");
            }


                #endregion

                /*#region 플레이어의 점프 입력

                if (Input.GetKey(KeyCode.W))
                {
                    Debug.Log("점프를 했습니다.");

                    transform.Translate(new Vector3(0, 10, 1) * Time.deltaTime);
                }
                #endregion*/

                #region 플레이어의 A 클릭 입력

                if (Input.GetKey(KeyCode.A))
            {
                //Debug.Log("A를 클릭 했습니다.");
                transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            }

            if(Input.GetKeyUp(KeyCode.A))
            {
                //Debug.Log("A 클릭을 멈추었습니다.");
            }

            #endregion

            // 마우스 입력

            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("마우스 왼쪽을 클릭 하였습니다.");
            }

            // 중력
            //transform.Translate(new Vector3(0, -9.8f,0) * Time.deltaTime);

        }
    }
}
