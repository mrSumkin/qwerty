using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x020011BB RID: 4539
public sealed class crp : d02, io
{
	// Token: 0x060060D2 RID: 24786 RVA: 0x002A3E80 File Offset: 0x002A2080
	public bool ahd()
	{
		return this.j.Count > 0;
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x002A3E90 File Offset: 0x002A2090
	public d4n ahe()
	{
		if (this.f >= 0 && this.f < this.a.Count)
		{
			return this.a[this.f];
		}
		return null;
	}

	// Token: 0x060060D4 RID: 24788 RVA: 0x002A3EC8 File Offset: 0x002A20C8
	public d4n ahf()
	{
		return this.p;
	}

	// Token: 0x060060D5 RID: 24789 RVA: 0x002A3ED0 File Offset: 0x002A20D0
	public bool ahg()
	{
		return this.e > azz.a;
	}

	// Token: 0x060060D6 RID: 24790 RVA: 0x002A3EDC File Offset: 0x002A20DC
	public bool ahh()
	{
		return this.e != azz.a && this.e != azz.c && this.ahe() != null;
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x002A3F00 File Offset: 0x002A2100
	public bh3 ahi()
	{
		return this.d;
	}

	// Token: 0x060060D8 RID: 24792 RVA: 0x002A3F08 File Offset: 0x002A2108
	public double ahj()
	{
		return this.k;
	}

	// Token: 0x060060D9 RID: 24793 RVA: 0x002A3F10 File Offset: 0x002A2110
	public void ahk(double A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060060DA RID: 24794 RVA: 0x002A3F1C File Offset: 0x002A211C
	public List<d4n> ahl()
	{
		return this.a;
	}

	// Token: 0x060060DB RID: 24795 RVA: 0x002A3F24 File Offset: 0x002A2124
	public Guid ahm()
	{
		return this.l;
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x002A3F88 File Offset: 0x002A2188
	public void ahn(amc A_0 = null, bool A_1 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h != null && c5x.h.b != null && c5x.h.b.aa().Dead)
			{
				return;
			}
		}
		if (A_0 == null || (A_0.a8() != null && A_0.a8().j == cgy.b))
		{
			if (this.e == azz.a)
			{
				this.b(A_0, A_1);
				ps service = bpo.GetService<ps>();
				if (service != null)
				{
					service.am5();
					return;
				}
			}
			else if (A_0 != null)
			{
				this.b(A_0);
			}
		}
	}

	// Token: 0x060060DE RID: 24798 RVA: 0x002A4060 File Offset: 0x002A2260
	public void aho(e6d A_0)
	{
		if (this.k > 0.0)
		{
			ps service = bpo.GetService<ps>();
			if (service == null || !service.ak4())
			{
				this.k -= A_0.a().ElapsedGameTime.TotalMilliseconds;
				if (this.k < 0.0)
				{
					this.k = 0.0;
				}
			}
		}
		if (this.j.Count > 0)
		{
			if (this.d == bh3.b)
			{
				this.d = bh3.c;
			}
		}
		else
		{
			if (this.d == bh3.c)
			{
				this.d = bh3.b;
				this.e();
			}
			if (this.i)
			{
				this.d();
			}
		}
		if (this.e == azz.c || this.e == azz.d || (this.e == azz.b && (this.d != bh3.b || (this.ahe() != null && !(this.ahe().b.aa() is e3q)))))
		{
			this.a();
		}
		else
		{
			this.b();
		}
		if (this.e == azz.b && this.ahe() != null && this.d == bh3.b)
		{
			this.ahe().h();
		}
		if (this.j.Count > 0)
		{
			for (int i = 0; i < this.j.Count; i++)
			{
				auv auv = this.j[i];
				if (auv.State == dc4.c || auv.State == dc4.d || auv.State == dc4.e)
				{
					this.j.RemoveAt(i);
					i--;
				}
			}
		}
		else if (this.e == azz.c)
		{
			this.h();
		}
		if (this.e == azz.a)
		{
			if (this.o > 0.0)
			{
				this.o -= A_0.a().ElapsedGameTime.TotalMilliseconds;
				if (this.o <= 0.0)
				{
					this.o = 0.0;
					this.n = 0;
				}
			}
			foreach (ca7 ca in Enumerable.ToList<ca7>(this.m))
			{
				ca.b -= A_0.a().ElapsedGameTime.TotalMilliseconds;
				if (ca.b <= 0.0)
				{
					this.m.Remove(ca);
				}
			}
		}
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x002A4340 File Offset: 0x002A2540
	public void ahp(auv A_0)
	{
		this.j.Add(A_0);
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x002A4350 File Offset: 0x002A2550
	public void ahq(d4n A_0, bool A_1 = true, bool A_2 = true, bool A_3 = true, int? A_4 = null, bool A_5 = true)
	{
		if (A_0 != null && (!A_5 || A_0 == this.ahe()) && !this.i)
		{
			if (A_2)
			{
				this.a(A_0);
			}
			if (A_0.b != null && A_0.b.aa() is e3q)
			{
				this.l = Guid.NewGuid();
			}
			if (A_3)
			{
				A_0.a(true);
			}
			if (A_0.e > 0.0 && A_0.b != null && A_0.b.a8() != null && A_0.b.aa().IsInCombat && !A_0.b.aa().Passive && A_0.b.aa().IsInControl)
			{
				bmj.a(A_0.b.a8(), new cmq((int)A_0.e));
			}
			if (A_1 && A_0.b != null)
			{
				A_0.b.ai();
				if (A_0.b.aa() is e3q)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						cyt cyt = serviceOrThrow.aqu();
						cyt.b(cyt.o() + TimeSpan.FromMilliseconds((double)d0u.b));
					}
				}
			}
			bm6 bm = A_0.b.a8().t.b;
			if (bm != null && bm.n())
			{
				a6s a_ = new a6s(bm, 0);
				bm.a8().Zone.ActionManager.g9(a_, atp.a);
				this.ahp(a_);
				this.d = bh3.c;
			}
			if (A_0.b.aa() is e3q)
			{
				this.m.Clear();
			}
			this.h = A_4;
			this.i = true;
		}
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x002A4538 File Offset: 0x002A2738
	public void ahr()
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.am6();
		}
		if (this.e == azz.b)
		{
			this.k = (double)d0u.e;
		}
		this.e = azz.a;
		this.f = -1;
		foreach (d4n d4n in this.a)
		{
			if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().t.b != null)
			{
				d4n.b.a8().t.b.l();
				d4n.b.aa().s();
			}
		}
		this.q.Clear();
	}

	// Token: 0x060060E2 RID: 24802 RVA: 0x002A462C File Offset: 0x002A282C
	public bool ahs(bool A_0, bool A_1 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.t.b != null)
			{
				foreach (d4n d4n in this.a)
				{
					if (!d4n.b.aa().Dead && d4n.b != c5x.h.b && d4n.b.a8().t != null)
					{
						if (!d4n.b.aa().Passive && (d4n.b.a8().t.b.e(c5x.h.b) || (A_1 && d4n.b.a8().t.b.b(c5x.h.b))))
						{
							if (!A_0)
							{
								a7v.a(new vr(null, null, "Нельзя завершить бой сейчас.", new Color?(adi.l), null));
							}
							return false;
						}
						if (A_1 && !d4n.b.aa().Passive && c5x.t.b.b(d4n.b, false) && d4n.b.a(c5x.h.b) == global::h.a)
						{
							if (!A_0)
							{
								a7v.a(new vr(null, null, "Нельзя завершить бой сейчас.", new Color?(adi.l), null));
							}
							return false;
						}
						bm6 bm = d4n.b.a8().t.b;
						if (bm != null)
						{
							foreach (b0b b0b in bm.r())
							{
								c5x c5x2 = (c5x)b0b;
								if (c5x2.h.b != null && !c5x2.h.b.aa().Dead && c5x2.h.b.aa().IsInCombat && (c5x2.h.b.aa().a(serviceOrThrow.aqu().ac(), asp.a) == global::h.e || awq.d(c5x2.h.b)))
								{
									if (!A_0)
									{
										a7v.a(new vr(null, null, "Нельзя завершить бой сейчас.", new Color?(adi.l), null));
									}
									return false;
								}
							}
						}
					}
				}
			}
		}
		this.ahr();
		return true;
	}

	// Token: 0x060060E3 RID: 24803 RVA: 0x002A4974 File Offset: 0x002A2B74
	public void aht()
	{
		this.ahr();
		this.a.Clear();
		this.c.Clear();
		this.j.Clear();
		this.m.Clear();
		this.k = 0.0;
		this.n = 0;
		this.o = 0.0;
	}

	// Token: 0x060060E4 RID: 24804 RVA: 0x002A49D8 File Offset: 0x002A2BD8
	public d4n ahu(efk A_0)
	{
		d4n result;
		this.c.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060060E5 RID: 24805 RVA: 0x002A49F8 File Offset: 0x002A2BF8
	public int ahv(efk A_0)
	{
		if (A_0 != null)
		{
			d4n d4n = this.ahu(A_0);
			if (d4n != null)
			{
				return (int)d4n.c;
			}
		}
		return 0;
	}

	// Token: 0x060060E6 RID: 24806 RVA: 0x002A4A24 File Offset: 0x002A2C24
	public int ahw(efk A_0)
	{
		if (A_0 != null)
		{
			d4n d4n = this.ahu(A_0);
			if (d4n != null)
			{
				return (int)d4n.d;
			}
		}
		return 0;
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x002A4A50 File Offset: 0x002A2C50
	public void ahx(amc A_0)
	{
		if (A_0 != null)
		{
			this.b(A_0);
		}
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x002A4A60 File Offset: 0x002A2C60
	public void ahy(amc A_0)
	{
		if (A_0 != null)
		{
			this.a(A_0);
		}
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x002A4A70 File Offset: 0x002A2C70
	public void ahz(chb A_0)
	{
		if (!this.b.Contains(A_0))
		{
			this.b.Add(A_0);
		}
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x002A4A90 File Offset: 0x002A2C90
	public void ah0(chb A_0)
	{
		this.b.Remove(A_0);
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x002A4AA0 File Offset: 0x002A2CA0
	public void ah1(amc A_0, amc A_1)
	{
		d4n d4n = this.ahu(A_0.aa());
		d4n d4n2 = this.ahu(A_1.aa());
		if (d4n != null)
		{
			this.a(d4n, 0.0, false);
		}
		if (d4n2 != null)
		{
			this.a(d4n2, 0.0, false);
		}
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x002A4AF8 File Offset: 0x002A2CF8
	public void ah2(int A_0, bool A_1, int A_2, bool A_3 = false)
	{
		this.m.Add(new ca7(A_0, (double)A_2, A_1, A_3));
	}

	// Token: 0x060060ED RID: 24813 RVA: 0x002A4B10 File Offset: 0x002A2D10
	public void ah3(int A_0)
	{
		this.n = A_0;
		this.o = 1500.0;
	}

	// Token: 0x060060EE RID: 24814 RVA: 0x002A4B28 File Offset: 0x002A2D28
	public void ah4()
	{
		this.e = azz.e;
		this.p = this.ahe();
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x002A4B40 File Offset: 0x002A2D40
	internal void a(d4n A_0, double A_1, bool A_2 = false)
	{
		bool flag = false;
		List<d4n> list = new List<d4n>();
		foreach (d4n d4n in Enumerable.ToList<d4n>(this.a))
		{
			if (d4n != A_0)
			{
				bm6 bm = d4n.b.a8().t.b;
				if (bm != null)
				{
					bm.a(A_0, A_1);
				}
				bm6 bm2 = A_0.b.a8().t.b;
				if (bm2 != null)
				{
					bm2.a(d4n, A_1);
				}
			}
		}
		if (A_0 == this.ahe() && flag)
		{
			foreach (d4n item in list)
			{
				this.a.Remove(item);
				this.a.Insert(this.f, item);
			}
			if (A_0.b.a8().i.b != null)
			{
				A_0.b.a8().i.b.a(true, false);
			}
			this.q[A_0.b.a8().qe()] = new KeyValuePair<int, int>((int)A_0.c, (int)A_0.d);
			this.ahq(A_0, false, false, false, new int?(this.f), false);
		}
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x002A4CDC File Offset: 0x002A2EDC
	private void b(amc A_0, bool A_1)
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null)
		{
			service.aim();
		}
		ps service2 = bpo.GetService<ps>();
		if (service2 != null)
		{
			service2.al9();
		}
		d4n d4n = null;
		if (A_0 != null)
		{
			d4n = this.b(A_0);
		}
		this.a(A_0, !A_1);
		if (d4n != null)
		{
			if (d4n.b.aa() is e3q)
			{
				this.d(d4n);
			}
			d4n d4n2 = Enumerable.FirstOrDefault<d4n>(this.a);
			if (d4n2 == null || d4n2.b == null || !(d4n2.b.aa() is e3q))
			{
				this.m.Clear();
			}
		}
		else
		{
			this.m.Clear();
		}
		foreach (d4n a_ in this.a)
		{
			this.b(a_);
		}
		this.e = azz.c;
		this.l = Guid.NewGuid();
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x002A4DF8 File Offset: 0x002A2FF8
	private void h()
	{
		foreach (d4n d4n in this.a)
		{
			bm6 bm = d4n.b.a8().t.b;
			if (bm != null && bm.v())
			{
				return;
			}
		}
		this.g();
		this.e = azz.b;
	}

	// Token: 0x060060F2 RID: 24818 RVA: 0x002A4E84 File Offset: 0x002A3084
	private void a(amc A_0, bool A_1)
	{
		List<KeyValuePair<d4n, int>> list = new List<KeyValuePair<d4n, int>>();
		foreach (d4n d4n in this.a)
		{
			int num = d4n.b.aa().Offense.ay();
			int num2 = cuo.a.Next(1, 16);
			int num3 = 0;
			if (d4n.b.aa() is e3q && this.n != 0)
			{
				num3 = this.n;
			}
			else if (d4n.b == A_0 && d4n.b.aa().SpecialStates.g && d4n.b.aa().IsInControl)
			{
				num3 = 100;
			}
			list.Add(new KeyValuePair<d4n, int>(d4n, num + num2 + num3));
			if (A_1)
			{
				diw a_ = new diw(new ap9(d4n.b.aa()), num, num2, num3);
				bey.a(a_, d4n.b.aa(), d4n.b);
				bmj.a(d4n.b.a8(), new dh1(num, num2, num3));
				a7v.a(a_);
			}
		}
		this.a = new List<d4n>(Enumerable.Select<KeyValuePair<d4n, int>, d4n>(Enumerable.OrderByDescending<KeyValuePair<d4n, int>, int>(list, new Func<KeyValuePair<d4n, int>, int>(crp.a.a.b)), new Func<KeyValuePair<d4n, int>, d4n>(crp.a.a.a)));
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x002A5044 File Offset: 0x002A3244
	private void d(d4n A_0)
	{
		this.a.Remove(A_0);
		this.a.Insert(0, A_0);
	}

	// Token: 0x060060F4 RID: 24820 RVA: 0x002A5060 File Offset: 0x002A3260
	private void c(d4n A_0)
	{
		this.a.Remove(A_0);
		this.a.Add(A_0);
	}

	// Token: 0x060060F5 RID: 24821 RVA: 0x002A507C File Offset: 0x002A327C
	private void g()
	{
		foreach (d4n d4n in this.a)
		{
			d4n.e();
		}
		this.f = 0;
		this.f();
	}

	// Token: 0x060060F6 RID: 24822 RVA: 0x002A50E0 File Offset: 0x002A32E0
	private d4n b(amc A_0)
	{
		if (this.e == azz.e && this.p != null && this.p.b == A_0)
		{
			this.e = azz.b;
			d4n result = this.p;
			this.p = null;
			return result;
		}
		d4n d4n;
		if (!this.c.TryGetValue(A_0.aa(), out d4n))
		{
			if (A_0 != null && A_0.a8() != null && A_0.a8().t.b != null)
			{
				d4n = new d4n(this, A_0);
				if (this.e == azz.b)
				{
					this.b(d4n);
				}
				this.a.Add(d4n);
				this.c[A_0.aa()] = d4n;
			}
			else
			{
				d4n = null;
			}
		}
		return d4n;
	}

	// Token: 0x060060F7 RID: 24823 RVA: 0x002A51AC File Offset: 0x002A33AC
	private void b(d4n A_0)
	{
		if (A_0.b.a8().i.b != null)
		{
			A_0.b.a8().i.b.a(m7.b, true, false);
			A_0.b.ad();
			A_0.e = 0.0;
			bm6 bm = A_0.b.a8().t.b;
			if (bm != null)
			{
				bm.s();
			}
		}
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x002A5230 File Offset: 0x002A3430
	private void a(amc A_0)
	{
		if (this.p != null && this.p.b == A_0)
		{
			return;
		}
		d4n d4n = this.ahu(A_0.aa());
		this.ahq(d4n, false, true, true, null, true);
		if (d4n != null)
		{
			int num = this.a.IndexOf(d4n);
			if (num < this.f || (this.i && num == this.f))
			{
				this.f--;
			}
			this.a.Remove(d4n);
			this.c.Remove(A_0.aa());
		}
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x002A52E0 File Offset: 0x002A34E0
	private void f()
	{
		this.d = bh3.a;
		this.j.Clear();
		if (this.ahe() != null)
		{
			this.ahe().c();
			KeyValuePair<int, int> keyValuePair;
			if (this.q.TryGetValue(this.ahe().b.a8().qe(), out keyValuePair))
			{
				this.ahe().c = (double)keyValuePair.Key;
				this.ahe().d = (double)keyValuePair.Value;
				this.q.Remove(this.ahe().b.a8().qe());
			}
			this.a(this.ahe());
			bm6 bm = this.ahe().b.a8().t.b;
			if (bm != null)
			{
				bm.u();
			}
			if (this.ahe().b.aa() is e3q)
			{
				int a_ = Enumerable.Sum<ca7>(Enumerable.Where<ca7>(this.m, new Func<ca7, bool>(crp.a.a.f)), new Func<ca7, int>(crp.a.a.e));
				int a_2 = Enumerable.Sum<ca7>(Enumerable.Where<ca7>(this.m, new Func<ca7, bool>(crp.a.a.b)), new Func<ca7, int>(crp.a.a.a));
				this.ahe().a(a_, true);
				this.ahe().b(a_2, false);
				int num = Enumerable.Sum<ca7>(Enumerable.Where<ca7>(this.m, new Func<ca7, bool>(crp.a.a.d)), new Func<ca7, int>(crp.a.a.c));
				if (num > 0)
				{
					if (this.ahe().b.aa().Feats.Contains<c4y>())
					{
						int num2 = e5b.a(this.ahe().b.aa());
						if (this.ahe().d > (double)num2)
						{
							this.ahe().d = (double)num2;
						}
					}
					else
					{
						this.ahe().b(num, false);
					}
				}
				this.m.Clear();
			}
			foreach (els els in Enumerable.ToList<els>(this.ahe().b.aa().StatusEffects.d()))
			{
				if (els.ah)
				{
					this.ahe().b.a(els);
				}
				if (els is sj && els.TimeLeft <= (double)d0u.b)
				{
					this.ahe().b.aa().StatusEffects.d(els);
				}
			}
			this.d = bh3.b;
			this.e();
			return;
		}
		this.d = bh3.a;
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x002A5638 File Offset: 0x002A3838
	private void a(d4n A_0)
	{
		if (A_0 != null && A_0.b != null && A_0.b.a8() != null)
		{
			HashSet<bqt> hashSet = new HashSet<bqt>();
			foreach (ak1 ak in A_0.b.a8().l)
			{
				foreach (bqt bqt in ak.TriggerProxies)
				{
					hashSet.Add(bqt);
				}
			}
			foreach (bqt bqt2 in hashSet)
			{
				bqt2.b(A_0.b.a8());
			}
		}
	}

	// Token: 0x060060FB RID: 24827 RVA: 0x002A574C File Offset: 0x002A394C
	private void e()
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.am7();
		}
	}

	// Token: 0x060060FC RID: 24828 RVA: 0x002A576C File Offset: 0x002A396C
	private void d()
	{
		if (this.h != null)
		{
			this.f = this.h.Value;
		}
		else
		{
			this.f++;
		}
		if (this.f >= this.a.Count)
		{
			this.c();
			this.f = 0;
		}
		this.f();
		this.i = false;
		this.h = null;
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x002A57EC File Offset: 0x002A39EC
	private void c()
	{
		foreach (chb chb in new List<chb>(this.b))
		{
			chb.c();
		}
	}

	// Token: 0x060060FE RID: 24830 RVA: 0x002A5848 File Offset: 0x002A3A48
	private void b()
	{
		if (this.g)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.amq();
			}
			this.g = false;
		}
	}

	// Token: 0x060060FF RID: 24831 RVA: 0x002A587C File Offset: 0x002A3A7C
	private void a()
	{
		if (!this.g)
		{
			this.g = true;
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.amp();
			}
		}
	}

	// Token: 0x0400293C RID: 10556
	private List<d4n> a = new List<d4n>();

	// Token: 0x0400293D RID: 10557
	private List<chb> b = new List<chb>();

	// Token: 0x0400293E RID: 10558
	private Dictionary<efk, d4n> c = new Dictionary<efk, d4n>();

	// Token: 0x0400293F RID: 10559
	private bh3 d;

	// Token: 0x04002940 RID: 10560
	private azz e;

	// Token: 0x04002941 RID: 10561
	private int f;

	// Token: 0x04002942 RID: 10562
	private bool g;

	// Token: 0x04002943 RID: 10563
	private int? h;

	// Token: 0x04002944 RID: 10564
	private bool i;

	// Token: 0x04002945 RID: 10565
	private List<auv> j = new List<auv>();

	// Token: 0x04002946 RID: 10566
	private double k;

	// Token: 0x04002947 RID: 10567
	private Guid l;

	// Token: 0x04002948 RID: 10568
	private List<ca7> m = new List<ca7>();

	// Token: 0x04002949 RID: 10569
	private int n;

	// Token: 0x0400294A RID: 10570
	private double o;

	// Token: 0x0400294B RID: 10571
	private d4n p;

	// Token: 0x0400294C RID: 10572
	private Dictionary<Guid, KeyValuePair<int, int>> q = new Dictionary<Guid, KeyValuePair<int, int>>();

	// Token: 0x020011BD RID: 4541
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006106 RID: 24838 RVA: 0x002A58C4 File Offset: 0x002A3AC4
		internal int b(KeyValuePair<d4n, int> A_0)
		{
			return A_0.Value;
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x002A58D0 File Offset: 0x002A3AD0
		internal d4n a(KeyValuePair<d4n, int> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x002A58DC File Offset: 0x002A3ADC
		internal bool f(ca7 A_0)
		{
			return !A_0.c;
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x002A58E8 File Offset: 0x002A3AE8
		internal int e(ca7 A_0)
		{
			return A_0.a;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x002A58F0 File Offset: 0x002A3AF0
		internal bool b(ca7 A_0)
		{
			return A_0.c && !A_0.d;
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x002A5908 File Offset: 0x002A3B08
		internal int a(ca7 A_0)
		{
			return A_0.a;
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x002A5910 File Offset: 0x002A3B10
		internal bool d(ca7 A_0)
		{
			return A_0.c && A_0.d;
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x002A5928 File Offset: 0x002A3B28
		internal int c(ca7 A_0)
		{
			return A_0.a;
		}

		// Token: 0x0400294D RID: 10573
		public static readonly crp.a a = new crp.a();

		// Token: 0x0400294E RID: 10574
		public static Func<KeyValuePair<d4n, int>, int> b;

		// Token: 0x0400294F RID: 10575
		public static Func<KeyValuePair<d4n, int>, d4n> c;

		// Token: 0x04002950 RID: 10576
		public static Func<ca7, bool> d;

		// Token: 0x04002951 RID: 10577
		public static Func<ca7, int> e;

		// Token: 0x04002952 RID: 10578
		public static Func<ca7, bool> f;

		// Token: 0x04002953 RID: 10579
		public static Func<ca7, int> g;

		// Token: 0x04002954 RID: 10580
		public static Func<ca7, bool> h;

		// Token: 0x04002955 RID: 10581
		public static Func<ca7, int> i;
	}
}
