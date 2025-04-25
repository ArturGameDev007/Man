using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class AddresableScriptLoader :MonoBehaviour
{
    [SerializeField] private AssetReference _loadableSprite;
    [SerializeField] private Image _uiImage;

    private async void Start()
    {
        AsyncOperationHandle<Sprite> handle = _loadableSprite.LoadAssetAsync<Sprite>();
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Sprite sprite = handle.Result;
            _uiImage.sprite = sprite;
            Addressables.Release(handle);
        }
    }
}
