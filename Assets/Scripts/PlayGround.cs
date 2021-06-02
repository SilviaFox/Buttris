using UnityEngine;

public class PlayGround : MonoBehaviour
{

    [SerializeField] GameObject gridPiece;
    int bufferArea = 2;

    // Start is called before the first frame update
    void Awake()
    {

        // Playspace - Buffer area
        transform.localScale = new Vector3(GameManager.width, GameManager.height - bufferArea);
    

        transform.position = new Vector3(transform.localScale.x /2, transform.localScale.y / 2);
        // GameManager.width = Mathf.RoundToInt(transform.localScale.x);
        // GameManager.height = Mathf.RoundToInt(transform.localScale.y);
        GameManager.spawnPoint = new Vector3(Mathf.FloorToInt(GameManager.width / 2), GameManager.height - 1.5f);

        if (GameSettings.enableGrid)
            for (int x = 0; x < GameManager.width; x++)
            {
                for (int y = 0; y < GameManager.height - bufferArea; y++)
                {
                    Instantiate(gridPiece, new Vector3(x + 0.5f,y + 0.5f), new Quaternion()).transform.SetParent(transform);
                }
            }

        Camera cam = FindObjectOfType<Camera>();
        cam.orthographicSize = (GameManager.height - bufferArea + GameManager.width) / 3 + 2;
        cam.transform.position = new Vector3(transform.position.x, (GameManager.height - bufferArea) / 2, -10);
    }

    void Start()
    {
        // InputScript.input.Gameplay.Enable();
    }

}
