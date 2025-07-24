using UnityEngine;

public class InOutRefTest : MonoBehaviour {

	void Start() {
		int a = 1;
		int b = 1;
		int c = 1;

		Debug.Log($"開始：a = {a}, c = {c}");

		RefMethod(ref a);
		OutMethod(out b);
		InMethod(in c);

		Debug.Log($"終了：a = {a}");
		Debug.Log($"終了：b = {b}");
		Debug.Log($"終了：c = {c}");
	}

	void RefMethod(ref int a) {
		a += 9;	// 呼び出し元の値を書き換える
		Debug.Log($"[RefMethod] a = {a}");
	}

	void OutMethod(out int b) {
		b = 10;	// 初期化が必要
		Debug.Log($"[OutMethod] b = {b}");
	}

	void InMethod(in int c) {
		//c += 9; 読み取り専用のためエラー
		Debug.Log($"[InMethod] c = {c}");
	}
}
