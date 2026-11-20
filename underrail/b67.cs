using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EA1 RID: 7841
[ayj("Flurry")]
public sealed class b67 : bon
{
	// Token: 0x0600AFFB RID: 45051 RVA: 0x003FF230 File Offset: 0x003FD430
	public override string y8()
	{
		return "Шквал";
	}

	// Token: 0x0600AFFC RID: 45052 RVA: 0x003FF238 File Offset: 0x003FD438
	public override string os()
	{
		return "Flurry";
	}

	// Token: 0x0600AFFD RID: 45053 RVA: 0x003FF240 File Offset: 0x003FD440
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AFFE RID: 45054 RVA: 0x003FF244 File Offset: 0x003FD444
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AFFF RID: 45055 RVA: 0x003FF248 File Offset: 0x003FD448
	public override int ct()
	{
		return 5;
	}

	// Token: 0x0600B000 RID: 45056 RVA: 0x003FF24C File Offset: 0x003FD44C
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B001 RID: 45057 RVA: 0x003FF254 File Offset: 0x003FD454
	public b67()
	{
		this.i = new List<string>();
		this.i.Add(d7f.a);
		this.i.Add(b67.a);
	}

	// Token: 0x0600B002 RID: 45058 RVA: 0x003FF288 File Offset: 0x003FD488
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.14";
	}

	// Token: 0x0600B003 RID: 45059 RVA: 0x003FF294 File Offset: 0x003FD494
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600B004 RID: 45060 RVA: 0x003FF348 File Offset: 0x003FD548
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600B005 RID: 45061 RVA: 0x003FF3FC File Offset: 0x003FD5FC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B006 RID: 45062 RVA: 0x003FF404 File Offset: 0x003FD604
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Flurry", new object[]
		{
			b67.a(A_0),
			b67.e,
			b67.f,
			l4.a(b67.b(A_0), false)
		});
	}

	// Token: 0x0600B007 RID: 45063 RVA: 0x003FF458 File Offset: 0x003FD658
	public static int b(cnm A_0)
	{
		int num = b67.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (int)((double)A_0.b8().GetSpecializationValue<ez5>(true) * ez5.a);
		}
		return num;
	}

	// Token: 0x0600B008 RID: 45064 RVA: 0x003FF494 File Offset: 0x003FD694
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B009 RID: 45065 RVA: 0x003FF4C8 File Offset: 0x003FD6C8
	public new static int a(cnm A_0)
	{
		return b67.c;
	}

	// Token: 0x0600B00A RID: 45066 RVA: 0x003FF4D4 File Offset: 0x003FD6D4
	protected override int hi(cnm A_0)
	{
		int num = b67.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<byx>(true) * byx.a;
			c53 c = Enumerable.FirstOrDefault<c53>(A_0.b8().StatusEffects.Get<c53>());
			if (c != null)
			{
				num -= c.Stacks * b67.e;
			}
		}
		return num;
	}

	// Token: 0x0600B00B RID: 45067 RVA: 0x003FF53C File Offset: 0x003FD73C
	protected override int ma(cnm A_0)
	{
		return b67.a(A_0) * b67.h;
	}

	// Token: 0x0600B00C RID: 45068 RVA: 0x003FF54C File Offset: 0x003FD74C
	protected override int mb(cnm A_0)
	{
		return b67.h;
	}

	// Token: 0x040040C6 RID: 16582
	public new static readonly string a = "SAt.Flurry";

	// Token: 0x040040C7 RID: 16583
	public static readonly int b = 3;

	// Token: 0x040040C8 RID: 16584
	public static readonly int c = 3;

	// Token: 0x040040C9 RID: 16585
	public static readonly int d = 35;

	// Token: 0x040040CA RID: 16586
	public new static readonly int e = 4;

	// Token: 0x040040CB RID: 16587
	public static readonly int f = 5;

	// Token: 0x040040CC RID: 16588
	public new static readonly int g = 2;

	// Token: 0x040040CD RID: 16589
	private new static readonly int h = 400;

	// Token: 0x040040CE RID: 16590
	private new List<string> i;
}
