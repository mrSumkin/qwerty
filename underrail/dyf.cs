using System;

// Token: 0x02000EE1 RID: 3809
[e79("Arena/ZapFightEnd")]
public sealed class dyf : bz6
{
	// Token: 0x06004E2A RID: 20010 RVA: 0x0022ACDC File Offset: 0x00228EDC
	protected override void il(cnk A_0, c5x A_1)
	{
		string str = "Непревзойдённо! Неужели никому не по силам остановить машину убийства по имени ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + "!?", 5);
		base.a("Трах пытался, но у него сели батарейки!", 4);
		base.a("Хардкорнее этих матчей не увидишь. Арена всегда утолит нашу жажду крови!", 4);
		base.a("Спасибо вам всем! До новой встречи!", 4);
	}
}
