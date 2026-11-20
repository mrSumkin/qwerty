using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001DFF RID: 7679
[d29("CO", "Conditioning")]
public sealed class e6k : ai8
{
	// Token: 0x0600A9FF RID: 43519 RVA: 0x003F2ECC File Offset: 0x003F10CC
	public e6k() : base("肰Выдержка")
	{
	}

	// Token: 0x0600AA00 RID: 43520 RVA: 0x003F2EDC File Offset: 0x003F10DC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA01 RID: 43521 RVA: 0x003F2EE0 File Offset: 0x003F10E0
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA02 RID: 43522 RVA: 0x003F2EE4 File Offset: 0x003F10E4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(e6k.b * 100.0),
			Convert.ToInt32(e6k.c * 100.0),
			e6k.a
		};
	}

	// Token: 0x0600AA03 RID: 43523 RVA: 0x003F2F3C File Offset: 0x003F113C
	public override List<d3e> cy(efk A_0)
	{
		if (A_0 != null)
		{
			List<d3e> list = new List<d3e>();
			double a_ = -(e6k.b + e6k.c * (double)Math.Max(0, A_0.BaseAbilities.Constitution - e6k.a) + (double)A_0.GetSpecializationValue<d9p>(true) * d9p.a);
			list.Add(new e3r(DamageType.Mechanical, a_));
			list.Add(new e3r(DamageType.Cold, a_));
			list.Add(new e3r(DamageType.Heat, a_));
			return list;
		}
		return null;
	}

	// Token: 0x0600AA04 RID: 43524 RVA: 0x003F2FB4 File Offset: 0x003F11B4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), e6k.a)
		};
	}

	// Token: 0x04003FA8 RID: 16296
	public new static readonly int a = 5;

	// Token: 0x04003FA9 RID: 16297
	public new static readonly double b = 0.1;

	// Token: 0x04003FAA RID: 16298
	public static readonly double c = 0.01;
}
