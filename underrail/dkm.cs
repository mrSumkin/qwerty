using System;
using System.Runtime.Serialization;

// Token: 0x020019C5 RID: 6597
[eiz("BPSIE3")]
[Serializable]
public sealed class dkm : bs1
{
	// Token: 0x06008D48 RID: 36168 RVA: 0x00392FB8 File Offset: 0x003911B8
	private dkm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D49 RID: 36169 RVA: 0x00392FC4 File Offset: 0x003911C4
	public override string f9()
	{
		return "crawlerPoison";
	}

	// Token: 0x06008D4A RID: 36170 RVA: 0x00392FCC File Offset: 0x003911CC
	public override string ga()
	{
		return "Яд краулера";
	}

	// Token: 0x06008D4B RID: 36171 RVA: 0x00392FD4 File Offset: 0x003911D4
	protected override string gb()
	{
		return "CrawlerPoison";
	}

	// Token: 0x06008D4C RID: 36172 RVA: 0x00392FDC File Offset: 0x003911DC
	public dkm()
	{
		base.RemainingTicks = 5;
	}

	// Token: 0x06008D4D RID: 36173 RVA: 0x00392FEC File Offset: 0x003911EC
	public override string gc(efk A_0)
	{
		int num = ezx.e;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/CrawlerPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}

	// Token: 0x06008D4E RID: 36174 RVA: 0x00393068 File Offset: 0x00391268
	public override string gd(efk A_0)
	{
		int num = ezx.e;
		if (A_0 != null && A_0.Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/CrawlerPoisonItemEffect_Applied", new object[]
		{
			num,
			l4.a(ezx.d, false),
			l4.a(ezx.f, false)
		});
	}
}
