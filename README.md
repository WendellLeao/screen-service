# Screen Service

Scene-based UI screen navigation service for Unity projects.

## Requirements

Add these dependencies **first**, before installing this package. The Unity Package Manager does not resolve git-URL dependencies automatically, so skipping any of them will throw an exception at runtime:

- [WendellLeao.ServiceLocator](https://github.com/WendellLeao/service-locator.git)
- [UniTask](https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask)

## Installation

Add the package via the Unity Package Manager using a git URL:

```
https://github.com/WendellLeao/screen-service.git
```

To pin a specific version, append `#v1.0.0` (or any tag) to the URL.

## Usage

1. Create a scene per screen, with a `UIScreen` subclass on a root GameObject.
2. Create a `UIScreenData` asset per screen (`Create > WendellLeao > Screens > UI Screen Data`), setting its `id`, `sceneName` (matching the screen's scene), and `screenType`.
3. Add a `ScreenService` component to a persistent GameObject.

```csharp
using WendellLeao.Screens;
using WendellLeao.ServiceLocator;

IScreenService screenService = Locator.Get<IScreenService>();

IUIScreen screen = await screenService.OpenScreenAsync(screenData);
```

`ScreenType.Single` hides the previous screen on top while opened and shows it again once closed. `ScreenType.Additive` opens on top without hiding anything underneath.

A screen closes itself by raising `IUIScreen.OnCloseRequested`, which `UIScreen` does automatically when its assigned close `Button` is clicked.

`ScreenService` registers itself as `IScreenService` on `Awake` and unregisters on `OnDestroy`.
