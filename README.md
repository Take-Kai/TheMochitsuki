# THE 餅つき
THE 餅つきは、小学生を対象とした餅つき体験ゲームです。

杵で1回餅をつき、臼で1回餅をこねることで餅つきを1回行ったという判定になり、制限時間20秒内にどれだけ餅つきをできたかを競うゲームです。

4人で協力して制作しましたが、私はUnityでのシステム構築とArduinoとUnityのシリアル通信のプログラム作成を担当しました。


## ハードウェアに関して
THE 餅つきでは、実際の餅つきと同じ動作で体験できるように、ピコピコハンマーで作った杵とダンボールで作った臼を使用します。

　　　<img src="https://github.com/Take-Kai/TheMochitsuki/assets/169955027/dbebed15-702d-4dd0-ac5d-fc1c5b6c9fd5" width="100">　　　　　　　　　　　<img src="https://github.com/Take-Kai/TheMochitsuki/assets/169955027/cb90d316-6fca-4d89-b8cc-3be6fd3a3ff8" width="200">

ピコピコハンマーで作った杵　　　　　　　　　ダンボールで作った臼



### 杵に関して
ピコピコハンマーの叩く部分の内部には小さなボタンが取り付けられており、残りのスペースには布が詰め込まれています。

叩いた時にジャバラ部分が縮まり、ボタンが布により押されるという構造になっています。

この小さなボタンからつながる配線はピコピコハンマーに穴あけ加工をすることで外部と接続できるようになっています。

ボタンの配線は後に述べる臼に取り付けられているArduinoに接続されています。



### 臼に関して
臼は主に段ボールとガムテープで作られています。

臼の表面は2つの領域に分かれており、杵で餅をつく領域と手で餅をこねる領域があります。

杵で餅をつく領域には黒いガムテープで「叩」と書かれています。

手で餅をこねる部分には大きな白いボタンが取り付けられており、このボタンを押すことで餅を1回こねたという判定になります。

臼の内部には小さなスペースが設けられており、そこにはArduinoマイコンが格納されています。

臼表面についているボタンと杵の内部に取り付けられた小さなボタンはArduinoに接続されており、このArduinoからUnityにデータ送信をしています。

この小さなスペースは臼側面からすぐに確認できるようになっており、配線のチェックなどを簡単に行うことができます。

<img src="https://github.com/Take-Kai/TheMochitsuki/assets/169955027/a75f9cda-ed4a-46fa-9149-1ada19dbbb71" width="200">

使用したArduinoマイコン
