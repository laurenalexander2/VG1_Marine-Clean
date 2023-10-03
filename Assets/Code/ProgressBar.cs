using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider progressSlider;

    public void SetProgress(float progress) {
        if (progressSlider) {
            progressSlider.value = progress;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
