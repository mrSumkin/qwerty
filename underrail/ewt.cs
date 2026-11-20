using System;
using System.Runtime.Serialization;

// Token: 0x020019C2 RID: 6594
[eiz("BPSIE7")]
[Serializable]
public sealed class ewt : bs1
{
	// Token: 0x06008D33 RID: 36147 RVA: 0x00392BE8 File Offset: 0x00390DE8
	private ewt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D34 RID: 36148 RVA: 0x00392BF4 File Offset: 0x00390DF4
	public override string f9()
	{
		return "leperPoison";
	}

	// Token: 0x06008D35 RID: 36149 RVA: 0x00392BFC File Offset: 0x00390DFC
	public override string ga()
	{
		return "Яд прокажённого змея";
	}

	// Token: 0x06008D36 RID: 36150 RVA: 0x00392C04 File Offset: 0x00390E04
	protected override string gb()
	{
		return "LeperPoison";
	}

	// Token: 0x06008D37 RID: 36151 RVA: 0x00392C0C File Offset: 0x00390E0C
	public ewt()
	{
	}

	// Token: 0x06008D38 RID: 36152 RVA: 0x00392C18 File Offset: 0x00390E18
	public override string gc(efk A_0)
	{
		int num = ezx.q;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/LeperPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			num,
			l4.a(ezx.t, false),
			Convert.ToInt32(ezx.r * 100.0),
			ezx.s
		});
	}

	// Token: 0x06008D39 RID: 36153 RVA: 0x00392CB0 File Offset: 0x00390EB0
	public override string gd(efk A_0)
	{
		int num = ezx.q;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/LeperPoisonItemEffect_Applied", new object[]
		{
			num,
			l4.a(ezx.t, false),
			Convert.ToInt32(ezx.r * 100.0),
			ezx.s
		});
	}
}
