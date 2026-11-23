using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013BF RID: 5055
[bs6("HFX:ElectroboltChain")]
[eiz("E36")]
[Serializable]
public sealed class e50 : cpl, ISerializable
{
	// Token: 0x060071DF RID: 29151 RVA: 0x002FCF1C File Offset: 0x002FB11C
	private e50(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071E0 RID: 29152 RVA: 0x002FCF28 File Offset: 0x002FB128
	public e50()
	{
	}

	// Token: 0x060071E1 RID: 29153 RVA: 0x002FCF34 File Offset: 0x002FB134
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
		int num = 0;
		if (base.agy() != null && base.agy().a != null)
		{
			num = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(e50.a.a.b)), new Func<csk, int>(e50.a.a.c));
		}
		if (num > 0)
		{
			if (!base.b().aa().Dead && cuo.a.NextDouble() < eho.b)
			{
				if (base.b().aa().Passive || (base.b().aa().c(d8o.e) && base.b().aa().d(CharacterImmunities.ShortCircuiting)) || (!base.b().aa().c(d8o.e) && base.b().aa().d(CharacterImmunities.Stun)))
				{
					if (base.a() != null && base.a().a8() != null)
					{
						etm a_;
						if (base.b().aa().c(d8o.e))
						{
							a_ = new etm(new ap9(base.b().aa()), "короткому замыканию");
						}
						else
						{
							a_ = new etm(new ap9(base.b().aa()), "оглушению");
						}
						bey.a(a_, base.a().aa(), base.b().aa(), base.b());
						a7v.a(a_);
					}
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					els els;
					if (base.b().aa().c(d8o.e))
					{
						els = new clt(d0u.b);
						if (base.a().a8().IsPlayer && !base.b().a8().IsPlayer)
						{
							cxc.a(eyy.bz);
						}
					}
					else
					{
						els = awq.a(base.b().aa(), d0u.b);
						if (base.a().a8().IsPlayer && !base.b().a8().IsPlayer && els is ab3)
						{
							cxc.a(eyy.by);
						}
					}
					base.b().aa().StatusEffects.a(els, false, false, false);
				}
			}
			if (base.agu().Power > 0)
			{
				c5x c5x = e50.a(base.a(), base.b());
				if (c5x != null)
				{
					this.a(num, base.a(), base.b().a8(), c5x, 1, base.agw());
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x060071E2 RID: 29154 RVA: 0x002FD298 File Offset: 0x002FB498
	private void a(int A_0, amc A_1, c5x A_2, c5x A_3, int A_4, cwt A_5)
	{
		b0b b0b = null;
		Vector3 a_ = A_2.Location + new Vector3(0f, 0f, A_2.Size.Z * 0.9f);
		Vector3 a_2 = A_3.Location + new Vector3(0f, 0f, A_3.Size.Z * 0.9f);
		dvv item = es2.a(a_, a_2, A_3.Area, "Electrobolt", null, out b0b);
		if (b0b != null && b0b.Zone != null)
		{
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			dtb.ad().Add(item2);
			awq.a(dtb, A_1.a8(), A_3, true, true);
			cwt a_3 = e50.a(A_0, A_1.aa(), A_3.h.b.aa(), A_4, A_5);
			akg akg = new akg(A_1, A_3.h.b, a_3, new b7x(null), false);
			dtb.ad().Add(akg);
			akg.q(new EventHandler<EventArgs>(this.a));
			bfq bfq = new bfq();
			bfq.b("electroshock" + Guid.NewGuid().ToString());
			bfq.c("Electroshock");
			dtb.ad().Add(new a4s(bfq, null, new ar7(A_3), null));
			eym.a(dtb, A_3, (double)aju.bf);
			string a_4 = "Electricity";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			bool a_6 = true;
			bool a_7 = true;
			float? a_8 = dz6.b();
			a7j item3 = new a7j(A_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null);
			dtb.ad().Add(item3);
			A_2.Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
	}

	// Token: 0x060071E3 RID: 29155 RVA: 0x002FD4A4 File Offset: 0x002FB6A4
	private static cwt a(int A_0, efk A_1, efk A_2, int A_3, cwt A_4)
	{
		cwt cwt = new cwt();
		cwt.i = new ap9(A_1);
		cwt.j = new ap9(A_2);
		cwt.f.Add(new csk(DamageType.Electricity, (int)Math.Max(0.0, (double)A_0 * eho.a)));
		cwt.v = "электроболт";
		cwt.b = true;
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.ad["jump"] = A_3;
		cpl.a(A_4, cwt);
		return cwt;
	}

	// Token: 0x060071E4 RID: 29156 RVA: 0x002FD530 File Offset: 0x002FB730
	private static c5x a(amc A_0, amc A_1)
	{
		c5x result = null;
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			HashSet<c5x> hashSet = new HashSet<c5x>();
			bool flag = false;
			if (A_1.a8().t.b != null)
			{
				HashSet<r0> hashSet2 = A_1.a8().t.b.b(service);
				if (hashSet2 != null && hashSet2.Count > 0)
				{
					flag = true;
					foreach (r0 r in hashSet2)
					{
						ak1 ak = A_1.a8().Area.a(r.a.a());
						if (ak != null)
						{
							double num = aw1.a(A_1.a8(), ak);
							if (num <= 4.0)
							{
								foreach (b0b b0b in ak.c.Values)
								{
									c5x c5x = (c5x)b0b;
									if (c5x != A_1.a8() && c5x.h.b != null && !c5x.h.b.aa().Dead && euf.d(c5x.h.b.aa()) && (c5x != A_0.a8() || num <= 2.0))
									{
										hashSet.Add(c5x);
									}
								}
							}
						}
					}
				}
			}
			if (!flag)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && !d4n.b.aa().Dead && euf.d(d4n.b.aa()) && d4n.b.a8() != null && d4n.b != A_1 && d4n.b.a8().t.b != null && d4n.b.a8().Zone == A_1.a8().Zone)
					{
						double num2 = aw1.b(d4n.b.a8(), A_1.a8());
						int num3;
						if (d4n.b == A_0)
						{
							num3 = 2;
						}
						else
						{
							num3 = 4;
						}
						if (num2 <= (double)num3 && d4n.b.a8().t.b.b(A_1, false))
						{
							hashSet.Add(d4n.b.a8());
						}
					}
				}
			}
			if (hashSet.Count > 0)
			{
				result = Enumerable.ToList<c5x>(hashSet)[cuo.a.Next(hashSet.Count)];
			}
		}
		return result;
	}

	// Token: 0x060071E5 RID: 29157 RVA: 0x002FD884 File Offset: 0x002FBA84
	[dcc("E36:mARA_F")]
	private void a(object A_0, EventArgs A_1)
	{
		akg akg = A_0 as akg;
		if (akg == null || akg.b() == null || akg.b().a == null || akg.b().a.Count == 0 || akg.m() == null || akg.n() == null)
		{
			return;
		}
		c5x c5x = e50.a(akg.n(), akg.m());
		if (c5x != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(akg.b().a, new Func<csk, bool>(e50.a.a.d)), new Func<csk, int>(e50.a.a.a));
			int value = akg.d().ad.GetPrimitivePropertyValue<int>("jump", new int?(1)).Value;
			if (num > 0 && value < base.agu().Power)
			{
				this.a(num, akg.n(), akg.m().a8(), c5x, value + 1, akg.d());
			}
		}
	}

	// Token: 0x020013C0 RID: 5056
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071E8 RID: 29160 RVA: 0x002FD9CC File Offset: 0x002FBBCC
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x002FD9D8 File Offset: 0x002FBBD8
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x002FD9E4 File Offset: 0x002FBBE4
		internal bool d(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x002FD9F0 File Offset: 0x002FBBF0
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E79 RID: 11897
		public static readonly e50.a a = new e50.a();

		// Token: 0x04002E7A RID: 11898
		public static Func<csk, bool> b;

		// Token: 0x04002E7B RID: 11899
		public static Func<csk, int> c;

		// Token: 0x04002E7C RID: 11900
		public static Func<csk, bool> d;

		// Token: 0x04002E7D RID: 11901
		public static Func<csk, int> e;
	}
}
