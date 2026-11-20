using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000307 RID: 775
[apc("crawler")]
public sealed class buk : cqw
{
	// Token: 0x06001650 RID: 5712 RVA: 0x0006C7EC File Offset: 0x0006A9EC
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x0006C7F0 File Offset: 0x0006A9F0
	public buk()
	{
		this.a = new fh(new arr[0]);
		this.b = new fh(new arr[0]);
		this.c = new TryInvokeSpecialAttackNode<dls>();
		this.e = new ej0();
		this.f = new fh(new arr[0]);
		this.d = new TryActivateAuraNode<e5b>();
		this.g = new ej0();
		this.h = new TryInvokeSpecialAbilityNode<amv>();
		this.h.a = e8t.b;
		this.c.a.Add(new Action<aij>(buk.a.a.a));
		fh fh = this.f;
		arr[] array = new arr[4];
		array[0] = new arr(this.d, new Func<e1k, bool>(buk.a.a.c));
		array[1] = new arr(this.d, new Func<e1k, bool>(this.d));
		array[2] = new arr(this.c, new Func<e1k, bool>(this.c));
		array[3] = new arr(this.c, null);
		fh.a(array);
		this.b.a(new arr[]
		{
			new arr(this.d, new Func<e1k, bool>(this.b)),
			new arr(this.f, null)
		});
		fh fh2 = this.a;
		arr[] array2 = new arr[4];
		array2[0] = new arr(this.f, new Func<e1k, bool>(buk.a.a.a));
		array2[1] = new arr(this.c, new Func<e1k, bool>(this.a));
		array2[2] = new arr(this.e, new Func<e1k, bool>(buk.a.a.b));
		array2[3] = new arr(this.p.a, null);
		fh2.a(array2);
		this.e.a = new Action<ej0>(buk.a.a.b);
		this.e.a = this.g;
		this.g.a = new Action<ej0>(buk.a.a.a);
		this.g.a = this.b;
		this.c.a = this.a;
		this.c.b = this.p.a;
		this.p.a = this.a;
		this.d.a = this.f;
		this.d.b = this.c;
		this.h.a = this.a;
		this.h.b = this.c;
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x0006CB00 File Offset: 0x0006AD00
	private new static bool e(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && amc.a8() != null && amc.a8().t.b != null)
		{
			d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
			HashSet<r0> hashSet = amc.a8().t.b.b(serviceOrThrow);
			foreach (ak1 ak in A_0.g().a8().l)
			{
				r0 r = new r0(ak.Area.c(), new Vector2((float)ak.Location.X, (float)ak.Location.Y));
				if (hashSet.Contains(r))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0006CC04 File Offset: 0x0006AE04
	private new static csd a(e1k A_0, amc A_1)
	{
		buk.b b = new buk.b();
		b.a = A_0;
		if (A_1 != null && A_1.a8() != null && A_1.a8().t.b != null && b.a.g().a8().Area != null && b.a.g().a8().Area.Zone != null && A_1.a8().Area == b.a.g().a8().Area)
		{
			d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
			HashSet<r0> hashSet = A_1.a8().t.b.b(serviceOrThrow);
			List<csd> list = Enumerable.ToList<csd>(Enumerable.Where<csd>(b.a.g().a8().Area.Zone.Waypoints, new Func<csd, bool>(b.a)));
			if (list.Count > 0)
			{
				List<csd> list2 = new List<csd>();
				double num = double.MaxValue;
				foreach (csd csd in list)
				{
					r0 r = new r0(csd.Area.c(), new Vector2((float)((int)csd.Location.X), (float)((int)csd.Location.Y)));
					if (!hashSet.Contains(r))
					{
						ak1 ak = csd.Area.a(csd.Location.a());
						if (ak != null && !aw1.a(null, ak, false, b.a.g().a8()))
						{
							double num2 = aw1.a(A_1.a8(), ak);
							if (num2 <= 7.0 && num2 - 3.0 <= num)
							{
								if (num2 < num)
								{
									num = num2;
								}
								list2.Add(csd);
							}
						}
					}
				}
				if (list2.Count > 0)
				{
					return list2[cuo.a.Next(list2.Count)];
				}
			}
		}
		return null;
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0006CE48 File Offset: 0x0006B048
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.g && this.d.a(A_0);
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0006CE74 File Offset: 0x0006B074
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("crawlAwayCooldown", new int?(0)).Value <= 0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && (!amc.aa().StatusEffects.a(ddr.a) || (!amc.aa().StatusEffects.a(bek.a) && !amc.aa().SpecialStates.a && A_0.g().aa().Offense.u().CustomProperties.GetPrimitivePropertyValue<bool>("allergy", new bool?(false)).Value)))
			{
				a2a a2a = Enumerable.FirstOrDefault<a2a>(amc.aa().StatusEffects.Get<a2a>());
				return (a2a == null || a2a.TimeLeft <= (double)d0u.b) && A_0.g().aa().SpecialStates.g && this.c.a(A_0);
			}
		}
		return false;
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0006CFA8 File Offset: 0x0006B1A8
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.g && this.d.a(A_0);
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0006CFD4 File Offset: 0x0006B1D4
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.c.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && (!amc.aa().StatusEffects.a(ddr.a) || (!amc.aa().StatusEffects.a(bek.a) && !amc.aa().SpecialStates.a && A_0.g().aa().Offense.u().CustomProperties.GetPrimitivePropertyValue<bool>("allergy", new bool?(false)).Value)))
			{
				a2a a2a = Enumerable.FirstOrDefault<a2a>(amc.aa().StatusEffects.Get<a2a>());
				return a2a == null || a2a.TimeLeft <= (double)d0u.b;
			}
		}
		return false;
	}

	// Token: 0x04000CEA RID: 3306
	private new fh a;

	// Token: 0x04000CEB RID: 3307
	private new fh b;

	// Token: 0x04000CEC RID: 3308
	private new TryInvokeSpecialAttackNode<dls> c;

	// Token: 0x04000CED RID: 3309
	private new TryActivateAuraNode<e5b> d;

	// Token: 0x04000CEE RID: 3310
	private new ej0 e;

	// Token: 0x04000CEF RID: 3311
	private new fh f;

	// Token: 0x04000CF0 RID: 3312
	private new ej0 g;

	// Token: 0x04000CF1 RID: 3313
	private new TryInvokeSpecialAbilityNode<amv> h;

	// Token: 0x02000308 RID: 776
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x0006D0E4 File Offset: 0x0006B2E4
		internal void a(aij A_0)
		{
			int num = A_0.b().d().GetPrimitivePropertyValue<int>("crawlAwayCooldown", new int?(0)).Value;
			num--;
			A_0.b().d()["crawlAwayCooldown"] = num;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0006D134 File Offset: 0x0006B334
		internal bool c(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && amc.a8() != null && !amc.aa().IsInControl;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0006D17C File Offset: 0x0006B37C
		internal bool a(e1k A_0)
		{
			return !buk.e(A_0) || A_0.g().aa().SpecialStates.g;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006D1AC File Offset: 0x0006B3AC
		internal bool b(e1k A_0)
		{
			if (A_0.g().aa().IsInControl && !A_0.g().aa().SpecialStates.b && A_0.d().GetPrimitivePropertyValue<int>("crawlAwayCooldown", new int?(0)).Value <= 0)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null && amc.a8() != null && amc.aa().IsInControl)
				{
					return buk.a(A_0, amc) != null;
				}
			}
			return false;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0006D250 File Offset: 0x0006B450
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				csd csd = buk.a(A_0.b(), amc);
				if (csd != null)
				{
					A_0.b().d()["crawlAwayCooldown"] = 1;
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
					awx.ad().Add(new a8v(A_0.b().g().a8(), csd.Location));
					awx.ad().Add(new a4s(new ey(csd.Direction), null, new ar7(A_0.b().g().a8()), null));
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
					A_0.b().g().a8().i.b.b(awx, atp.a);
				}
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006D3A0 File Offset: 0x0006B5A0
		internal void a(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				amc.a8().t.b.a(A_0.b().g().a8());
			}
		}

		// Token: 0x04000CF2 RID: 3314
		public static readonly buk.a a = new buk.a();

		// Token: 0x04000CF3 RID: 3315
		public static Action<aij> b;

		// Token: 0x04000CF4 RID: 3316
		public static Func<e1k, bool> c;

		// Token: 0x04000CF5 RID: 3317
		public static Func<e1k, bool> d;

		// Token: 0x04000CF6 RID: 3318
		public static Func<e1k, bool> e;

		// Token: 0x04000CF7 RID: 3319
		public static Action<ej0> f;

		// Token: 0x04000CF8 RID: 3320
		public static Action<ej0> g;
	}

	// Token: 0x02000309 RID: 777
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06001661 RID: 5729 RVA: 0x0006D400 File Offset: 0x0006B600
		internal bool a(csd A_0)
		{
			return A_0.Area == this.a.g().a8().Area && (A_0.Name.StartsWith("hide_", StringComparison.OrdinalIgnoreCase) || A_0.Name.StartsWith("hidden_", StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x04000CF9 RID: 3321
		public e1k a;
	}
}
