using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Onwrongpress : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro1; // First text
    public TextMeshProUGUI textMeshPro2; // Second text
    public TextMeshProUGUI textMeshPro3; // third text
    public TextMeshProUGUI textMeshPro4; // fourth text
    public TextMeshProUGUI textMeshPro5; // fifth text
    public TextMeshProUGUI textMeshPro6; // Sixth text
    public TextMeshProUGUI textMeshPro7; // Seventh text
    public TextMeshProUGUI textMeshPro8; // eighth text
    public TextMeshProUGUI textMeshPro9; // ninth text
    public int redCount = 0; // Track the number of times the text turns red
    public int greenCount = 0; // Track the number of times the text turns green
    private float[] rotations = new float[4] { 0f, 90f, 180f, 270f }; // Set the possible rotations
    private int currentRotationIndex = 0; // Track the current rotation

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial rotation and scale of the texts
        textMeshPro1.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro2.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro3.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro4.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro5.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro6.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro7.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro8.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro9.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);


    }

    // Update is called once per frame
    void Update()
    {
        if (redCount >= 4 || greenCount >= 10)
        {
            Debug.Log("Task finished");
            return; // End the task if the text has turned red three times or green eleven times
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckKey(2);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckKey(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckKey(0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckKey(3);
        }
    }

    void CheckKey(int keyIndex)
    {
        if (keyIndex == currentRotationIndex)
        {
            // Correct key was pressed
            textMeshPro1.color = Color.black;
            textMeshPro2.color = Color.black;
            textMeshPro3.color = Color.black;
            textMeshPro4.color = Color.black;
            textMeshPro5.color = Color.black;
            textMeshPro6.color = Color.black;
            textMeshPro7.color = Color.black;
            textMeshPro8.color = Color.black;
            textMeshPro9.color = Color.black;

            // Disable the previous TextMeshPro object
            switch (greenCount)
            {
                case 0:
                    textMeshPro1.gameObject.SetActive(false);
                    break;
                case 1:
                    textMeshPro2.gameObject.SetActive(false);
                    break;
                case 2:
                    textMeshPro3.gameObject.SetActive(false);
                    break;
                case 3:
                    textMeshPro4.gameObject.SetActive(false);
                    break;
                case 4:
                    textMeshPro5.gameObject.SetActive(false);
                    break;
                case 5:
                    textMeshPro6.gameObject.SetActive(false);
                    break;
                case 6:
                    textMeshPro7.gameObject.SetActive(false);
                    break;
                case 7:
                    textMeshPro8.gameObject.SetActive(false);
                    break;
                case 8:
                    textMeshPro9.gameObject.SetActive(false);
                    break;
                default:
                    break;
            }

            // Enable the next TextMeshPro object in sequence
            if (redCount < 4 && greenCount < 10)
            {
                switch (greenCount)
                {
                    case 0:
                        textMeshPro2.gameObject.SetActive(true);
                        break;
                    case 1:
                        textMeshPro3.gameObject.SetActive(true);
                        break;
                    case 2:
                        textMeshPro4.gameObject.SetActive(true);
                        break;
                    case 3:
                        textMeshPro5.gameObject.SetActive(true);
                        break;
                    case 4:
                        textMeshPro6.gameObject.SetActive(true);
                        break;
                    case 5:
                        textMeshPro7.gameObject.SetActive(true);
                        break;
                    case 6:
                        textMeshPro8.gameObject.SetActive(true);
                        break;
                    case 7:
                        textMeshPro9.gameObject.SetActive(true);
                        break;
                    case 8:
                        textMeshPro9.gameObject.SetActive(true);
                        break;
                    default:
                        break;
                }
                greenCount++;
            }
        }
        else
        {
            // Incorrect key was pressed
            textMeshPro1.color = Color.red;
            textMeshPro2.color = Color.red;
            textMeshPro3.color = Color.red;
            textMeshPro4.color = Color.red;
            textMeshPro5.color = Color.red;
            textMeshPro6.color = Color.red;
            textMeshPro7.color = Color.red;
            textMeshPro8.color = Color.red;
            textMeshPro9.color = Color.red;

            switch (greenCount)
            {
                case 0:
                    textMeshPro1.gameObject.SetActive(false);
                    break;
                case 1:
                    textMeshPro2.gameObject.SetActive(false);
                    break;
                case 2:
                    textMeshPro3.gameObject.SetActive(false);
                    break;
                case 3:
                    textMeshPro4.gameObject.SetActive(false);
                    break;
                case 4:
                    textMeshPro5.gameObject.SetActive(false);
                    break;
                case 5:
                    textMeshPro6.gameObject.SetActive(false);
                    break;
                case 6:
                    textMeshPro7.gameObject.SetActive(false);
                    break;
                case 7:
                    textMeshPro8.gameObject.SetActive(false);
                    break;
                case 8:
                    textMeshPro9.gameObject.SetActive(false);
                    break;
                default:
                    break;
            }
            switch (greenCount - 1)
            {
                case 0:
                    textMeshPro1.gameObject.SetActive(true);
                    break;
                case 1:
                    textMeshPro2.gameObject.SetActive(true);
                    break;
                case 2:
                    textMeshPro3.gameObject.SetActive(true);
                    break;
                case 3:
                    textMeshPro4.gameObject.SetActive(true);
                    break;
                case 4:
                    textMeshPro5.gameObject.SetActive(true);
                    break;
                case 5:
                    textMeshPro6.gameObject.SetActive(true);
                    break;
                case 6:
                    textMeshPro7.gameObject.SetActive(true);
                    break;
                case 7:
                    textMeshPro8.gameObject.SetActive(true);
                    break;
                case 8:
                    textMeshPro9.gameObject.SetActive(true);
                    break;
                default:
                    break;
            }


            // Increment redCount
            redCount++;
            greenCount--;

        }

        // Choose a new random rotation from the array
        currentRotationIndex = Random.Range(0, rotations.Length);

        // Apply the new rotation to the texts
        textMeshPro1.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro2.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro3.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro4.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro5.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro6.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro7.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro8.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
        textMeshPro9.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotations[currentRotationIndex]);
    }


}

