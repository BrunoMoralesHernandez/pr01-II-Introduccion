/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 2: Introducción C# 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Segundo ejercicio de la hoja de problemas. Script para mostrar
 * diferentes datos sobre una esfera.
 * @date Sep 28 2026
 * @version 1.0
 */
 
using UnityEngine;

public class prueba : MonoBehaviour
{
  // Vectores que se pide inicializar
  public Vector3 vector1 = new Vector3();
  public Vector3 vector2 = new Vector3();

  // Atributos para almacenar cada una de las variables
  public float magnitude1;
  public float magnitude2;
  public float angle;
  public float distance;
  public string masAlto;

  /*
   * Metoda start. Llama a metodos aux
   */
  public void Start()
  {
    GuardarInformacion();
    MostrarInformacion();
  }

  /*
   * Metodo para inicializar los atributos
   */
  public void GuardarInformacion()
  {
    magnitude1 = vector1.magnitude;
    magnitude2 = vector2.magnitude;
    angle = Vector3.Angle(vector1, vector2);
    distance = Vector3.Distance(vector1, vector2);
    if (vector1.y > vector2.y)
    {
        masAlto = "Vector 1 está más alto";
    }
    else if (vector2.y > vector1.y)
    {
        masAlto = "Vector 2 está más alto";
    }
    else
    {
        masAlto = "Ambos vectores están a la misma altura";
    }
  }

  /*
   * Metodo para mostrar atributos
   */
  public void MostrarInformacion()
  {
    Debug.Log("Magnitud de cada vector. Vec1 = " + magnitude1 + ". Vec2 = " + magnitude2);
    Debug.Log("Angulo que forman los vectores = " + angle);
    Debug.Log("Distancia entre vectores = " + distance);
    Debug.Log("Vector mayor altura: " + masAlto);
  }
}
