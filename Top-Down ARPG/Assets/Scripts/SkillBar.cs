using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillBar : MonoBehaviour
{
    public SkillUI skillQ;
    public SkillUI skillW;
    public SkillUI skillE;
    public SkillUI skillR;

    private EventSystem eventSystem;

    private void Start()
    {
        eventSystem = EventSystem.current;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            eventSystem.SetSelectedGameObject(skillQ.gameObject);
            skillQ.GreyOut();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            eventSystem.SetSelectedGameObject(skillW.gameObject);
            skillW.GreyOut();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            eventSystem.SetSelectedGameObject(skillE.gameObject);
            skillE.GreyOut();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            eventSystem.SetSelectedGameObject(skillR.gameObject);
            skillR.GreyOut();
        }
    }
}
