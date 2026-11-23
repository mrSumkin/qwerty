using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001FED RID: 8173
public class bbk : zt
{
	// Token: 0x0600C00E RID: 49166 RVA: 0x004295F8 File Offset: 0x004277F8
	public bool x()
	{
		return this.g;
	}

	// Token: 0x0600C00F RID: 49167 RVA: 0x00429600 File Offset: 0x00427800
	public new void e(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600C010 RID: 49168 RVA: 0x0042960C File Offset: 0x0042780C
	public bool w()
	{
		return this.h;
	}

	// Token: 0x0600C011 RID: 49169 RVA: 0x00429614 File Offset: 0x00427814
	public new void d(bool A_0)
	{
		this.h = A_0;
		this.wt();
	}

	// Token: 0x0600C012 RID: 49170 RVA: 0x00429624 File Offset: 0x00427824
	public new Point d()
	{
		return this.i;
	}

	// Token: 0x0600C013 RID: 49171 RVA: 0x0042962C File Offset: 0x0042782C
	public new void c(Point A_0)
	{
		this.i = A_0;
		this.wt();
	}

	// Token: 0x0600C014 RID: 49172 RVA: 0x0042963C File Offset: 0x0042783C
	public new int f()
	{
		return this.j;
	}

	// Token: 0x0600C015 RID: 49173 RVA: 0x00429644 File Offset: 0x00427844
	public new void b(int A_0)
	{
		this.j = A_0;
		this.wt();
	}

	// Token: 0x0600C016 RID: 49174 RVA: 0x00429654 File Offset: 0x00427854
	public bool q()
	{
		return this.k;
	}

	// Token: 0x0600C017 RID: 49175 RVA: 0x0042965C File Offset: 0x0042785C
	public new void a(bool A_0)
	{
		this.k = A_0;
		this.wt();
	}

	// Token: 0x0600C018 RID: 49176 RVA: 0x0042966C File Offset: 0x0042786C
	public Point i()
	{
		return this.l;
	}

	// Token: 0x0600C019 RID: 49177 RVA: 0x00429674 File Offset: 0x00427874
	public new void a(Point A_0)
	{
		this.l = A_0;
		this.wt();
	}

	// Token: 0x0600C01A RID: 49178 RVA: 0x00429684 File Offset: 0x00427884
	public int g()
	{
		return this.m;
	}

	// Token: 0x0600C01B RID: 49179 RVA: 0x0042968C File Offset: 0x0042788C
	public new void a(int A_0)
	{
		this.m = A_0;
		this.wt();
	}

	// Token: 0x0600C01C RID: 49180 RVA: 0x0042969C File Offset: 0x0042789C
	public Color r()
	{
		return this.n;
	}

	// Token: 0x0600C01D RID: 49181 RVA: 0x004296A4 File Offset: 0x004278A4
	public new void b(Color A_0)
	{
		this.n = A_0;
	}

	// Token: 0x0600C01E RID: 49182 RVA: 0x004296B0 File Offset: 0x004278B0
	public Color t()
	{
		return this.o;
	}

	// Token: 0x0600C01F RID: 49183 RVA: 0x004296B8 File Offset: 0x004278B8
	public new void a(Color A_0)
	{
		this.o = A_0;
	}

	// Token: 0x0600C020 RID: 49184 RVA: 0x004296C4 File Offset: 0x004278C4
	public int l()
	{
		return this.u;
	}

	// Token: 0x0600C021 RID: 49185 RVA: 0x004296CC File Offset: 0x004278CC
	public new void c(int A_0)
	{
		this.u = A_0;
		this.wt();
	}

	// Token: 0x0600C022 RID: 49186 RVA: 0x004296DC File Offset: 0x004278DC
	public new int h()
	{
		return this.v;
	}

	// Token: 0x0600C023 RID: 49187 RVA: 0x004296E4 File Offset: 0x004278E4
	public new void f(int A_0)
	{
		this.v = A_0;
	}

	// Token: 0x0600C024 RID: 49188 RVA: 0x004296F0 File Offset: 0x004278F0
	public Stat<int> j()
	{
		return this.w;
	}

	// Token: 0x0600C025 RID: 49189 RVA: 0x004296F8 File Offset: 0x004278F8
	public new void a(Stat<int> A_0)
	{
		if (this.w != A_0)
		{
			this.vf();
			this.w = A_0;
			if (base.Activated)
			{
				this.ve();
				this.wt();
			}
		}
	}

	// Token: 0x0600C026 RID: 49190 RVA: 0x0042972C File Offset: 0x0042792C
	protected virtual bool vd()
	{
		return this.w != null;
	}

	// Token: 0x0600C027 RID: 49191 RVA: 0x00429738 File Offset: 0x00427938
	protected virtual bool s()
	{
		return this.w != null && this.w.f() > this.v();
	}

	// Token: 0x0600C028 RID: 49192 RVA: 0x0042975C File Offset: 0x0042795C
	public virtual int v()
	{
		return this.x;
	}

	// Token: 0x0600C029 RID: 49193 RVA: 0x00429764 File Offset: 0x00427964
	public new virtual void e(int A_0)
	{
		this.x = A_0;
	}

	// Token: 0x0600C02A RID: 49194 RVA: 0x00429770 File Offset: 0x00427970
	public bool u()
	{
		return this.y;
	}

	// Token: 0x0600C02B RID: 49195 RVA: 0x00429778 File Offset: 0x00427978
	public new void b(bool A_0)
	{
		if (this.y != A_0)
		{
			this.y = A_0;
			this.wt();
		}
	}

	// Token: 0x0600C02C RID: 49196 RVA: 0x00429794 File Offset: 0x00427994
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(bbk.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C02D RID: 49197 RVA: 0x004297D0 File Offset: 0x004279D0
	public override bool ws()
	{
		return base.VisuallyEnabled && this.y;
	}

	// Token: 0x0600C02E RID: 49198 RVA: 0x004297E8 File Offset: 0x004279E8
	public new bool b()
	{
		return this.p;
	}

	// Token: 0x0600C02F RID: 49199 RVA: 0x004297F0 File Offset: 0x004279F0
	public new void c(bool A_0)
	{
		this.p = A_0;
		this.wt();
	}

	// Token: 0x0600C030 RID: 49200 RVA: 0x00429800 File Offset: 0x00427A00
	public new Point e()
	{
		return this.r;
	}

	// Token: 0x0600C031 RID: 49201 RVA: 0x00429808 File Offset: 0x00427A08
	public new void b(Point A_0)
	{
		this.r = A_0;
		this.wt();
	}

	// Token: 0x0600C032 RID: 49202 RVA: 0x00429818 File Offset: 0x00427A18
	public int m()
	{
		return this.q;
	}

	// Token: 0x0600C033 RID: 49203 RVA: 0x00429820 File Offset: 0x00427A20
	public new void d(int A_0)
	{
		this.q = A_0;
		this.wt();
	}

	// Token: 0x0600C034 RID: 49204 RVA: 0x00429830 File Offset: 0x00427A30
	public Color p()
	{
		return this.s;
	}

	// Token: 0x0600C035 RID: 49205 RVA: 0x00429838 File Offset: 0x00427A38
	public new void d(Color A_0)
	{
		this.s = A_0;
	}

	// Token: 0x0600C036 RID: 49206 RVA: 0x00429844 File Offset: 0x00427A44
	public Color n()
	{
		return this.t;
	}

	// Token: 0x0600C037 RID: 49207 RVA: 0x0042984C File Offset: 0x00427A4C
	public new void c(Color A_0)
	{
		this.t = A_0;
	}

	// Token: 0x0600C038 RID: 49208 RVA: 0x00429858 File Offset: 0x00427A58
	public bbk()
	{
		this.a();
		e4z.e(this);
	}

	// Token: 0x0600C039 RID: 49209 RVA: 0x00429910 File Offset: 0x00427B10
	public bbk(Stat<int> A_0) : this()
	{
		this.w = A_0;
	}

	// Token: 0x0600C03A RID: 49210 RVA: 0x00429924 File Offset: 0x00427B24
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.o();
		if (this.Enabled && this.y)
		{
			if (this.IsMousedOver || euz.DesignMode)
			{
				this.b.Color = this.b;
				this.c.Color = this.t();
				this.d.Color = this.n();
			}
			else
			{
				this.b.Color = this.a;
				this.c.Color = this.r();
				this.d.Color = this.p();
			}
		}
		else
		{
			this.b.Color = this.c;
			this.c.Color = this.c;
			this.d.Color = this.c;
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C03B RID: 49211 RVA: 0x00429A10 File Offset: 0x00427C10
	[CompilerGenerated]
	public new void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.z;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C03C RID: 49212 RVA: 0x00429A48 File Offset: 0x00427C48
	[CompilerGenerated]
	public new void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.z;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C03D RID: 49213 RVA: 0x00429A80 File Offset: 0x00427C80
	private new void a(object A_0, c1 A_1)
	{
		this.wt();
	}

	// Token: 0x0600C03E RID: 49214 RVA: 0x00429A88 File Offset: 0x00427C88
	public new void c()
	{
		this.wt();
	}

	// Token: 0x0600C03F RID: 49215 RVA: 0x00429A94 File Offset: 0x00427C94
	protected override void wt()
	{
		base.wt();
		if (this.b != null)
		{
			this.b.Visible = this.h;
			this.b.Location = this.i;
			this.b.Size = new esj(this.j, base.Size.d);
			this.b.a(base.Font);
		}
		if (this.c != null)
		{
			this.c.Visible = this.k;
			this.c.Location = this.l;
			this.c.Size = new esj(this.m, base.Size.d);
			this.c.a(base.Font);
		}
		if (this.d != null)
		{
			this.d.Visible = this.p;
			this.d.Location = this.r;
			this.d.Size = new esj(this.q, base.Size.d);
			this.d.a(base.Font);
		}
		if (this.b != null && this.c != null && this.d != null)
		{
			this.o();
		}
		if (this.e != null)
		{
			this.e.Visible = (this.Enabled && !this.g && this.vd() && this.y);
			this.e.Location = new Point(this.u, (base.Size.d - this.e.Size.d) / 2);
		}
		if (this.f != null)
		{
			this.f.Visible = (this.Enabled && !this.g && this.s() && this.y);
			this.f.Location = new Point(this.u + this.e.Size.c + this.v, (base.Size.d - this.f.Size.d) / 2);
		}
	}

	// Token: 0x0600C040 RID: 49216 RVA: 0x00429CF4 File Offset: 0x00427EF4
	protected void o()
	{
		this.b.Text = ((this.w != null) ? this.w.f().ToString() : "?");
		this.c.Text = "(" + ((this.w != null) ? this.w.g().ToString() : "?") + ")";
		this.c.Visible = (this.w != null && this.k && this.w.g() != this.w.f());
		if (this.j() != null && this.j().atw() != null)
		{
			this.d.Text = "/ " + this.j().atw().Value.ToString();
			return;
		}
		this.d.Text = "";
	}

	// Token: 0x0600C041 RID: 49217 RVA: 0x00429E1C File Offset: 0x0042801C
	protected virtual void vc()
	{
		if (this.z != null)
		{
			this.z(this, new c1(this.j().f(), this.j().f() - 1));
		}
		Stat<int> stat = this.j();
		int num = stat.f();
		stat.a(num - 1);
		if (this.j().e() != null && this.j().e().re() != null)
		{
			this.j().e().re().bl();
		}
	}

	// Token: 0x0600C042 RID: 49218 RVA: 0x00429EB8 File Offset: 0x004280B8
	protected virtual void vb()
	{
		if (this.z != null)
		{
			this.z(this, new c1(this.j().f(), this.j().f() + 1));
		}
		Stat<int> stat = this.j();
		int num = stat.f();
		stat.a(num + 1);
		if (this.j().e() != null && this.j().e().re() != null)
		{
			this.j().e().re().bl();
		}
	}

	// Token: 0x0600C043 RID: 49219 RVA: 0x00429F54 File Offset: 0x00428154
	protected virtual void ve()
	{
		if (this.w != null)
		{
			this.a = new EventHandler<c1>(this.a);
			this.w.b(this.a);
		}
	}

	// Token: 0x0600C044 RID: 49220 RVA: 0x00429F84 File Offset: 0x00428184
	protected virtual void vf()
	{
		if (this.w != null && this.a != null)
		{
			this.w.a(this.a);
		}
	}

	// Token: 0x0600C045 RID: 49221 RVA: 0x00429FB0 File Offset: 0x004281B0
	protected e3q k()
	{
		if (this.j() == null || this.j().e() == null || !(this.j().e().re() is e3q))
		{
			return null;
		}
		return (e3q)this.j().e().re();
	}

	// Token: 0x0600C046 RID: 49222 RVA: 0x0042A00C File Offset: 0x0042820C
	protected override void i0()
	{
		this.ve();
		this.wt();
	}

	// Token: 0x0600C047 RID: 49223 RVA: 0x0042A01C File Offset: 0x0042821C
	protected override void i1()
	{
		this.vf();
	}

	// Token: 0x0600C048 RID: 49224 RVA: 0x0042A024 File Offset: 0x00428224
	protected override void n6(object A_0, c1 A_1)
	{
		base.n6(A_0, A_1);
		this.wt();
	}

	// Token: 0x0600C049 RID: 49225 RVA: 0x0042A038 File Offset: 0x00428238
	private new void a()
	{
		base.HorizontalAlignment = cab.a;
		base.TextLabelOffset = new Point(30, 7);
		base.Text = "Stat";
		this.b = new avo();
		this.b.IsPrivateComponent = true;
		this.b.a(false);
		this.b.a(cab.c);
		this.c = new avo();
		this.c.IsPrivateComponent = true;
		this.c.a(false);
		this.c.a(cab.c);
		this.d = new avo();
		this.d.IsPrivateComponent = true;
		this.d.a(false);
		this.d.a(cab.a);
		this.e = new aqw();
		this.e.IsPrivateComponent = true;
		this.e.a = bo1.a6;
		this.e.Size = new esj(24, 23);
		this.e.b(new EventHandler<b25>(this.a));
		e4z.b(this.e);
		this.f = new aqw();
		this.f.IsPrivateComponent = true;
		this.f.a = bo1.a6;
		this.f.Size = new esj(24, 23);
		this.f.b = new Point(0, 23);
		this.f.b(new EventHandler<b25>(this.b));
		e4z.b(this.f);
		wj wj = wj.a();
		if (!wj.c())
		{
			this.e.a = (this.f.a = wj.f);
			this.e.c = (this.f.c = wj.gz);
			this.e.b = (this.f.b = wj.gy);
			this.e.Size = (this.f.Size = wj.gz);
			aqw aqw = this.f;
			aqw.b.Y = aqw.b.Y + wj.gz.d;
		}
		this.aox(this.b);
		this.aox(this.c);
		this.aox(this.d);
		this.aox(this.e);
		this.aox(this.f);
		this.wt();
	}

	// Token: 0x0600C04A RID: 49226 RVA: 0x0042A2B4 File Offset: 0x004284B4
	private new void b(object A_0, b25 A_1)
	{
		this.vc();
		this.wt();
	}

	// Token: 0x0600C04B RID: 49227 RVA: 0x0042A2C4 File Offset: 0x004284C4
	private new void a(object A_0, b25 A_1)
	{
		this.vb();
		this.wt();
	}

	// Token: 0x0400455A RID: 17754
	private new EventHandler<c1> a;

	// Token: 0x0400455B RID: 17755
	private new avo b;

	// Token: 0x0400455C RID: 17756
	private new avo c;

	// Token: 0x0400455D RID: 17757
	private new avo d;

	// Token: 0x0400455E RID: 17758
	private new aqw e;

	// Token: 0x0400455F RID: 17759
	private new aqw f;

	// Token: 0x04004560 RID: 17760
	private new bool g;

	// Token: 0x04004561 RID: 17761
	private new bool h = true;

	// Token: 0x04004562 RID: 17762
	private Point i = new Point(250, 7);

	// Token: 0x04004563 RID: 17763
	private new int j = 30;

	// Token: 0x04004564 RID: 17764
	private new bool k = true;

	// Token: 0x04004565 RID: 17765
	private new Point l = new Point(300, 7);

	// Token: 0x04004566 RID: 17766
	private new int m;

	// Token: 0x04004567 RID: 17767
	private Color n = Color.White;

	// Token: 0x04004568 RID: 17768
	private Color o = Color.Black;

	// Token: 0x04004569 RID: 17769
	private bool p;

	// Token: 0x0400456A RID: 17770
	private int q = 30;

	// Token: 0x0400456B RID: 17771
	private Point r = new Point(350, 7);

	// Token: 0x0400456C RID: 17772
	private Color s = Color.White;

	// Token: 0x0400456D RID: 17773
	private Color t = Color.Black;

	// Token: 0x0400456E RID: 17774
	private int u = 360;

	// Token: 0x0400456F RID: 17775
	private int v = 10;

	// Token: 0x04004570 RID: 17776
	private Stat<int> w;

	// Token: 0x04004571 RID: 17777
	private int x;

	// Token: 0x04004572 RID: 17778
	private bool y = true;

	// Token: 0x04004573 RID: 17779
	[CompilerGenerated]
	private EventHandler<c1> z;

	// Token: 0x02002021 RID: 8225
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C2B7 RID: 49847 RVA: 0x004366D0 File Offset: 0x004348D0
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x04004686 RID: 18054
		public static readonly bbk.a a = new bbk.a();

		// Token: 0x04004687 RID: 18055
		public static Func<euz, bool> b;
	}
}
