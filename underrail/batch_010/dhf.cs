using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000181 RID: 385
public class dhf : euz
{
	// Token: 0x06000A85 RID: 2693 RVA: 0x0002B120 File Offset: 0x00029320
	public bool g()
	{
		return this.c;
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0002B128 File Offset: 0x00029328
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0002B134 File Offset: 0x00029334
	public int h()
	{
		return this.g;
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x0002B13C File Offset: 0x0002933C
	public void c(int A_0)
	{
		if (this.g != A_0)
		{
			this.g = A_0;
			this.j();
		}
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x0002B158 File Offset: 0x00029358
	public int i()
	{
		return this.h;
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0002B160 File Offset: 0x00029360
	public void d(int A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.j();
		}
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0002B17C File Offset: 0x0002937C
	public int k()
	{
		return this.f;
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0002B184 File Offset: 0x00029384
	public void e(int A_0)
	{
		if (this.f != A_0)
		{
			this.f = A_0;
			this.j();
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0002B1A0 File Offset: 0x000293A0
	public cs9 l()
	{
		return this.k;
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x0002B1A8 File Offset: 0x000293A8
	public void a(cs9 A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0002B1B4 File Offset: 0x000293B4
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x0002B1BC File Offset: 0x000293BC
	public void a(bool A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.j();
		}
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0002B1D8 File Offset: 0x000293D8
	public override bool hh()
	{
		return true;
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0002B1E0 File Offset: 0x000293E0
	public dhf(List<euz> A_0, int A_1 = 0, int A_2 = 0, int A_3 = 0, int A_4 = 50, int A_5 = 300, int A_6 = 0, Type A_7 = null, int A_8 = 26)
	{
		czh.a(A_0, "controls");
		this.j = A_7;
		this.l = A_8;
		this.m = A_6;
		this.f = A_1;
		this.e = A_2;
		this.d = A_3;
		this.g = A_4;
		this.h = A_5;
		this.a = this.a(A_0);
		this.d();
		this.b();
		this.j();
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0002B278 File Offset: 0x00029478
	private void d()
	{
		int a_ = this.f * (this.g + this.d) - this.d + 2 * this.e;
		int a_2 = this.h + 2 * this.e;
		base.Size = new esj(a_2, a_);
		if (this.j != null)
		{
			try
			{
				this.k = (Activator.CreateInstance(this.j) as cs9);
			}
			catch
			{
			}
		}
		if (this.k == null)
		{
			this.k = new bdl();
		}
		this.k.Gravity = axy.c;
		this.k.c(1);
		this.k.d(5);
		this.k.e(0);
		this.k.IsPrivateComponent = true;
		this.k.Location = new Point(base.Size.c - this.l + this.m, -2);
		this.k.Size = new esj(this.l, base.Size.d + 4);
		this.k.f(new EventHandler<c1>(this.a));
		this.aox(this.k);
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0002B3D0 File Offset: 0x000295D0
	public void j()
	{
		foreach (caf caf in this.c())
		{
			euz euz = caf.Control;
			if (euz != null)
			{
				euz.Size = new esj(this.h - this.e - this.k.Size.c, euz.Size.d);
				euz.aoy();
			}
		}
		this.a();
		if (this.i > this.f)
		{
			this.k.Enabled = true;
			this.k.a(this.i - this.f);
			this.k.b(0);
			if (this.k.l() > this.k.k())
			{
				this.k.e(this.k.k());
			}
		}
		else
		{
			this.k.e(0);
			this.k.Enabled = false;
		}
		foreach (euz a_ in Enumerable.ToList<euz>(Enumerable.Where<euz>(base.Controls, new Func<euz, bool>(dhf.a.a.a))))
		{
			this.g(a_);
		}
		foreach (caf caf2 in this.c())
		{
			this.a(caf2);
			euz euz2 = caf2.Control;
			if (euz2 != null)
			{
				euz2.Size = new esj(this.h - this.e - (this.k.Visible ? this.k.Size.c : 0), euz2.Size.d);
				euz2.Location = new Point(this.e, this.e + (caf2.Position - this.k.l()) * (this.g + this.d));
				euz2.v(new EventHandler<b25>(this.a));
				euz2.t(new EventHandler<b25>(this.a));
				this.aox(euz2);
			}
		}
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0002B684 File Offset: 0x00029884
	private List<caf> c()
	{
		List<caf> list = new List<caf>();
		bool flag = false;
		foreach (caf caf in this.a)
		{
			if (this.k.l() + this.f > caf.Position && caf.Position + caf.HeightInUnits >= this.k.l())
			{
				list.Add(caf);
				flag = true;
			}
			else if (flag)
			{
				break;
			}
		}
		return list;
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x0002B734 File Offset: 0x00029934
	private void b()
	{
		int num = 0;
		foreach (caf caf in this.a)
		{
			num += caf.HeightInUnits;
		}
		this.i = num;
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x0002B798 File Offset: 0x00029998
	private List<caf> a(List<euz> A_0)
	{
		List<caf> list = new List<caf>();
		int num = 0;
		if (A_0 != null)
		{
			foreach (euz euz in A_0)
			{
				int num2 = this.a(euz.Size.d);
				caf caf = new caf(euz, num2, num);
				num += num2;
				list.Add(caf);
				this.a(caf);
			}
		}
		return list;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0002B828 File Offset: 0x00029A28
	private void a(caf A_0)
	{
		dyo dyo = A_0.Control as dyo;
		if (dyo != null)
		{
			dyo.ata(A_0.HeightInUnits * (this.g + this.d) - this.e);
		}
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0002B868 File Offset: 0x00029A68
	private void b(int A_0)
	{
		for (int i = A_0; i < this.a.Count; i++)
		{
			this.a[i].Position = ((i > 0) ? (this.a[i - 1].Position + this.a[i - 1].HeightInUnits) : 0);
		}
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x0002B8D4 File Offset: 0x00029AD4
	private void a()
	{
		int num = 0;
		foreach (caf caf in this.a)
		{
			caf.Position = num;
			caf.HeightInUnits = this.a(caf.Control.Size.d);
			num += caf.HeightInUnits;
			this.a(caf);
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0002B95C File Offset: 0x00029B5C
	private int a(int A_0)
	{
		int result;
		if (A_0 > this.g)
		{
			result = 1 + (int)Math.Ceiling((double)(A_0 - this.g) / (double)(this.g + this.d));
		}
		else
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0002B9A0 File Offset: 0x00029BA0
	public virtual void xm(int A_0)
	{
		if (A_0 < 0 || A_0 > this.a.Count - 1)
		{
			return;
		}
		this.a.RemoveAt(A_0);
		this.b(A_0);
		this.b();
		this.j();
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0002B9E8 File Offset: 0x00029BE8
	public virtual void xl(euz A_0)
	{
		dhf.c c = new dhf.c();
		c.a = A_0;
		czh.a(c.a, "control");
		caf caf = Enumerable.FirstOrDefault<caf>(Enumerable.Where<caf>(this.a, new Func<caf, bool>(c.a)));
		if (caf != null)
		{
			int a_ = this.a.IndexOf(caf);
			this.a.Remove(caf);
			this.b(a_);
			this.b();
			this.j();
		}
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x0002BA64 File Offset: 0x00029C64
	public virtual void xn()
	{
		this.a.Clear();
		this.b();
		this.j();
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0002BA80 File Offset: 0x00029C80
	public virtual void a(euz A_0, euz A_1 = null)
	{
		dhf.b b = new dhf.b();
		b.a = A_0;
		czh.a(b.a, "control");
		caf caf = Enumerable.FirstOrDefault<caf>(Enumerable.Where<caf>(this.a, new Func<caf, bool>(b.a)));
		if (caf != null)
		{
			int a_ = this.a.IndexOf(caf);
			if (A_1 != null)
			{
				caf.Control = A_1;
			}
			caf.HeightInUnits = this.a(caf.Control.Size.d);
			this.b(a_);
			if (this.b || caf.HeightInUnits == 1)
			{
				this.b();
				this.b(a_);
			}
			else
			{
				caf.Position = a_;
				this.i = this.a.Count + caf.HeightInUnits - 1;
			}
			if (this.c)
			{
				this.k.a(Math.Max(0, this.i - this.f));
				if (this.k.k() > 0)
				{
					if (this.f + this.k.l() < caf.Position + caf.HeightInUnits)
					{
						int num = caf.Position + caf.HeightInUnits - this.f;
						bool flag;
						if (caf.Position < Math.Min(num, this.k.k()))
						{
							flag = (this.k.l() != caf.Position);
							this.k.e(caf.Position);
						}
						else
						{
							flag = (this.k.l() != num);
							this.k.e(num);
						}
						if (flag)
						{
							return;
						}
					}
					else if (caf.Position < this.k.l())
					{
						this.k.e(caf.Position);
					}
				}
			}
			this.j();
		}
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0002BC68 File Offset: 0x00029E68
	public virtual void xj(euz A_0)
	{
		czh.a(A_0, "control");
		caf caf = new caf(A_0, 0, -1);
		caf.Position = 0;
		caf.HeightInUnits = this.a(A_0.Size.d);
		foreach (caf caf2 in this.a)
		{
			caf2.Position++;
		}
		this.a.Insert(0, caf);
		this.b();
		this.j();
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0002BD14 File Offset: 0x00029F14
	public virtual void xk(euz A_0, int A_1)
	{
		czh.a(A_0, "control");
		if (A_1 < 0 || A_1 > this.a.Count)
		{
			return;
		}
		caf caf = new caf(A_0, 0, -1);
		caf.Position = ((A_1 > 0) ? this.a[A_1].Position : 0);
		caf.HeightInUnits = this.a(A_0.Size.d);
		this.a.Insert(A_1, caf);
		this.b(A_1 + 1);
		this.b();
		this.j();
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x0002BDAC File Offset: 0x00029FAC
	public virtual void b(List<euz> A_0)
	{
		foreach (euz a_ in A_0)
		{
			this.xj(a_);
		}
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x0002BE00 File Offset: 0x0002A000
	protected override Rectangle rv()
	{
		Rectangle result = base.rv();
		result.X += this.e;
		result.Y += this.e;
		result.Width -= this.e * 2;
		result.Height -= this.e * 2;
		return result;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0002BE60 File Offset: 0x0002A060
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		if (this.k != null)
		{
			this.k.Size = new esj(this.l, base.Size.d + 4);
		}
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0002BE98 File Offset: 0x0002A098
	private void a(object A_0, c1 A_1)
	{
		this.j();
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		cs9 cs = this.k;
		cs.e(cs.l() - this.k.m() * Math.Sign(A_1.c()));
		this.j();
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
	private void a(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		cs9 cs = this.k;
		cs.e(cs.l() - this.k.m() * Math.Sign(A_1.c()));
		this.j();
	}

	// Token: 0x04000683 RID: 1667
	private new List<caf> a;

	// Token: 0x04000684 RID: 1668
	private new bool b;

	// Token: 0x04000685 RID: 1669
	private new bool c;

	// Token: 0x04000686 RID: 1670
	private new int d;

	// Token: 0x04000687 RID: 1671
	private new int e;

	// Token: 0x04000688 RID: 1672
	private new int f = 1;

	// Token: 0x04000689 RID: 1673
	private new int g = 50;

	// Token: 0x0400068A RID: 1674
	private int h = 300;

	// Token: 0x0400068B RID: 1675
	private int i;

	// Token: 0x0400068C RID: 1676
	private new Type j;

	// Token: 0x0400068D RID: 1677
	private new cs9 k;

	// Token: 0x0400068E RID: 1678
	private new int l;

	// Token: 0x0400068F RID: 1679
	private new int m;

	// Token: 0x02000183 RID: 387
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06000B8A RID: 2954 RVA: 0x0002FA50 File Offset: 0x0002DC50
		internal bool a(euz A_0)
		{
			return !A_0.IsPrivateComponent;
		}

		// Token: 0x040006DC RID: 1756
		public static readonly dhf.a a = new dhf.a();

		// Token: 0x040006DD RID: 1757
		public static Func<euz, bool> b;
	}

	// Token: 0x02000184 RID: 388
	[CompilerGenerated]
	private new sealed class c
	{
		// Token: 0x06000B8C RID: 2956 RVA: 0x0002FA64 File Offset: 0x0002DC64
		internal bool a(caf A_0)
		{
			return A_0.Control == this.a;
		}

		// Token: 0x040006DE RID: 1758
		public euz a;
	}

	// Token: 0x02000185 RID: 389
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		internal bool a(caf A_0)
		{
			return A_0.Control == this.a;
		}

		// Token: 0x040006DF RID: 1759
		public euz a;
	}
}
