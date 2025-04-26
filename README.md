# ManRunner
![Gameplay](https://github.com/user-attachments/assets/19f73422-1c80-4249-a197-5bdfba438827)
![Finish](https://github.com/user-attachments/assets/c0c2c359-19b4-4be2-93c7-e90b69b5ef18)

https://github.com/user-attachments/assets/e06bc945-9513-4a8e-b00e-6b786cd03200

*3-ех уровневый Pet-project формата 3D ManRunner разработано на инструментах таких как: C# & Unity.*
*В ходе разработки были реазованы следующее: *
+ реализация игровой логики
+ механика персонажа (управление)
+ UI
+ DOTWeen
+ Audio
+ 3 level gameplay
+ Препятствия
+ Oclussion Culing
+ Системы частиц для эффектов собирания монет и празднования прохождения уровня

*Улучшение производительности игры для обеспечения плавного игрового процесса:*
- [X] Метод GetComponent() в  Awake() - метод кэширования для избежания снижения производительности вместо метода Update()
- [X] Минимизировал методы Instantiate() и Destroy()
- [X] Оптимизировал, материалы и текстуры, уменьшив из качество для стабильности программы
- [X] Включение Oclussion Culling - позволяет польностью не рендерить объект, который не входит в поле зрения камеры
- [X] Избежал методов поиска по сцене, для быстроты приняти ярешения программы
- [X] Инструмент созданий аниммаций DOTWeen помог с решением повысить производительность, вместо того-же Animator

*Для более безопасности и повторения кода проекта, внедрял Объекно Ориентированное Программирование (ООП)*
*Пример из проекта ManRunner:*
```c#
public abstract class Window :MonoBehaviour
{
    [SerializeField] private EndPanelAnimation _animation;
    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioSource _gameplay;

    protected internal virtual void Enable()
    {
        ActiveWindow();
        DisableSoundGameplay();
        SoundPlay();
    }

    private void ActiveWindow()
    {
        gameObject.SetActive(true);
        _animation.Play();
    }

    private void DisableSoundGameplay()
    {
        _gameplay.enabled = false;
    }

    private void SoundPlay()
    {
        _sound.Play();
    }
}
public class LoseView :Window
{
    protected internal override void Enable()
    {
        base.Enable();
    }
}

public class WinView :Window
{
    protected internal override void Enable()
    {
        base.Enable();
    }
}
```


