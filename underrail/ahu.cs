using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02002052 RID: 8274
public sealed class ahu : ec9
{
	// Token: 0x0600C458 RID: 50264 RVA: 0x00442D54 File Offset: 0x00440F54
	public cwp j()
	{
		return this.b;
	}

	// Token: 0x0600C459 RID: 50265 RVA: 0x00442D5C File Offset: 0x00440F5C
	public cfe g()
	{
		return this.f;
	}

	// Token: 0x0600C45A RID: 50266 RVA: 0x00442D64 File Offset: 0x00440F64
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.h;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C45B RID: 50267 RVA: 0x00442D9C File Offset: 0x00440F9C
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.h;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C45C RID: 50268 RVA: 0x00442DD4 File Offset: 0x00440FD4
	public ahu(efk A_0)
	{
		this.g = A_0;
		this.e();
	}

	// Token: 0x0600C45D RID: 50269 RVA: 0x00442DFC File Offset: 0x00440FFC
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.e != null)
		{
			Point point = base.at();
			if (wj.a().c())
			{
				this.e.a(new Point(point.X + ((this.f == null || this.f.e == null) ? 60 : ((base.Size.c - this.e.b.c) / 2)), point.Y + 170), A_1, null, 1f);
				return;
			}
			Point a_ = new Point(point.X + (base.Size.c - this.e.b.c) / 2, point.Y + base.Size.d - this.e.b.d - 10);
			this.e.a(a_, A_1, null, 1f);
		}
	}

	// Token: 0x0600C45E RID: 50270 RVA: 0x00442F04 File Offset: 0x00441104
	public void a(cwp A_0)
	{
		if (this.b != A_0)
		{
			if (this.b != null)
			{
				this.f();
			}
			this.b = A_0;
			this.c();
			this.b();
		}
	}

	// Token: 0x0600C45F RID: 50271 RVA: 0x00442F38 File Offset: 0x00441138
	public cfe i()
	{
		this.h();
		cfe result;
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (this.f != null && this.f.a() != null && this.f.d && this.f.a(serviceOrThrow.aqu().v()))
			{
				foreach (emy emy in Enumerable.OfType<emy>(base.Controls))
				{
					if (this.f.c != null && !string.IsNullOrEmpty(emy.ComponentName))
					{
						coh a_;
						this.f.c.TryGetValue(emy.ComponentName, out a_);
						emy.a(a_);
					}
					else
					{
						emy.a(null);
					}
				}
				result = this.f;
			}
			else
			{
				result = null;
			}
		}
		finally
		{
			this.h();
		}
		return result;
	}

	// Token: 0x0600C460 RID: 50272 RVA: 0x00443054 File Offset: 0x00441254
	public void f()
	{
		this.b = null;
		this.c = null;
		this.d = null;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		foreach (emy emy in Enumerable.ToList<emy>(Enumerable.OfType<emy>(base.Controls)))
		{
			if (emy.x6() != null)
			{
				chr serviceOrThrow2 = bpo.GetServiceOrThrow<chr>();
				if (serviceOrThrow2.aw() && serviceOrThrow2.ax() != null && serviceOrThrow2.ax().c() == emy.x6())
				{
					serviceOrThrow2.ay();
				}
				serviceOrThrow.aqu().v().Bag.z3(emy.x6(), true);
			}
			this.g(emy);
		}
	}

	// Token: 0x0600C461 RID: 50273 RVA: 0x00443134 File Offset: 0x00441334
	public void h()
	{
		this.f = null;
		if (this.b != null)
		{
			Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
			foreach (emy emy in Enumerable.Union<emy>(this.c, this.d))
			{
				if (emy != null && emy.Slot != null && emy.x6() != null)
				{
					dictionary[emy.ComponentName] = emy.x6();
				}
			}
			this.f = this.b.a(this.g, dictionary);
		}
		this.e = null;
		if (this.f != null)
		{
			if (this.f.e != null)
			{
				this.e = this.a(this.f.e);
			}
			else if (this.f.a() != null)
			{
				this.e = ahu.a(this.f.b);
			}
		}
		foreach (emy emy2 in Enumerable.OfType<emy>(base.Controls))
		{
			emy2.c(this.f != null && this.f.a() != null && emy2.x6() != null && this.f.d);
		}
	}

	// Token: 0x0600C462 RID: 50274 RVA: 0x004432D0 File Offset: 0x004414D0
	private new void e()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.t;
			return;
		}
		this.c = wj.f;
		this.e = wj.d5;
		this.d = new esj?(wj.d6);
		this.d();
	}

	// Token: 0x0600C463 RID: 50275 RVA: 0x0044332C File Offset: 0x0044152C
	private new void d()
	{
		this.a = new Point(base.Size.c / 2, (int)((double)base.Size.d * 0.33));
	}

	// Token: 0x0600C464 RID: 50276 RVA: 0x00443360 File Offset: 0x00441560
	private new void c()
	{
		this.c = new List<emy>();
		this.d = new List<emy>();
		if (this.b.Slots != null)
		{
			foreach (KeyValuePair<string, cgo> keyValuePair in this.b.Slots)
			{
				cgo value = keyValuePair.Value;
				if ((!(value.h != null) || (this.g != null && this.g.Feats.c(value.h))) && value != null)
				{
					if (value.b)
					{
						this.d.Add(this.a(keyValuePair.Key, value));
					}
					else
					{
						this.c.Add(this.a(keyValuePair.Key, value));
					}
				}
			}
		}
	}

	// Token: 0x0600C465 RID: 50277 RVA: 0x00443468 File Offset: 0x00441668
	private emy a(string A_0, cgo A_1)
	{
		emy emy = new emy(A_0, A_1);
		emy.b(new EventHandler(this.a));
		emy.p(new EventHandler<b25>(this.a));
		return emy;
	}

	// Token: 0x0600C466 RID: 50278 RVA: 0x00443498 File Offset: 0x00441698
	private void b()
	{
		wj wj = wj.a();
		Point point = this.a;
		int num;
		if (wj.c())
		{
			num = (int)(0.65 * (double)emy.a().d);
		}
		else
		{
			num = (int)(0.6 * (double)emy.a().d);
		}
		bool flag = this.d.Count >= 1 && this.c.Count >= 4;
		if (this.d.Count > 0)
		{
			int y;
			if (wj.c())
			{
				point.Y -= num;
				y = this.a.Y + 2 * num;
			}
			else
			{
				point.Y -= (int)((float)num * 0.65f);
				y = this.a.Y + (int)((float)num * 1.35f);
			}
			if (this.d.Count > 2)
			{
				this.a(new Point(this.a.X - num * 2, y), this.d[0]);
				this.a(new Point(this.a.X, y), this.d[1]);
				this.a(new Point(this.a.X + num * 2, y), this.d[2]);
			}
			else if (this.d.Count > 1)
			{
				if (flag)
				{
					this.a(new Point(this.a.X, y), this.d[0]);
					this.a(new Point(this.a.X + num * 2, y), this.d[1]);
				}
				else
				{
					this.a(new Point(this.a.X - num, y), this.d[0]);
					this.a(new Point(this.a.X + num, y), this.d[1]);
				}
			}
			else if (flag)
			{
				this.a(new Point(point.X + num * 2, point.Y + num * 2), this.d[0]);
			}
			else
			{
				this.a(new Point(this.a.X, y), this.d[0]);
			}
		}
		if (this.c.Count > 4)
		{
			this.a(new Point(point.X - num * 2, point.Y), this.c[0]);
			this.a(new Point(point.X, point.Y), this.c[1]);
			this.a(new Point(point.X + num * 2, point.Y), this.c[2]);
			if (flag)
			{
				this.a(new Point(point.X - num * 2, point.Y + num * 2), this.c[3]);
				this.a(new Point(point.X, point.Y + num * 2), this.c[4]);
				return;
			}
			this.a(new Point(point.X - num, point.Y + num * 2), this.c[3]);
			this.a(new Point(point.X + num, point.Y + num * 2), this.c[4]);
			return;
		}
		else if (this.c.Count > 3)
		{
			if (flag)
			{
				this.a(new Point(point.X - num * 2, point.Y), this.c[0]);
				this.a(new Point(point.X, point.Y), this.c[1]);
				this.a(new Point(point.X + num * 2, point.Y), this.c[2]);
				this.a(new Point(point.X - num * 2, point.Y + num * 2), this.c[3]);
				return;
			}
			this.a(new Point(point.X - num, point.Y), this.c[0]);
			this.a(new Point(point.X + num, point.Y), this.c[1]);
			this.a(new Point(point.X - num, point.Y + num * 2), this.c[2]);
			this.a(new Point(point.X + num, point.Y + num * 2), this.c[3]);
			return;
		}
		else
		{
			if (this.c.Count > 2)
			{
				this.a(new Point(point.X - num * 2, point.Y), this.c[0]);
				this.a(new Point(point.X, point.Y), this.c[1]);
				this.a(new Point(point.X + num * 2, point.Y), this.c[2]);
				return;
			}
			if (this.c.Count > 1)
			{
				this.a(new Point(point.X - num, point.Y), this.c[0]);
				this.a(new Point(point.X + num, point.Y), this.c[1]);
				return;
			}
			this.a(new Point(point.X, point.Y), this.c[0]);
			return;
		}
	}

	// Token: 0x0600C467 RID: 50279 RVA: 0x00443AA0 File Offset: 0x00441CA0
	private void a(Point A_0, emy A_1)
	{
		A_1.Location = new Point(A_0.X - emy.a().c / 2, A_0.Y - emy.a().d / 2);
		this.aox(A_1);
	}

	// Token: 0x0600C468 RID: 50280 RVA: 0x00443ADC File Offset: 0x00441CDC
	private static dn3 a(Dictionary<string, int> A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ecs ecs = new ecs();
		string a_ = ahu.a();
		foreach (KeyValuePair<string, int> keyValuePair in A_0)
		{
			try
			{
				bool flag = serviceOrThrow.aqu().v().Skills.a(keyValuePair.Key).g() >= keyValuePair.Value;
				bph bph = new bph(new d22(a_, Color.LightGray), keyValuePair.Key + " ", null);
				bph bph2 = new bph(new d22(a_, flag ? Color.White : Color.Red), keyValuePair.Value.ToString(), null);
				ecs.a.Add(new dl6(new bph[]
				{
					bph,
					bph2
				}));
			}
			catch
			{
			}
		}
		return ecs.b();
	}

	// Token: 0x0600C469 RID: 50281 RVA: 0x00443C04 File Offset: 0x00441E04
	private new static string a()
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			return wj.ee;
		}
		if (!egg.v)
		{
			return egg.ad;
		}
		return egg.n;
	}

	// Token: 0x0600C46A RID: 50282 RVA: 0x00443C40 File Offset: 0x00441E40
	private dn3 a(string A_0)
	{
		string a_ = ahu.a();
		ecs ecs = Enumerable.First<ecs>(new ecs
		{
			a = 
			{
				new dl6(new bph[]
				{
					new bph(new d22(a_, Color.Red), A_0, null)
				})
			}
		}.a((int)((float)base.Size.c * 0.9f), int.MaxValue));
		return ecs.b();
	}

	// Token: 0x0600C46B RID: 50283 RVA: 0x00443CB0 File Offset: 0x00441EB0
	private void a(object A_0, EventArgs A_1)
	{
		if (this.h != null)
		{
			this.h(this, new EventArgs());
		}
		this.h();
	}

	// Token: 0x0600C46C RID: 50284 RVA: 0x00443CD8 File Offset: 0x00441ED8
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b || A_1.b() == eoo.d)
		{
			emy emy = A_0 as emy;
			if (emy != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (!bpo.GetServiceOrThrow<chr>().aw())
				{
					if (emy.x6() != null)
					{
						serviceOrThrow.aqu().v().Bag.z3(emy.x6(), true);
						emy.yb(null, false);
						return;
					}
					foreach (coh coh in serviceOrThrow.aqu().v().Bag.z2())
					{
						if (emy.ye(null, coh))
						{
							emy.yb(coh, false);
							serviceOrThrow.aqu().v().Bag.z5(coh);
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C46D RID: 50285 RVA: 0x00443DD8 File Offset: 0x00441FD8
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		if (!wj.a().c())
		{
			this.d();
		}
	}

	// Token: 0x04004793 RID: 18323
	private new Point a = new Point(100, 85);

	// Token: 0x04004794 RID: 18324
	private new cwp b;

	// Token: 0x04004795 RID: 18325
	internal new List<emy> c;

	// Token: 0x04004796 RID: 18326
	internal new List<emy> d;

	// Token: 0x04004797 RID: 18327
	private new dn3 e;

	// Token: 0x04004798 RID: 18328
	private new cfe f;

	// Token: 0x04004799 RID: 18329
	private new efk g;

	// Token: 0x0400479A RID: 18330
	[CompilerGenerated]
	private EventHandler h;
}
