using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class ThunderArrowSkill : Skill
{
    public override void Cast(GameObject parent)
    {
        parent.GetComponent<PlayerMovement>().LookAtTheMousePosition();
        parent.GetComponent<Animator>().Play("Standing Draw Arrow");
        //if(projectile != null)
        //{
        //    Transform center = parent.GetComponent<SkillHolder>().center;
        //    GameObject arrow = Instantiate(projectile, center.position, center.rotation);
        //}
    }
}
