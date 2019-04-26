using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Основной класс, отвечающий за запуск базового функционала 
/// </summary>

public class Bootstrapper : MonoBehaviour
{
    IObjectsStorage _objectsStorage;
    IUpdateManager _updateManager;
    ILevelManager _levelManager;
    IElementsCreator _elementsCreator;
    ILogicManager _logicManager;

    //IUnitCreatePublisher _publisher;


    void Start()
    {
        var updateManagerObject = new GameObject("UpdateManager");
        _updateManager = updateManagerObject.AddComponent<UpdateManager>();

        _objectsStorage = new ObjectsStorage();
        _elementsCreator = new ElementsCreator(_objectsStorage);
        _levelManager = new LevelManager(_elementsCreator);
        _logicManager = new LogicManager(_objectsStorage, _updateManager, _levelManager, _elementsCreator);
        _logicManager.CreateNewElements();
        //_logicManager.Ready();
        //_logicManager.Shift();
        //_logicManager.CreateElements();


        _updateManager.Start(); //начало игры


        // _publisher = new UnitCreatePublisher();
        //_loadManager = new LoadManager();

        // _gameManager = new GameManager(_objectsStorage, _publisher);

        // _objectsStorage.StartListsInitialization();
        // _gameManager.Activate();
    }
}
