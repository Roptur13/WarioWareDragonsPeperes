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

        public class PlayerController : MonoBehaviour
        {

            private bool canMove;

            public float distance;

            public GameObject treasure;

            // Start is called before the first frame update
            void Start()
            {
                canMove = true;

                distance = 1.0f;

            }

            private void FixedUpdate()
            {
                if(treasure.GetComponent<WinOrLooseScript>().finished == false)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) <= 0.2 && Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) <= 0.2)
                    {
                        canMove = true;
                    }
                }                

                if (canMove == true)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) >= 0.95f)
                    {
                        if(Input.GetAxisRaw("Left_Joystick_X") > 0f)
                        {
                            transform.position += new Vector3(distance, 0, 0);
                        }
                        if (Input.GetAxisRaw("Left_Joystick_X") < 0f)
                        {
                            transform.position += new Vector3(-distance, 0, 0);
                        }

                        canMove = false;
                    }
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) >= 0.95f)
                    {
                        if (Input.GetAxisRaw("Left_Joystick_Y") > 0f)
                        {
                            transform.position += new Vector3(0, distance, 0);
                        }
                        if (Input.GetAxisRaw("Left_Joystick_Y") < 0f)
                        {
                            transform.position += new Vector3(0, -distance, 0);
                        }
                        canMove = false;
                    }
                }

                /*if (treasure.GetComponent<WinOrLooseScript>().finished == true)
                {
                    canMove = false;
                }*/
            }
        }
    }
}
