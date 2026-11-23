using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;

// Token: 0x02002077 RID: 8311
public sealed class d57 : daj
{
	// Token: 0x0600C680 RID: 50816 RVA: 0x00457288 File Offset: 0x00455488
	public d57(cyt A_0)
	{
		this.Focusable = true;
		this.d = A_0;
		this.e = ehx.a(A_0);
		this.c();
		this.h = d57.b.a;
	}

	// Token: 0x0600C681 RID: 50817 RVA: 0x004572B8 File Offset: 0x004554B8
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.f < this.e.Count)
		{
			if (this.j > 0.0)
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>("Concept\\es\\" + this.e[this.f].a, null);
				if (resource != null)
				{
					A_1.b().w5(resource, this.m, new Rectangle?(this.l), Color.White * (float)this.j);
				}
			}
			if (this.k > 0.0 && this.o != null)
			{
				int num = base.Size.d - (int)this.n.Y;
				Texture2D resource2 = A_1.a.GetResource<Texture2D>(bo1.al, null);
				if (this.o.Count > 0 && this.o[0].b.c > 30 && resource2 != null)
				{
					int num2 = Enumerable.Sum<dn3>(this.o, new Func<dn3, int>(d57.a.a.a));
					Rectangle a_ = new Rectangle((int)this.n.X / 2, num - num2 - (int)this.n.Y / 2, base.Size.c - (int)this.n.X, num2 + (int)this.n.Y);
					c4o.a(A_1, resource2, new esj(25, 25), Point.Zero, a_, Color.White * 0.8f * (float)this.k, true, null);
				}
				for (int i = this.o.Count - 1; i >= 0; i--)
				{
					num -= this.o[i].b.d;
					this.o[i].a(new Point((int)this.n.X, num), A_1, null, (float)this.k);
				}
			}
		}
	}

	// Token: 0x0600C682 RID: 50818 RVA: 0x00457508 File Offset: 0x00455708
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (!this.r)
		{
			if (this.f >= this.e.Count || this.q)
			{
				this.r = true;
				bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ReturnToMainMenuFromEndStory, new object[0]));
				return;
			}
			if (this.h == d57.b.e)
			{
				if ((this.i -= A_0.a().ElapsedGameTime.TotalMilliseconds) <= 0.0)
				{
					this.h = d57.b.d;
					this.i = 0.0;
					return;
				}
			}
			else if (this.h == d57.b.a)
			{
				this.j = Math.Min(1.0, this.j + A_0.a().ElapsedGameTime.TotalMilliseconds * 0.0005);
				if (this.j == 1.0)
				{
					this.h = d57.b.c;
					this.b();
					this.k = 0.0;
					this.g = 0;
					return;
				}
			}
			else if (this.h == d57.b.b)
			{
				this.j = Math.Max(0.0, this.j - A_0.a().ElapsedGameTime.TotalMilliseconds * 0.0005);
				if (this.j == 0.0)
				{
					if (this.p)
					{
						this.q = true;
					}
					this.h = d57.b.a;
					this.f++;
					return;
				}
			}
			else if (this.h == d57.b.c)
			{
				this.k = Math.Min(1.0, this.k + A_0.a().ElapsedGameTime.TotalMilliseconds * 0.003);
				if (this.k == 1.0)
				{
					this.h = d57.b.e;
					int? num = this.e[this.f].b[this.g].b;
					if (num != null)
					{
						this.i = (double)num.Value;
						return;
					}
					this.i = d57.a(this.e[this.f].b[this.g].a);
					return;
				}
			}
			else if (this.h == d57.b.d)
			{
				this.k = Math.Max(0.0, this.k - A_0.a().ElapsedGameTime.TotalMilliseconds * 0.003);
				if (this.k == 0.0)
				{
					this.o = null;
					int num2 = this.g + 1;
					this.g = num2;
					if (num2 >= this.e[this.f].b.Count || this.p)
					{
						this.h = d57.b.b;
						this.g = 0;
						return;
					}
					this.b();
					this.h = d57.b.c;
				}
			}
		}
	}

	// Token: 0x0600C683 RID: 50819 RVA: 0x00457840 File Offset: 0x00455A40
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1.a == Keys.Space)
		{
			this.i = -1.0;
			return;
		}
		if (A_1.a == Keys.Escape)
		{
			this.p = true;
			this.i = 0.0;
		}
	}

	// Token: 0x0600C684 RID: 50820 RVA: 0x00457898 File Offset: 0x00455A98
	private void c()
	{
		base.Size = a2x.a();
		this.l = new Rectangle(Math.Max(0, (d57.c.c - base.Size.c) / 2), Math.Max(0, (d57.c.d - base.Size.d) / 2), Math.Min(d57.c.c, base.Size.c), Math.Min(base.Size.d, d57.c.d));
		this.m = new Vector2((float)((base.Size.c - this.l.Width) / 2), (float)((base.Size.d - this.l.Height) / 2));
		this.n = new Vector2(Math.Max(50f, this.m.X), 50f);
	}

	// Token: 0x0600C685 RID: 50821 RVA: 0x00457990 File Offset: 0x00455B90
	public static double a(string A_0)
	{
		return (double)(A_0.Split(new char[]
		{
			' '
		}, StringSplitOptions.RemoveEmptyEntries).Length * 550);
	}

	// Token: 0x0600C686 RID: 50822 RVA: 0x004579B0 File Offset: 0x00455BB0
	private void b()
	{
		this.o = new List<dn3>();
		foreach (dl6 dl in Enumerable.FirstOrDefault<ecs>(new ecs
		{
			a = 
			{
				new dl6(new bph[]
				{
					new bph(new d22(this.a(), adi.a), this.e[this.f].b[this.g].a, null)
				})
			}
		}.a((int)((float)base.Size.c - this.n.X * 2f), int.MaxValue)).a)
		{
			ecs ecs = new ecs(new dl6[]
			{
				dl
			});
			this.o.Add(ecs.b());
		}
	}

	// Token: 0x0600C687 RID: 50823 RVA: 0x00457AB8 File Offset: 0x00455CB8
	private string a()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			return egg.b;
		}
		return wj.i2;
	}

	// Token: 0x040048F9 RID: 18681
	private new const double a = 0.0005;

	// Token: 0x040048FA RID: 18682
	private new const double b = 0.003;

	// Token: 0x040048FB RID: 18683
	private new static readonly esj c = new esj(1920, 1080);

	// Token: 0x040048FC RID: 18684
	private new cyt d;

	// Token: 0x040048FD RID: 18685
	private new List<bny> e;

	// Token: 0x040048FE RID: 18686
	private new int f;

	// Token: 0x040048FF RID: 18687
	private new int g;

	// Token: 0x04004900 RID: 18688
	private d57.b h;

	// Token: 0x04004901 RID: 18689
	private double i;

	// Token: 0x04004902 RID: 18690
	private new double j;

	// Token: 0x04004903 RID: 18691
	private new double k;

	// Token: 0x04004904 RID: 18692
	private new Rectangle l;

	// Token: 0x04004905 RID: 18693
	private new Vector2 m;

	// Token: 0x04004906 RID: 18694
	private Vector2 n;

	// Token: 0x04004907 RID: 18695
	private List<dn3> o;

	// Token: 0x04004908 RID: 18696
	private bool p;

	// Token: 0x04004909 RID: 18697
	private bool q;

	// Token: 0x0400490A RID: 18698
	private bool r;

	// Token: 0x02002078 RID: 8312
	public new enum b
	{
		// Token: 0x0400490C RID: 18700
		a,
		// Token: 0x0400490D RID: 18701
		b,
		// Token: 0x0400490E RID: 18702
		c,
		// Token: 0x0400490F RID: 18703
		d,
		// Token: 0x04004910 RID: 18704
		e
	}

	// Token: 0x02002079 RID: 8313
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C68B RID: 50827 RVA: 0x00457B10 File Offset: 0x00455D10
		internal int a(dn3 A_0)
		{
			return A_0.b.d;
		}

		// Token: 0x04004911 RID: 18705
		public static readonly d57.a a = new d57.a();

		// Token: 0x04004912 RID: 18706
		public static Func<dn3, int> b;
	}
}
