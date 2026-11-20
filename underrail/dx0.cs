using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EFA RID: 7930
[ayj("QuickTinkering")]
public sealed class dx0 : c0z
{
	// Token: 0x0600B56A RID: 46442 RVA: 0x00409930 File Offset: 0x00407B30
	public override string y8()
	{
		return "Быстрый взвод";
	}

	// Token: 0x0600B56B RID: 46443 RVA: 0x00409938 File Offset: 0x00407B38
	public override string os()
	{
		return "QuickTinkering";
	}

	// Token: 0x0600B56C RID: 46444 RVA: 0x00409940 File Offset: 0x00407B40
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B56D RID: 46445 RVA: 0x00409944 File Offset: 0x00407B44
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B56E RID: 46446 RVA: 0x00409948 File Offset: 0x00407B48
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.d
		};
	}

	// Token: 0x0600B56F RID: 46447 RVA: 0x0040995C File Offset: 0x00407B5C
	public dx0()
	{
		this.c = new List<string>();
		this.c.Add("SA.QuickTinkering");
	}

	// Token: 0x0600B570 RID: 46448 RVA: 0x00409980 File Offset: 0x00407B80
	public override string bm(cnm A_0)
	{
		return "QuickTinkering";
	}

	// Token: 0x0600B571 RID: 46449 RVA: 0x00409988 File Offset: 0x00407B88
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B572 RID: 46450 RVA: 0x0040998C File Offset: 0x00407B8C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/QuickTinkering", new object[]
		{
			dg1.a((A_0 != null) ? A_0.b8() : null)
		});
	}

	// Token: 0x0600B573 RID: 46451 RVA: 0x004099C8 File Offset: 0x00407BC8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		double num = (double)dx0.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<d8x>(true) * d8x.a;
		}
		return new List<cfd>
		{
			new cfd("SA.QuickTinkering", (int)(num * (double)d0u.b), false, false)
		};
	}

	// Token: 0x0600B574 RID: 46452 RVA: 0x00409A24 File Offset: 0x00407C24
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B575 RID: 46453 RVA: 0x00409A2C File Offset: 0x00407C2C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B576 RID: 46454 RVA: 0x00409A30 File Offset: 0x00407C30
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004218 RID: 16920
	private new const string a = "SA.QuickTinkering";

	// Token: 0x04004219 RID: 16921
	public static readonly int b = 5;

	// Token: 0x0400421A RID: 16922
	private List<string> c;
}
