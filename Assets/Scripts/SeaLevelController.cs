using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeaLevelController : MonoBehaviour
{
    public Transform gameElementTransform;
    public float seaLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        var x = GetComponent<Slider>();
        float sliderValue = x.value;
        Vector3 newPosition = gameElementTransform.position;
        newPosition.y = sliderValue;
        gameElementTransform.position = newPosition;
        seaLevel = (float)(sliderValue * 3.04347826);
}

}
