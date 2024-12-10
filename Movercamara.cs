using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movercamara: MonoBehaviour
{
public int health = 1;   
public int level = 1;
public float speed = 1.2f;
void Start()
{
health = health + level;
print("Lives:" + health);
}
void Update ()
{
Vector3 newPosition =transform.position;
newPosition.z += speed * Time.deltaTime;
transform.position = newPosition;
}
}
