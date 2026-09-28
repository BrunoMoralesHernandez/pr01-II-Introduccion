using UnityEngine;

public class ShowSpherePosition : MonoBehaviour
{
  void Start()
  {
    // Opción 1: Acceso directo al transform del GameObject
    Vector3 posDirecta = transform.position;

    // Opción 2: Usando GetComponent explícito como sugiere el enunciado
    Vector3 posComponent = GetComponent<Transform>().position;

    Debug.Log($"[transform.position] Posición de la esfera: {posDirecta}");
    Debug.Log($"[GetComponent<Transform>()] Posición de la esfera: {posComponent}");
  }
}