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

        public class PlayerTimedController : TimedBehaviour
        {
            private bool canMove;

            public float distance;
            private float speed;
            

            public GameObject treasure;
            public GameObject target;
            public GameObject bulle;
            public GameObject spritePerso;

            private SpriteRenderer spriteRenderer;
            private AudioSource audiosource;

            public Sprite upSprite;
            public Sprite downSprite;
            public Sprite leftSprite;
            public Sprite rightSprite;
            public Sprite movingRightSprite;
            public Sprite movingLeftSprite;
            public Sprite movingUpSprite;
            public Sprite movingDownSprite;

            private Sprite movingSprite;
            private Sprite idleSprite;

            public float bpmAccelerator;


            public override void Start()
            {
                base.Start(); //Do not erase this line!

                canMove = true;

                distance = 0.8f;

                spriteRenderer = spritePerso.GetComponent<SpriteRenderer>();

                audiosource = gameObject.GetComponent<AudioSource>();

                bpmAccelerator = bpm / 60;

                target.transform.position = new Vector3(0, 0, 0);

                speed = 5f;

                idleSprite = downSprite;

                bulle.SetActive(false);                
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * bpmAccelerator * Time.deltaTime);

                if (treasure.GetComponent<WinOrLooseScript>().finished == false)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) <= 0.2 && Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) <= 0.2 && transform.position == target.transform.position)
                    {
                        canMove = true;
                    }
                }

                if(transform.position == target.transform.position)
                {
                    spriteRenderer.sprite = idleSprite;
                }
                else if (transform.position != target.transform.position)
                {
                    spriteRenderer.sprite = movingSprite;
                }
                

                if (canMove == true)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) >= 0.95f)
                    {
                        if (Input.GetAxisRaw("Left_Joystick_X") > 0f)
                        {
                            target.transform.position += new Vector3(distance, 0, 0);
                            StartCoroutine(Jump());
                            movingSprite = movingRightSprite;
                            idleSprite = rightSprite;
                            audiosource.Play();
                        }
                        if (Input.GetAxisRaw("Left_Joystick_X") < 0f)
                        {
                            target.transform.position += new Vector3(-distance, 0, 0);
                            StartCoroutine(Jump());
                            movingSprite = movingLeftSprite;
                            idleSprite = leftSprite;
                            audiosource.Play();
                        }

                        canMove = false;
                    }

                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) >= 0.95f)
                    {
                        if (Input.GetAxisRaw("Left_Joystick_Y") > 0f)
                        {
                            target.transform.position += new Vector3(0, distance, 0);
                            StartCoroutine(Jump());
                            movingSprite = movingUpSprite;
                            idleSprite = upSprite;
                            audiosource.Play();
                        }
                        if (Input.GetAxisRaw("Left_Joystick_Y") < 0f)
                        {
                            target.transform.position += new Vector3(0, -distance, 0);
                            StartCoroutine(Jump());
                            movingSprite = movingDownSprite;
                            idleSprite = downSprite;
                            audiosource.Play();
                        }
                        canMove = false;
                    }
                }

                if(transform.position == target.transform.position)
                {
                    audiosource.Stop();
                }

                if(transform.position == treasure.transform.position)
                {
                    bulle.SetActive(true);
                }

                if (treasure.GetComponent<WinOrLooseScript>().finished == true)
                {
                    canMove = false;
                }

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {

            }

            IEnumerator Jump()
            {
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, 0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);

                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);
                yield return new WaitForSeconds((speed * bpmAccelerator * Time.deltaTime) / 20);
                spritePerso.transform.position += new Vector3(0, -0.05f, 0);

                yield return null;



            }
        }
    }
}