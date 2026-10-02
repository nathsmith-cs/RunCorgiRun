using UnityEngine;

public class Corgi : MonoBehaviour
{
    private SpriteRenderer corgiSpriteRenderer;

    public void Awake()
    {
        corgiSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector2 direction)
    {
        
        FaceCorrectDirection(direction);
        
        Vector2 movement = direction * Time.deltaTime * GameParameters.CorgiMoveSpeed;
        corgiSpriteRenderer.transform.Translate(movement);

        corgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(corgiSpriteRenderer);
    }
    
    
    
    public void FaceCorrectDirection(Vector2 direction)
    {
        
        if (direction.x > 0)
        {
            corgiSpriteRenderer.flipX = false;
        }
        
        if (direction.x < 0)
        {
            corgiSpriteRenderer.flipX = true;
        }
        
    }

    public Vector3 GetPosition()
    {
        return corgiSpriteRenderer.transform.position;
    }
}
