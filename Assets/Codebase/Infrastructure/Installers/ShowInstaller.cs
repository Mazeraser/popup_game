using UnityEngine;
using Zenject;
using Assets.Codebase.Mechanics.CoreMechanic;

public class ShowInstaller : MonoInstaller
{
    [SerializeField]
    private ShowImage _showImage;
    [SerializeField]
    private ShowMusic _showMusic;

    public override void InstallBindings()
    {
        var image = Container.InstantiatePrefabForComponent<ShowImage>(_showImage);
        var music = Container.InstantiatePrefabForComponent<ShowMusic>(_showMusic);

        Container.BindInstance(image).AsCached().NonLazy();
        Container.BindInstance(music).AsCached().NonLazy();
    }
}