# Visual Effect

Kapı mekaniği olan koşu oyunları için hazırlanmış bir görsel efekt denemesi. Vurulan engel kırılıyor, içinden çıkan çekirdek yere düşüp büyüyerek bir kapıya dönüşüyor.

![Efekt](Images/VisualEffect.gif)

## Neden?

Koşu oyunlarındaki kapıların sahneye sıradan bir şekilde konması yerine, oyuncunun ateşiyle ortaya çıkan bir ödül gibi hissettirmesi için yapıldı.

## Nasıl çalışıyor

- Engel, dönerek oyuncuya doğru yuvarlanan bir top. Üzerinde kalan canı yazıyor.
- Silahtan çıkan her mermi engelin canını azaltıyor.
- Can bittiğinde engel kırılıyor, içindeki enerji çekirdeği yere düşüyor ve büyüyerek geçilebilecek bir kapıya dönüşüyor.

## Ekranlar

| | | |
|---|---|---|
| ![Görüntü 1](Images/Picture%201.png) | ![Görüntü 2](Images/Picture%202.png) | ![Görüntü 3](Images/Picture%203.png) |

Videolar: [30 fps](Images/EffectVideo30Fps.mp4) · [60 fps](Images/EffectVideo60Fps.mp4)

## Teknik

| | |
|---|---|
| **Motor** | Unity 2021.3.7f1, URP |
| **Kullanılanlar** | DOTween, görsel efektler |
| **Kod** | `Assets/ballScript.cs` (engel ve can), `Assets/gunScript.cs`, `Assets/bulletScript.cs` |
| **GitHub'a yükleme** | Mart 2023 |
