using UnityEngine;

namespace WendellLeao.Screens
{
    [CreateAssetMenu(menuName = "WendellLeao/Screens/UI Screen Data", fileName = "NewUIScreenData")]
    public sealed class UIScreenData : ScriptableObject
    {
        [SerializeField]
        private string id;
        [SerializeField]
        private string sceneName;
        [SerializeField]
        private ScreenType screenType;

        public string Id => id;
        public string SceneName => sceneName;
        public ScreenType ScreenType => screenType;
    }
}
