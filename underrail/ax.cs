using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002FD RID: 765
[apc("facelessGaunt")]
public sealed class ax : ake
{
	// Token: 0x06001611 RID: 5649 RVA: 0x00069A1C File Offset: 0x00067C1C
	public ax()
	{
		this.a = new fh(new arr[0]);
		this.c = new ej0();
		this.d = new fh(new arr[0]);
		this.b = new TryActivateAuraNode<e5b>();
		this.e = new ej0();
		this.c.a.Add(new Action<aij>(global::ax.a.a.a));
		fh fh = this.d;
		arr[] array = new arr[3];
		array[0] = new arr(this.a, new Func<e1k, bool>(global::ax.a.a.a));
		array[1] = new arr(this.b, new Func<e1k, bool>(this.a));
		array[2] = new arr(this.c, null);
		fh.a(array);
		fh fh2 = this.a;
		arr[] array2 = new arr[3];
		array2[0] = new arr(this.d, new Func<e1k, bool>(global::ax.a.a.c));
		array2[1] = new arr(this.c, new Func<e1k, bool>(global::ax.a.a.b));
		array2[2] = new arr(this.p.a, null);
		fh2.a(array2);
		this.c.a = new Action<ej0>(global::ax.a.a.a);
		this.c.a = this.e;
		this.e.a = new Action<ej0>(global::ax.a.a.b);
		this.e.a = this.b;
		this.p.a = this.a;
		this.b.a = this.d;
		this.b.b = this.c;
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00069C44 File Offset: 0x00067E44
	private new static bool b(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && amc.a8() != null)
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

	// Token: 0x06001613 RID: 5651 RVA: 0x00069D30 File Offset: 0x00067F30
	private new static csd a(e1k A_0, amc A_1)
	{
		ax.b b = new ax.b();
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
							if (num2 <= 10.0 && num2 - 3.0 <= num)
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

	// Token: 0x06001614 RID: 5652 RVA: 0x00069F74 File Offset: 0x00068174
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !A_0.g().aa().SpecialStates.g && this.b.a(A_0);
	}

	// Token: 0x04000CA1 RID: 3233
	private new fh a;

	// Token: 0x04000CA2 RID: 3234
	private new TryActivateAuraNode<e5b> b;

	// Token: 0x04000CA3 RID: 3235
	private new ej0 c;

	// Token: 0x04000CA4 RID: 3236
	private new fh d;

	// Token: 0x04000CA5 RID: 3237
	private new ej0 e;

	// Token: 0x020002FF RID: 767
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600161D RID: 5661 RVA: 0x0006A558 File Offset: 0x00068758
		internal void a(aij A_0)
		{
			int num = A_0.b().d().GetPrimitivePropertyValue<int>("crawlAwayCooldown", new int?(0)).Value;
			num--;
			A_0.b().d()["crawlAwayCooldown"] = num;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0006A5A8 File Offset: 0x000687A8
		internal bool a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && amc.a8() != null && !amc.aa().IsInControl;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0006A5F0 File Offset: 0x000687F0
		internal bool c(e1k A_0)
		{
			return !global::ax.b(A_0);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0006A604 File Offset: 0x00068804
		internal bool b(e1k A_0)
		{
			if (A_0.g().aa().IsInControl && !A_0.g().aa().SpecialStates.b && A_0.d().GetPrimitivePropertyValue<int>("crawlAwayCooldown", new int?(0)).Value <= 0)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null && amc.a8() != null && amc.aa().StatusEffects.a(ddr.a) && amc.aa().IsInControl)
				{
					return global::ax.a(A_0, amc) != null;
				}
			}
			return false;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0006A6C4 File Offset: 0x000688C4
		internal void a(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				csd csd = global::ax.a(A_0.b(), amc);
				if (csd != null)
				{
					A_0.b().d()["crawlAwayCooldown"] = 3;
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
					awx.ad().Add(new a8v(A_0.b().g().a8(), csd.Location));
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
					A_0.b().g().a8().i.b.b(awx, atp.a);
				}
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0006A7E0 File Offset: 0x000689E0
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				amc.a8().t.b.a(A_0.b().g().a8());
			}
		}

		// Token: 0x04000CAE RID: 3246
		public static readonly ax.a a = new ax.a();

		// Token: 0x04000CAF RID: 3247
		public static Action<aij> b;

		// Token: 0x04000CB0 RID: 3248
		public static Func<e1k, bool> c;

		// Token: 0x04000CB1 RID: 3249
		public static Func<e1k, bool> d;

		// Token: 0x04000CB2 RID: 3250
		public static Func<e1k, bool> e;

		// Token: 0x04000CB3 RID: 3251
		public static Action<ej0> f;

		// Token: 0x04000CB4 RID: 3252
		public static Action<ej0> g;
	}

	// Token: 0x02000300 RID: 768
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06001624 RID: 5668 RVA: 0x0006A840 File Offset: 0x00068A40
		internal bool a(csd A_0)
		{
			return A_0.Area == this.a.g().a8().Area && A_0.Name.StartsWith("hide_", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000CB5 RID: 3253
		public e1k a;
	}
}
