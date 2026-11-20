using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x02000348 RID: 840
[ajo("PriTarTr")]
public sealed class eiu : dj4
{
	// Token: 0x060017B8 RID: 6072 RVA: 0x00078A8C File Offset: 0x00076C8C
	public override bool abf()
	{
		return false;
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00078A90 File Offset: 0x00076C90
	public override bool abg()
	{
		return false;
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00078A94 File Offset: 0x00076C94
	public override bool akm()
	{
		return true;
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00078A98 File Offset: 0x00076C98
	public override void abi(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		bm6 bm = A_0 as bm6;
		if (bm == null || bm.a8().k.b == null)
		{
			base.a();
			return;
		}
		new eiu.a(this, bm).a();
	}

	// Token: 0x02000349 RID: 841
	private new class a : cdf
	{
		// Token: 0x060017BD RID: 6077 RVA: 0x00078AE8 File Offset: 0x00076CE8
		public a(eiu A_0, bm6 A_1)
		{
			this.a = A_0;
			this.b = A_1;
			if (this.b == null || this.b.a8() == null)
			{
				this.i = Vector2.One / 2f;
				return;
			}
			if (this.b.a8().z != null)
			{
				this.i = this.b.a8().z.Value / 2f;
				return;
			}
			this.i = this.b.a8().Size.b() / 2f;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00078BB8 File Offset: 0x00076DB8
		public void a()
		{
			amc amc = new bzv(this.b.y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				this.c = amc.a8().aj().a();
				this.d = amc.a8().Area;
				if (this.d != null)
				{
					this.e = this.d.c();
				}
				anp anp = aw1.b(this.c, this.d, (float)cy1.i, 0L, 0L);
				anp.a(new EventHandler<EventArgs>(this.b));
				anp.k();
				return;
			}
			this.b.y6()[cy1.h] = null;
			this.a.a();
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00078C94 File Offset: 0x00076E94
		private void b(object A_0, EventArgs A_1)
		{
			anp anp = A_0 as anp;
			if (anp.f() != null)
			{
				foreach (Point point in anp.f())
				{
					this.f.Add(point);
				}
			}
			wu serviceOrThrow = bpo.GetServiceOrThrow<wu>();
			czp czp = new czp();
			czp.g = this.b.a8().k.b;
			czp.j = this;
			czp.n.a = false;
			czp.n.c = 3f;
			czp.b = czr.c;
			czp.m = new esj((int)Math.Ceiling((double)this.b.a8().Size.X) * 4 - 1, (int)Math.Ceiling((double)this.b.a8().Size.Y) * 4 - 1);
			Point point2 = new Point((int)(this.b.a8().Location.X * 4f), (int)(this.b.a8().Location.Y * 4f));
			czp.c = new ee4(this.b.a8().Area.c(), point2);
			Vector2 vector = new Vector2(this.b.a8().Location.X * 4f, this.b.a8().Location.Y * 4f);
			if (vector != point2.b())
			{
				czp.d = new Vector2?(vector);
			}
			czp.e = new ee4(this.d.c(), new Point(this.c.X * 4, this.c.Y * 4));
			if (czp.e.b == czp.c.b && czp.e.a.X - czp.c.a.X < czp.m.c && czp.e.a.X - czp.c.a.X >= 0 && czp.e.a.Y - czp.c.a.Y < czp.m.d && czp.e.a.Y - czp.c.a.Y >= 0)
			{
				this.h.a(0, 0f, czp.c.a);
			}
			czp.r = this.b.a8().Zone.CustomProperties.GetPrimitivePropertyValue<bool>(a46.c, new bool?(false)).Value;
			this.g = serviceOrThrow.aki(czp, this.b.a8().Playfield.PathProcessor, eso.d);
			this.g.auw(new EventHandler<EventArgs>(this.a));
			this.g.auz(new EventHandler<EventArgs>(this.a));
			this.g.au2();
			Trace.WriteLine("PrimaryTargetTracingScanner pathfinding...");
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00079034 File Offset: 0x00077234
		private void a(object A_0, EventArgs A_1)
		{
			this.b.y6()[cy1.h] = this.h;
			this.a.a();
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0007905C File Offset: 0x0007725C
		public bool fs(ee4 A_0, int A_1, cr6 A_2)
		{
			if (A_0.b == this.e && ar1.a(A_0.a, this.f, new Vector2?(this.i)))
			{
				int num = (int)bnx.a(new Point(A_0.a.X / 4, A_0.a.Y / 4), this.c);
				float a_ = (float)A_1 / 40f;
				this.h.a(num, a_, A_0.a);
				if (num <= 1)
				{
					this.h.a(0, a_, A_0.a);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000E0E RID: 3598
		private eiu a;

		// Token: 0x04000E0F RID: 3599
		private bm6 b;

		// Token: 0x04000E10 RID: 3600
		private Point c;

		// Token: 0x04000E11 RID: 3601
		private aud d;

		// Token: 0x04000E12 RID: 3602
		private int e;

		// Token: 0x04000E13 RID: 3603
		private HashSet<Point> f = new HashSet<Point>();

		// Token: 0x04000E14 RID: 3604
		private c5w g;

		// Token: 0x04000E15 RID: 3605
		private cmb h = new cmb();

		// Token: 0x04000E16 RID: 3606
		private Vector2 i;
	}
}
