using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace ChasseAuTresor
    {
        public class PlayerController : MonoBehaviour
        {

            private bool canMove;

            public float speed;

            public Transform movePoint;


            // Start is called before the first frame update
            void Start()
            {
                canMove = true;

                speed = 3.0f;

                movePoint.parent = null;
            }

            // Update is called once per frame
            void Update()
            {
                
            }

            private void FixedUpdate()
            {
                transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);

                if(Vector3.Distance(transform.position, movePoint.position) < 0.05)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) == 1.0f)
                    {
                        movePoint.position += new Vector3(Input.GetAxisRaw("Left_Joystick_X"), 0, 0);
                    }
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) == 1.0f)
                    {
                        movePoint.position += new Vector3(0, -Input.GetAxisRaw("Left_Joystick_Y"), 0);
                    }
                }                
            }
        }
    }
}
