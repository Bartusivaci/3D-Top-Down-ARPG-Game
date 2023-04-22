using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillHolder : MonoBehaviour
{
    public Skill skill1;
    public Skill skill2;
    public Skill skill3;
    public Skill skill4;

    public Transform center;

    private PlayerMovement player;

    private void Start()
    {
        player = GetComponent<PlayerMovement>();
    }


    private void Update()
    {
        if (!player.GetIsAttacking())
        {


            if (Input.GetKey(KeyCode.Q))
            {
                skill1.Cast(gameObject);
            }
            if (Input.GetKey(KeyCode.W))
            {
                skill2.Cast(gameObject);
            }
            if (Input.GetKey(KeyCode.E))
            {
                skill3.Cast(gameObject);
            }
            if (Input.GetKey(KeyCode.R))
            {
                skill4.Cast(gameObject);
            }

        }
    }

    public void InstantiateEffect(int num)
    {
        switch (num)
        {
            case 1:
                GameObject arrow1 = Instantiate(skill1.projectile, center.position, center.rotation);
                Destroy(arrow1, 5f);
                break;
            case 2:
                GameObject arrow2 = Instantiate(skill2.projectile, center.position, center.rotation);
                Destroy(arrow2, 5f);
                break;
            case 3:
                GameObject arrow3 = Instantiate(skill3.projectile, center.position, center.rotation);
                Destroy(arrow3, 5f);
                break;
            case 4:
                GameObject arrow4 = Instantiate(skill4.projectile, center.position, center.rotation);
                Destroy(arrow4, 5f);
                break;
        }
    }

}
