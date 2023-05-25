using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class images : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;

    public TextMeshProUGUI seaLevelText;

    public Slider slider;
    public SeaLevelController seaLevelController;

    private bool image1Active = false; // Add a boolean flag to track whether image1 is active
    private bool image2Active = false;
    private bool image3Active = false;
    private bool image4Active = false;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
        seaLevelController = GameObject.FindGameObjectWithTag("Slider").GetComponent<SeaLevelController>();
        image3.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
        // image4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        
        float sliderValue = slider.value;
        float seaLevel = seaLevelController.seaLevel; 
        
        if (seaLevel >= 0.0f)
        {
            seaLevelText.text = "Sea level: " + seaLevel.ToString("F2") + "m";

        }

        if (slider.value <= 10.0f && slider.value >= 1.0f)
        {
            if (!image1Active) // Only set image1 to active if it's not already active
            {
                image1.gameObject.SetActive(true);
                image1Active = true; // Set the boolean flag to true
                Debug.Log("Image 1 is active");
            }
        }
        else
        {
            if (image1Active)
            {
                image1.gameObject.SetActive(false);
                image1Active = false; // Set the boolean flag to false
                Debug.Log("Image 1 is inactive");
            }
        }

        //image 2
        if (slider.value <= 21.0f && slider.value >= 16.2f)
        {
            if (!image2Active)
            {
                image2.gameObject.SetActive(true);
                image2Active = true;
                Debug.Log("Image 2 is active");
            }
        }
        else
        {
            if (image2Active)
            {
                image2.gameObject.SetActive(false);
                image2Active = false;
                Debug.Log("Image 2 is inactive");
            }
        }

        //image 3

        if (slider.value <= 21.0f && slider.value >= 16.3f)
        {
            if (!image3Active)
            {
                image3.gameObject.SetActive(true);
                image3Active = true;
                Debug.Log("Image 3 is active");
            }
            // Map the range of slider values to the range of desired scale values
            float normalizedValue = Mathf.InverseLerp(16.3f, 19.0f, slider.value);
            float scaleValue = Mathf.Lerp(1f, 200f, normalizedValue);
            
            // Clamp the scale value
            scaleValue = Mathf.Min(scaleValue, 153.8203f);

            // Scale image3 on the y-axis
            Vector3 scale = image3.transform.localScale;
            scale.y = scaleValue;
            image3.transform.localScale = scale;
        }
        else
        {
            if (image3Active)
            {
                image3.gameObject.SetActive(false);
                image3Active = false;
                Debug.Log("Image 3 is inactive");
            }
        }

        //image 4

                if (slider.value <= 10.0f && slider.value >= 1.0f)
        {
            if (!image4Active)
            {
                image4.gameObject.SetActive(true);
                image4Active = true; 
                Debug.Log("Image 4 is active");
            }
        }
        else
        {
            if (image4Active)
            {
                image4.gameObject.SetActive(false);
                image4Active = false;
                Debug.Log("Image 4 is inactive");
            }
        }
    }
}
