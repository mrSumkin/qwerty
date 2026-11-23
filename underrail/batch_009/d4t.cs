using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9B RID: 8091
[ayj("IrongutConsumation")]
public sealed class d4t : awn
{
	// Token: 0x0600BE12 RID: 48658 RVA: 0x00418628 File Offset: 0x00416828
	public override string y8()
	{
		return "Стальной желудок";
	}

	// Token: 0x0600BE13 RID: 48659 RVA: 0x00418630 File Offset: 0x00416830
	public override string os()
	{
		return "IrongutConsumation";
	}

	// Token: 0x0600BE14 RID: 48660 RVA: 0x00418638 File Offset: 0x00416838
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE16 RID: 48662 RVA: 0x00418644 File Offset: 0x00416844
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE17 RID: 48663 RVA: 0x00418648 File Offset: 0x00416848
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE18 RID: 48664 RVA: 0x0041864C File Offset: 0x0041684C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Irongut", new object[]
		{
			(int)(aah.a * 100.0),
			l4.a(d4t.a, false)
		});
	}

	// Token: 0x0400444A RID: 17482
	public new static readonly int a = 8;
}
