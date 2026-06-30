using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{

    public class ActivateTeleportRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTpRay;
        public GameObject rightTpRay;

        // Activate 버튼 인풋
        public InputActionProperty leftActivate;
        public InputActionProperty rightActivate;
        #endregion

        #region Unity Event Methods
        private void Update()
        {
            // Activate 버튼 인풋
            float leftValue = leftActivate.action.ReadValue<float>();
            float rightValue = rightActivate.action.ReadValue<float>();

            // 텔레포트 레이 활성화 / 비활성화
            leftTpRay.SetActive(leftValue > 0.1f);
            rightTpRay.SetActive(rightValue > 0.1f);
        }
        #endregion
    }
}