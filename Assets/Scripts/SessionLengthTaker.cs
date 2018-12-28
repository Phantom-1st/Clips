using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SessionLengthTaker : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private UnityEngine.UI.Text sliderText;
    [HideInInspector] public float sliderValue=60;
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            slider.gameObject.SetActive(false);
        }
        sliderText.text = sliderValue.ToString() + " minutes";
	}

    public void UpdateSliderValue()
    {
        sliderValue = slider.value;
    }
}
