using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001DF0 RID: 7664
[d29("Psychosis", "Psychosis")]
public sealed class c80 : ai8
{
	// Token: 0x0600A99F RID: 43423 RVA: 0x003F21D8 File Offset: 0x003F03D8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9A0 RID: 43424 RVA: 0x003F21DC File Offset: 0x003F03DC
	public c80() : base("臑Психоз")
	{
	}

	// Token: 0x0600A9A1 RID: 43425 RVA: 0x003F21EC File Offset: 0x003F03EC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9A2 RID: 43426 RVA: 0x003F21F0 File Offset: 0x003F03F0
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9A3 RID: 43427 RVA: 0x003F21F4 File Offset: 0x003F03F4
	public override object[] at()
	{
		return new object[]
		{
			(int)(c80.a * 100f),
			(int)(c80.b * 100f)
		};
	}

	// Token: 0x0600A9A4 RID: 43428 RVA: 0x003F2228 File Offset: 0x003F0428
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		float a_ = (float)((double)c80.a + (double)A_0.GetSpecializationValue<bhr>(true) * bhr.a);
		list.Add(new bi0(new PsiSchool?(PsiSchool.Metathermics), a_));
		list.Add(new bi0(new PsiSchool?(PsiSchool.Psychokinesis), a_));
		list.Add(new bi0(new PsiSchool?(PsiSchool.ThoughtControl), a_));
		list.Add(new bi0(new PsiSchool?(PsiSchool.TemporalManipulation), a_));
		return list;
	}

	// Token: 0x0600A9A5 RID: 43429 RVA: 0x003F229C File Offset: 0x003F049C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new c2y(new Type[]
			{
				typeof(cvc)
			})
		};
	}

	// Token: 0x04003F92 RID: 16274
	public new static readonly float a = 0.15f;

	// Token: 0x04003F93 RID: 16275
	public new static readonly float b = 0.2f;
}
