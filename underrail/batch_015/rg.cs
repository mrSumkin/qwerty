using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F90 RID: 8080
[ayj("TwitchConsumation")]
public sealed class rg : awn
{
	// Token: 0x0600BDB8 RID: 48568 RVA: 0x004180CC File Offset: 0x004162CC
	public override string y8()
	{
		return "Рывок";
	}

	// Token: 0x0600BDB9 RID: 48569 RVA: 0x004180D4 File Offset: 0x004162D4
	public override string os()
	{
		return "TwitchConsumation";
	}

	// Token: 0x0600BDBA RID: 48570 RVA: 0x004180DC File Offset: 0x004162DC
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDBC RID: 48572 RVA: 0x004180E8 File Offset: 0x004162E8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDBD RID: 48573 RVA: 0x004180EC File Offset: 0x004162EC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDBE RID: 48574 RVA: 0x004180F0 File Offset: 0x004162F0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Twitch", new object[]
		{
			rg.b,
			l4.a(rg.a, false)
		});
	}

	// Token: 0x04004439 RID: 17465
	public new static readonly int a = 20;

	// Token: 0x0400443A RID: 17466
	public static readonly int b = 8;
}
