using UnityEngine;
using UnityEngine.SceneManagement;

public class animationSpeed : MonoBehaviour
{
     public Animator animator; // Arraste seu Animator aqui no Inspector
    public float speedStep = 0.1f; // Valor pelo qual a velocidade será alterada
    private float currentSpeed = 1.0f; // Velocidade inicial

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
        animator.speed = currentSpeed; // Definir a velocidade inicial
    }

    // Função para aumentar a velocidade
    public void IncreaseSpeed()
    {
        currentSpeed += speedStep;
        animator.speed = currentSpeed;
    }

    // Função para diminuir a velocidade
    public void DecreaseSpeed()
    {
        if (currentSpeed > 0)
        {
            currentSpeed -= speedStep;
            animator.speed = currentSpeed;
        }
    }

    public void resertAnimation()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
