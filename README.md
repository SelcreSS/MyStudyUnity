# PopupSystemの構築

個別のシーンで出る可能性のあるポップアップを一括管理で表示非表示するシステムです。
<br>※Instantiateでprefabからインスタンス化する手法ではない
<br>渡すデータの型が違っていても共通でPopupを開けます。

<使い方> カッコ内はこのサンプルの名称
 - 1、シーンにStackPopupsを配置する。多々シーンがある場合はVariant prefabでそのシーンごと作るのも〇
 - 2、StackPopups以下階層にPopupを付けます
 - 3、Popupごとのスクリプトを書きます（TestPrefab.cs/TestPrefab2.cs）
 - 4、どこかで呼び出しコードを記載します（Main.cs)

<注意点>
PopupのPrefabは必ずroot、SetActiveでON/OFFする階層を作成してくだい
