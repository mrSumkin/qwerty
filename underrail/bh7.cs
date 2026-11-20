using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020002D8 RID: 728
[apc("seaWyrm")]
public class bh7 : cqw
{
	// Token: 0x0600158B RID: 5515 RVA: 0x00065380 File Offset: 0x00063580
	public override bool vz()
	{
		return true;
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x00065384 File Offset: 0x00063584
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x0006538C File Offset: 0x0006358C
	public bh7()
	{
		this.c = new ej0();
		this.d = new ej0();
		this.e = new ej0();
		this.h = new ej0();
		this.h.a = this.k.a;
		this.k.a = this.h;
		this.i.a = this.d;
		this.b = new ej0(new Action<ej0>(bh7.a.a.a));
		this.b.a = this.c.a;
		this.c.a = this.b;
		this.f = new ej0(new Action<ej0>(bh7.a.a.e));
		this.f.a = this.i.b;
		this.g = new ej0(new Action<ej0>(bh7.a.a.d));
		this.g.a = this.i.b;
		this.a = new fh(new arr[0]);
		fh fh = this.a;
		arr[] array = new arr[4];
		array[0] = new arr(this.c, new Func<e1k, bool>(this.a));
		array[1] = new arr(this.e, new Func<e1k, bool>(bh7.a.a.a));
		array[2] = new arr(this.f, new Func<e1k, bool>(bh7.a.a.b));
		array[3] = new arr(this.g, null);
		fh.a(array);
		this.i.b = this.a;
		this.h.b = this.a;
		this.c.a = new Action<ej0>(this.a);
		this.c.a = this.a;
		this.d.a = new Action<ej0>(bh7.a.a.f);
		this.d.a = this.c;
		this.e.a = new Action<ej0>(bh7.a.a.b);
		this.e.a = this.a;
		this.h.a = new Action<ej0>(bh7.a.a.c);
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0006567C File Offset: 0x0006387C
	private new List<ak1> a(amc A_0, amc A_1)
	{
		List<ak1> list = new List<ak1>();
		if (A_1 != null && A_1.a8() != null && A_1.a8().t.b != null && A_1.a8().Area == A_0.a8().Area)
		{
			HashSet<r0> hashSet = A_1.a8().t.b.b(bpo.GetServiceOrThrow<d02>());
			if (hashSet != null)
			{
				foreach (r0 r in hashSet)
				{
					ak1 ak = A_0.a8().Area.b((int)r.a.X, (int)r.a.Y);
					if (ak != null && !aw1.a(A_0.a8(), ak, false, null) && aw1.a(A_1.a8(), ak) < (double)A_0.aa().Offense.b(WeaponKey.Secondary).TypedDefinition.ad())
					{
						list.Add(ak);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x000657B0 File Offset: 0x000639B0
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value == 0)
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.a8().Area == A_0.g().a8().Area)
			{
				blk blk = bzv.c(amc.a8().qe());
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (!blk.b() || num > (double)((int)A_0.g().aa().Offense.b(WeaponKey.Secondary).TypedDefinition.ad()))
				{
					return this.a(A_0.g(), amc).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00065894 File Offset: 0x00063A94
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		bh7.b b = new bh7.b();
		b.a = A_0;
		amc amc = new bzv(b.a.b().c().y6()).g();
		if (amc != null)
		{
			List<ak1> list = this.a(b.a.b().g(), amc);
			if (list.Count > 0)
			{
				ak1 ak = Enumerable.FirstOrDefault<ak1>(Enumerable.OrderBy<ak1, double>(list, new Func<ak1, double>(b.a)));
				double num = aw1.a(b.a.b().g().a8(), ak) * 10.0;
				int a_ = (int)(Math.Min(80.0, num) + Math.Max(0.0, num - 80.0) * 0.7);
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				d4n d4n = serviceOrThrow.ahu(b.a.b().g().aa());
				if (d4n == serviceOrThrow.ahe())
				{
					d4n.b(a_, true);
				}
				e3i.a(b.a, amc, ak);
			}
		}
		b.a.b().c().y6()[ddq.a8] = 1;
	}

	// Token: 0x04000C3A RID: 3130
	private new fh a;

	// Token: 0x04000C3B RID: 3131
	private new ej0 b;

	// Token: 0x04000C3C RID: 3132
	private new ej0 c;

	// Token: 0x04000C3D RID: 3133
	private new ej0 d;

	// Token: 0x04000C3E RID: 3134
	private new ej0 e;

	// Token: 0x04000C3F RID: 3135
	private new ej0 f;

	// Token: 0x04000C40 RID: 3136
	private new ej0 g;

	// Token: 0x04000C41 RID: 3137
	private new ej0 h;

	// Token: 0x020002D9 RID: 729
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x000659F8 File Offset: 0x00063BF8
		internal void a(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a8] = num;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00065A58 File Offset: 0x00063C58
		internal void e(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00065A80 File Offset: 0x00063C80
		internal void d(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00065AA8 File Offset: 0x00063CA8
		internal bool a(e1k A_0)
		{
			return A_0.g().ap != null;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00065AC4 File Offset: 0x00063CC4
		internal bool b(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				du2 du = amc.aa().Defense.af()[DamageType.Mechanical];
				if (du.c() < 0.4 && du.a() < 20 && aw1.b(A_0.g().a8(), amc.a8()) <= 1.5)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00065B50 File Offset: 0x00063D50
		internal void f(ej0 A_0)
		{
			if (A_0.b().g().ap == null)
			{
				c5x c5x = A_0.b().g().a8();
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveIn"), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new a7j(A_0.b().g().a8(), bu3.b(A_0.b().g()), 1, double.MaxValue, false, false, null, null, null, null, false, null));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom4, dz6.b(80), 0, null, 1));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom3, dz6.b(80), 0, null, 1));
				awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new a4s(new dr5(new Vector3(c5x.Size.X, c5x.Size.Y, 0.2f)), null, new ar7(c5x), null));
				awx.ad().Add(new amd(A_0.b().g(), new els[]
				{
					new ewc(0)
				}));
				awx.ad().Add(new duh(A_0.b().g(), new string[]
				{
					aw3.a
				}));
				awx.ad().Add(new duh(A_0.b().g(), new string[]
				{
					bk9.a
				}));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00065D9C File Offset: 0x00063F9C
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			c5x c5x = A_0.b().g().a8();
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.k));
			awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveOut"), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(80), 0, null, 1));
			if (amc != null)
			{
				List<auv> list = awx.ad();
				a4s a4s = new a4s(new akw(), null, null, null);
				a4s.a(new ar7(A_0.b().g().a8()));
				a4s.b(new ar7(amc.a8()));
				list.Add(a4s);
			}
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom5, dz6.b(80), 0, null, 1));
			awx.ad().Add(new a4s(new epw(null), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new a4s(new dr5(new Vector3(c5x.Size.X, c5x.Size.Y, 2f)), null, new ar7(c5x), null));
			awx.ad().Add(new duh(A_0.b().g(), new string[]
			{
				ewc.a
			}));
			awx.ad().Add(new amd(A_0.b().g(), new els[]
			{
				new aw3(0)
			}));
			A_0.b().i().b(awx, atp.a);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00065FA0 File Offset: 0x000641A0
		internal void c(ej0 A_0)
		{
			c5x c5x = null;
			axo axo = Enumerable.FirstOrDefault<axo>(A_0.b().g().aa().StatusEffects.Get<axo>());
			if (axo != null)
			{
				ar7 ar = axo.ObjectOfFear as ar7;
				if (ar != null)
				{
					c5x = (ar.ao() as c5x);
				}
			}
			if (c5x == null)
			{
				c5x = or.a(A_0.b().g());
			}
			ak1 ak = g8.a(A_0.b().c(), c5x, 10);
			if (ak != null)
			{
				e3i.a(A_0, null, ak);
			}
		}

		// Token: 0x04000C42 RID: 3138
		public static readonly bh7.a a = new bh7.a();

		// Token: 0x04000C43 RID: 3139
		public static Action<ej0> b;

		// Token: 0x04000C44 RID: 3140
		public static Action<ej0> c;

		// Token: 0x04000C45 RID: 3141
		public static Action<ej0> d;

		// Token: 0x04000C46 RID: 3142
		public static Func<e1k, bool> e;

		// Token: 0x04000C47 RID: 3143
		public static Func<e1k, bool> f;

		// Token: 0x04000C48 RID: 3144
		public static Action<ej0> g;

		// Token: 0x04000C49 RID: 3145
		public static Action<ej0> h;

		// Token: 0x04000C4A RID: 3146
		public static Action<ej0> i;
	}

	// Token: 0x020002DA RID: 730
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x00066034 File Offset: 0x00064234
		internal double a(ak1 A_0)
		{
			return aw1.a(this.a.b().g().a8(), A_0);
		}

		// Token: 0x04000C4B RID: 3147
		public ej0 a;
	}
}
