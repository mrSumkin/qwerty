using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E9E RID: 7838
[ayj("SavageKingShieldBash")]
public sealed class d8i : c0z
{
	// Token: 0x0600AFC4 RID: 44996 RVA: 0x003FEA20 File Offset: 0x003FCC20
	public override string y8()
	{
		return "Дикарский удар";
	}

	// Token: 0x0600AFC5 RID: 44997 RVA: 0x003FEA28 File Offset: 0x003FCC28
	public override string os()
	{
		return "SavageKingShieldBash";
	}

	// Token: 0x0600AFC6 RID: 44998 RVA: 0x003FEA30 File Offset: 0x003FCC30
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AFC7 RID: 44999 RVA: 0x003FEA34 File Offset: 0x003FCC34
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600AFC8 RID: 45000 RVA: 0x003FEA38 File Offset: 0x003FCC38
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600AFC9 RID: 45001 RVA: 0x003FEA3C File Offset: 0x003FCC3C
	public override string c1()
	{
		return "Ошарашивание";
	}

	// Token: 0x0600AFCA RID: 45002 RVA: 0x003FEA44 File Offset: 0x003FCC44
	public d8i()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add("SAt.SavageKingShieldBash");
	}

	// Token: 0x0600AFCB RID: 45003 RVA: 0x003FEA78 File Offset: 0x003FCC78
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.r,
			d = new int?(65),
			a = c0e.r,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600AFCC RID: 45004 RVA: 0x003FEAB4 File Offset: 0x003FCCB4
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600AFCD RID: 45005 RVA: 0x003FEABC File Offset: 0x003FCCBC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AFCE RID: 45006 RVA: 0x003FEAC0 File Offset: 0x003FCCC0
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AFCF RID: 45007 RVA: 0x003FEAC8 File Offset: 0x003FCCC8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int a_ = uf.a(d8i.b, A_0, new CooldownCategory[]
		{
			CooldownCategory.DirtyKick
		});
		list.Add(new cfd("SAt.SavageKingShieldBash", a_, false, false));
		return list;
	}

	// Token: 0x0600AFD0 RID: 45008 RVA: 0x003FEB24 File Offset: 0x003FCD24
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600AFD1 RID: 45009 RVA: 0x003FEB2C File Offset: 0x003FCD2C
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600AFD2 RID: 45010 RVA: 0x003FEB30 File Offset: 0x003FCD30
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AFD3 RID: 45011 RVA: 0x003FEB38 File Offset: 0x003FCD38
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600AFD4 RID: 45012 RVA: 0x003FEB3C File Offset: 0x003FCD3C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AFD5 RID: 45013 RVA: 0x003FEB44 File Offset: 0x003FCD44
	public new static a1q a(cnm A_0)
	{
		double num = qw.a(A_0.b8(), null, new WeaponSubtype?(WeaponSubtype.Sledgehammer));
		return new a1q(DamageType.Mechanical, (int)(35.0 * (1.0 + num)), (int)(70.0 * (1.0 + num)));
	}

	// Token: 0x040040BB RID: 16571
	private new const string a = "SAt.SavageKingShieldBash";

	// Token: 0x040040BC RID: 16572
	public static readonly int b = d0u.b * 3;

	// Token: 0x040040BD RID: 16573
	public static readonly int c = d0u.b * 2;

	// Token: 0x040040BE RID: 16574
	private List<string> d;
}
