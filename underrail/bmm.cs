using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013C1 RID: 5057
[eiz("E33")]
[bs6("HFX:pneumaticImpact")]
[Serializable]
public sealed class bmm : cpl, ISerializable, enp
{
	// Token: 0x060071EC RID: 29164 RVA: 0x002FD9FC File Offset: 0x002FBBFC
	private bmm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071ED RID: 29165 RVA: 0x002FDA08 File Offset: 0x002FBC08
	public bmm()
	{
	}

	// Token: 0x060071EE RID: 29166 RVA: 0x002FDA10 File Offset: 0x002FBC10
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		cd1 cd = base.c();
		if (cd == null)
		{
			return dc4.c;
		}
		int num = cd.CustomProperties.GetPrimitivePropertyValue<int>("PneumaticStrikeCounter", new int?(0)).Value + 1;
		if (num >= 4)
		{
			num = 0;
			int num2 = b86.c(base.agu());
			if ((double)num2 <= cd.Battery)
			{
				cd.Battery -= (double)num2;
				int num3 = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agw().f, new Func<csk, bool>(bmm.a.a.c)), new Func<csk, int>(bmm.a.a.d));
				if (num3 > 0)
				{
					dtb dtb = new dtb();
					dtb.b(false);
					dtb.c(false);
					dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Stun"), null, new ar7(base.b().a8()), null));
					dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), (int)((double)num3 * b86.b(base.agu())), base.b()), new b7x(this), false));
					dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
					base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
					dz6.a(dtb);
				}
			}
		}
		cd.CustomProperties["PneumaticStrikeCounter"] = num;
		return dc4.c;
	}

	// Token: 0x060071EF RID: 29167 RVA: 0x002FDC54 File Offset: 0x002FBE54
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_3.a != null && !A_2.c.GetValueOrDefault())
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bmm.a.a.b)), new Func<csk, int>(bmm.a.a.a)) > 0)
			{
				if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Incapacitation))
				{
					if (A_0 != null)
					{
						etm a_ = new etm(new ap9(A_1.aa()), "ошеломлению");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
					}
					bmj.a(A_1.a8(), new ba0());
					return;
				}
				cd1 cd = base.c();
				if (euf.e((int)euf.a(A_0.aa(), cd.TypedDefinition.e(), false), A_1.aa()))
				{
					c6f a_2 = new c6f(new ap9(A_1.aa()), null, "ошеломлению");
					bey.a(a_2, A_1.aa(), A_1);
					a7v.a(a_2);
					bmj.a(A_1.a8(), new dym());
					return;
				}
				cjy a_3 = new cjy(b86.a(base.agu()) * d0u.b);
				A_1.aa().StatusEffects.a(a_3, false, false, false);
				if (A_0 != null && A_0.aa() is e3q && !(A_1.aa() is e3q))
				{
					cxc.a(eyy.b0);
				}
				if (A_1.a8() != null && A_1.a8().t.b != null)
				{
					A_1.a8().t.b.ah();
				}
				vr a_4 = new vr(new ap9(A_1.aa()), null, "{0}: ошеломление.", new Color?(adi.j), null);
				bey.a(a_4, A_1.aa(), A_1);
				a7v.a(a_4);
				return;
			}
			else
			{
				c6f a_5 = new c6f(new ap9(A_1.aa()), null, "ошеломлению");
				bey.a(a_5, A_1.aa(), A_1);
				a7v.a(a_5);
				bmj.a(A_1.a8(), new dym());
			}
		}
	}

	// Token: 0x060071F0 RID: 29168 RVA: 0x002FDEB8 File Offset: 0x002FC0B8
	private cwt a(cwt A_0, int A_1, amc A_2)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.c = A_0.c;
		cwt.f.Add(new csk(DamageType.Mechanical, A_1));
		cwt.v = "пневматический удар";
		cwt.h = ImpactSpeed.Low;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = true;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x020013C2 RID: 5058
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071F3 RID: 29171 RVA: 0x002FDF4C File Offset: 0x002FC14C
		internal bool c(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x002FDF58 File Offset: 0x002FC158
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x002FDF64 File Offset: 0x002FC164
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x002FDF70 File Offset: 0x002FC170
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E7E RID: 11902
		public static readonly bmm.a a = new bmm.a();

		// Token: 0x04002E7F RID: 11903
		public static Func<csk, bool> b;

		// Token: 0x04002E80 RID: 11904
		public static Func<csk, int> c;

		// Token: 0x04002E81 RID: 11905
		public static Func<csk, bool> d;

		// Token: 0x04002E82 RID: 11906
		public static Func<csk, int> e;
	}
}
