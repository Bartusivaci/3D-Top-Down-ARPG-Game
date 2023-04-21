using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUI : MonoBehaviour
{
    public float skillResetTime = 0.3f;
    
    private Image image;
    private Color originalColor;

    private void Start()
    {
        image = GetComponent<Image>();
        originalColor = image.color;
    }

    public void GreyOut()
    {
        image.color = Color.grey;
        Invoke("ResetColor", skillResetTime);
    }

    private void ResetColor()
    {
        image.color = originalColor;
    }
}
