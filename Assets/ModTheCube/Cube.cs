using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float AngleX;
    public float cubeScale = 5f;
    public float angleY;
    public float anglez;

   

    
    void Start()
    {
        movingPos();
        InvokeRepeating("colourChange",5,5);
        InvokeRepeating("movingPos", 5, 5);

    }

    void colourChange()
    {

    float red = Random.value;
    float green = Random.Range(0, 1f);
    float blue = Random.Range(0, 1f);
    float alpha = Random.Range(0, 1f);
        Material material = Renderer.material;
        material.color = new Color(red, green, blue, alpha);
    }

  void movingPos()
    {
        {
            float xPos = Random.Range(0, 6);
            float yPos = Random.Range(0, 6);
            float zPos = Random.Range(0, 6);
            transform.position = new Vector3(xPos, yPos, zPos);

            
        }
    }
    void spinAngles()
    {
        AngleX = Random.Range(0, 5);
        angleY = Random.Range(0, 5);
        anglez = Random.Range(0, 7);
        transform.Rotate(AngleX * Time.deltaTime, angleY * Time.deltaTime, anglez * Time.deltaTime);
    }
    void Update()
    {
       // colourChange();
       // InvokeRepeating("movingPos", 5, 5);
         spinAngles();
            transform.localScale = Vector3.one * cubeScale;

    
    
            

    }
  
}

