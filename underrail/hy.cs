using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EF9 RID: 7929
[ayj("LastStand")]
public sealed class hy : c0z
{
	// Token: 0x0600B55B RID: 46427 RVA: 0x004097F0 File Offset: 0x004079F0
	public override string y8()
	{
		return "Последний рубеж";
	}

	// Token: 0x0600B55C RID: 46428 RVA: 0x004097F8 File Offset: 0x004079F8
	public override string os()
	{
		return "LastStand";
	}

	// Token: 0x0600B55D RID: 46429 RVA: 0x00409800 File Offset: 0x00407A00
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B55E RID: 46430 RVA: 0x00409804 File Offset: 0x00407A04
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B55F RID: 46431 RVA: 0x00409808 File Offset: 0x00407A08
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B560 RID: 46432 RVA: 0x0040981C File Offset: 0x00407A1C
	public hy()
	{
		this.d = new List<string>();
		this.d.Add("SA.LastStand");
	}

	// Token: 0x0600B561 RID: 46433 RVA: 0x00409840 File Offset: 0x00407A40
	public override string bm(cnm A_0)
	{
		return "LastStand";
	}

	// Token: 0x0600B562 RID: 46434 RVA: 0x00409848 File Offset: 0x00407A48
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B563 RID: 46435 RVA: 0x0040984C File Offset: 0x00407A4C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/LastStand", new object[]
		{
			l4.a((double)hy.a(A_0), false)
		});
	}

	// Token: 0x0600B564 RID: 46436 RVA: 0x00409870 File Offset: 0x00407A70
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = hy.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<d4g>(true) * d4g.a;
		}
		return new List<cfd>
		{
			new cfd("SA.LastStand", num * d0u.b, false, false)
		};
	}

	// Token: 0x0600B565 RID: 46437 RVA: 0x004098C8 File Offset: 0x00407AC8
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B566 RID: 46438 RVA: 0x004098D0 File Offset: 0x00407AD0
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B567 RID: 46439 RVA: 0x004098D4 File Offset: 0x00407AD4
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B568 RID: 46440 RVA: 0x004098DC File Offset: 0x00407ADC
	public new static int a(cnm A_0)
	{
		int num = hy.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (int)((double)A_0.b8().GetSpecializationValue<d8b>(true) * d8b.a);
		}
		return num * d0u.b;
	}

	// Token: 0x04004214 RID: 16916
	private new const string a = "SA.LastStand";

	// Token: 0x04004215 RID: 16917
	public static readonly int b = 10;

	// Token: 0x04004216 RID: 16918
	public static readonly int c = 2;

	// Token: 0x04004217 RID: 16919
	private List<string> d;
}
