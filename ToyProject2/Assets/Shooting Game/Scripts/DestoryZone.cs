using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class DestoryZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }

    }
}
