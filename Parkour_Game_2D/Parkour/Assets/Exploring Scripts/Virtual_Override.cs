using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virtual_Override : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon myWeapon1 = new Sword();
        Weapon myWeapon2 = new Bow();
        Weapon myweapon3 = new Sword();

        myWeapon1.Attack();
        myWeapon2.Attack();
        myweapon3.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public class Weapon: MonoBehaviour
{
    public virtual void Attack()
    {

        Debug.Log("Attack");

    }


}

public class Sword: Weapon
{
    public override void Attack()
    {
        Debug.Log("Sword attack");
    }

}

public class Bow: Weapon
{

    public override void Attack()
    {
        Debug.Log("Bow attack");
    }

}