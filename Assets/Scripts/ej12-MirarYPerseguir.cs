/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes 2026-2027
 * 4º Año de Carrera
 * Ejercicio 12: Scripts de Movimiento 
 *
 * @author Bruno Morales Hernandez alu0101664309@ull.edu.es
 * @brief Orienta el eje Z positivo del cubo hacia la esfera mediante LookAt
 * y avanza frontalmente sin modificar su altura.
 * @date Oct 5 2026
 * @version 1.0
 */

using UnityEngine;

public class MirarYPerseguir : MonoBehaviour
{
  // Referencia al objetivo que se va a mirar y perseguir
  public Transform targetEsfera;

  // Velocidad de avance continuo hacia el frente
  public float speed = 3.0f;

  /*
   * Metodo Update. Orienta y desplaza al objeto en cada frame
   */
  void Update()
  {
    MirarYAvanzar();
  }

  /*
   * Rota el eje frontal hacia la esfera y avanza hacia adelante en espacio local
   */
  private void MirarYAvanzar()
  {
    if (targetEsfera == null) return;

    // 1. Creamos un punto objetivo ficticio con la misma altura Y del cubo
    // para que la orientacion ocurra únicamente sobre el plano horizontal
    Vector3 puntoObjetivo = new Vector3(
      targetEsfera.position.x,
      transform.position.y,
      targetEsfera.position.z
    );

    // Calculamos la distancia para evitar rotaciones bruscas si estan pegados
    float distancia = Vector3.Distance(transform.position, puntoObjetivo);

    if (distancia > 0.1f)
    {
      // 2. Rotamos el cubo para que su eje Z positivo mire hacia el objetivo
      transform.LookAt(puntoObjetivo);

      // 3. Avanzamos hacia adelante respecto a su propio sistema de referencia (Space.Self)
      transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
  }
}