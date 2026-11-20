using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E95 RID: 7829
[ayj("Cleave")]
public sealed class p8 : bon
{
	// Token: 0x0600AF2F RID: 44847 RVA: 0x003FD768 File Offset: 0x003FB968
	public override string y8()
	{
		return "Расщепление";
	}

	// Token: 0x0600AF30 RID: 44848 RVA: 0x003FD770 File Offset: 0x003FB970
	public override string os()
	{
		return "Cleave";
	}

	// Token: 0x0600AF31 RID: 44849 RVA: 0x003FD778 File Offset: 0x003FB978
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF32 RID: 44850 RVA: 0x003FD77C File Offset: 0x003FB97C
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AF33 RID: 44851 RVA: 0x003FD780 File Offset: 0x003FB980
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600AF34 RID: 44852 RVA: 0x003FD784 File Offset: 0x003FB984
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600AF35 RID: 44853 RVA: 0x003FD788 File Offset: 0x003FB988
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600AF36 RID: 44854 RVA: 0x003FD78C File Offset: 0x003FB98C
	public p8()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add(p8.b);
	}

	// Token: 0x0600AF37 RID: 44855 RVA: 0x003FD7C0 File Offset: 0x003FB9C0
	public override string bm(cnm A_0)
	{
		return "Abilities.68";
	}

	// Token: 0x0600AF38 RID: 44856 RVA: 0x003FD7C8 File Offset: 0x003FB9C8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AF39 RID: 44857 RVA: 0x003FD7D0 File Offset: 0x003FB9D0
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Cleave", new object[]
		{
			Convert.ToInt32(p8.a * 100)
		}) + " " + qv.a("Feats/BoneBreaker_Cleave", new object[]
		{
			(int)(bsx.a * 100.0),
			(int)(bsx.b * 100.0),
			l4.a(bsx.d, false),
			bsx.c
		});
	}

	// Token: 0x0600AF3A RID: 44858 RVA: 0x003FD868 File Offset: 0x003FBA68
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AF3B RID: 44859 RVA: 0x003FD874 File Offset: 0x003FBA74
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd(p8.b, p8.c * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600AF3C RID: 44860 RVA: 0x003FD8C4 File Offset: 0x003FBAC4
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600AF3D RID: 44861 RVA: 0x003FD8CC File Offset: 0x003FBACC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0400409B RID: 16539
	public new static readonly int a = 2;

	// Token: 0x0400409C RID: 16540
	public static readonly string b = "SAt.Cleave";

	// Token: 0x0400409D RID: 16541
	public static readonly int c = 3;

	// Token: 0x0400409E RID: 16542
	private List<string> d;
}
