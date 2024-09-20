using UnityEngine;

public class DD2Player : MonoBehaviour
{
    public int damage = 1;
    public float attackDelay = 1.0f;
    private bool canAttack = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canAttack)
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                StartCoroutine(AttackDelay());
            }
        }
    }

    private System.Collections.IEnumerator AttackDelay()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackDelay);
        canAttack = true;
    }
}
