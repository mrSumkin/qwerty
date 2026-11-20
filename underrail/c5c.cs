using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001ED6 RID: 7894
[ayj("ElectricTorchAura")]
public sealed class c5c : cx6
{
	// Token: 0x0600B311 RID: 45841 RVA: 0x004060A8 File Offset: 0x004042A8
	public override string y8()
	{
		return "Электрический фонарь";
	}

	// Token: 0x0600B312 RID: 45842 RVA: 0x004060B0 File Offset: 0x004042B0
	public override string os()
	{
		return "ElectricTorchAura";
	}

	// Token: 0x0600B313 RID: 45843 RVA: 0x004060B8 File Offset: 0x004042B8
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B314 RID: 45844 RVA: 0x004060BC File Offset: 0x004042BC
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600B315 RID: 45845 RVA: 0x004060C4 File Offset: 0x004042C4
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B316 RID: 45846 RVA: 0x004060CC File Offset: 0x004042CC
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B317 RID: 45847 RVA: 0x004060D0 File Offset: 0x004042D0
	public override string bm(cnm A_0)
	{
		return "Devices.29";
	}

	// Token: 0x0600B318 RID: 45848 RVA: 0x004060D8 File Offset: 0x004042D8
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Utilities/ElectricTorchAura", new object[]
		{
			c5c.c,
			c5c.d,
			c5c.g
		});
	}

	// Token: 0x0600B319 RID: 45849 RVA: 0x00406114 File Offset: 0x00404314
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B31A RID: 45850 RVA: 0x00406120 File Offset: 0x00404320
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B31B RID: 45851 RVA: 0x00406128 File Offset: 0x00404328
	public override List<els> j8(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return new List<els>
		{
			new axg(a_)
		};
	}

	// Token: 0x0600B31C RID: 45852 RVA: 0x00406160 File Offset: 0x00404360
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		return coh != null && coh.Battery >= c5c.c;
	}

	// Token: 0x0600B31D RID: 45853 RVA: 0x004061AC File Offset: 0x004043AC
	public override bool cu(cnm A_0)
	{
		if (!base.cu(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		return coh != null && coh.Battery > 0.0;
	}

	// Token: 0x0600B31E RID: 45854 RVA: 0x004061F8 File Offset: 0x004043F8
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004181 RID: 16769
	private new const string a = "Electric Lantern";

	// Token: 0x04004182 RID: 16770
	private const string b = "ElectricTorchAura";

	// Token: 0x04004183 RID: 16771
	public static readonly double c = 10.0;

	// Token: 0x04004184 RID: 16772
	public static readonly double d = 3.0;

	// Token: 0x04004185 RID: 16773
	public new static readonly double e = 0.75;

	// Token: 0x04004186 RID: 16774
	public new static readonly double f = 0.14;

	// Token: 0x04004187 RID: 16775
	public static readonly double g = 5.0;

	// Token: 0x04004188 RID: 16776
	public static readonly Color h = new Color(200, 200, 255);
}
