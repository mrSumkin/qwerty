using System;
using System.Collections.Generic;

// Token: 0x02001CBC RID: 7356
[d29("NavalJousting", "Naval Jousting")]
public sealed class eyf : ai8
{
	// Token: 0x0600A146 RID: 41286 RVA: 0x003E73D8 File Offset: 0x003E55D8
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A147 RID: 41287 RVA: 0x003E73E0 File Offset: 0x003E55E0
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A148 RID: 41288 RVA: 0x003E73E4 File Offset: 0x003E55E4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A149 RID: 41289 RVA: 0x003E73E8 File Offset: 0x003E55E8
	public eyf() : base("Нарвал")
	{
	}

	// Token: 0x0600A14A RID: 41290 RVA: 0x003E73F8 File Offset: 0x003E55F8
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A14B RID: 41291 RVA: 0x003E73FC File Offset: 0x003E55FC
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A14C RID: 41292 RVA: 0x003E7400 File Offset: 0x003E5600
	public override object[] at()
	{
		return new object[]
		{
			(int)(eyf.a * 100.0)
		};
	}

	// Token: 0x0600A14D RID: 41293 RVA: 0x003E7420 File Offset: 0x003E5620
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(70, new Type[]
			{
				typeof(jk)
			}),
			new b4k(new Type[]
			{
				typeof(ej3)
			})
		};
	}

	// Token: 0x04003E03 RID: 15875
	public new static readonly double a = 0.3;
}
