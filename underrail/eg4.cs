using System;
using System.Runtime.Serialization;

// Token: 0x020019C3 RID: 6595
[eiz("BPSIE6")]
[Serializable]
public sealed class eg4 : bs1
{
	// Token: 0x06008D3A RID: 36154 RVA: 0x00392D40 File Offset: 0x00390F40
	private eg4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D3B RID: 36155 RVA: 0x00392D4C File Offset: 0x00390F4C
	public override string f9()
	{
		return "blindingPoison";
	}

	// Token: 0x06008D3C RID: 36156 RVA: 0x00392D54 File Offset: 0x00390F54
	public override string ga()
	{
		return "Яд слепитель";
	}

	// Token: 0x06008D3D RID: 36157 RVA: 0x00392D5C File Offset: 0x00390F5C
	protected override string gb()
	{
		return "BlindingPoison";
	}

	// Token: 0x06008D3E RID: 36158 RVA: 0x00392D64 File Offset: 0x00390F64
	public eg4()
	{
	}

	// Token: 0x06008D3F RID: 36159 RVA: 0x00392D70 File Offset: 0x00390F70
	public override string gc(efk A_0)
	{
		int num = ezx.l;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/BlindingPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}

	// Token: 0x06008D40 RID: 36160 RVA: 0x00392DF8 File Offset: 0x00390FF8
	public override string gd(efk A_0)
	{
		int num = ezx.l;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/BlindingPoisonItemEffect_Applied", new object[]
		{
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}
}
