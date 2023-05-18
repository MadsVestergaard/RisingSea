using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class images : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;

    public Text text1;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
        image1.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        float sliderValue = slider.value;
        Debug.Log(sliderValue);

        if (slider.value <= 10.0f && slider.value >= 1.0f)
        {
            image1.gameObject.SetActive(true);
            // text1.text = "This is the text for image 1";
            Debug.Log("Image 1 is active");
        }
        else
        {
            image1.gameObject.SetActive(false);
            Debug.Log("Image 1 is inactive");
        }


        //make the above code block for the rest of the images 2-5
        if (slider.value <= 20.0f && slider.value >= 11.0f)
        {
            image2.gameObject.SetActive(true);
            Debug.Log("Image 2 is active");
        }
        else
        {
            image2.gameObject.SetActive(false);
            Debug.Log("Image 2 is inactive");
        }

        // if (slider.value <= 30.0f && slider.value >= 21.0f)
        // {
        //     image3.gameObject.SetActive(true);
        //     Debug.Log("Image 3 is active");
        // }
        // else
        // {
        //     image3.gameObject.SetActive(false);
        //     Debug.Log("Image 3 is inactive");
        // }

        // if (slider.value <= 40.0f && slider.value >= 31.0f)
        // {
        //     image4.gameObject.SetActive(true);
        //     Debug.Log("Image 4 is active");
        // }
        // else
        // {
        //     image4.gameObject.SetActive(false);
        //     Debug.Log("Image 4 is inactive");
        // }
        
    }
}
