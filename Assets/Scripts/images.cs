using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class images : MonoBehaviour
{
    public Image image1;
    public Image image1b;
    public Image image2;
    public Image image2b;
    public Image image3;
    public Image image4;
    public Image image4b;


    public TextMeshProUGUI seaLevelText;
    public TextMeshProUGUI year;

    public Slider slider;
    public SeaLevelController seaLevelController;

    private bool image1Active = false; // Add a boolean flag to track whether image1 is active
    private bool image1bActive = false;
    private bool image2Active = false;
    private bool image2bActive = false;
    private bool image3Active = false;
    private bool image4Active = false;
    private bool image4bActive = false;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
        seaLevelController = GameObject.FindGameObjectWithTag("Slider").GetComponent<SeaLevelController>();
        image1b.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        image3.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0f);
        
        // image1.gameObject.SetActive(false);
        image1b.gameObject.SetActive(false);
        // image2.gameObject.SetActive(false);
        // image2b.gameObject.SetActive(false);
        // image3.gameObject.SetActive(false);
        image4b.gameObject.SetActive(false);

        // image4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        
        float sliderValue = slider.value;
        float seaLevel = seaLevelController.seaLevel; 
        
        //displaying the projected sea level
        if (seaLevel >= 0.0f)
        {
            seaLevelText.text = "Sea level: " + seaLevel.ToString("F2") + "m";

        }
        
        
        //for displaying the projected year
        if (slider.value >= 0.0f)
        {
            float seaLevelRisePerYear = 2.2f / 100; // Convert cm to m
            float seaLevelRise = slider.value * 3.04f;
            int x = (int)(seaLevelRise / seaLevelRisePerYear);
            year.text = "Projected Year: " + (2023 + x);

        }


        //image1 Mermaid
        if (slider.value <= 6.0f && slider.value >= 0.2f)
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
                // image1.gameObject.SetActive(false);
                image1Active = false; // Set the boolean flag to false
                Debug.Log("Image 1 is inactive");
            }
        }



        //image1b Mermaid water
        if (slider.value <= 6.0f && slider.value >= 0.2f)
        {
            if (!image1bActive) // Only set image1b to active if it's not already active
            {
                image1b.gameObject.SetActive(true);
                image1bActive = true; // Set the boolean flag to true
                Debug.Log("Image 1b is active");
            }

            // Map the range of slider values to the range of desired scale values
            float normalizedValue = Mathf.InverseLerp(0.2f, 6.0f, slider.value);
            float scaleValue = Mathf.Lerp(1f, 1200f, normalizedValue);
            
            // Clamp the scale value
            scaleValue = Mathf.Min(scaleValue, 153.8203f);

            // Scale image1b on the y-axis
            Vector3 scale = image1b.transform.localScale;
            scale.y = scaleValue;
            image1b.transform.localScale = scale;
        }
        else
        {
            if (image1bActive)
            {
                // image1b.gameObject.SetActive(false);
                image1bActive = false; // Set the boolean flag to false
                Debug.Log("Image 1b is inactive");
            }
        }



        //image 2 Aros
        if (slider.value <= 21.0f && slider.value >= 2.6f)
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
                // image2.gameObject.SetActive(false);
                image2Active = false;
                Debug.Log("Image 2 is inactive");
            }
        }

        //image 2b(3) Aros Water

    if (slider.value <= 21.0f && slider.value >= 2.6f)
{
    if (!image3Active)
    {
        image3.gameObject.SetActive(true);
        image3Active = true;
        Debug.Log("Image 3 is active");
    }
    // Map the range of slider values to the range of desired scale values
    float normalizedValue = Mathf.InverseLerp(2.6f, 21.0f, slider.value);
    float scaleValue = Mathf.Lerp(1f, 130.89f, normalizedValue);
    
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
                // image3.gameObject.SetActive(false);
                image3Active = false;
                Debug.Log("Image 3 is inactive");
            }
        }

        //image 4 bridge 

                if (slider.value <= 13.15f && slider.value >= 0.2f)
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
                // image4.gameObject.SetActive(false);
                image4Active = false;
                Debug.Log("Image 4 is inactive");
            }
        }
        //image4b bridgewater
        if (slider.value <= 13.15f && slider.value >= 0.2f)
        {
            if (!image4bActive) // Only set image4b to active if it's not already active
            {
                image4b.gameObject.SetActive(true);
                image4bActive = true; // Set the boolean flag to true
                Debug.Log("Image 4b is active");
            }

            // Map the range of slider values to the range of desired scale values
            float normalizedValue = Mathf.InverseLerp(0.2f, 13.15f, slider.value);
            float scaleValue = Mathf.Lerp(1f, 153.8203f, normalizedValue);
            
            // Clamp the scale value
            scaleValue = Mathf.Min(scaleValue, 153.8203f);

            // Scale image4b on the y-axis
            Vector3 scale = image4b.transform.localScale;
            scale.y = scaleValue;
            image4b.transform.localScale = scale;
        }
        else
        {
            if (image4bActive)
            {
                // image4b.gameObject.SetActive(false);
                image4bActive = false; // Set the boolean flag to false
                Debug.Log("Image 4b is inactive");
            }
        }
    }
}
