using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F98 RID: 8088
[ayj("JumpingBeanConsumation")]
public sealed class b0z : awn
{
	// Token: 0x0600BDFA RID: 48634 RVA: 0x004184B8 File Offset: 0x004166B8
	public override string y8()
	{
		return "Прыгающий боб";
	}

	// Token: 0x0600BDFB RID: 48635 RVA: 0x004184C0 File Offset: 0x004166C0
	public override string os()
	{
		return "JumpingBeanConsumation";
	}

	// Token: 0x0600BDFC RID: 48636 RVA: 0x004184C8 File Offset: 0x004166C8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDFE RID: 48638 RVA: 0x004184D4 File Offset: 0x004166D4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDFF RID: 48639 RVA: 0x004184D8 File Offset: 0x004166D8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE00 RID: 48640 RVA: 0x004184E0 File Offset: 0x004166E0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/JumpingBean", new object[]
		{
			(int)(al0.b * 100.0),
			al0.c,
			l4.a(b0z.a, false)
		});
	}

	// Token: 0x04004447 RID: 17479
	public new static readonly int a = 4;
}
