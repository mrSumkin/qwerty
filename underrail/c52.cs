using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015DF RID: 5599
[euj]
public sealed class c52
{
	// Token: 0x06007B73 RID: 31603 RVA: 0x00339D6C File Offset: 0x00337F6C
	[ayh("PsychokineticChain_SpawnCreationEffects")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null)
		{
			Vector3 a_ = A_1.aj() - new Vector3(0.5f, 0.5f, 0f);
			dv1.a(new List<string>
			{
				"Projectiles\\PsiFlake"
			}, A_1.Area, a_, 25, 150, 2f, 8f, true, true, false, new Action<c5x>(cv.a), true);
		}
	}

	// Token: 0x06007B74 RID: 31604 RVA: 0x00339DE8 File Offset: 0x00337FE8
	[ayh("PsychokineticChain_LinkCarrierDamaged")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ec4 ec;
		cwt cwt;
		cru cru;
		if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.Zone != null && A_1.h.b.aa() != null && A_2 != null && A_2.QuickGet("StatusEffect", out ec) && A_2.QuickGet("attackResult", out cwt) && A_2.QuickGet("stats", out cru) && ec != null)
		{
			ar7 ar = ec.e as ar7;
			if (ar != null)
			{
				c5x c5x = ar.ao() as c5x;
				if (c5x == null || c5x.j != cgy.b || c5x.h == null || c5x.h.b == null || c5x.h.b.aa() == null || c5x.h.b.aa().Dead || c5x.h.b.aa().SpecialStates.k)
				{
					return;
				}
				if (cwt.b && !cwt.w && !cwt.p && cru.b != null)
				{
					int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.b, new Func<csk, bool>(c52.a.a.b)), new Func<csk, int>(c52.a.a.a));
					num = Convert.ToInt32((double)num * ec.f);
					if (num > 0)
					{
						if (num > ec.g)
						{
							num = ec.g;
						}
						dtb dtb = new dtb();
						dtb.b(false);
						dtb.c(false);
						this.a(dtb, A_1, c5x, cwt, num);
						A_1.Zone.ActionManager.g9(dtb, atp.a);
						dz6.a(dtb);
						c5x c5x2 = this.a(ec);
						if (c5x2 != null && egy.a(c5x2, c5x))
						{
							eg2 eg = egy.a(c5x2);
							if (eg != null)
							{
								egy.a(eg);
								eg.b();
								qy qy = new qy();
								qy.ad().Add(new bm3(dz6.b(200)));
								this.a(qy, eg.a8(), c5x, cwt, num);
								A_1.Zone.ActionManager.g9(qy, atp.a);
								dz6.a(qy);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007B75 RID: 31605 RVA: 0x0033A098 File Offset: 0x00338298
	private c5x a(ec4 A_0)
	{
		ar7 ar = A_0.c as ar7;
		if (ar != null)
		{
			return ar.ao() as c5x;
		}
		return null;
	}

	// Token: 0x06007B76 RID: 31606 RVA: 0x0033A0C4 File Offset: 0x003382C4
	private void a(qy A_0, c5x A_1, c5x A_2, cwt A_3, int A_4)
	{
		int num = 1;
		if (A_4 > 20)
		{
			if (A_4 > 50)
			{
				num = 3;
			}
			else
			{
				num = 2;
			}
		}
		cwt cwt = new cwt();
		cwt.i = A_3.i;
		cwt.l = true;
		cwt.e = false;
		cwt.f.Add(new csk(DamageType.Mechanical, A_4));
		cwt.v = "психокинетической цепной реакции";
		cwt.b = true;
		cwt.h = ImpactSpeed.High;
		cwt.ad["PsionicSource"] = PsiSchool.Psychokinesis;
		b0b b0b;
		dvv dvv = es2.a(A_1, A_2, "PsychokineticChain", 0.5f, null, out b0b, true, 0.5f);
		A_1.c().a("PsychokineticChainApplicationLaunch" + Guid.NewGuid().ToString(), "PsychokineticChainApplicationLaunch", 1f, c9z.a, false, false);
		if (dvv != null)
		{
			A_0.ad().Add(dvv);
		}
		if (b0b != null)
		{
			A_0.ad().Add(new c7(b0b, false, false, true, false));
		}
		List<auv> list = A_0.ad();
		string a_ = "PsiChainAttack" + num.ToString();
		int a_2 = 1;
		double maxValue = double.MaxValue;
		bool a_3 = true;
		bool a_4 = true;
		float? a_5 = dz6.b();
		list.Add(new a7j(A_2, a_, a_2, maxValue, a_3, a_4, null, null, null, a_5, false, null));
		A_0.ad().Add(new a4s(new bfq("PsychokineticChainHit"), null, new ar7(A_2), null));
		A_0.ad().Add(new bm3(dz6.b(100)));
		A_0.ad().Add(new akg(null, A_2.h.b, cwt, null, false));
	}

	// Token: 0x06007B77 RID: 31607 RVA: 0x0033A288 File Offset: 0x00338488
	[ayh("PsychokineticChain_LinkHearbeat")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ec4 ec;
		if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.Zone != null && A_1.h.b.aa() != null && A_2 != null && A_2.QuickGet("StatusEffect", out ec))
		{
			ar7 ar = ec.d as ar7;
			if (ar != null)
			{
				c5x c5x = ar.ao() as c5x;
				if (c5x == null || c5x.j != cgy.b || c5x.Zone == null || c5x.h == null || c5x.h.b == null || c5x.h.b.aa() == null || c5x.h.b.aa().Dead || !c5x.h.b.aa().StatusEffects.a(ec4.a))
				{
					ec.d = null;
				}
				else
				{
					ec.h = aw1.a(c5x, A_1, true).GetValueOrDefault();
				}
			}
			ar7 ar2 = ec.e as ar7;
			if (ar2 != null)
			{
				c5x c5x2 = ar2.ao() as c5x;
				if (c5x2 == null || c5x2.j != cgy.b || c5x2.Zone == null || c5x2.h == null || c5x2.h.b == null || c5x2.h.b.aa() == null || c5x2.h.b.aa().Dead)
				{
					ec.e = null;
				}
				else
				{
					ec.i = aw1.a(A_1, c5x2, true).GetValueOrDefault();
				}
			}
			if (ec.d == null && ec.e == null)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				dtb.ad().Add(new bm3(1000));
				dtb.ad().Add(new e43(A_1.h.b, new Guid[]
				{
					ec.Id
				}));
				A_1.Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
				Vector3 a_ = A_1.aj() - new Vector3(0.5f, 0.5f, 0f);
				dv1.a(new List<string>
				{
					"Projectiles\\PsiFlake"
				}, A_1.Area, a_, 0.1f, 20, 175, 2f, 10f, true, true, false, new Action<c5x>(cv.a), true);
			}
		}
	}

	// Token: 0x06007B78 RID: 31608 RVA: 0x0033A560 File Offset: 0x00338760
	[ayh("PsychokineticChain_LinkSoundOn")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			A_1.c().a("psychokineticChain", false);
			A_1.c().a("psychokineticChain", "PsychokineticChainLoop", 1f, c9z.a, true, false);
		}
	}

	// Token: 0x06007B79 RID: 31609 RVA: 0x0033A5A4 File Offset: 0x003387A4
	[ayh("PsychokineticChain_LinkSoundOff")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			A_1.c().a("psychokineticChain", false);
		}
	}

	// Token: 0x020015E0 RID: 5600
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06007B7D RID: 31613 RVA: 0x0033A5DC File Offset: 0x003387DC
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical || A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x0033A5F8 File Offset: 0x003387F8
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0400311C RID: 12572
		public static readonly c52.a a = new c52.a();

		// Token: 0x0400311D RID: 12573
		public static Func<csk, bool> b;

		// Token: 0x0400311E RID: 12574
		public static Func<csk, int> c;
	}
}
