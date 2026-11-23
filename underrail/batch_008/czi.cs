using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EBB RID: 7867
[ayj("DirtyKick")]
public sealed class czi : c0z
{
	// Token: 0x0600B177 RID: 45431 RVA: 0x004023F8 File Offset: 0x004005F8
	public override string y8()
	{
		return "Низкий удар";
	}

	// Token: 0x0600B178 RID: 45432 RVA: 0x00402400 File Offset: 0x00400600
	public override string os()
	{
		return "DirtyKick";
	}

	// Token: 0x0600B179 RID: 45433 RVA: 0x00402408 File Offset: 0x00400608
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B17A RID: 45434 RVA: 0x0040240C File Offset: 0x0040060C
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B17B RID: 45435 RVA: 0x00402410 File Offset: 0x00400610
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B17C RID: 45436 RVA: 0x00402414 File Offset: 0x00400614
	public czi()
	{
		this.f = new List<string>();
		this.f.Add(d7f.a);
		this.f.Add("SAt.DirtyKick");
	}

	// Token: 0x0600B17D RID: 45437 RVA: 0x0040244C File Offset: 0x0040064C
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().b(d8o.t))
			{
				return new a3b
				{
					c = c0e.p,
					a = c0e.p,
					b = new int?(int.MaxValue)
				};
			}
			if (A_0.b8().Gear.l().Item != null && A_0.b8().Gear.l().Item.fu().a())
			{
				return new a3b
				{
					c = c0e.c,
					a = c0e.c,
					b = new int?(int.MaxValue)
				};
			}
		}
		return new a3b
		{
			c = c0e.k,
			a = c0e.k,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B17E RID: 45438 RVA: 0x00402544 File Offset: 0x00400744
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.DirtyKick";
	}

	// Token: 0x0600B17F RID: 45439 RVA: 0x0040254C File Offset: 0x0040074C
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 == null || A_0.b8() == null || !A_0.b8().SpecialStates.b);
	}

	// Token: 0x0600B180 RID: 45440 RVA: 0x00402584 File Offset: 0x00400784
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B181 RID: 45441 RVA: 0x0040258C File Offset: 0x0040078C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/DirtyKick", new object[]
		{
			czi.a(A_0).a(true),
			l4.a((double)czi.c, false),
			l4.a((double)czi.d, false)
		});
	}

	// Token: 0x0600B182 RID: 45442 RVA: 0x004025DC File Offset: 0x004007DC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int a_ = uf.a(czi.b, A_0, new CooldownCategory[]
		{
			CooldownCategory.DirtyKick
		});
		list.Add(new cfd("SAt.DirtyKick", a_, false, false));
		return list;
	}

	// Token: 0x0600B183 RID: 45443 RVA: 0x00402638 File Offset: 0x00400838
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B184 RID: 45444 RVA: 0x00402640 File Offset: 0x00400840
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600B185 RID: 45445 RVA: 0x00402644 File Offset: 0x00400844
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 == null || A_0.b8() == null || !A_0.b8().SpecialStates.b);
	}

	// Token: 0x0600B186 RID: 45446 RVA: 0x0040267C File Offset: 0x0040087C
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B187 RID: 45447 RVA: 0x00402684 File Offset: 0x00400884
	protected override int hi(cnm A_0)
	{
		return czi.e;
	}

	// Token: 0x0600B188 RID: 45448 RVA: 0x0040268C File Offset: 0x0040088C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B189 RID: 45449 RVA: 0x00402698 File Offset: 0x00400898
	public new static a1q a(cnm A_0)
	{
		bke bke = euf.i(A_0.b8()).TypedDefinition;
		double a_ = euf.a(A_0.b8(), btz.g, false);
		a1q a1q = Enumerable.FirstOrDefault<a1q>(Enumerable.Where<a1q>(bke.l(), new Func<a1q, bool>(czi.a.a.a)));
		double num = qw.a(bke, a_);
		WeaponSubtype? a_2 = euf.d(bke);
		double num2 = qw.a(A_0.b8(), bke, a_2);
		double num3 = 4.0 * A_0.b8().SpecialCategoryModifiers[SpecialCategory.DirtyKick].a;
		double num4 = (double)A_0.b8().GetSpecializationValue<b9e>(true) * b9e.a;
		return new a1q(DamageType.Mechanical, (int)((double)a1q.LowerBoundary * (1.0 + num2 + num) * num3 * (1.0 + num4)), (int)((double)a1q.UpperBoundary * (1.0 + num2 + num) * num3 * (1.0 + num4)));
	}

	// Token: 0x0400411C RID: 16668
	private new const string a = "SAt.DirtyKick";

	// Token: 0x0400411D RID: 16669
	public static readonly int b = d0u.b * 6;

	// Token: 0x0400411E RID: 16670
	public static readonly int c = d0u.b;

	// Token: 0x0400411F RID: 16671
	public static readonly int d = d0u.b * 2;

	// Token: 0x04004120 RID: 16672
	public new static readonly int e = 15;

	// Token: 0x04004121 RID: 16673
	private List<string> f;

	// Token: 0x02001EBC RID: 7868
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600B18D RID: 45453 RVA: 0x004027E4 File Offset: 0x004009E4
		internal bool a(a1q A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x04004122 RID: 16674
		public static readonly czi.a a = new czi.a();

		// Token: 0x04004123 RID: 16675
		public static Func<a1q, bool> b;
	}
}
