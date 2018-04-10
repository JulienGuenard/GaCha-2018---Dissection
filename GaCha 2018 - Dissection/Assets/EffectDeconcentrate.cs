using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectDeconcentrate : MonoBehaviour
{

    public Slider slider;
    public HandController hand;

    // Use this for initialization
    void Start()
    {
        EventDeconcentrate.deconcentrate += Deconcentrate;
        EventDeconcentrate.dropItem += itemDropped;
    }

    void Deconcentrate(float ratio)
    {
        slider.value += ratio;
        Debug.Log("Deconcentrated");
    }

    void itemDropped()
    {
        slider.value = 0;
        hand.Drop();
        Debug.Log("Item Dropped");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Deconcentrate(0.3f);
        slider.value -= 0.001f;
        if(slider.value > 0.99f)
        {
            itemDropped();
        }
    }
}
