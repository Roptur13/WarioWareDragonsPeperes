using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace CestNotreTresor
    {
        /// <summary>
        /// Mael Ricou
        /// </summary>

        public class PlayerController : MonoBehaviour
        {

            [SerializeField] float speed = 10f;
            private float moveInput;

            Rigidbody2D rb;

            private void Start()
            {
                rb = GetComponent<Rigidbody2D>();
            }

            private void Update()
            {
  
            }

            private void FixedUpdate()
            {
                moveInput = Input.GetAxisRaw("Left_Joystick_X");
                rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            }

        }
    }
}

   
