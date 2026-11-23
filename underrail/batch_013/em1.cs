using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001358 RID: 4952
[eiz("TAB")]
[Serializable]
public abstract class em1 : b1z, bgn, aig, ISerializable
{
	// Token: 0x06007015 RID: 28693 RVA: 0x002F0E10 File Offset: 0x002EF010
	protected em1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetInt32("TAB:IP");
		this.d = A_0.GetSingle("TAB:IPC");
		this.e = (c9o)A_0.GetValue("TAB:TS", typeof(c9o));
		this.f = A_0.GetInt32("TAB:PE");
		this.g = A_0.GetInt32("TAB:A");
		this.h = A_0.GetBoolean("TAB:ASS");
		this.i = A_0.GetDouble("TAB:PEC");
		this.j = A_0.GetInt32("TAB:CA");
		this.l = (qy)A_0.GetValue("TAB:CMA", typeof(qy));
		this.m = (EntityAspectReference<ale, ale>)A_0.GetValue("TAB:TR", typeof(EntityAspectReference<ale, ale>));
		this.n = A_0.GetInt32("TAB:RD");
		this.p = A_0.GetBoolean("TAB:OVP");
	}

	// Token: 0x06007016 RID: 28694 RVA: 0x002F0F30 File Offset: 0x002EF130
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TAB:IP", this.c);
		info.AddValue("TAB:IPC", this.d);
		info.AddValue("TAB:TS", this.e);
		info.AddValue("TAB:PE", this.f);
		info.AddValue("TAB:A", this.g);
		info.AddValue("TAB:ASS", this.h);
		info.AddValue("TAB:PEC", this.i);
		info.AddValue("TAB:CA", this.j);
		info.AddValue("TAB:CMA", this.l);
		info.AddValue("TAB:TR", this.m);
		info.AddValue("TAB:RD", this.n);
		info.AddValue("TAB:OVP", this.p);
	}

	// Token: 0x06007017 RID: 28695 RVA: 0x002F1018 File Offset: 0x002EF218
	public int r()
	{
		return this.f;
	}

	// Token: 0x06007018 RID: 28696 RVA: 0x002F1020 File Offset: 0x002EF220
	public void d(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06007019 RID: 28697 RVA: 0x002F102C File Offset: 0x002EF22C
	public int p()
	{
		return this.g;
	}

	// Token: 0x0600701A RID: 28698 RVA: 0x002F1034 File Offset: 0x002EF234
	public void c(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600701B RID: 28699 RVA: 0x002F1040 File Offset: 0x002EF240
	public bool i()
	{
		return this.h;
	}

	// Token: 0x0600701C RID: 28700 RVA: 0x002F1048 File Offset: 0x002EF248
	public void b(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600701D RID: 28701 RVA: 0x002F1054 File Offset: 0x002EF254
	public override m7 kh()
	{
		m7 m = m7.b;
		if (this.l != null)
		{
			m |= m7.e;
		}
		return m;
	}

	// Token: 0x0600701E RID: 28702 RVA: 0x002F1074 File Offset: 0x002EF274
	protected ale n()
	{
		return this.m.ao();
	}

	// Token: 0x0600701F RID: 28703 RVA: 0x002F1084 File Offset: 0x002EF284
	public c9o q()
	{
		return this.e;
	}

	// Token: 0x06007020 RID: 28704 RVA: 0x002F108C File Offset: 0x002EF28C
	public int? tm()
	{
		if (this.e != c9o.d)
		{
			return null;
		}
		if (this.m != null && this.m.ao() != null && this.m.ao().a8() != null && this.m.ao().a8().h.b != null && this.m.ao().a8().h.b.at != null)
		{
			return new int?(this.m.ao().a8().h.b.at.Value);
		}
		return new int?(this.c);
	}

	// Token: 0x06007021 RID: 28705 RVA: 0x002F115C File Offset: 0x002EF35C
	public CharacterState? q1()
	{
		if (this.e != c9o.d)
		{
			return null;
		}
		if (this.m != null && this.m.ao() != null && this.m.ao().a8() != null && this.m.ao().a8().h.b != null && this.m.ao().a8().h.b.@as != null)
		{
			return new CharacterState?(this.m.ao().a8().h.b.@as.Value);
		}
		return new CharacterState?(CharacterState.Move);
	}

	// Token: 0x06007022 RID: 28706
	public abstract object fm();

	// Token: 0x06007023 RID: 28707 RVA: 0x002F1228 File Offset: 0x002EF428
	public virtual ci8? oi()
	{
		return new ci8?(ci8.a);
	}

	// Token: 0x06007024 RID: 28708 RVA: 0x002F1230 File Offset: 0x002EF430
	public int u()
	{
		return this.n;
	}

	// Token: 0x06007025 RID: 28709 RVA: 0x002F1238 File Offset: 0x002EF438
	public void b(int A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06007026 RID: 28710 RVA: 0x002F1244 File Offset: 0x002EF444
	protected em1(ale A_0)
	{
		czh.a(A_0, "trekker");
		this.m = new EntityAspectReference<ale, ale>(A_0);
		if (A_0.a8() != null && A_0.a8().IsPlayer)
		{
			if (em1.a != null)
			{
				this.c = em1.a.Value;
			}
			if (em1.b != null)
			{
				this.d = em1.b.Value;
			}
		}
	}

	// Token: 0x06007027 RID: 28711 RVA: 0x002F12DC File Offset: 0x002EF4DC
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		this.d -= A_3;
		while (this.d < 0f)
		{
			float num;
			if (this.n() != null && this.n().a8() != null && this.n().a8().h.b != null)
			{
				num = (this.n().a8().h.b.g.g ?? cux.g);
			}
			else
			{
				num = cux.g;
			}
			this.d += num;
			int num2 = this.c + 1;
			this.c = num2;
			if (num2 == 2147483647)
			{
				this.c = 0;
			}
		}
		d4n d4n = this.c();
		if (d4n != null && !d4n.a(A_3))
		{
			this.e = c9o.h;
			this.l.j();
		}
		if (this.n() != null && this.n().a8() != null && this.n().a8().IsPlayer)
		{
			em1.a = new int?(this.c);
			em1.b = new float?(this.d);
		}
		return false;
	}

	// Token: 0x06007028 RID: 28712 RVA: 0x002F1438 File Offset: 0x002EF638
	public void l()
	{
		if (dz6.e())
		{
			this.f = 0;
			this.g = 1;
			return;
		}
		if ((this.n().a8().g & e2b.d) == e2b.d)
		{
			this.f = aju.n;
			this.g = aju.o;
			this.n = aju.p;
			return;
		}
		this.f = aju.k;
		this.g = aju.l;
		this.n = aju.m;
	}

	// Token: 0x06007029 RID: 28713 RVA: 0x002F14BC File Offset: 0x002EF6BC
	public void m()
	{
		if (this.l != null)
		{
			bpr bpr = this.l.aa() as bpr;
			if (bpr != null)
			{
				bpr.c(false);
			}
		}
	}

	// Token: 0x0600702A RID: 28714 RVA: 0x002F14F4 File Offset: 0x002EF6F4
	public static void a(czp A_0, ale A_1)
	{
		Point point;
		Point point2;
		A_1.a8().b(out point, out point2);
		A_0.c = new ee4(A_1.a8().Area.c(), point);
		A_0.r = A_1.a8().Zone.CustomProperties.GetPrimitivePropertyValue<bool>(a46.c, new bool?(false)).Value;
		Vector2 vector = new Vector2(A_1.a8().Location.X * 4f, A_1.a8().Location.Y * 4f);
		A_0.m = A_1.a8().i();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		A_0.p = ((A_1.a8().h.b.@as() && serviceOrThrow.aq1().c().d()) || (!A_1.a8().h.b.@as() && A_1.a8().h.b != null && A_1.a8().h.b.aa().c(d8o.d)));
		A_0.q = (!A_1.a8().h.b.@as() || serviceOrThrow.aq1().c().d());
		d25 d = new d25
		{
			b = A_0.p,
			c = A_0.q,
			e = new ee4?(A_0.e)
		};
		A_0.l = d;
		d.f = dd5.b(A_1.a8());
		d.g = bpv.a(A_1.a8());
		if (vector != point.b())
		{
			A_0.d = new Vector2?(vector);
		}
		if (A_1 != null)
		{
			d5s addon = A_1.a8().Zone.GetAddon<d5s>();
			if (addon != null)
			{
				List<d0z> collection = addon.aj4(A_1.a);
				A_0.k.AddRange(collection);
			}
			if ((A_1.a8().g & e2b.d) != e2b.d && !A_1.b)
			{
				List<d0z> collection2 = em1.a(A_1.a8().Zone);
				A_0.k.AddRange(collection2);
			}
		}
		if (!A_1.a8().IsPlayer && A_1.a8().h != null && A_1.a8().h.b != null)
		{
			foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
			{
				if (d4n.b != null && d4n.b != A_1.a8().h.b)
				{
					bool flag = false;
					if (d4n.b.aa().FactionId == A_1.a8().h.b.aa().FactionId)
					{
						flag = true;
					}
					else if (A_1.a8().h.b.a(d4n.b) == global::h.e)
					{
						flag = true;
					}
					if (flag)
					{
						if (d.h == null)
						{
							d.h = new HashSet<Guid>();
						}
						d.h.Add(d4n.b.a8().qe());
					}
				}
			}
		}
		bm6 bm = A_1.a8().t.b;
		if (bm != null)
		{
			string classPropertyValue = bm.y6().GetClassPropertyValue<string>(ddq.bv);
			if (string.IsNullOrEmpty(classPropertyValue))
			{
				classPropertyValue = bm.ad().GetClassPropertyValue<string>(ddq.bv);
			}
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				d.i = new HashSet<r0>();
				foreach (aud aud in A_1.a8().Zone.Areas)
				{
					int a_ = aud.c();
					foreach (ya ya in aud.Triggers)
					{
						a41 a = ya as a41;
						if (a != null && a.MarkerCode == classPropertyValue)
						{
							for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
							{
								for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
								{
									d.i.Add(new r0(a_, new Vector2((float)i, (float)j)));
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600702B RID: 28715 RVA: 0x002F1A78 File Offset: 0x002EFC78
	protected override dc4 dt()
	{
		if (this.n() == null)
		{
			return dc4.e;
		}
		b0b b0b = this.fm() as b0b;
		if (b0b != null && (b0b.Area == null || b0b.j != cgy.b))
		{
			return dc4.e;
		}
		this.e = c9o.a;
		if (this.n().a8() == null || this.n().a8().j == null)
		{
			return dc4.e;
		}
		if (this.fn())
		{
			return dc4.b;
		}
		return dc4.e;
	}

	// Token: 0x0600702C RID: 28716
	protected abstract bool fn();

	// Token: 0x0600702D RID: 28717 RVA: 0x002F1AFC File Offset: 0x002EFCFC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.n() == null)
		{
			return dc4.e;
		}
		if (this.e == c9o.h)
		{
			return dc4.e;
		}
		if (this.e == c9o.g)
		{
			return dc4.c;
		}
		if (this.e == c9o.i)
		{
			if ((this.o -= A_1.TotalMilliseconds) <= 0.0)
			{
				this.o();
			}
			return dc4.b;
		}
		if (this.e == c9o.b || this.e == c9o.c || this.e == c9o.e)
		{
			return dc4.b;
		}
		if (this.e == c9o.d)
		{
			if (this.n().a8().h.b != null)
			{
				this.n().a8().h.b.aa().Offense.ae();
			}
			if (this.q == null)
			{
				this.m();
				this.q = new bool?(this.n().a8().c(dm9.b));
			}
			else
			{
				bool flag = this.n().a8().c(dm9.b);
				if (flag != this.q.Value)
				{
					this.m();
					this.q = new bool?(flag);
				}
			}
			if (this.l.x() == dc4.c)
			{
				this.t();
				return dc4.b;
			}
			if (this.l.x() == dc4.e)
			{
				return this.b();
			}
			if (this.l.x() == dc4.d)
			{
				return dc4.e;
			}
			if (this.l.x() == dc4.b)
			{
				if (this.f > 0 && !dz6.e() && (this.i += A_1.TotalMilliseconds) >= (double)this.f)
				{
					this.l.j();
					this.l = null;
					this.i = 0.0;
					this.o();
					return dc4.b;
				}
				return dc4.b;
			}
		}
		return dc4.e;
	}

	// Token: 0x0600702E RID: 28718 RVA: 0x002F1D0C File Offset: 0x002EFF0C
	protected sealed override void j4()
	{
		if (this.e == c9o.d && this.l != null)
		{
			this.l.j();
		}
		else if (this.e == c9o.c && this.k != null)
		{
			this.k.au3();
		}
		this.e = c9o.g;
	}

	// Token: 0x0600702F RID: 28719 RVA: 0x002F1D6C File Offset: 0x002EFF6C
	protected override void agp()
	{
		this.j4();
	}

	// Token: 0x06007030 RID: 28720
	protected abstract void fo();

	// Token: 0x06007031 RID: 28721
	protected abstract void fp();

	// Token: 0x06007032 RID: 28722 RVA: 0x002F1D74 File Offset: 0x002EFF74
	protected virtual void fq()
	{
	}

	// Token: 0x06007033 RID: 28723 RVA: 0x002F1D78 File Offset: 0x002EFF78
	protected void h()
	{
		this.e = c9o.f;
	}

	// Token: 0x06007034 RID: 28724 RVA: 0x002F1D84 File Offset: 0x002EFF84
	protected void a(c5w A_0)
	{
		this.k = A_0;
		if (this.e == c9o.b)
		{
			if (this.k != null)
			{
				this.k.auw(new EventHandler<EventArgs>(this.a));
				this.k.auz(new EventHandler<EventArgs>(this.b));
				this.k.au2();
				this.e = c9o.c;
				return;
			}
			this.h();
		}
	}

	// Token: 0x06007035 RID: 28725 RVA: 0x002F1DF8 File Offset: 0x002EFFF8
	protected void c(bool A_0)
	{
		if (A_0)
		{
			this.fq();
			this.e = c9o.g;
			return;
		}
		if (this.p)
		{
			this.e = c9o.f;
			return;
		}
		this.b();
	}

	// Token: 0x06007036 RID: 28726 RVA: 0x002F1E2C File Offset: 0x002F002C
	private static List<d0z> a(c1a A_0)
	{
		List<d0z> list = new List<d0z>();
		foreach (aud aud in A_0.Areas)
		{
			aud.c();
			foreach (b0j b0j in Enumerable.OfType<b0j>(aud.Triggers))
			{
				if (!string.IsNullOrEmpty(b0j.DestinationWaypoint))
				{
					csd csd = A_0.g(b0j.DestinationWaypoint);
					if (csd != null && csd.Area != null)
					{
						ee4 a_ = new ee4(csd.Area.c(), new Point((int)csd.Location.X * 4, (int)csd.Location.Y * 4));
						ee4 a_2 = new ee4(aud.c(), new Point((b0j.Location.X + (int)((double)b0j.Size.c / 2.0)) * 4, (b0j.Location.Y + (int)((double)b0j.Size.d / 2.0)) * 4));
						d0z item = new d0z(Guid.NewGuid().ToString(), new abo(a_2, chj.a, aj.a, 0, null), new abo(a_, chj.c, aj.a, 0, new HorizontalDirection?(csd.Direction)), null);
						list.Add(item);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06007037 RID: 28727 RVA: 0x002F2008 File Offset: 0x002F0208
	private void d()
	{
		this.e = c9o.i;
		this.o = (double)((int)((0.75 + cuo.a.NextDouble() * 0.5) * (double)this.n));
	}

	// Token: 0x06007038 RID: 28728 RVA: 0x002F2040 File Offset: 0x002F0240
	protected void o()
	{
		this.e = c9o.b;
		this.fo();
	}

	// Token: 0x06007039 RID: 28729 RVA: 0x002F2050 File Offset: 0x002F0250
	protected void t()
	{
		this.e = c9o.e;
		this.fp();
	}

	// Token: 0x0600703A RID: 28730 RVA: 0x002F2060 File Offset: 0x002F0260
	private void b(object A_0, EventArgs A_1)
	{
		this.k = null;
		this.e = c9o.f;
	}

	// Token: 0x0600703B RID: 28731 RVA: 0x002F2070 File Offset: 0x002F0270
	private void a(object A_0, EventArgs A_1)
	{
		if (this.e != c9o.f && this.e != c9o.g)
		{
			this.a();
			this.k = null;
		}
	}

	// Token: 0x0600703C RID: 28732 RVA: 0x002F2098 File Offset: 0x002F0298
	private d4n c()
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg() && this.n() != null && this.n().a8() != null && this.n().a8().h.b != null)
		{
			return service.ahu(this.n().a8().h.b.aa());
		}
		return null;
	}

	// Token: 0x0600703D RID: 28733 RVA: 0x002F2114 File Offset: 0x002F0314
	private dc4 b()
	{
		if (this.g > 0)
		{
			int num = this.j + 1;
			this.j = num;
			if (num >= this.g)
			{
				goto IL_6F;
			}
		}
		if (!dz6.e() || this.j < 1)
		{
			this.l = null;
			if (this.j != 0 && this.n > 0)
			{
				this.d();
			}
			else
			{
				this.o();
			}
			return dc4.b;
		}
		IL_6F:
		this.e = c9o.f;
		return dc4.e;
	}

	// Token: 0x0600703E RID: 28734 RVA: 0x002F2198 File Offset: 0x002F0398
	private void a()
	{
		if (this.n().a8().h.b != null && this.n().a8().h.b.aa() != null && !this.n().a8().h.b.aa().IsMobile)
		{
			this.e = c9o.h;
			return;
		}
		c5x c5x = this.n().a8();
		mj a_ = this.n().a8().j.b;
		new Point((int)c5x.Location.X, (int)c5x.Location.Y);
		List<auv> list = new List<auv>();
		d4n d4n = this.c();
		if (d4n != null && this.k.aus().Count > 0 && !d4n.g())
		{
			this.e = c9o.h;
			return;
		}
		for (int i = 0; i < this.k.aus().Count; i++)
		{
			yz yz = this.k.aus()[i];
			Vector2 vector = yz.a.a;
			if (yz is bne)
			{
				bpr item;
				if (this.i() && this.k.aus().Count == 1)
				{
					item = new bpr(a_, new Vector3(vector.X / 4f, vector.Y / 4f, 0f));
				}
				else
				{
					item = new bpr(a_, new Vector3(vector.X / 4f, vector.Y / 4f, 0f));
				}
				list.Add(item);
			}
			else
			{
				a5b a5b = yz as a5b;
				if (a5b != null)
				{
					bsz item2 = new bsz(c5x, a5b.a, 100);
					list.Add(item2);
				}
				else
				{
					e28 e = yz as e28;
					if (e != null)
					{
						aud aud = c5x.Zone.b(e.a.b);
						if (aud != null)
						{
							Point a_2 = new Point((int)(vector.X / 4f), (int)(vector.Y / 4f));
							ak1 ak = aud.a(a_2);
							if (ak != null)
							{
								dnf item3 = new dnf(c5x, ak);
								list.Add(item3);
							}
						}
					}
				}
			}
		}
		this.l = new qy(list);
		this.l.b(true);
		this.l.c(false);
		this.n().a8().Zone.ActionManager.g9(this.l, atp.a);
		this.q = null;
		this.e = c9o.d;
	}

	// Token: 0x04002DD3 RID: 11731
	private new static int? a;

	// Token: 0x04002DD4 RID: 11732
	private static float? b;

	// Token: 0x04002DD5 RID: 11733
	private int c;

	// Token: 0x04002DD6 RID: 11734
	private float d = cux.g;

	// Token: 0x04002DD7 RID: 11735
	private c9o e;

	// Token: 0x04002DD8 RID: 11736
	private int f;

	// Token: 0x04002DD9 RID: 11737
	private int g = 1;

	// Token: 0x04002DDA RID: 11738
	private bool h;

	// Token: 0x04002DDB RID: 11739
	private double i;

	// Token: 0x04002DDC RID: 11740
	protected new int j;

	// Token: 0x04002DDD RID: 11741
	[NonSerialized]
	private new c5w k;

	// Token: 0x04002DDE RID: 11742
	private qy l;

	// Token: 0x04002DDF RID: 11743
	private EntityAspectReference<ale, ale> m;

	// Token: 0x04002DE0 RID: 11744
	private new int n;

	// Token: 0x04002DE1 RID: 11745
	private double o;

	// Token: 0x04002DE2 RID: 11746
	public bool p;

	// Token: 0x04002DE3 RID: 11747
	[NonSerialized]
	private bool? q;
}
