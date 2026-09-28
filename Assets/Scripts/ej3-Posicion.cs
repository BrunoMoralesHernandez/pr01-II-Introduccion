/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 3: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Muestra en pantalla el vector con la posición de la esfera en el mundo
 * utilizando tanto 'transform.position' como 'GetComponent<Transform>()'.
 * @date Sep 28 2026
 * @version 1.0
 */

using UnityEngine;

public class PosicionEsfera : MonoBehaviour
{
  public Vector3 posicionDirecta;
  public Vector3 posicionComponente;

  public void Start()
  {
    GuardarPosicion();
    MostrarPosicion();
  }

  public void GuardarPosicion()
  {
    // Opcion 1: Acceso directo al transform del GameObject
    posicionDirecta = transform.position;

    // Opcion 2: Usando GetComponent explicito
    posicionComponente = GetComponent<Transform>().position;
  }
  public void MostrarPosicion()
  {
    Debug.Log("Posicion usando transform.position: " + posicionDirecta);
    Debug.Log("Posicion usando GetComponent<Transform>(): " + posicionComponente);
  }
}