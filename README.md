# THE 餅つき
THE 餅つきは、小学生を対象とした餅つき体験ゲームです。

杵で1回餅をつき、臼で1回餅をこねることで餅つきを1回行ったという判定になり、制限時間20秒内にどれだけ餅つきをできたかを競うゲームです。

4人で協力して制作しましたが、私はUnityでのシステム構築とArduinoとUnityのシリアル通信のプログラム作成を担当しました。


## ハードウェアについて
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


## ソフトウェアについて
THE 餅つきはのシステム構築にはUnityを用いました。

スタート画面、プレイ画面、リザルト画面の3つに分けてそれぞれのシーンでプログラムを分けています。

このリポジトリ上にあるフォルダのうち、StartSceneにはスタート画面に関するソースコード、PlaySceneにはプレイ画面に関するソースコード、ResultSceneにはリザルト画面に関するソースコードが入っています。

### スタート画面
<img alt="Start" src="https://github.com/Take-Kai/TheMochitsuki/assets/169955027/88e619be-0135-4b37-9d5b-0ed0930dc20a" width="500">

スタート画面には餅つきのイラスト、うさぎが餅をついているイラスト、タイトルが記載されています。タイトルの下には、「臼のボタンを押してね」と表示されています。この表示は点滅しており、強調されています。

### プレイ画面
<img alt="playing" src="https://github.com/Take-Kai/TheMochitsuki/assets/169955027/97d6ee7d-174f-4ab6-a53d-c2dc93aa3fd6" width="500">

プレイ画面に移ると、まずは「エンターキーを押してね」と表示されます。ここでエンターキーを押すと、餅つきゲームが始まるまでのカウントダウンがスタートします。

カウントダウンが「3...2...1...」と進むと、「スタート！」と表示され、餅つきゲームがスタートします。

スタートしたらピコピコハンマーで作成した杵と段ボールの臼を用いて、実際の餅つきと同じ動作をすることで餅つき回数がカウントされていきます。

杵で餅をつく動作をすると画面上の杵のイラストが餅をつくアニメーションをし、臼についているボタンを押して餅をこねる動作をすると画面上の手のイラストが餅をこねるアニメーションをします。

また、左右に表示されているウサギのイラストは常にジャンプしているアニメーションが再生されています。

この際に20秒がカウントダウンされており、この間にどれだけ餅をつけたかを競います。

20秒が経過したら「終了！」と表示され、餅つき動作を行えなくなります。

その後は3秒程度経過した後にリザルト画面に遷移します。


### リザルト画面



リザルト画面に遷移すると、何回餅をつくことができたのかを表示されています。

その下には画面には「タイトル」ボタンと「もういちど」ボタンが表示されています。

臼に取り付けられたボタンを押すことで「もういちど」ボタンを押しことに相当し、杵のボタンを押すことで「タイトル」ボタンを押すことに相当します。

また、画面に表示されているキャラクターは常に左右に揺れるようなアニメーションが再生されています。

