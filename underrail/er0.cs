using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02000202 RID: 514
internal class er0 : c5w
{
	// Token: 0x06000E7A RID: 3706 RVA: 0x0003AA90 File Offset: 0x00038C90
	public dv8 aun()
	{
		return this.d;
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x0003AA98 File Offset: 0x00038C98
	public Guid qe()
	{
		return this.a;
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x0003AAA0 File Offset: 0x00038CA0
	public ee4 auo()
	{
		return this.i;
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0003AAA8 File Offset: 0x00038CA8
	public Vector2? s()
	{
		return this.j;
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0003AAB0 File Offset: 0x00038CB0
	public void a(Vector2? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0003AABC File Offset: 0x00038CBC
	public ee4 aup()
	{
		return this.k;
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x0003AAC4 File Offset: 0x00038CC4
	public object auq()
	{
		return this.m;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0003AACC File Offset: 0x00038CCC
	public List<ci1> aur()
	{
		return this.q;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0003AAD4 File Offset: 0x00038CD4
	public List<yz> aus()
	{
		return this.u;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x0003AADC File Offset: 0x00038CDC
	public int? aut()
	{
		return this.v;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0003AAE4 File Offset: 0x00038CE4
	internal e0 p()
	{
		return this.s;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0003AAEC File Offset: 0x00038CEC
	internal czr q()
	{
		return this.f;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0003AAF4 File Offset: 0x00038CF4
	public esj auu()
	{
		return this.g;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x0003AAFC File Offset: 0x00038CFC
	internal bool r()
	{
		return this.l;
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0003AB04 File Offset: 0x00038D04
	public double t()
	{
		return this.z;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0003AB0C File Offset: 0x00038D0C
	public ef auv()
	{
		return this.y;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x0003AB18 File Offset: 0x00038D18
	[CompilerGenerated]
	public void auw(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.aj;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0003AB50 File Offset: 0x00038D50
	[CompilerGenerated]
	public void auy(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.aj;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0003AB88 File Offset: 0x00038D88
	[CompilerGenerated]
	public void auz(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ak;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0003ABC0 File Offset: 0x00038DC0
	[CompilerGenerated]
	public void au0(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ak;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x0003ABF8 File Offset: 0x00038DF8
	internal er0(djf A_0, czp A_1, v8 A_2, eso A_3)
	{
		czh.a(A_0, "pathfindingManager");
		this.b = A_0;
		this.c = A_2;
		this.ah = A_3;
		this.b(A_1);
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0003AC4C File Offset: 0x00038E4C
	public void au1()
	{
		if (this.d == dv8.b)
		{
			this.o();
			this.anv();
			while (!this.anw())
			{
			}
		}
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0003AC70 File Offset: 0x00038E70
	public void au2()
	{
		if (this.d == dv8.b)
		{
			this.o();
			if (this.c != null)
			{
				this.c.o0(this, this.ah);
				return;
			}
			this.q.Add(ci1.g);
			this.au1();
		}
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x0003ACC0 File Offset: 0x00038EC0
	public void au3()
	{
		if (this.c != null)
		{
			this.c.o1(this);
			if (this.ag != null)
			{
				daw.a(this.ag);
			}
		}
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x0003ACF0 File Offset: 0x00038EF0
	public void anv()
	{
		if (this.ai)
		{
			return;
		}
		this.ai = true;
		this.n();
		this.n = new dew(this);
		this.o = new ug(this);
		this.l();
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0003AD2C File Offset: 0x00038F2C
	public bool anw()
	{
		if (this.d == dv8.f)
		{
			if (this.d())
			{
				this.d = dv8.d;
				this.c();
				return true;
			}
			return false;
		}
		else
		{
			if (this.d != dv8.c)
			{
				return true;
			}
			uint num = 0U;
			while (num < this.b.ake())
			{
				if (this.k())
				{
					if (this.d == dv8.e)
					{
						this.c();
						return true;
					}
					this.d = dv8.f;
					return false;
				}
				else
				{
					num += 1U;
				}
			}
			return false;
		}
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0003ADB4 File Offset: 0x00038FB4
	internal int a(int A_0)
	{
		if (this.af)
		{
			return 0;
		}
		return A_0;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x0003ADC4 File Offset: 0x00038FC4
	private void o()
	{
		this.ag = daw.b(7);
		this.ad = this.ag.a.a;
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0003ADE8 File Offset: 0x00038FE8
	private void n()
	{
		if (this.ag == null)
		{
			this.o();
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0003ADFC File Offset: 0x00038FFC
	private void b(czp A_0)
	{
		if (!this.a(A_0))
		{
			return;
		}
		this.a = Guid.NewGuid();
		this.f = A_0.b;
		this.e = A_0.a;
		this.i = A_0.c;
		this.j = A_0.d;
		this.k = A_0.e;
		this.l = A_0.f;
		this.g = A_0.m;
		this.h = A_0.m.c * A_0.m.d;
		this.m = A_0.l;
		this.r = A_0.g;
		this.t = A_0.j;
		this.z = A_0.o;
		this.aa = A_0.p;
		this.ab = A_0.q;
		if (!A_0.h)
		{
			if (A_0.i != null)
			{
				this.s = A_0.i;
			}
			else
			{
				this.s = bjc.a();
			}
		}
		if (A_0.k != null && A_0.k.Count > 0)
		{
			this.w = new cgi(this, A_0.k);
		}
		this.y = A_0.n.a();
		this.af = A_0.r;
		this.d = dv8.b;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0003AF60 File Offset: 0x00039160
	private bool a(czp A_0)
	{
		if ((A_0.b & czr.b) == czr.b && A_0.j == null)
		{
			this.q.Add(ci1.f);
			this.m();
		}
		if (A_0.g == null)
		{
			this.q.Add(ci1.d);
			this.m();
		}
		return this.q.Count == 0;
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x0003AFC4 File Offset: 0x000391C4
	private void m()
	{
		if (this.d != dv8.e)
		{
			this.d = dv8.e;
			if (this.ak != null)
			{
				this.ak(this, new EventArgs());
			}
		}
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x0003AFF8 File Offset: 0x000391F8
	private void l()
	{
		if ((this.f & czr.a) == czr.a && this.i.a(this.k))
		{
			this.e();
			return;
		}
		if (this.c(this.i).b == ac7.b)
		{
			this.q.Add(ci1.c);
			this.m();
			return;
		}
		br a_ = new br(this.i, 0, this.a(this.i));
		this.n.a(a_);
		this.d = dv8.c;
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x0003B088 File Offset: 0x00039288
	private bool k()
	{
		this.p = this.n.a();
		if (this.p == null)
		{
			if (this.z > 0.0 && this.ac != null && (double)this.ac.c / 10.0 <= this.z)
			{
				this.p = this.ac;
			}
			else
			{
				this.q.Add(ci1.e);
				this.m();
			}
			return true;
		}
		this.o.a(this.p.d);
		if (this.g())
		{
			return true;
		}
		if (this.h())
		{
			return true;
		}
		if (this.i())
		{
			return false;
		}
		this.j();
		return false;
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0003B15C File Offset: 0x0003935C
	private void j()
	{
		this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X + 1, this.p.d.a.Y)), null);
		this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X - 1, this.p.d.a.Y)), null);
		this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X, this.p.d.a.Y + 1)), null);
		this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X, this.p.d.a.Y - 1)), null);
		if (!this.a(1, 1))
		{
			this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X + 1, this.p.d.a.Y + 1)), null);
		}
		if (!this.a(1, -1))
		{
			this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X + 1, this.p.d.a.Y - 1)), null);
		}
		if (!this.a(-1, 1))
		{
			this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X - 1, this.p.d.a.Y + 1)), null);
		}
		if (!this.a(-1, -1))
		{
			this.a(new ee4(this.p.d.b, new Point(this.p.d.a.X - 1, this.p.d.a.Y - 1)), null);
		}
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x0003B450 File Offset: 0x00039650
	private bool i()
	{
		if (this.w != null && this.w.e.Count > 0)
		{
			bool flag = false;
			for (int i = 0; i < this.auu().d; i++)
			{
				for (int j = 0; j < this.g.c; j++)
				{
					Point point = new Point(this.p.d.a.X + j, this.p.d.a.Y + i);
					foreach (abo abo in this.w.e)
					{
						if (abo.c.b == this.p.d.b && abo.c.a == point)
						{
							abo abo2 = abo.a();
							Point a_;
							if (abo2.f == global::aj.a)
							{
								a_ = abo2.c.a;
							}
							else
							{
								a_ = new Point(abo2.c.a.X - this.g.c / 2, abo2.c.a.Y - this.g.d / 2);
							}
							this.a(new ee4(abo2.c.b, a_), new abo?(abo));
							this.x.Add(abo.a);
							flag = (abo.e == chj.b);
							if (flag)
							{
								break;
							}
						}
					}
					if (flag)
					{
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			if (this.x.Count > 0)
			{
				foreach (d0z a_2 in this.x)
				{
					this.w.a(a_2);
				}
				if (this.e)
				{
					this.f();
				}
				this.x.Clear();
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0003B6D4 File Offset: 0x000398D4
	private bool a(int A_0, int A_1)
	{
		int num = (A_0 == 1) ? 0 : (this.g.c - 1);
		int num2 = (A_1 == 1) ? this.g.d : -1;
		ee4 a_ = new ee4(this.p.d.b, new Point(this.p.d.a.X + num, this.p.d.a.Y + num2));
		eyu a_2 = this.c(a_);
		if (!this.a(a_, a_2))
		{
			return true;
		}
		num = ((A_0 == 1) ? this.g.c : -1);
		num2 = ((A_1 == 1) ? 0 : (this.g.d - 1));
		ee4 a_3 = new ee4(this.p.d.b, new Point(this.p.d.a.X + num, this.p.d.a.Y + num2));
		eyu a_4 = this.c(a_3);
		return !this.a(a_3, a_4);
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x0003B814 File Offset: 0x00039A14
	private bool a(ee4 A_0, eyu A_1)
	{
		return A_1.b != ac7.a && A_1.a <= 50f && A_1.b != ac7.b && !this.b(A_0);
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0003B84C File Offset: 0x00039A4C
	private static bool a(eyu A_0)
	{
		return A_0.b == ac7.c;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x0003B858 File Offset: 0x00039A58
	private bool h()
	{
		if ((this.f & czr.b) == czr.b)
		{
			if (!this.r())
			{
				for (int i = 0; i < this.auu().d; i++)
				{
					for (int j = 0; j < this.g.c; j++)
					{
						if (this.t.fs(new ee4(this.p.d.b, new Point(this.p.d.a.X + j, this.p.d.a.Y + i)), this.p.b, this))
						{
							return true;
						}
					}
				}
			}
			else if (this.t.fs(this.p.d, this.p.b, this))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x0003B948 File Offset: 0x00039B48
	private bool g()
	{
		if (this.z > 0.0 && (this.ac == null || this.ac.c > this.p.c || (this.ac.c == this.p.c && this.p.b < this.ac.b)) && this.p.a != -1 && this.p.c != -1)
		{
			this.ac = this.p;
		}
		if ((this.f & czr.a) == czr.a && this.p.d.b == this.k.b)
		{
			if (!this.r())
			{
				if (this.k.a.X >= this.p.d.a.X && this.k.a.X < this.p.d.a.X + this.g.c && this.k.a.Y >= this.p.d.a.Y && this.k.a.Y < this.p.d.a.Y + this.g.d)
				{
					return true;
				}
			}
			else if (this.p.d.a == this.k.a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x0003BB18 File Offset: 0x00039D18
	private void f()
	{
		List<br> list = new List<br>();
		br br;
		while ((br = this.n.a()) != null)
		{
			br.c = this.a(br.d);
			br.a();
			list.Add(br);
		}
		foreach (br a_ in list)
		{
			this.n.a(a_);
		}
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x0003BBAC File Offset: 0x00039DAC
	private void a(ee4 A_0, abo? A_1)
	{
		if (this.o.b(A_0))
		{
			return;
		}
		br br = this.n.a(A_0);
		bool flag = br == null;
		bool flag2 = false;
		if (!flag)
		{
			if (br.b(this.p, A_1))
			{
				br.e = this.p;
				br.f = A_1;
				br.c();
				this.n.b(br);
			}
			return;
		}
		float num = 0f;
		int num2 = 0;
		if (A_1 != null || this.p.d.a(A_0) || A_0.b != this.p.d.b)
		{
			for (int i = 0; i < this.auu().d; i++)
			{
				for (int j = 0; j < this.g.c; j++)
				{
					num2++;
					if (!this.a(A_0, j, i, ref num))
					{
						flag2 = true;
						this.o.a(new ee4(A_0.b, new Point(A_0.a.X + j, A_0.a.Y + i)));
					}
				}
			}
		}
		else
		{
			bool flag3 = false;
			bool flag4 = false;
			if (A_0.a.Y < this.p.d.a.Y)
			{
				flag3 = true;
				for (int k = 0; k < this.g.c; k++)
				{
					num2++;
					if (!this.a(A_0, k, 0, ref num))
					{
						flag2 = true;
						this.o.a(new ee4(A_0.b, new Point(A_0.a.X + k, A_0.a.Y)));
					}
				}
			}
			else if (A_0.a.Y > this.p.d.a.Y)
			{
				flag4 = true;
				for (int l = 0; l < this.g.c; l++)
				{
					num2++;
					if (!this.a(A_0, l, this.g.d - 1, ref num))
					{
						flag2 = true;
						this.o.a(new ee4(A_0.b, new Point(A_0.a.X + l, A_0.a.Y + this.g.d - 1)));
					}
				}
			}
			if (A_0.a.X < this.p.d.a.X)
			{
				for (int m = (flag3 > false) ? 1 : 0; m < (flag4 ? (this.auu().d - 1) : this.auu().d); m++)
				{
					num2++;
					if (!this.a(A_0, 0, m, ref num))
					{
						flag2 = true;
						this.o.a(new ee4(A_0.b, new Point(A_0.a.X, A_0.a.Y + m)));
					}
				}
			}
			else if (A_0.a.X > this.p.d.a.X)
			{
				for (int n = (flag3 > false) ? 1 : 0; n < (flag4 ? (this.auu().d - 1) : this.auu().d); n++)
				{
					num2++;
					if (!this.a(A_0, this.g.c - 1, n, ref num))
					{
						flag2 = true;
						this.o.a(new ee4(A_0.b, new Point(A_0.a.X + this.g.c - 1, A_0.a.Y + n)));
					}
				}
			}
		}
		if (flag2)
		{
			return;
		}
		float num3 = num / (float)num2;
		br = new br(A_0);
		if (this.e)
		{
			br.c = this.a(br.d);
		}
		br.e = this.p;
		br.f = A_1;
		br.h = num3;
		br.c();
		this.n.a(br);
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x0003C00C File Offset: 0x0003A20C
	private eyu c(ee4 A_0)
	{
		this.n();
		if (A_0.a.X >= 0 && A_0.a.Y >= 0)
		{
			eyu eyu = this.ad[this.a(A_0.b), A_0.a.X, A_0.a.Y];
			if (!eyu.f)
			{
				eyu = this.r.p3(A_0, this);
				this.ad[this.a(A_0.b), A_0.a.X, A_0.a.Y] = eyu;
			}
			return eyu;
		}
		return new eyu
		{
			f = true,
			b = ac7.b
		};
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
	private bool a(ee4 A_0, int A_1, int A_2, ref float A_3)
	{
		Point a_ = new Point(A_0.a.X + A_1, A_0.a.Y + A_2);
		eyu eyu = this.c(new ee4(A_0.b, a_));
		A_3 += eyu.a;
		return er0.a(eyu);
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0003C128 File Offset: 0x0003A328
	private bool b(ee4 A_0)
	{
		return this.w != null && this.w.f.Contains(A_0);
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x0003C148 File Offset: 0x0003A348
	private int a(ee4 A_0)
	{
		if (this.s == null)
		{
			return 0;
		}
		int num;
		if (A_0.b != this.k.b)
		{
			num = int.MaxValue;
		}
		else
		{
			num = this.s.p4(A_0.a, this.k.a);
		}
		if (this.w != null)
		{
			foreach (e6u e6u in this.w.a())
			{
				int num2 = e6u.a(A_0);
				if (num2 != -1)
				{
					if (e6u.a().e == chj.b && e6u.a().c.a(A_0))
					{
						return num2;
					}
					if (num2 < num)
					{
						num = num2;
					}
				}
			}
			return num;
		}
		return num;
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x0003C244 File Offset: 0x0003A444
	private void e()
	{
		if (this.d != dv8.e)
		{
			this.d = dv8.d;
			if (this.y.a)
			{
				this.u = this.a();
			}
			else
			{
				this.u = this.b();
			}
			if (this.aj != null)
			{
				this.aj(this, new EventArgs());
			}
		}
		if (this.ag != null)
		{
			daw.a(this.ag);
		}
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x0003C2C4 File Offset: 0x0003A4C4
	private bool d()
	{
		if (this.y.a)
		{
			if (this.ae == null)
			{
				List<yz> list = this.b();
				if (list.Count == 0)
				{
					this.u = list;
					return true;
				}
				this.ae = new er0.b(this, list);
			}
			else if (this.ae.c())
			{
				this.u = this.ae.e;
				if (this.u.Count > 1 && this.u[0] is bne)
				{
					this.u.RemoveAt(0);
				}
				return true;
			}
			return false;
		}
		this.u = this.b();
		return true;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0003C380 File Offset: 0x0003A580
	private void c()
	{
		if (this.ag != null)
		{
			daw.a(this.ag);
		}
		this.ai = false;
		if (this.aj != null)
		{
			this.aj(this, new EventArgs());
		}
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
	private List<yz> b()
	{
		this.n();
		Dictionary<ee4, e28> dictionary = new Dictionary<ee4, e28>();
		List<yz> list = new List<yz>();
		this.v = new int?((this.p != null) ? this.p.b : 0);
		for (br br = this.p; br != null; br = br.e)
		{
			int index = 0;
			yz yz;
			if (br.f != null)
			{
				yz = new a5b
				{
					a = br.f.Value
				};
			}
			else
			{
				bool flag = false;
				int num = 0;
				while (num < this.auu().c && !flag)
				{
					for (int i = 0; i < this.auu().d; i++)
					{
						eyu eyu = this.ad[this.a(br.d.b), br.d.a.X + num, br.d.a.Y + i];
						if (eyu.f && ((eyu.d && this.aa) || (eyu.e && this.ab)))
						{
							index = 1;
							int num2;
							if (num == 2 && (br.d.a.X + num) % 4 == 3)
							{
								num2 = 1;
							}
							else
							{
								num2 = 0;
							}
							int num3;
							if (i == 2 && (br.d.a.Y + i) % 4 == 3)
							{
								num3 = 1;
							}
							else
							{
								num3 = 0;
							}
							ee4 ee = new ee4(br.d.b, new Point((br.d.a.X + num) / 4 + num2, (br.d.a.Y + i) / 4 + num3));
							e28 e;
							if (dictionary.TryGetValue(ee, out e))
							{
								list.Remove(e);
							}
							else
							{
								e = new e28();
								e.a = new r0(ee.b, new Vector2((float)(ee.a.X * 4), (float)(ee.a.Y * 4)));
								dictionary[ee] = e;
							}
							list.Insert(0, e);
							flag = true;
							break;
						}
					}
					num++;
				}
				yz = new bne();
			}
			yz.a = new r0(br.d.b, br.d.a.b());
			list.Insert(index, yz);
		}
		if (this.j != null)
		{
			list.Insert(0, new bne
			{
				a = new r0(this.auo().b, this.j.Value)
			});
		}
		return list;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x0003C6B0 File Offset: 0x0003A8B0
	private List<yz> a()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		List<yz> list = this.b();
		if (list.Count == 0)
		{
			return list;
		}
		List<yz> list2 = new er0.a(this, list).a();
		stopwatch.Stop();
		Trace.WriteLine("Ouroboros - Creating smooth path: " + stopwatch.Elapsed.ToString());
		if (list2.Count > 1 && list2[0] is bne)
		{
			list2.RemoveAt(0);
		}
		return list2;
	}

	// Token: 0x0400089A RID: 2202
	private Guid a;

	// Token: 0x0400089B RID: 2203
	private djf b;

	// Token: 0x0400089C RID: 2204
	private v8 c;

	// Token: 0x0400089D RID: 2205
	private dv8 d;

	// Token: 0x0400089E RID: 2206
	private bool e;

	// Token: 0x0400089F RID: 2207
	private czr f;

	// Token: 0x040008A0 RID: 2208
	private esj g;

	// Token: 0x040008A1 RID: 2209
	private int h;

	// Token: 0x040008A2 RID: 2210
	private ee4 i;

	// Token: 0x040008A3 RID: 2211
	private Vector2? j;

	// Token: 0x040008A4 RID: 2212
	private ee4 k;

	// Token: 0x040008A5 RID: 2213
	private bool l;

	// Token: 0x040008A6 RID: 2214
	private object m;

	// Token: 0x040008A7 RID: 2215
	private dew n;

	// Token: 0x040008A8 RID: 2216
	private ug o;

	// Token: 0x040008A9 RID: 2217
	private br p;

	// Token: 0x040008AA RID: 2218
	private List<ci1> q = new List<ci1>();

	// Token: 0x040008AB RID: 2219
	private e0p r;

	// Token: 0x040008AC RID: 2220
	private e0 s;

	// Token: 0x040008AD RID: 2221
	private cdf t;

	// Token: 0x040008AE RID: 2222
	private List<yz> u;

	// Token: 0x040008AF RID: 2223
	private int? v;

	// Token: 0x040008B0 RID: 2224
	private cgi w;

	// Token: 0x040008B1 RID: 2225
	private List<d0z> x = new List<d0z>();

	// Token: 0x040008B2 RID: 2226
	private ef y;

	// Token: 0x040008B3 RID: 2227
	private double z;

	// Token: 0x040008B4 RID: 2228
	private bool aa;

	// Token: 0x040008B5 RID: 2229
	private bool ab;

	// Token: 0x040008B6 RID: 2230
	private br ac;

	// Token: 0x040008B7 RID: 2231
	private eyu[,,] ad;

	// Token: 0x040008B8 RID: 2232
	private er0.b ae;

	// Token: 0x040008B9 RID: 2233
	private bool af;

	// Token: 0x040008BA RID: 2234
	internal chh ag;

	// Token: 0x040008BB RID: 2235
	private eso ah;

	// Token: 0x040008BC RID: 2236
	private bool ai;

	// Token: 0x040008BD RID: 2237
	[CompilerGenerated]
	private EventHandler<EventArgs> aj;

	// Token: 0x040008BE RID: 2238
	[CompilerGenerated]
	private EventHandler<EventArgs> ak;

	// Token: 0x02000203 RID: 515
	internal class b
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x0003C734 File Offset: 0x0003A934
		public b(er0 A_0, List<yz> A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0003C74C File Offset: 0x0003A94C
		public List<yz> b()
		{
			HashSet<ee4> a_ = this.b(this.b);
			List<yz> list = new List<yz>();
			List<List<yz>> list2 = er0.b.a(this.b);
			Stopwatch stopwatch = Stopwatch.StartNew();
			foreach (List<yz> list3 in list2)
			{
				if (list3.Count > 2)
				{
					List<yz> collection = this.a(list3, a_);
					list.AddRange(collection);
				}
				else
				{
					list.AddRange(list3);
				}
			}
			stopwatch.Stop();
			Trace.WriteLine("Ouroboros - Smoothing sections: " + stopwatch.Elapsed.ToString());
			return list;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0003C818 File Offset: 0x0003AA18
		public bool c()
		{
			if (!this.c)
			{
				this.d = this.b(this.b);
				this.e = new List<yz>();
				this.f = er0.b.a(this.b);
				this.g = 0;
				this.c = true;
				this.h = false;
				return false;
			}
			for (int i = 0; i < 30; i++)
			{
				if (this.a())
				{
					this.e.AddRange(this.i);
					this.g++;
					this.h = false;
					if (this.g >= this.f.Count)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003C8D0 File Offset: 0x0003AAD0
		private bool a()
		{
			List<yz> list = this.f[this.g];
			if (!this.h)
			{
				this.h = true;
				this.j = list.Count - 1;
				this.i = new List<yz>();
				this.i.Add(list[0]);
				this.i.Add(list[this.j]);
				this.k = 1;
				this.l = (list.Count > 3);
				this.m = this.j;
				this.n = 0;
				this.o = true;
				this.p = 0;
				this.q = this.j;
			}
			if (!this.l && !this.o)
			{
				this.h = false;
				return true;
			}
			if (this.l && (!this.o || Math.Abs(this.n - this.m) > Math.Abs(this.q - this.p)))
			{
				if (this.m - this.n == 1 || this.a(list[this.n], list[this.m], this.d))
				{
					this.i.Insert(this.k, list[this.n]);
					this.m = this.n;
					this.n = this.p + 1;
					if (this.o && this.q > this.m)
					{
						this.q = this.m;
					}
				}
				else
				{
					this.n++;
				}
			}
			else if (this.q - this.p == 1 || this.a(list[this.p], list[this.q], this.d))
			{
				if (this.q != this.j)
				{
					this.i.Insert(this.k, list[this.q]);
					this.k++;
				}
				this.p = this.q;
				this.q = this.m;
				if (this.l && this.n < this.p)
				{
					this.n = this.p;
				}
			}
			else
			{
				this.q--;
			}
			if (this.m <= this.n)
			{
				this.l = false;
			}
			if (this.p >= this.q)
			{
				this.o = false;
			}
			return false;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0003CB94 File Offset: 0x0003AD94
		private float c(List<yz> A_0)
		{
			float num = 0f;
			if (A_0.Count > 1)
			{
				Vector2 value = A_0[0].a.a;
				for (int i = 1; i < A_0.Count; i++)
				{
					float num2 = (A_0[i].a.a - value).Length();
					num += num2;
					value = A_0[i].a.a;
				}
			}
			return num;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0003CC14 File Offset: 0x0003AE14
		private HashSet<ee4> b(List<yz> A_0)
		{
			HashSet<ee4> hashSet = new HashSet<ee4>();
			foreach (yz yz in A_0)
			{
				for (int i = 0; i < this.a.g.c; i++)
				{
					for (int j = 0; j < this.a.g.d; j++)
					{
						ee4 ee = new ee4(yz.a.b, new Point((int)yz.a.a.X + i, (int)yz.a.a.Y + j));
						hashSet.Add(ee);
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		private static List<List<yz>> a(List<yz> A_0)
		{
			List<List<yz>> list = new List<List<yz>>();
			List<yz> list2 = null;
			foreach (yz yz in A_0)
			{
				if (!(yz is bne))
				{
					if (list2 != null)
					{
						list.Add(list2);
					}
					list2 = new List<yz>();
				}
				if (list2 == null)
				{
					list2 = new List<yz>();
				}
				list2.Add(yz);
				if (yz is e28)
				{
					list.Add(list2);
					list2 = new List<yz>();
				}
			}
			list.Add(list2);
			return list;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0003CD9C File Offset: 0x0003AF9C
		private List<yz> a(List<yz> A_0, HashSet<ee4> A_1)
		{
			int num = A_0.Count - 1;
			List<yz> list = new List<yz>();
			list.Add(A_0[0]);
			list.Add(A_0[num]);
			int num2 = 1;
			bool flag = A_0.Count > 3;
			int num3 = num;
			int num4 = 0;
			bool flag2 = true;
			int num5 = 0;
			int num6 = num;
			while (flag || flag2)
			{
				if (flag && (!flag2 || Math.Abs(num4 - num3) > Math.Abs(num6 - num5)))
				{
					if (num3 - num4 == 1 || this.a(A_0[num4], A_0[num3], A_1))
					{
						list.Insert(num2, A_0[num4]);
						num3 = num4;
						num4 = num5 + 1;
						if (flag2 && num6 > num3)
						{
							num6 = num3;
						}
					}
					else
					{
						num4++;
					}
				}
				else if (num6 - num5 == 1 || this.a(A_0[num5], A_0[num6], A_1))
				{
					if (num6 != num)
					{
						list.Insert(num2, A_0[num6]);
						num2++;
					}
					num5 = num6;
					num6 = num3;
					if (flag && num4 < num5)
					{
						num4 = num5;
					}
				}
				else
				{
					num6--;
				}
				if (num3 <= num4)
				{
					flag = false;
				}
				if (num5 >= num6)
				{
					flag2 = false;
				}
			}
			return list;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003CF0C File Offset: 0x0003B10C
		private float a(yz A_0, yz A_1)
		{
			return (A_0.a.a - A_1.a.a).Length();
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003CF3C File Offset: 0x0003B13C
		private bool a(yz A_0, yz A_1, HashSet<ee4> A_2)
		{
			float num = 0.02f;
			bbg bbg = new bbg();
			bbg.a(false);
			bbg.a().Add(new er0.b.b(this.a, A_2, A_0.a.b));
			bbg.a(float.MaxValue);
			bbg bbg2 = new bbg();
			bbg2.a(false);
			bbg2.a().Add(new er0.b.c(this.a, A_2, A_0.a.b));
			bbg2.a(float.MaxValue);
			exm exm = new exm(bbg, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + num), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + num));
			float num2 = A_1.a.a.X - A_0.a.a.X;
			float num3 = A_1.a.a.Y - A_0.a.a.Y;
			exm exm2;
			exm exm3;
			if (num2 == 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + num), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + num));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + (1f - num), A_0.a.a.Y + num), new Vector2(A_1.a.a.X + (1f - num), A_1.a.a.Y + num));
			}
			else if (num3 == 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + num), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + num));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + (1f - num)), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + (1f - num)));
			}
			else if (num2 * num3 > 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + (float)(this.a.g.c - 1) + (1f - num), A_0.a.a.Y + num), new Vector2(A_1.a.a.X + (float)(this.a.g.c - 1) + (1f - num), A_1.a.a.Y + num));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + (float)(this.a.g.d - 1) + (1f - num)), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + (float)(this.a.g.d - 1) + (1f - num)));
			}
			else
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + num, A_0.a.a.Y + num), new Vector2(A_1.a.a.X + num, A_1.a.a.Y + num));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + (float)(this.a.g.c - 1) + (1f - num), A_0.a.a.Y + (float)(this.a.g.d - 1) + (1f - num)), new Vector2(A_1.a.a.X + (float)(this.a.g.c - 1) + (1f - num), A_1.a.a.Y + (float)(this.a.g.d - 1) + (1f - num)));
			}
			p2 p = exm.a(null);
			p2 p2 = exm2.a(null);
			p2 p3 = exm3.a(null);
			return p.b() && p2.b() && p3.b();
		}

		// Token: 0x040008BF RID: 2239
		private er0 a;

		// Token: 0x040008C0 RID: 2240
		private List<yz> b;

		// Token: 0x040008C1 RID: 2241
		private bool c;

		// Token: 0x040008C2 RID: 2242
		private HashSet<ee4> d;

		// Token: 0x040008C3 RID: 2243
		public List<yz> e;

		// Token: 0x040008C4 RID: 2244
		private List<List<yz>> f;

		// Token: 0x040008C5 RID: 2245
		private int g;

		// Token: 0x040008C6 RID: 2246
		private bool h;

		// Token: 0x040008C7 RID: 2247
		private List<yz> i;

		// Token: 0x040008C8 RID: 2248
		private int j;

		// Token: 0x040008C9 RID: 2249
		private int k;

		// Token: 0x040008CA RID: 2250
		private bool l;

		// Token: 0x040008CB RID: 2251
		private int m;

		// Token: 0x040008CC RID: 2252
		private int n;

		// Token: 0x040008CD RID: 2253
		private bool o;

		// Token: 0x040008CE RID: 2254
		private int p;

		// Token: 0x040008CF RID: 2255
		private int q;

		// Token: 0x02000204 RID: 516
		private abstract class a
		{
			// Token: 0x06000EB8 RID: 3768 RVA: 0x0003D488 File Offset: 0x0003B688
			protected a(er0 A_0, HashSet<ee4> A_1, int A_2)
			{
				this.a = A_1;
				this.b = A_0;
				this.c = A_2;
			}

			// Token: 0x06000EB9 RID: 3769 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
			protected bool a(ee4 A_0)
			{
				if (!this.a.Contains(A_0))
				{
					if (this.b.b(A_0))
					{
						return false;
					}
					eyu eyu = this.b.r.p3(A_0, this.b);
					if (!er0.a(eyu))
					{
						return false;
					}
					if (eyu.a > this.b.y.c)
					{
						return false;
					}
					if (this.b.y.b != null && this.b.y.b.p3(A_0, this.b).b != ac7.c)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x040008D0 RID: 2256
			protected HashSet<ee4> a;

			// Token: 0x040008D1 RID: 2257
			protected er0 b;

			// Token: 0x040008D2 RID: 2258
			protected int c;
		}

		// Token: 0x02000205 RID: 517
		private class b : er0.b.a, ok
		{
			// Token: 0x06000EBA RID: 3770 RVA: 0x0003D55C File Offset: 0x0003B75C
			public b(er0 A_0, HashSet<ee4> A_1, int A_2) : base(A_0, A_1, A_2)
			{
			}

			// Token: 0x06000EBB RID: 3771 RVA: 0x0003D56C File Offset: 0x0003B76C
			public bool g5(anl A_0)
			{
				for (int i = 0; i < this.b.g.d; i++)
				{
					for (int j = 0; j < this.b.g.c; j++)
					{
						ee4 a_ = new ee4(this.c, new Point(A_0.d().X + j, A_0.d().Y + i));
						if (!base.a(a_))
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x02000206 RID: 518
		private class c : er0.b.a, ok
		{
			// Token: 0x06000EBC RID: 3772 RVA: 0x0003D5F0 File Offset: 0x0003B7F0
			public c(er0 A_0, HashSet<ee4> A_1, int A_2) : base(A_0, A_1, A_2)
			{
			}

			// Token: 0x06000EBD RID: 3773 RVA: 0x0003D5FC File Offset: 0x0003B7FC
			public bool g5(anl A_0)
			{
				ee4 a_ = new ee4(this.c, A_0.d());
				return base.a(a_);
			}
		}
	}

	// Token: 0x02000207 RID: 519
	internal class a
	{
		// Token: 0x06000EBE RID: 3774 RVA: 0x0003D624 File Offset: 0x0003B824
		public a(er0 A_0, List<yz> A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0003D640 File Offset: 0x0003B840
		public List<yz> a()
		{
			HashSet<ee4> a_ = this.b(this.b);
			List<yz> list = new List<yz>();
			List<List<yz>> list2 = er0.a.a(this.b);
			Stopwatch stopwatch = Stopwatch.StartNew();
			foreach (List<yz> list3 in list2)
			{
				if (list3.Count > 2)
				{
					List<yz> collection = this.a(list3, a_);
					list.AddRange(collection);
				}
				else
				{
					list.AddRange(list3);
				}
			}
			stopwatch.Stop();
			Trace.WriteLine("Ouroboros - Smoothing sections: " + stopwatch.Elapsed.ToString());
			return list;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003D70C File Offset: 0x0003B90C
		private float c(List<yz> A_0)
		{
			float num = 0f;
			if (A_0.Count > 1)
			{
				Vector2 value = A_0[0].a.a;
				for (int i = 1; i < A_0.Count; i++)
				{
					float num2 = (A_0[i].a.a - value).Length();
					num += num2;
					value = A_0[i].a.a;
				}
			}
			return num;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003D78C File Offset: 0x0003B98C
		private HashSet<ee4> b(List<yz> A_0)
		{
			HashSet<ee4> hashSet = new HashSet<ee4>();
			foreach (yz yz in A_0)
			{
				for (int i = 0; i < this.a.g.c; i++)
				{
					for (int j = 0; j < this.a.g.d; j++)
					{
						ee4 ee = new ee4(yz.a.b, new Point((int)yz.a.a.X + i, (int)yz.a.a.Y + j));
						hashSet.Add(ee);
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0003D86C File Offset: 0x0003BA6C
		private static List<List<yz>> a(List<yz> A_0)
		{
			List<List<yz>> list = new List<List<yz>>();
			List<yz> list2 = null;
			foreach (yz yz in A_0)
			{
				if (!(yz is bne))
				{
					if (list2 != null)
					{
						list.Add(list2);
					}
					list2 = new List<yz>();
				}
				if (list2 == null)
				{
					list2 = new List<yz>();
				}
				list2.Add(yz);
				if (yz is e28)
				{
					list.Add(list2);
					list2 = new List<yz>();
				}
			}
			list.Add(list2);
			return list;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003D914 File Offset: 0x0003BB14
		private List<yz> a(List<yz> A_0, HashSet<ee4> A_1)
		{
			int num = A_0.Count - 1;
			List<yz> list = new List<yz>();
			list.Add(A_0[0]);
			list.Add(A_0[num]);
			int num2 = 1;
			bool flag = A_0.Count > 3;
			int num3 = num;
			int num4 = 0;
			bool flag2 = true;
			int num5 = 0;
			int num6 = num;
			while (flag || flag2)
			{
				if (flag && (!flag2 || Math.Abs(num4 - num3) > Math.Abs(num6 - num5)))
				{
					if (num3 - num4 == 1 || this.a(A_0[num4], A_0[num3], A_1))
					{
						list.Insert(num2, A_0[num4]);
						num3 = num4;
						num4 = num5 + 1;
						if (flag2 && num6 > num3)
						{
							num6 = num3;
						}
					}
					else
					{
						num4++;
					}
				}
				else if (num6 - num5 == 1 || this.a(A_0[num5], A_0[num6], A_1))
				{
					if (num6 != num)
					{
						list.Insert(num2, A_0[num6]);
						num2++;
					}
					num5 = num6;
					num6 = num3;
					if (flag && num4 < num5)
					{
						num4 = num5;
					}
				}
				else
				{
					num6--;
				}
				if (num3 <= num4)
				{
					flag = false;
				}
				if (num5 >= num6)
				{
					flag2 = false;
				}
			}
			return list;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003DA84 File Offset: 0x0003BC84
		private float a(yz A_0, yz A_1)
		{
			return (A_0.a.a - A_1.a.a).Length();
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003DAB4 File Offset: 0x0003BCB4
		private bool a(yz A_0, yz A_1, HashSet<ee4> A_2)
		{
			bbg bbg = new bbg();
			bbg.a(false);
			bbg.a().Add(new er0.a.b(this.a, A_2, A_0.a.b));
			bbg.a(float.MaxValue);
			bbg bbg2 = new bbg();
			bbg2.a(false);
			bbg2.a().Add(new er0.a.a(this.a, A_2, A_0.a.b));
			bbg2.a(float.MaxValue);
			exm exm = new exm(bbg, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + 0.05f));
			float num = A_1.a.a.X - A_0.a.a.X;
			float num2 = A_1.a.a.Y - A_0.a.a.Y;
			exm exm2;
			exm exm3;
			if (num == 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + 0.05f));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.95f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + 0.95f, A_1.a.a.Y + 0.05f));
			}
			else if (num2 == 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + 0.05f));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + 0.95f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + 0.95f));
			}
			else if (num * num2 > 0f)
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + (float)(this.a.g.c - 1) + 0.95f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + (float)(this.a.g.c - 1) + 0.95f, A_1.a.a.Y + 0.05f));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + (float)(this.a.g.d - 1) + 0.95f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + (float)(this.a.g.d - 1) + 0.95f));
			}
			else
			{
				exm2 = new exm(bbg2, new Vector2(A_0.a.a.X + 0.05f, A_0.a.a.Y + 0.05f), new Vector2(A_1.a.a.X + 0.05f, A_1.a.a.Y + 0.05f));
				exm3 = new exm(bbg2, new Vector2(A_0.a.a.X + (float)(this.a.g.c - 1) + 0.95f, A_0.a.a.Y + (float)(this.a.g.d - 1) + 0.95f), new Vector2(A_1.a.a.X + (float)(this.a.g.c - 1) + 0.95f, A_1.a.a.Y + (float)(this.a.g.d - 1) + 0.95f));
			}
			p2 p = exm.a(null);
			p2 p2 = exm2.a(null);
			p2 p3 = exm3.a(null);
			return p.b() && p2.b() && p3.b();
		}

		// Token: 0x040008D3 RID: 2259
		private er0 a;

		// Token: 0x040008D4 RID: 2260
		private List<yz> b;

		// Token: 0x02000208 RID: 520
		private abstract class c
		{
			// Token: 0x06000EC6 RID: 3782 RVA: 0x0003E03C File Offset: 0x0003C23C
			protected c(er0 A_0, HashSet<ee4> A_1, int A_2)
			{
				this.a = A_1;
				this.b = A_0;
				this.c = A_2;
			}

			// Token: 0x06000EC7 RID: 3783 RVA: 0x0003E05C File Offset: 0x0003C25C
			protected bool a(ee4 A_0)
			{
				if (!this.a.Contains(A_0))
				{
					if (this.b.b(A_0))
					{
						return false;
					}
					eyu eyu = this.b.r.p3(A_0, this.b);
					if (!er0.a(eyu))
					{
						return false;
					}
					if (eyu.a > this.b.y.c)
					{
						return false;
					}
					if (this.b.y.b != null && this.b.y.b.p3(A_0, this.b).b != ac7.c)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x040008D5 RID: 2261
			protected HashSet<ee4> a;

			// Token: 0x040008D6 RID: 2262
			protected er0 b;

			// Token: 0x040008D7 RID: 2263
			protected int c;
		}

		// Token: 0x02000209 RID: 521
		private class b : er0.a.c, ok
		{
			// Token: 0x06000EC8 RID: 3784 RVA: 0x0003E110 File Offset: 0x0003C310
			public b(er0 A_0, HashSet<ee4> A_1, int A_2) : base(A_0, A_1, A_2)
			{
			}

			// Token: 0x06000EC9 RID: 3785 RVA: 0x0003E120 File Offset: 0x0003C320
			public bool g5(anl A_0)
			{
				for (int i = 0; i < this.b.g.d; i++)
				{
					for (int j = 0; j < this.b.g.c; j++)
					{
						ee4 a_ = new ee4(this.c, new Point(A_0.d().X + j, A_0.d().Y + i));
						if (!base.a(a_))
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x0200020A RID: 522
		private class a : er0.a.c, ok
		{
			// Token: 0x06000ECA RID: 3786 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
			public a(er0 A_0, HashSet<ee4> A_1, int A_2) : base(A_0, A_1, A_2)
			{
			}

			// Token: 0x06000ECB RID: 3787 RVA: 0x0003E1B0 File Offset: 0x0003C3B0
			public bool g5(anl A_0)
			{
				ee4 a_ = new ee4(this.c, A_0.d());
				return base.a(a_);
			}
		}
	}
}
