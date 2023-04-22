using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IceShot : Skill
{
    public override void Cast(GameObject parent)
    {
        parent.GetComponent<PlayerMovement>().LookAtTheMousePosition();
        parent.GetComponent<Animator>().Play("Ice Shot Draw");
    }
}
