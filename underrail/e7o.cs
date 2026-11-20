using System;

// Token: 0x02000ED5 RID: 3797
[e79("Arena/BullsEyeFightEnd")]
public sealed class e7o : bz6
{
	// Token: 0x06004E06 RID: 19974 RVA: 0x0022A428 File Offset: 0x00228628
	protected override void il(cnk A_0, c5x A_1)
	{
		dag.a();
		base.a("Хардкор! Это было невероятно! Аспид повержен на наших глазах!", 4);
		base.a("Но... что я слышу?", 4);
		base.a("Толпа скандирует... Я не могу расслышать...", 4);
		object obj = A_0.aqu().r()["playerArenaTitle"];
		string str = (obj != null) ? obj.ToString() : null;
		string str2 = "! Толпа кричит ";
		object obj2 = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + str2 + ((obj2 != null) ? obj2.ToString() : null) + "!", 4);
		base.a("Потрясающе! Яркое будущее ждёт нашего претенден... гладиатора, конечно же!", 5);
		base.a("Это всё на сегодня, кровожадные маньяки. До новой встречи!", 4);
	}
}
