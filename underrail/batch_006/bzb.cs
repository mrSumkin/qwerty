using System;

// Token: 0x02000ED8 RID: 3800
[e79("Arena/MasterExploderFightEnd")]
public sealed class bzb : bz6
{
	// Token: 0x06004E0F RID: 19983 RVA: 0x0022A640 File Offset: 0x00228840
	protected override void il(cnk A_0, c5x A_1)
	{
		string str = "Прекрасная бойня! Посчитаем, сколько конечностей теперь имеет ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + "!", 4);
		base.a("Одна... Две... Три...", 3);
		base.a("Если только я не совсем не умею считать, все руки и ноги у нашего гладиатора всё ещё на месте!", 3);
		string str2 = "Оказалось, что даже Мастеру-Детонатору не по зубам ";
		object obj2 = A_0.aqu().r()["playerArenaTitle"];
		base.a(str2 + ((obj2 != null) ? obj2.ToString() : null) + "! Прекрасная работа!", 4);
		base.a("Ненаглядные маньяки, это всё на сегодня! До следующей встречи, и не теряйте жажду крови!", 4);
	}
}
