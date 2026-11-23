using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002ED RID: 749
[apc("primeTentacle")]
public class ft : cqw
{
	// Token: 0x060015D8 RID: 5592 RVA: 0x000679B4 File Offset: 0x00065BB4
	protected virtual int l7()
	{
		return 10;
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x000679B8 File Offset: 0x00065BB8
	public override bool ef()
	{
		return false;
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000679BC File Offset: 0x00065BBC
	public ft()
	{
		this.d = new ej0();
		this.c = new ej0(new Action<ej0>(ft.a.a.a));
		this.c.a = this.c.a;
		this.c.a = this.c;
		this.a = new fh(new arr[0]);
		this.a.a(new arr[]
		{
			new arr(this.d, new Func<e1k, bool>(this.b)),
			new arr(this.i.b, null)
		});
		this.b = new fh(new arr[0]);
		this.b.a(new arr[]
		{
			new arr(this.d, new Func<e1k, bool>(this.a)),
			new arr(this.i.a, null)
		});
		this.i.b = this.a;
		this.i.a = this.b;
		this.h.b = this.a;
		this.d.a = new Action<ej0>(this.a);
		this.d.a = this.a;
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00067B2C File Offset: 0x00065D2C
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value == 0)
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.a8().Area == A_0.g().a8().Area)
			{
				blk blk = bzv.c(amc.a8().qe());
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (!blk.b() || num >= (double)this.l7())
				{
					return dan.a(A_0.c(), amc.a8(), this.l7()).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00067C00 File Offset: 0x00065E00
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value == 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && dan.a(c5x))
				{
					return dan.a(A_0.c(), c5x, this.l7()).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00067CB0 File Offset: 0x00065EB0
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		bzv bzv = new bzv(A_0.b().c().y6());
		c5x c5x = null;
		csd csd = null;
		amc amc = bzv.g();
		if (amc != null && amc.a8().Area == A_0.b().g().a8().Area)
		{
			blk blk = bzv.c(amc.a8().qe());
			double num = aw1.b(A_0.b().g().a8(), amc.a8());
			if (!blk.b() || num >= (double)this.l7())
			{
				List<csd> list = dan.a(A_0.b().c(), amc.a8(), this.l7());
				if (list.Count > 0)
				{
					csd = list[cuo.a.Next(list.Count)];
					c5x = amc.a8();
				}
			}
		}
		else
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x2 != null)
				{
					List<csd> list2 = dan.a(A_0.b().c(), c5x2, this.l7());
					if (list2.Count > 0)
					{
						csd = list2[cuo.a.Next(list2.Count)];
						c5x = c5x2;
					}
				}
			}
		}
		if (c5x != null && csd != null)
		{
			awx awx = new awx(csd.Name);
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.k));
			awx.ad().Add(new a4s(new bfq("TentacleDiveIn"), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
			List<auv> list3 = awx.ad();
			ch3 ch = new ch3();
			ch.a(new float?(0f));
			list3.Add(new a4s(ch, null, new ar7(A_0.b().g().a8()), null));
			List<auv> list4 = awx.ad();
			b16 b = new b16();
			b.a(new int?(0));
			list4.Add(new a4s(b, null, new ar7(A_0.b().g().a8()), null));
			List<auv> list5 = awx.ad();
			epw epw = new epw();
			epw.a(new CharacterState?(CharacterState.Custom1));
			list5.Add(new a4s(epw, null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new bm3(dz6.b(500)));
			awx.ad().Add(new a8v(A_0.b().g().a8(), csd.Location));
			awx.ad().Add(new a4s(new akw(), new ar7(A_0.b().g().a8()), new ar7(c5x), null));
			List<auv> list6 = awx.ad();
			ch3 ch2 = new ch3();
			ch2.a(null);
			list6.Add(new a4s(ch2, null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new a4s(new bfq("TentacleDiveOut"), null, new ar7(A_0.b().g().a8()), null));
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
			List<auv> list7 = awx.ad();
			b16 b2 = new b16();
			b2.a(null);
			list7.Add(new a4s(b2, null, new ar7(A_0.b().g().a8()), null));
			List<auv> list8 = awx.ad();
			epw epw2 = new epw();
			epw2.a(null);
			list8.Add(new a4s(epw2, null, new ar7(A_0.b().g().a8()), null));
			A_0.b().i().b(awx, atp.a);
		}
		A_0.b().c().y6()[ddq.a8] = 1;
	}

	// Token: 0x04000C76 RID: 3190
	private new fh a;

	// Token: 0x04000C77 RID: 3191
	private new fh b;

	// Token: 0x04000C78 RID: 3192
	private new ej0 c;

	// Token: 0x04000C79 RID: 3193
	private new ej0 d;

	// Token: 0x020002F0 RID: 752
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x000688B4 File Offset: 0x00066AB4
		internal void a(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a8] = num;
		}

		// Token: 0x04000C81 RID: 3201
		public static readonly ft.a a = new ft.a();

		// Token: 0x04000C82 RID: 3202
		public static Action<ej0> b;
	}
}
