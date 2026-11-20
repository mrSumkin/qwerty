using System;

// Token: 0x02000EE5 RID: 3813
[e79("Arena/CarnifexFightEnd")]
public sealed class a86 : bz6
{
	// Token: 0x06004E35 RID: 20021 RVA: 0x0022AFFC File Offset: 0x002291FC
	protected override void il(cnk A_0, c5x A_1)
	{
		base.a("Маньяки, я... Я не верю своим глазам...", 4);
		base.a("Карнифекс... он мёртв. Величайший из гладиаторов мёртв.", 4);
		base.a("После более чем двухсот кровавых матчей он подарил нам ещё один, свой последний.", 5);
		base.a("Это может означать лишь одно...", 3);
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(((obj != null) ? obj.ToString() : null) + " новый инвиктус!", 4);
		base.a("Я не слышу вас, маньяки!", 4);
		base.a("Поднимается новый инвиктус!", 3);
		base.a("Инвиктус!", 4);
	}
}
