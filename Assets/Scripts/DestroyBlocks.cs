using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    [SerializeField] private LayerMask Blocks;
    [SerializeField] private TerrainGenerate TG;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Blocks))
            {
                if (hit.collider != null)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Blocks))
            {
                if (hit.collider != null)
                {
                    Vector3 hitPointLocal = hit.collider.transform.InverseTransformPoint(hit.point);

                    if (hitPointLocal.y < hit.collider.bounds.extents.y + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y + 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y + 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y + 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y + 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y + 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                        }
                    }
                    else if (hitPointLocal.y < -hit.collider.bounds.extents.y + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y - 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y - 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y - 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y - 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y - 0.01f), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                        }
                    }
                    else if (hitPointLocal.x < -hit.collider.bounds.extents.x + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x - 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x - 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x - 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x - 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x - 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                        }
                    }
                    else if (hitPointLocal.x < hit.collider.bounds.extents.x + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x + 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x + 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x + 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x + 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x + 0.01f), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                        }
                    }
                    else if (hitPointLocal.z < -hit.collider.bounds.extents.z + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z - 0.01f)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z - 0.01f)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z - 0.01f)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z - 0.01f)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z - 0.01f)), Quaternion.identity);
                                break;
                        }
                    }
                    else if (hitPointLocal.z < hit.collider.bounds.extents.z + 0.01f)
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z + 0.01f)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z + 0.01f)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z + 0.01f)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z + 0.01f)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z + 0.01f)), Quaternion.identity);
                                break;
                        }
                    }
                    else
                    {
                        switch (GameManager.GM.ChosenBlock)
                        {
                            case 1:
                                Instantiate(GameManager.GM.Grass, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(GameManager.GM.Dirt, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(GameManager.GM.Stone, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(GameManager.GM.Wood, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(GameManager.GM.Leaves, new Vector3(Mathf.RoundToInt(hit.point.x), Mathf.RoundToInt(hit.point.y), Mathf.RoundToInt(hit.point.z)), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
        }
    }
}