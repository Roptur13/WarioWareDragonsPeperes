using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace Dragons_Peperes
{
    namespace ChasseAuTresor
    {
        /// <summary>
        /// Noé Blanc
        /// </summary>

        public class WinOrLooseScript : TimedBehaviour
        {
            public GameObject player;
            public GameObject inputAppearance;

            private SpriteRenderer spriteRenderer;
            public Sprite chest;

            public bool finished;
            private bool treasureFound;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

                finished = false;

                treasureFound = false;
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!
                
                if(Input.GetKeyDown(KeyCode.Joystick1Button0) && inputAppearance.GetComponent<InputsChoiceScript>().inputsChosen == true)
                {
                    if(transform.position == player.transform.position)
                    {
                        Debug.Log("Gagné !");
                        spriteRenderer.sprite = chest;
                        finished = true;
                        treasureFound = true;
                    }
                    if(transform.position != player.transform.position)
                    {
                        Debug.Log("Perdu !");
                        finished = true;
                    }
                }
            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                if(Tick == 8 && treasureFound == true)
                {
                    
                    Manager.Instance.Result(true);
                }
                if(Tick == 8 && treasureFound == false)
                {
                    
                    Manager.Instance.Result(false);
                }
            }
        }
    }
}