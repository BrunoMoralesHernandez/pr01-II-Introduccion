/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 4: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Script asociado a la esfera que localiza el cubo y el cilindro en la escena
 * y calcula la distancia euclídea hasta cada uno de ellos.
 * @date Sep 28 2026
 * @version 1.0
 */

using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
  private GameObject _cubo;
  private GameObject _cilindro;

  public float distanciaAlCubo;
  public float distanciaAlCilindro;

  public void Start()
  {
    BuscarObjetos();
    CalcularDistancias();
    MostrarDistancias();
  }

  public void BuscarObjetos()
  {
    _cubo = GameObject.Find("Cube");
    _cilindro = GameObject.Find("Cylinder");
  }

  public void CalcularDistancias()
  {
    if (_cubo != null)
    {
      distanciaAlCubo = Vector3.Distance(transform.position, _cubo.transform.position);
    }

    if (_cilindro != null)
    {
      distanciaAlCilindro = Vector3.Distance(transform.position, _cilindro.transform.position);
    }
  }

  public void MostrarDistancias()
  {
    if (_cubo != null && _cilindro != null)
    {
      Debug.Log("Distancia de la esfera al Cubo: " + distanciaAlCubo);
      Debug.Log("Distancia de la esfera al Cilindro: " + distanciaAlCilindro);
    }
    else
    {
      Debug.LogWarning("No se encontro el Cubo o el Cilindro. Comprueba sus nombres o etiquetas en la jerarquia.");
    }
  }
}