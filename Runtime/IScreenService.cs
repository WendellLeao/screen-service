using Cysharp.Threading.Tasks;

namespace WendellLeao.Screens
{
    public interface IScreenService
    {
        public UniTask<IUIScreen> OpenScreenAsync(UIScreenData screenData);
    }
}
