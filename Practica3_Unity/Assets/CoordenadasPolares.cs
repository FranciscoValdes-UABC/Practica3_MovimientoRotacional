using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoordenadasPolares : MonoBehaviour
{
    public float r;
    public Text posLabel;
    public Text velLabel;
    public Text acelLabel;
    public Text tiempoLabel;
    public Text mensajeClic;
    public GameObject circulo;

    private float posAngular;
    private float velAngular;
    private float acelAngular;
    private float t = 0;
    private float click = 0;
    // Start is called before the first frame update
    void Start()
    {
        circulo.transform.localScale = new Vector3(2 * r, 2 * r, 2 * r);
        tiempoLabel.text = "Tiempo: " + t;

        posAngular = (-1 - 0.6f * t + 0.25f * (Mathf.Pow(t, 2)));
        posLabel.text = "Pos Angular: " + posAngular;

        velAngular = (-0.6f + 0.5f * t);
        velLabel.text = "Vel Angular: " + velAngular;

        acelAngular = 0.5f;
        acelLabel.text = "Acel Angular: " + acelAngular;

        transform.position = Polares(r, posAngular);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click = 1;
            Destroy(mensajeClic);
        }
        if (click == 1)
        {
            t += Time.deltaTime;
            tiempoLabel.text = "Tiempo: " + t;

            posAngular = (-1 - 0.6f * t + 0.25f * (Mathf.Pow(t, 2)));
            posLabel.text = "Pos Angular: " + posAngular;

            velAngular = (-0.6f + 0.5f * t);
            velLabel.text = "Vel Angular: " + velAngular;

            acelAngular = 0.5f;
            acelLabel.text = "Acel Angular: " + acelAngular;

            transform.position = Polares(r, posAngular);
        }
    }

    Vector3 Polares(float r, float angulo)
    {
        Vector3 pos = new Vector3(r * Mathf.Cos(angulo), r * Mathf.Sin(angulo), 0);
        return pos;
    }
}
