using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002DB RID: 731
[apc("seaSerpent1")]
public sealed class a78 : cqw
{
	// Token: 0x0600159D RID: 5533 RVA: 0x00066054 File Offset: 0x00064254
	public override bool vz()
	{
		return true;
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x00066058 File Offset: 0x00064258
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0006605C File Offset: 0x0006425C
	public a78()
	{
		this.c = new ej0();
		this.d = new ej0();
		this.e = new ej0();
		this.f = new ej0();
		this.f.a = this.k.a;
		this.k.a = this.f;
		this.i.a = this.d;
		this.b = new ej0(new Action<ej0>(a78.a.a.c));
		this.b.a = this.c.a;
		this.c.a = this.b;
		this.a = new fh(new arr[0]);
		fh fh = this.a;
		arr[] array = new arr[3];
		array[0] = new arr(this.c, new Func<e1k, bool>(this.a));
		array[1] = new arr(this.e, new Func<e1k, bool>(a78.a.a.a));
		array[2] = new arr(this.i.b, null);
		fh.a(array);
		this.i.b = this.a;
		this.h.b = this.a;
		this.c.a = new Action<ej0>(this.a);
		this.c.a = this.a;
		this.d.a = new Action<ej0>(a78.a.a.b);
		this.d.a = this.c;
		this.e.a = new Action<ej0>(a78.a.a.a);
		this.e.a = this.a;
		this.f.a = new Action<ej0>(a78.a.a.d);
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0006629C File Offset: 0x0006449C
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
					if (ak != null && !aw1.a(A_0.a8(), ak, false, null) && aw1.a(A_1.a8(), ak) < (double)A_0.aa().Offense.u().TypedDefinition.ad())
					{
						list.Add(ak);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x000663D0 File Offset: 0x000645D0
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
				if (!blk.b() || num > (double)((int)A_0.g().aa().Offense.u().TypedDefinition.ad()))
				{
					return this.a(A_0.g(), amc).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x000664B4 File Offset: 0x000646B4
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		a78.b b = new a78.b();
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

	// Token: 0x04000C4C RID: 3148
	private new fh a;

	// Token: 0x04000C4D RID: 3149
	private new ej0 b;

	// Token: 0x04000C4E RID: 3150
	private new ej0 c;

	// Token: 0x04000C4F RID: 3151
	private new ej0 d;

	// Token: 0x04000C50 RID: 3152
	private new ej0 e;

	// Token: 0x04000C51 RID: 3153
	private new ej0 f;

	// Token: 0x020002DC RID: 732
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x00066618 File Offset: 0x00064818
		internal void c(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a8] = num;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00066678 File Offset: 0x00064878
		internal bool a(e1k A_0)
		{
			return A_0.g().ap != null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00066694 File Offset: 0x00064894
		internal void b(ej0 A_0)
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

		// Token: 0x060015A8 RID: 5544 RVA: 0x000668E0 File Offset: 0x00064AE0
		internal void a(ej0 A_0)
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
			awx.ad().Add(new a4s(new dr5(new Vector3(c5x.Size.X, c5x.Size.Y, bu3.a(A_0.b().g()))), null, new ar7(c5x), null));
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

		// Token: 0x060015A9 RID: 5545 RVA: 0x00066AF0 File Offset: 0x00064CF0
		internal void d(ej0 A_0)
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

		// Token: 0x04000C52 RID: 3154
		public static readonly a78.a a = new a78.a();

		// Token: 0x04000C53 RID: 3155
		public static Action<ej0> b;

		// Token: 0x04000C54 RID: 3156
		public static Func<e1k, bool> c;

		// Token: 0x04000C55 RID: 3157
		public static Action<ej0> d;

		// Token: 0x04000C56 RID: 3158
		public static Action<ej0> e;

		// Token: 0x04000C57 RID: 3159
		public static Action<ej0> f;
	}

	// Token: 0x020002DD RID: 733
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x00066B84 File Offset: 0x00064D84
		internal double a(ak1 A_0)
		{
			return aw1.a(this.a.b().g().a8(), A_0);
		}

		// Token: 0x04000C58 RID: 3160
		public ej0 a;
	}
}
