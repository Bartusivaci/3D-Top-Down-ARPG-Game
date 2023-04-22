using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class MagicArrowSkill : Skill
{
    public override void Cast(GameObject parent)
    {
        parent.GetComponent<PlayerMovement>().LookAtTheMousePosition();
        parent.GetComponent<Animator>().Play("Magic Arrow Draw");
    }
}
