using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    float velocidadX = 0.0f;
    float velocidadY = 0.0f;
    float velocidadZ = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public Vector3 getVelocidad() {
        return new Vector3(velocidadX, velocidadY, velocidadZ);
    }

    public void setVelocidad(Vector3 velocidad)
    {
        velocidadX = velocidad.x;
        velocidadY = velocidad.y;
        velocidadZ = velocidad.z;
    }
}
class Particula(){
    public float velocidadI;
    public float velocidadF;
    public float radio;
    public float masa;
    public float posicion;

// constructor 
public Particula(float velocidadI,float velocidadF,float radio,float masa)
{
    this.velocidadI = velocidadI;   
    this.velocidadF = velocidadF;
    this.radio = radio;
    this.masa = masa;
}
public Vector3 getVelocidad() {
    return new Vector3(velocidadI, velocidadF, radio,masa);
}

public void setVelocidad(Vector3 velocidad)
{
    velocidadX = velocidad.x;
    velocidadY = velocidad.y;
    velocidadZ = velocidad.z;

}