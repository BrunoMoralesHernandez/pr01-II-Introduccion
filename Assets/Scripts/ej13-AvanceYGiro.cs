/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 13: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Rota un objeto usando el eje Horizontal y traslada continuamente
 * la entidad hacia su frente (transform.forward) mostrando un rayo de depuracion.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class AvanceYGiro : MonoBehaviour
{
  // Velocidad de avance lineal continuo
  public float speed = 3.0f;

  // Velocidad de rotacion angular en grados por segundo
  public float rotationSpeed = 100.0f;

  // Longitud de la linea visual de depuracion
  public float longitudRayo = 3.0f;

  /*
   * Metodo Update. Aplica rotacion por entrada, traslacion frontal y dibuja el rayo
   */
  void Update()
  {
    RotarYAvanzar();
    DibujarRayoDireccion();
  }

  /*
   * Captura el eje horizontal para girar y desplaza el objeto hacia su frente
   */
  private void RotarYAvanzar()
  {
    // 1. Obtenemos el valor del eje Horizontal (-1 a 1)
    float entradaHorizontal = Input.GetAxis("Horizontal");

    // 2. Calculamos los grados de giro y rotamos sobre el eje vertical local (Y)
    float gradosGiro = entradaHorizontal * rotationSpeed * Time.deltaTime;
    transform.Rotate(0.0f, gradosGiro, 0.0f);

    // 3. Avanzamos hacia adelante usando la direccion actual del objeto (transform.forward)
    // Se utiliza Space.World porque transform.forward ya esta en coordenadas mundiales
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
  }

  /*
   * Dibuja un rayo en tiempo de ejecucion en la direccion transform.forward
   */
  private void DibujarRayoDireccion()
  {
    // Dibuja una linea de color rojo desde la posicion actual hacia adelante
    Debug.DrawRay(transform.position, transform.forward * longitudRayo, Color.red);
  }
}