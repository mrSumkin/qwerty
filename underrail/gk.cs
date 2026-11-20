using System;
using System.Runtime.Serialization;

// Token: 0x020019C1 RID: 6593
[eiz("BPSIE8")]
[Serializable]
public sealed class gk : bs1
{
	// Token: 0x06008D2C RID: 36140 RVA: 0x00392AC8 File Offset: 0x00390CC8
	private gk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D2D RID: 36141 RVA: 0x00392AD4 File Offset: 0x00390CD4
	public override string f9()
	{
		return "heartbreakPoison";
	}

	// Token: 0x06008D2E RID: 36142 RVA: 0x00392ADC File Offset: 0x00390CDC
	public override string ga()
	{
		return "Яд сердцеед";
	}

	// Token: 0x06008D2F RID: 36143 RVA: 0x00392AE4 File Offset: 0x00390CE4
	protected override string gb()
	{
		return "HeartbreakPoison";
	}

	// Token: 0x06008D30 RID: 36144 RVA: 0x00392AEC File Offset: 0x00390CEC
	public gk()
	{
	}

	// Token: 0x06008D31 RID: 36145 RVA: 0x00392AF8 File Offset: 0x00390CF8
	public override string gc(efk A_0)
	{
		int num = ezx.v;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/HeartbreakPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			num,
			l4.a(ezx.y, false),
			ezx.x
		});
	}

	// Token: 0x06008D32 RID: 36146 RVA: 0x00392B74 File Offset: 0x00390D74
	public override string gd(efk A_0)
	{
		int num = ezx.v;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/HeartbreakPoisonItemEffect_Applied", new object[]
		{
			num,
			l4.a(ezx.y, false),
			ezx.x
		});
	}
}
