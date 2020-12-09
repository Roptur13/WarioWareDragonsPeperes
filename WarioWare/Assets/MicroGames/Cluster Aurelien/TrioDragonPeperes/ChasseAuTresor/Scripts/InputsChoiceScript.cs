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

        public class InputsChoiceScript : TimedBehaviour
        {
            
            private int possibilityNumber;

            private Vector3[] easyInputLocationList = { new Vector3(-3.7f, 0, 0), new Vector3(0, 0, 0), new Vector3(3.7f, 0, 0) };
            private Vector3[] mediumInputLocationList = { new Vector3(-7.2f, 0, 0), new Vector3(-3.6f, 0, 0), new Vector3(0, 0, 0), new Vector3(3.6f, 0, 0), new Vector3(7.2f, 0, 0) };
            private Vector3[] hardInputLocationList = { new Vector3(-5, 2.2f, 0), new Vector3(-2.5f, 2.2f, 0), new Vector3(2.5f, 2.2f, 0), new Vector3(5, 2.2f, 0), new Vector3(-3.4f, -2.2f, 0), new Vector3(0, -2.2f, 0), new Vector3(3.4f, -2.2f, 0) };

            private List<GameObject> inputInstantiated = new List<GameObject>();

            public GameObject upArrow;
            public GameObject downArrow;
            public GameObject leftArrow;
            public GameObject rightArrow;

            public float duration;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                duration = 2f;
                if(currentDifficulty == Testing.Manager.Difficulty.EASY)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        possibilityNumber = Random.Range(1, 5);

                        switch (possibilityNumber)
                        {
                            case 1:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 2:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 3:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 4:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                break;
                        }
                    }
                }

                if (currentDifficulty == Testing.Manager.Difficulty.MEDIUM)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        possibilityNumber = Random.Range(1, 5);

                        switch (possibilityNumber)
                        {
                            case 1:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 2:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 3:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 4:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                break;
                        }
                    }
                }

                if (currentDifficulty == Testing.Manager.Difficulty.HARD)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        possibilityNumber = Random.Range(1, 5);

                        switch (possibilityNumber)
                        {
                            case 1:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                if (i == 5)
                                {
                                    GameObject input6 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input6);
                                    //Destroy(input3, duration);
                                }
                                if (i == 6)
                                {
                                    GameObject input7 = Instantiate(upArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input7);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 2:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                if (i == 5)
                                {
                                    GameObject input6 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input6);
                                    //Destroy(input3, duration);
                                }
                                if (i == 6)
                                {
                                    GameObject input7 = Instantiate(downArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input7);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 3:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                if (i == 5)
                                {
                                    GameObject input6 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input6);
                                    //Destroy(input3, duration);
                                }
                                if (i == 6)
                                {
                                    GameObject input7 = Instantiate(leftArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input7);
                                    //Destroy(input3, duration);
                                }
                                break;
                            case 4:
                                if (i == 0)
                                {
                                    GameObject input1 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input1);
                                    //Destroy(input1, duration);
                                }
                                if (i == 1)
                                {
                                    GameObject input2 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input2);
                                    //Destroy(input2, duration);
                                }
                                if (i == 2)
                                {
                                    GameObject input3 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input3);
                                    //Destroy(input3, duration);
                                }
                                if (i == 3)
                                {
                                    GameObject input4 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input4);
                                    //Destroy(input3, duration);
                                }
                                if (i == 4)
                                {
                                    GameObject input5 = Instantiate(rightArrow, easyInputLocationList[i], Quaternion.identity);
                                    inputInstantiated.Add(input5);
                                    //Destroy(input3, duration);
                                }
                                break;
                        }
                    }
                }
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!



            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                if(Tick == 3)
                {
                    for(int i = 0; i< inputInstantiated.Count; i++)
                    {
                        Destroy(inputInstantiated[i]);
                    }
                }
            }
            
        }
    }
}