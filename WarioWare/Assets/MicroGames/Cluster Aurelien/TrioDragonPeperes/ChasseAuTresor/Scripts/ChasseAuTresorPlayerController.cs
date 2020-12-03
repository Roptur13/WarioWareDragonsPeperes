using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace ChasseAuTresor
    {

        /// <summary>
        /// Noé Blanc
        /// </summary>

        public class ChasseAuTresorPlayerController : TimedBehaviour
        {
            private bool canMove;

            private float speed;

            private Rigidbody2D rbPlayer;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                canMove = true;

                speed = 3.0f;

                rbPlayer = GetComponent<Rigidbody2D>();

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

                if (canMove == true && Input.GetAxisRaw("Left_Joystick_X") != 0)
                {
                    rbPlayer.velocity = new Vector2(Input.GetAxisRaw("Left_Joystick_X") * speed, rbPlayer.velocity.y);
                    canMove = false;
                }
                else if (canMove == true && Input.GetAxisRaw("Left_Joystick_Y") != 0)
                {
                    rbPlayer.velocity = new Vector2(rbPlayer.velocity.x , Input.GetAxisRaw("Left_Joystick_Y") * speed);
                    canMove = false;
                }

                if (/*Tick > 2 &&*/ Input.GetAxisRaw("Left_Joystick_X") == 0 && Input.GetAxisRaw("Left_Joystick_Y") == 0)
                {
                    canMove = true;
                }
            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                
            }
        }
    }
}