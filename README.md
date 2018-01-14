# AddForce test
RigitBody.AddForce() でどのような動きをするかテストするプロジェクト

## How to use
1. シーン 1 を開いて実行する
1. Attack ボタンを押すと中央に表示された Cube に AddForce() される。Cube が画面外に出てしまった場合は Reset Position ボタンを押すと Cube が初期位置に戻る。

AddForce の動きに影響するのは以下のような値・設定である。

- Project Setting - Physics の Gravity
- RigidBody の Mass (*1)
- AddForce で与える力のベクトル (*2)
- AddForce の ForceMode (*3)

(*1) は Cube オブジェクトの RigidBody で、(*2) は Cube オブジェクトの Forcer コンポーネントの設定 Force Direction, Force Power で、(*3) は Forcer の Force Mode で変更することができる。
これらの設定は実行中でも変更して挙動の変化を確認することができる。
