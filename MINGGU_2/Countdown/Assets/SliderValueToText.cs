using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider sliderUI;
    public Text textSliderValue;

    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    // Update is called once per frame
    public void ShowSliderValue()
    {
        string sliderMessage = "Slider value =" + sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}
