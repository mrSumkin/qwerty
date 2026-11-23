using System;
using System.Runtime.Serialization;

// Token: 0x020019C4 RID: 6596
[eiz("BPSIE5")]
[Serializable]
public sealed class eig : bs1
{
	// Token: 0x06008D41 RID: 36161 RVA: 0x00392E78 File Offset: 0x00391078
	private eig(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D42 RID: 36162 RVA: 0x00392E84 File Offset: 0x00391084
	public override string f9()
	{
		return "spiritPoison";
	}

	// Token: 0x06008D43 RID: 36163 RVA: 0x00392E8C File Offset: 0x0039108C
	public override string ga()
	{
		return "Яд призрак";
	}

	// Token: 0x06008D44 RID: 36164 RVA: 0x00392E94 File Offset: 0x00391094
	protected override string gb()
	{
		return "SpiritPoison";
	}

	// Token: 0x06008D45 RID: 36165 RVA: 0x00392E9C File Offset: 0x0039109C
	public eig()
	{
		base.RemainingTicks = 1;
	}

	// Token: 0x06008D46 RID: 36166 RVA: 0x00392EB0 File Offset: 0x003910B0
	public override string gc(efk A_0)
	{
		int num = ezx.i;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/SpiritPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			num,
			l4.a(ezx.h, false),
			(int)(ezx.j * 100.0)
		});
	}

	// Token: 0x06008D47 RID: 36167 RVA: 0x00392F38 File Offset: 0x00391138
	public override string gd(efk A_0)
	{
		int num = ezx.i;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/SpiritPoisonItemEffect_Applied", new object[]
		{
			num,
			l4.a(ezx.h, false),
			(int)(ezx.j * 100.0)
		});
	}
}
