using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9A RID: 8090
[ayj("TranceConsumation")]
public sealed class cpz : awn
{
	// Token: 0x0600BE0A RID: 48650 RVA: 0x004185A0 File Offset: 0x004167A0
	public override string y8()
	{
		return "Транс";
	}

	// Token: 0x0600BE0B RID: 48651 RVA: 0x004185A8 File Offset: 0x004167A8
	public override string os()
	{
		return "TranceConsumation";
	}

	// Token: 0x0600BE0C RID: 48652 RVA: 0x004185B0 File Offset: 0x004167B0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE0E RID: 48654 RVA: 0x004185BC File Offset: 0x004167BC
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE0F RID: 48655 RVA: 0x004185C0 File Offset: 0x004167C0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE10 RID: 48656 RVA: 0x004185C4 File Offset: 0x004167C4
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Trance", new object[]
		{
			(int)(egc.a * 100.0),
			(int)(egc.b * 100.0),
			l4.a(cpz.a, false)
		});
	}

	// Token: 0x04004449 RID: 17481
	public new static readonly int a = 5;
}
