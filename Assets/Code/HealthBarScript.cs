using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

public Slider slider;
private Image healthBarImage;
private float max;

  public void SetMaxHealth(float health) {
  slider.maxValue = health;
  max = slider.maxValue;
  }
  public void SetHealth(float health) {
   slider.value = health;
   UpdateHealthBarColor();
  }
  void Start(){
          GameObject childObject = GameObject.FindWithTag("health");
          //GameObject childObject = GameObject.FindWithTag("health");
          //Debug.Log("Found GameObject with tag 'health'");
          //Transform childTransform = slider.transform.FindWithTag("health");
          healthBarImage = childObject.GetComponentInChildren<Image>();
          //healthBarImage = GetComponent<Image>();
          //healthBarImage = slider.GetComponentInChildren<Image>();
          healthBarImage.color = Color.green;
  }
  private void UpdateHealthBarColor()
  {
      //float normalizedHealth = 1/4;
          // Assuming the Image component is on the same GameObject as HealthBarScript
          if(slider.value < max/4){
            healthBarImage.color = Color.red;
          }

      // If healthBar also has a Slider component, you can update its value
      //healthBar.healthSlider.value = normalizedHealth;
  }



}
