using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class HPSystem : MonoBehaviour
    {
        [SerializeField] private int hp;   // 현재 체력
        public int maxHP; // 최대 체력

        public GameObject[] lifeCount;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;    // hp 값을 value로 변경해주세요.
                Debug.Log("체력이 변경되었습니다.");

                if (hp >= maxHP ) hp = maxHP; // 최대 체력을 넘지 못 하게 한다.

                if (hp <= 0) hp = 0;

                Update();
            }
        }

        void UpdateUI()
        {

        }


        public void DecreaseHP(int damage = 1) // enemy
        {
            HP -= damage;
        }

        public void IncreaseHP(int value = 1) // enemy
        {
            HP += value;
        }

        private void Start()
        {
            hp = maxHP;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                DecreaseHP();
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                IncreaseHP();
            }
        }
    }

}
