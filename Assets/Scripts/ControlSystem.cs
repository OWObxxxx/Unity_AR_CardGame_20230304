using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ARCardGame
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("目標物件")]
        private Transform target;

        private void Update()
        {
            LookAtTarget();
        }

        /// <summary>
        /// 面向目標
        /// </summary>
        private void LookAtTarget()
        {
            transform.LookAt(target);

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}

