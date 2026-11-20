using System;

// Token: 0x02000EE4 RID: 3812
[e79("Arena/StygianExorcistFightEnd")]
public sealed class bko : bz6
{
	// Token: 0x06004E33 RID: 20019 RVA: 0x0022AF0C File Offset: 0x0022910C
	protected override void il(cnk A_0, c5x A_1)
	{
		base.a("Чудовищная бойня! Прекрасно, великолепно!", 4);
		string str = "Теперь, после смерти Стигийского экзорциста, ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + " может сразиться с Властелином ужаса \u0097 текущим инвиктусом.", 5);
		string str2 = "Сможет ли ";
		object obj2 = A_0.aqu().r()["playerArenaTitle"];
		base.a(str2 + ((obj2 != null) ? obj2.ToString() : null) + " выступить против Властелина ужаса?", 4);
		string str3 = "Сможет ли ";
		object obj3 = A_0.aqu().r()["playerArenaTitle"];
		base.a(str3 + ((obj3 != null) ? obj3.ToString() : null) + " стать инвиктусом или присоединится к ста пятидесяти шести мёртвым гладиаторам на счету Властелина ужаса?", 5);
		base.a("Так или иначе, нам есть что предвкушать!", 4);
		base.a("Спасибо вам всем! До новой встречи!", 4);
	}
}
