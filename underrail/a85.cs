using System;

// Token: 0x02000EDC RID: 3804
[e79("Arena/SurgeonFightEnd")]
public sealed class a85 : bz6
{
	// Token: 0x06004E1A RID: 19994 RVA: 0x0022A94C File Offset: 0x00228B4C
	protected override void il(cnk A_0, c5x A_1)
	{
		base.a("Ой! Ой! Ой!", 3);
		string str = "Лицензия Хирурга аннулирована! ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + " снова одерживает победу.", 4);
		base.a("Я не сомневаюсь, наш любимый гладиатор ещё преподнесёт нам не один жестокий матч!", 4);
		base.a("И это всё на сегодня. Увидимся в следующий раз!", 4);
	}
}
