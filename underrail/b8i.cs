using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002047 RID: 8263
public sealed class b8i : euz, amj
{
	// Token: 0x0600C3EE RID: 50158 RVA: 0x0043F960 File Offset: 0x0043DB60
	public bp2 a()
	{
		return this.h;
	}

	// Token: 0x0600C3EF RID: 50159 RVA: 0x0043F968 File Offset: 0x0043DB68
	public void b(bp2 A_0)
	{
		this.a(A_0);
	}

	// Token: 0x0600C3F0 RID: 50160 RVA: 0x0043F974 File Offset: 0x0043DB74
	public int b()
	{
		return this.i;
	}

	// Token: 0x0600C3F1 RID: 50161 RVA: 0x0043F97C File Offset: 0x0043DB7C
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(b8i.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C3F3 RID: 50163 RVA: 0x0043FA3C File Offset: 0x0043DC3C
	public b8i(euz A_0, bool A_1)
	{
		wj wj = wj.a();
		this.l = A_0;
		this.k = new dsy(this, this, esj.a(), 300, null, null, 3000, false, false);
		Point cz;
		esj c;
		int c2;
		if (wj.d == UiSize.Classic)
		{
			if (A_1)
			{
				cz = b8i.d;
				c = b8i.e;
				c2 = b8i.f;
			}
			else
			{
				cz = b8i.a;
				c = b8i.b;
				c2 = b8i.c;
			}
		}
		else
		{
			this.g = wj.f;
			cz = wj.cz;
			c = wj.c0;
			c2 = wj.c1;
		}
		int num = 0;
		for (int i = 0; i < c65.a().Count; i++)
		{
			bp2 a_ = c65.a()[i];
			if (i != 0)
			{
				num += c2;
			}
			else
			{
				this.h = a_;
			}
			aqw aqw = new aqw();
			aqw.a = this.g;
			aqw.b = new Point(cz.X, cz.Y + i * c.d);
			aqw.c = c;
			aqw.Size = c;
			aqw.Location = new Point(num, 0);
			aqw.p(new EventHandler<b25>(this.c));
			aqw.j(new EventHandler<b25>(this.a));
			aqw.l(new EventHandler<b25>(this.b));
			aqw.Tag = a_;
			aqw.Checked = (i == 0);
			e4z.f(aqw);
			e4z.i(aqw);
			this.aox(aqw);
			num += c.c;
		}
		base.Size = new esj(num, c.d);
	}

	// Token: 0x0600C3F4 RID: 50164 RVA: 0x0043FC28 File Offset: 0x0043DE28
	public override void ag5(e6d A_0)
	{
		if (this.l != null)
		{
			euz euz = this.l;
			if (this.l.Parent is evh)
			{
				euz = this.l.Parent;
			}
			Point point = euz.at();
			if (point != Point.Zero)
			{
				this.k.a(new Rectangle?(new Rectangle(point.X, point.Y, euz.Size.c, euz.Size.d)));
			}
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C3F5 RID: 50165 RVA: 0x0043FCC0 File Offset: 0x0043DEC0
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.k.a(A_0);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C3F6 RID: 50166 RVA: 0x0043FCD8 File Offset: 0x0043DED8
	public ecs yf(euz A_0)
	{
		foreach (aqw aqw in Enumerable.OfType<aqw>(base.Controls))
		{
			if (aqw.IsMousedOver && aqw.Tag != null)
			{
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.d(), adi.c), dh9.c("CharInventory_Filter_" + aqw.Tag.ToString()), null)
					})
				});
			}
		}
		return null;
	}

	// Token: 0x0600C3F7 RID: 50167 RVA: 0x0043FD9C File Offset: 0x0043DF9C
	private void a(bp2 A_0)
	{
		foreach (aqw aqw in Enumerable.OfType<aqw>(base.Controls))
		{
			aqw.Checked = (aqw.Tag == A_0);
		}
		bp2 bp = this.h;
		this.h = A_0;
		this.i = c65.a().IndexOf(this.h);
		if (A_0 != bp && this.m != null)
		{
			this.m(this, new c1(bp, A_0));
		}
	}

	// Token: 0x0600C3F8 RID: 50168 RVA: 0x0043FE48 File Offset: 0x0043E048
	private void c(object A_0, b25 A_1)
	{
		aqw aqw = A_0 as aqw;
		if (aqw != null)
		{
			this.a(aqw.Tag as bp2);
		}
	}

	// Token: 0x0600C3F9 RID: 50169 RVA: 0x0043FE74 File Offset: 0x0043E074
	private void b(object A_0, b25 A_1)
	{
		this.k.b();
	}

	// Token: 0x0600C3FA RID: 50170 RVA: 0x0043FE84 File Offset: 0x0043E084
	private void a(object A_0, b25 A_1)
	{
		this.k.b();
	}

	// Token: 0x0400474E RID: 18254
	private new static readonly Point a = new Point(0, 116);

	// Token: 0x0400474F RID: 18255
	private new static readonly esj b = new esj(35, 33);

	// Token: 0x04004750 RID: 18256
	private new static readonly int c = 3;

	// Token: 0x04004751 RID: 18257
	private new static readonly Point d = new Point(106, 116);

	// Token: 0x04004752 RID: 18258
	private new static readonly esj e = new esj(23, 23);

	// Token: 0x04004753 RID: 18259
	private new static readonly int f = 1;

	// Token: 0x04004754 RID: 18260
	private new string g = bo1.a8;

	// Token: 0x04004755 RID: 18261
	private bp2 h;

	// Token: 0x04004756 RID: 18262
	private int i;

	// Token: 0x04004757 RID: 18263
	public new static readonly int j = b8i.b.c * c65.a().Count + b8i.c * (c65.a().Count - 1);

	// Token: 0x04004758 RID: 18264
	private new dsy k;

	// Token: 0x04004759 RID: 18265
	private new euz l;

	// Token: 0x0400475A RID: 18266
	public new EventHandler<c1> m;

	// Token: 0x02002048 RID: 8264
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C3FD RID: 50173 RVA: 0x0043FEA8 File Offset: 0x0043E0A8
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x0400475B RID: 18267
		public static readonly b8i.a a = new b8i.a();

		// Token: 0x0400475C RID: 18268
		public static Func<euz, bool> b;
	}
}
