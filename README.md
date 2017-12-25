# LogoffAll
Windows で自分以外のユーザーを強制ログさせます。
ターミナル サービスでメンテしたいときに有用かもしれません。

## これは何？？
ターミナル サービスで複数ユーザーがログオン（サインイン）していて一度にログオフさせたいことがあります。
無人で毎日動かしている実績があるので、公開します。

## 使い方
LogoffAll.exe を実行すると、自分以外のユーザーをすべて強制ログオフさせます。
タスク スケジューラーに登録しておくと便利に使える場合があります。

## 対象
たぶん Windows XP, Vista, Server 2008, 2008 R2, 2012。
特にターミナル サービスを運用している Windows サーバー機。
そのWindows で QWINSTA コマンドが使えないと動きません。
.NET Framework 3.5 上で動作します。

## License

Copyright (c) 2017 Ogawa, Takasi (Ogacha)

Released under the MIT license
http://opensource.org/licenses/mit-license.php
