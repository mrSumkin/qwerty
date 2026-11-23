using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ECF RID: 7887
[ayj("BulletTime")]
public sealed class cyc : c0z
{
	// Token: 0x0600B28D RID: 45709 RVA: 0x004050B4 File Offset: 0x004032B4
	public override string y8()
	{
		return "Время пули";
	}

	// Token: 0x0600B28E RID: 45710 RVA: 0x004050BC File Offset: 0x004032BC
	public override string os()
	{
		return "BulletTime";
	}

	// Token: 0x0600B28F RID: 45711 RVA: 0x004050C4 File Offset: 0x004032C4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B290 RID: 45712 RVA: 0x004050C8 File Offset: 0x004032C8
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B291 RID: 45713 RVA: 0x004050CC File Offset: 0x004032CC
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600B292 RID: 45714 RVA: 0x004050E0 File Offset: 0x004032E0
	public cyc()
	{
		this.d = new List<string>();
		this.d.Add("SA.BulletTime");
	}

	// Token: 0x0600B293 RID: 45715 RVA: 0x00405104 File Offset: 0x00403304
	public override string bm(cnm A_0)
	{
		return "BulletTime";
	}

	// Token: 0x0600B294 RID: 45716 RVA: 0x0040510C File Offset: 0x0040330C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B295 RID: 45717 RVA: 0x00405110 File Offset: 0x00403310
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/BulletTime", new object[]
		{
			Convert.ToInt32(cyc.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B296 RID: 45718 RVA: 0x00405140 File Offset: 0x00403340
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.BulletTime", cyc.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600B297 RID: 45719 RVA: 0x00405164 File Offset: 0x00403364
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B298 RID: 45720 RVA: 0x0040516C File Offset: 0x0040336C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B299 RID: 45721 RVA: 0x00405170 File Offset: 0x00403370
	public new static double a(cnm A_0)
	{
		double num = cyc.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<sr>(true) * sr.a;
		}
		return num;
	}

	// Token: 0x0600B29A RID: 45722 RVA: 0x004051AC File Offset: 0x004033AC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400415D RID: 16733
	private new const string a = "SA.BulletTime";

	// Token: 0x0400415E RID: 16734
	public static readonly int b = 10;

	// Token: 0x0400415F RID: 16735
	public static readonly double c = 0.3;

	// Token: 0x04004160 RID: 16736
	private List<string> d;
}
