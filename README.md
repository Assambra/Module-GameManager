<a name="readme-top"></a>
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
# 
<!-- PROJECT LOGO -->
<div align="center">
    <a href="https://github.com/Assambra">
        <img src="Github/Images/Assambra-Logo-512x512.png" alt="Logo" width="80" height="80">
    </a>
    <h1 align="center">Modul-GameManager</h1>
    <p align="center">
        The GameManager is a module and part of our <a href="https://github.com/Assambra/Unity-Game-Framework">Unity Game Framework</a>
    </p>
</div>
<br /> 
    <h4>Key Features</h4>
    <ul>
        <li>We use one persistent Scene all other scene will be load additive/async the last one will unloaded async.</li>
        <li>For each scene we can create a scene asset (ScriptableObject) that holds a List of SceneUISet also a asset (ScriptableObject). You can also add multiple Unity scenes per "Scene".</li> 
        <li>A SceneUISet (ScriptableObject) containing all the UIElement prefabs as a Set in an Array that we want to instantiate in the Scene. You can also add multiple sets per scene.</li>
        <li>All Scene UIs will automatically be instantiated for the new scene and last Scene UIs will be destroyed.</li>
        <li>We only instantiate uIElements that were not present in the last SceneUISet (are already instantiated). Only those that are no longer present in the new SceneUISet but were instantiated in the last scene are destroyed.</li>
        <li>GameState machine to use in switch case statement and also event driven to use in e.g UI Elements, events for SceneChanged(scene), GameStateChanged(newScene, lastScene).</li>
    </ul>
    <br />
    <p align="center">
    <a href="https://github.com/Assambra/Module-GameManager/wiki"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Assambra/Module-GameManager/releases">Get Latest</a>
    ·
    <a href="https://github.com/Assambra/Module-GameManager/issues">Report Bug</a>
    ·
    <a href="https://github.com/Assambra/Module-GameManager/issues">Request Feature</a>
  </p>
<br />

<!-- TABLE OF CONTENTS -->
<details>
    <summary>Table of Contents</summary>
    <ol>
        <li><a href="#demo-image">Demo Image</a></li>
        <li><a href="#the-unity-game-framework">The Unity Game Framework</a>
        <li><a href="#built-with">Built With</a></li>
        <li><a href="#modules">Modules</a></li>
        <li><a href="#contact">Contact</a></li>
    </ol>
</details>
<br />

<!-- Demo Image-->
## Demo Image
![Our Demo Scene][product-screenshot]
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ABOUT THE PROJECT -->
## The Unity Game Framework
Learn more about the Unity Game Framework <a href="https://github.com/Assambra/Unity-Game-Framework#the-unity-game-framework">here</a>
<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With
[![Unity][Unity.com]][Unity-url]
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MODULES -->
## Modules
<ul>
    <li><a href="https://github.com/Assambra/Module-GameManager">GameManager</a></li>
    <li><a href="https://github.com/Assambra/Module-MouseHandler">MouseHandler</a></li>
    <li><a href="https://github.com/Assambra/Module-CameraController">CameraController</a></li>
</ul>
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- Contact -->
## Contact
Join us on <a href="https://discord.gg/qyCdkYSWVG">Discord</a>
<p align="right">(<a href="#readme-top">back to top</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/Assambra/Module-GameManager.svg?style=for-the-badge
[contributors-url]: https://github.com/Assambra/Module-GameManager/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Assambra/Module-GameManager.svg?style=for-the-badge
[forks-url]: https://github.com/Assambra/Module-GameManager/network/members
[stars-shield]: https://img.shields.io/github/stars/Assambra/Module-GameManager.svg?style=for-the-badge
[stars-url]: https://github.com/Assambra/Module-GameManager/stargazers
[issues-shield]: https://img.shields.io/github/issues/Assambra/Module-GameManager.svg?style=for-the-badge
[issues-url]: https://github.com/Assambra/Module-GameManager/issues
[license-shield]: https://img.shields.io/github/license/Assambra/Module-GameManager.svg?style=for-the-badge
[license-url]: https://github.com/Assambra/Module-GameManager/blob/main/LICENSE
[product-screenshot]: Github/Images/GameManager-Demo-v1.0.0.jpg
[Unity-url]: https://www.unity.com 
[Unity.com]: https://img.shields.io/badge/Unity-000000.svg?style=for-the-badge&logo=unity&logoColor=white

