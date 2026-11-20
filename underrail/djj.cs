using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F03 RID: 7939
[ayj("LocusOfControl")]
public sealed class djj : c0z
{
	// Token: 0x0600B5F9 RID: 46585 RVA: 0x0040A748 File Offset: 0x00408948
	public override string y8()
	{
		return "Локус контроля";
	}

	// Token: 0x0600B5FA RID: 46586 RVA: 0x0040A750 File Offset: 0x00408950
	public override string os()
	{
		return "LocusOfControl";
	}

	// Token: 0x0600B5FB RID: 46587 RVA: 0x0040A758 File Offset: 0x00408958
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B5FC RID: 46588 RVA: 0x0040A75C File Offset: 0x0040895C
	public override int e8()
	{
		return 3;
	}

	// Token: 0x0600B5FD RID: 46589 RVA: 0x0040A760 File Offset: 0x00408960
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B5FE RID: 46590 RVA: 0x0040A774 File Offset: 0x00408974
	public djj()
	{
		this.b = new List<string>();
		this.b.Add("SA.LocusOfControl");
	}

	// Token: 0x0600B5FF RID: 46591 RVA: 0x0040A798 File Offset: 0x00408998
	public override string bm(cnm A_0)
	{
		return "LocusOfControl";
	}

	// Token: 0x0600B600 RID: 46592 RVA: 0x0040A7A0 File Offset: 0x004089A0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B601 RID: 46593 RVA: 0x0040A7A4 File Offset: 0x004089A4
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/LocusOfControl", new object[]
		{
			l4.a((double)djj.a(A_0), false)
		});
	}

	// Token: 0x0600B602 RID: 46594 RVA: 0x0040A7C8 File Offset: 0x004089C8
	public new static int a(cnm A_0)
	{
		int num = cbv.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (int)((double)A_0.b8().GetSpecializationValue<a84>(true) * a84.a) * d0u.b;
		}
		return num;
	}

	// Token: 0x0600B603 RID: 46595 RVA: 0x0040A80C File Offset: 0x00408A0C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = cbv.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<@in>(true) * @in.a * d0u.b;
		}
		return new List<cfd>
		{
			new cfd("SA.LocusOfControl", num, false, false)
		};
	}

	// Token: 0x0600B604 RID: 46596 RVA: 0x0040A864 File Offset: 0x00408A64
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B605 RID: 46597 RVA: 0x0040A86C File Offset: 0x00408A6C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B606 RID: 46598 RVA: 0x0040A874 File Offset: 0x00408A74
	public override bool hm(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && !A_0.b8().SpecialStates.h && !A_0.b8().StatusEffects.a(ex.a);
	}

	// Token: 0x0600B607 RID: 46599 RVA: 0x0040A8C4 File Offset: 0x00408AC4
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004239 RID: 16953
	private new const string a = "SA.LocusOfControl";

	// Token: 0x0400423A RID: 16954
	private List<string> b;
}
