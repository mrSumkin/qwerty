using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ED9 RID: 7897
[ayj("EmpoweredInvocation")]
public sealed class cch : c0z
{
	// Token: 0x0600B344 RID: 45892 RVA: 0x00406528 File Offset: 0x00404728
	public override string y8()
	{
		return "Псионическое усиление";
	}

	// Token: 0x0600B345 RID: 45893 RVA: 0x00406530 File Offset: 0x00404730
	public override string os()
	{
		return "EmpoweredInvocation";
	}

	// Token: 0x0600B346 RID: 45894 RVA: 0x00406538 File Offset: 0x00404738
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B347 RID: 45895 RVA: 0x0040653C File Offset: 0x0040473C
	public override int e8()
	{
		return 5;
	}

	// Token: 0x0600B348 RID: 45896 RVA: 0x00406540 File Offset: 0x00404740
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B349 RID: 45897 RVA: 0x00406554 File Offset: 0x00404754
	public cch()
	{
		this.d = new List<string>();
		this.d.Add("SA.EmpoweredInvocation");
	}

	// Token: 0x0600B34A RID: 45898 RVA: 0x00406578 File Offset: 0x00404778
	public override string bm(cnm A_0)
	{
		return "EmpoweredInvocation." + cch.a(A_0).ToString();
	}

	// Token: 0x0600B34B RID: 45899 RVA: 0x004065A4 File Offset: 0x004047A4
	public new static PsiSchool a(cnm A_0)
	{
		return cch.a((A_0 != null) ? A_0.b8() : null);
	}

	// Token: 0x0600B34C RID: 45900 RVA: 0x004065C0 File Offset: 0x004047C0
	public static PsiSchool a(efk A_0)
	{
		if (A_0 != null)
		{
			foreach (ai8 ai in A_0.Feats)
			{
				ci4 ci = ai as ci4;
				if (ci != null)
				{
					return ci.gp();
				}
			}
			return PsiSchool.Metathermics;
		}
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B34D RID: 45901 RVA: 0x00406630 File Offset: 0x00404830
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B34E RID: 45902 RVA: 0x00406634 File Offset: 0x00404834
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/EmpoweredInvocation", new object[]
		{
			cch.a(A_0).ToString().a(),
			Convert.ToInt32(cch.b * 100.0)
		});
	}

	// Token: 0x0600B34F RID: 45903 RVA: 0x0040668C File Offset: 0x0040488C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.EmpoweredInvocation", cch.c * d0u.b, false, false)
		};
	}

	// Token: 0x0600B350 RID: 45904 RVA: 0x004066B0 File Offset: 0x004048B0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B351 RID: 45905 RVA: 0x004066B8 File Offset: 0x004048B8
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B352 RID: 45906 RVA: 0x004066BC File Offset: 0x004048BC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004191 RID: 16785
	private new const string a = "SA.EmpoweredInvocation";

	// Token: 0x04004192 RID: 16786
	public static readonly double b = 0.35;

	// Token: 0x04004193 RID: 16787
	public static readonly int c = 10;

	// Token: 0x04004194 RID: 16788
	private List<string> d;
}
