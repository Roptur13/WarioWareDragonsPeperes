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

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                canMove = false;

                speed = 5.0f;

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

                if (canMove == true && Input.GetAxisRaw("Horizontal") != 0)
                {
                    gameObject.transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
                    canMove = false;
                }
                else if (canMove == true && Input.GetAxisRaw("Vertical") != 0)
                {
                    gameObject.transform.Translate(0 , Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
                    canMove = false;
                }

                if (Tick > 2 && Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
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