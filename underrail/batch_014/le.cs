using System;

// Token: 0x02000EDB RID: 3803
[e79("Arena/ChemicalAgentFightEnd")]
public sealed class le : bz6
{
	// Token: 0x06004E18 RID: 19992 RVA: 0x0022A8D4 File Offset: 0x00228AD4
	protected override void il(cnk A_0, c5x A_1)
	{
		base.a("Вот это был хардкорный матч, дорогие кровожадные маньяки!", 4);
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(((obj != null) ? obj.ToString() : null) + " просто убивает всех подряд, даже лучших гладиаторов!", 4);
		base.a("Всякого, кто станет на пути этого гладиатора, ждёт жестокая смерть!", 4);
		base.a("Спасибо всем вам, и увидимся в следующий раз! Не теряйте кровожадности!", 4);
	}
}
