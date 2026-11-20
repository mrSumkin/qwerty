using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;

// Token: 0x02001093 RID: 4243
[eiz("OLLGJ")]
[Serializable]
public sealed class awh : cze, ISerializable
{
	// Token: 0x060058C0 RID: 22720 RVA: 0x0026736C File Offset: 0x0026556C
	private awh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("OLLGJ:LSEI", typeof(Guid));
		this.b = (Guid)A_0.GetValue("OLLGJ:RSEI", typeof(Guid));
		this.c = A_0.GetString("OLLGJ:AN");
		this.d = (bbo)A_0.GetValue("OLLGJ:O", typeof(bbo));
		this.e = (A_0.GetValue("OLLGJ:TF", typeof(int?)) as int?);
		this.f = (A_0.GetValue("OLLGJ:AS", typeof(int?)) as int?);
		this.g = A_0.GetString("OLLGJ:OS");
		this.h = A_0.GetString("OLLGJ:CS");
		if (ell.a() >= 439)
		{
			this.i = A_0.GetBoolean("OLLGJ:E");
		}
	}

	// Token: 0x060058C1 RID: 22721 RVA: 0x00267480 File Offset: 0x00265680
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OLLGJ:LSEI", this.a);
		info.AddValue("OLLGJ:RSEI", this.b);
		info.AddValue("OLLGJ:AN", this.c);
		info.AddValue("OLLGJ:O", this.d);
		info.AddValue("OLLGJ:TF", this.e);
		info.AddValue("OLLGJ:AS", this.f);
		info.AddValue("OLLGJ:OS", this.g);
		info.AddValue("OLLGJ:CS", this.h);
		info.AddValue("OLLGJ:E", this.i);
	}

	// Token: 0x060058C2 RID: 22722 RVA: 0x00267548 File Offset: 0x00265748
	private int d()
	{
		return this.e.GetValueOrDefault(4);
	}

	// Token: 0x060058C3 RID: 22723 RVA: 0x00267558 File Offset: 0x00265758
	private int c()
	{
		return this.f.GetValueOrDefault(500);
	}

	// Token: 0x060058C4 RID: 22724 RVA: 0x0026756C File Offset: 0x0026576C
	private string b()
	{
		return this.h ?? "LargeDoor";
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x00267580 File Offset: 0x00265780
	private string a()
	{
		return this.g ?? "LargeDoor";
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x00267594 File Offset: 0x00265794
	public int? h()
	{
		return this.e;
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x0026759C File Offset: 0x0026579C
	public void a(int? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x002675A8 File Offset: 0x002657A8
	public int? i()
	{
		return this.f;
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x002675B0 File Offset: 0x002657B0
	public void b(int? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060058CA RID: 22730 RVA: 0x002675BC File Offset: 0x002657BC
	public string g()
	{
		return this.g;
	}

	// Token: 0x060058CB RID: 22731 RVA: 0x002675C4 File Offset: 0x002657C4
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060058CC RID: 22732 RVA: 0x002675D0 File Offset: 0x002657D0
	public string j()
	{
		return this.h;
	}

	// Token: 0x060058CD RID: 22733 RVA: 0x002675D8 File Offset: 0x002657D8
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060058CE RID: 22734 RVA: 0x002675E4 File Offset: 0x002657E4
	public Guid l()
	{
		return this.a;
	}

	// Token: 0x060058CF RID: 22735 RVA: 0x002675EC File Offset: 0x002657EC
	public void b(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060058D0 RID: 22736 RVA: 0x002675F8 File Offset: 0x002657F8
	public Guid m()
	{
		return this.b;
	}

	// Token: 0x060058D1 RID: 22737 RVA: 0x00267600 File Offset: 0x00265800
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060058D2 RID: 22738 RVA: 0x0026760C File Offset: 0x0026580C
	public string k()
	{
		return this.c;
	}

	// Token: 0x060058D3 RID: 22739 RVA: 0x00267614 File Offset: 0x00265814
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060058D4 RID: 22740 RVA: 0x00267620 File Offset: 0x00265820
	public bbo e()
	{
		return this.d;
	}

	// Token: 0x060058D5 RID: 22741 RVA: 0x00267628 File Offset: 0x00265828
	public void a(bbo A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060058D6 RID: 22742 RVA: 0x00267634 File Offset: 0x00265834
	public bool f()
	{
		return this.i;
	}

	// Token: 0x060058D7 RID: 22743 RVA: 0x0026763C File Offset: 0x0026583C
	public void a(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060058D8 RID: 22744 RVA: 0x00267648 File Offset: 0x00265848
	public awh()
	{
	}

	// Token: 0x060058D9 RID: 22745 RVA: 0x00267650 File Offset: 0x00265850
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_2 != null && A_2.ContainsKey(dmh.e))
		{
			e6z e6z = A_2[dmh.e] as e6z;
			if (e6z != null)
			{
				aud = e6z.ao();
			}
		}
		if (aud == null)
		{
			if (string.IsNullOrWhiteSpace(this.c))
			{
				return;
			}
			c1a c1a = null;
			if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
			}
			else if (A_2 != null && A_2.ContainsKey(dmh.d))
			{
				a55 a = A_2[dmh.d] as a55;
				if (a != null)
				{
					c1a = a.ao();
				}
			}
			if (c1a == null)
			{
				return;
			}
			aud = c1a.n(this.c);
		}
		if (aud == null)
		{
			return;
		}
		ar7 ar = new ar7(this.a, aud);
		ar7 ar2 = new ar7(this.b, aud);
		if (ar.ao() != null && ar2.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			cd0 aspect2 = ar2.ao().GetAspect<cd0>();
			ny aspect3 = ar.ao().GetAspect<ny>();
			ny aspect4 = ar2.ao().GetAspect<ny>();
			if (aspect != null && aspect2 != null && aspect3 != null && aspect4 != null)
			{
				if (this.d == bbo.b)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "open")
						{
							this.a(aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != this.d() - 1)
					{
						this.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (this.d == bbo.c)
				{
					if (aspect3.a() != null)
					{
						if (aspect3.a().Name != "close")
						{
							this.a(aud, aspect, aspect2, aspect3, aspect4);
							return;
						}
					}
					else if (aspect.b.X != 0)
					{
						this.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
				}
				else if (aspect3.a() != null)
				{
					if (aspect3.a().Name == "open")
					{
						this.a(aud, aspect, aspect2, aspect3, aspect4);
						return;
					}
					this.a(aspect, aspect2, aspect3, aspect4);
					return;
				}
				else
				{
					if (aspect.b.X < this.d() / 2)
					{
						this.a(aspect, aspect2, aspect3, aspect4);
						return;
					}
					this.a(aud, aspect, aspect2, aspect3, aspect4);
				}
			}
		}
	}

	// Token: 0x060058DA RID: 22746 RVA: 0x00267908 File Offset: 0x00265B08
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		Guid guid = this.a;
		if (A_2 != null && A_2.ContainsKey(dmh.e))
		{
			e6z e6z = A_2[dmh.e] as e6z;
			if (e6z != null)
			{
				aud = e6z.ao();
			}
		}
		if (aud == null)
		{
			if (string.IsNullOrWhiteSpace(this.c))
			{
				return false;
			}
			c1a c1a = null;
			if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
			}
			else if (A_2.ContainsKey(dmh.d))
			{
				a55 a = A_2[dmh.d] as a55;
				if (a != null)
				{
					c1a = a.ao();
				}
			}
			if (c1a == null)
			{
				return false;
			}
			aud = c1a.n(this.c);
		}
		if (aud == null)
		{
			return false;
		}
		ar7 ar = new ar7(this.a, aud);
		if (ar.ao() != null)
		{
			cd0 aspect = ar.ao().GetAspect<cd0>();
			ny aspect2 = ar.ao().GetAspect<ny>();
			if (aspect2 != null)
			{
				if (aspect2.a() != null)
				{
					return aspect2.a().Name == "close";
				}
				if (aspect != null)
				{
					return aspect.b.X == 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060058DB RID: 22747 RVA: 0x00267A6C File Offset: 0x00265C6C
	private void a(cd0 A_0, cd0 A_1, ny A_2, ny A_3)
	{
		awx awx = new awx("open");
		awx.a(m7.b | m7.k);
		dqm dqm = new dqm(A_0);
		dqm.c(this.d() - 1 - A_0.b.X);
		dqm.a(true);
		dqm.b(A_0.b.X);
		dqm.a(1);
		dqm.a((double)this.c());
		l6 l = new l6();
		l.a(new ar7(A_0.a8()));
		l.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l.a(x3.c);
		l6 l2 = new l6();
		l2.a(new ar7(A_0.a8()));
		l2.a().c(new List<byte>
		{
			1
		});
		l2.a(x3.c);
		awx.ad().Add(new bm3(200));
		awx.ad().Add(l);
		awx.ad().Add(dqm);
		awx.ad().Add(l2);
		awx awx2 = new awx("open");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_1);
		dqm2.c(this.d() - 1 - A_1.b.X);
		dqm2.a(true);
		dqm2.b(A_1.b.X);
		dqm2.a(1);
		dqm2.a((double)this.c());
		l6 l3 = new l6();
		l3.a(new ar7(A_1.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l3.a(x3.c);
		l6 l4 = new l6();
		l4.a(new ar7(A_1.a8()));
		l4.a().c(new List<byte>
		{
			1
		});
		l4.a(x3.c);
		awx2.ad().Add(new bm3(200));
		awx2.ad().Add(l3);
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l4);
		A_2.a(awx, atp.a, true, true);
		A_3.a(awx2, atp.a, true, true);
		aru aru = (A_2.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", this.a(), 1f, c9z.a, false, false);
		}
		if (this.i)
		{
			eym.a(A_2.a8() as c5x, (double)aju.bw);
		}
	}

	// Token: 0x060058DC RID: 22748 RVA: 0x00267D34 File Offset: 0x00265F34
	private void a(aud A_0, cd0 A_1, cd0 A_2, ny A_3, ny A_4)
	{
		awx awx = new awx("close");
		awx.a(m7.b | m7.k);
		clw clw = new clw();
		clw.a(new e6z(A_0));
		clw.a(true);
		if (A_2.a.EndsWith("y", StringComparison.OrdinalIgnoreCase))
		{
			clw.a(Axis.X);
			clw.a().Add(A_2.a8().Location.a());
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 1), false));
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(0, 2), false));
		}
		else
		{
			clw.a(Axis.Y);
			clw.a().Add(A_2.a8().Location.a());
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(1, 0), false));
			clw.a().Add(d05.a(A_2.a8().Location.a(), new Point(2, 0), false));
		}
		clw.e().Add(A_1.a8().qe());
		clw.e().Add(A_2.a8().qe());
		dqm dqm = new dqm(A_1);
		dqm.c(A_1.b.X);
		dqm.a(false);
		dqm.b(A_1.b.X);
		dqm.a(-1);
		dqm.a((double)this.c());
		l6 l = new l6();
		l.a(new ar7(A_1.a8()));
		l.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l.a(x3.b);
		l6 l2 = new l6();
		l2.a(new ar7(A_1.a8()));
		l2.a().c(new List<byte>
		{
			1
		});
		l2.a(x3.b);
		awx.ad().Add(new bm3(250));
		awx.ad().Add(l2);
		awx.ad().Add(dqm);
		awx.ad().Add(l);
		awx.ad().Add(clw);
		awx awx2 = new awx("close");
		awx2.a(m7.b | m7.k);
		dqm dqm2 = new dqm(A_2);
		dqm2.c(A_2.b.X);
		dqm2.a(false);
		dqm2.b(A_2.b.X);
		dqm2.a(-1);
		dqm2.a((double)this.c());
		l6 l3 = new l6();
		l3.a(new ar7(A_2.a8()));
		l3.a().c(new List<byte>
		{
			0,
			2,
			17
		});
		l3.a(x3.b);
		l6 l4 = new l6();
		l4.a(new ar7(A_2.a8()));
		l4.a().c(new List<byte>
		{
			1
		});
		l4.a(x3.b);
		awx2.ad().Add(new bm3(250));
		awx2.ad().Add(l4);
		awx2.ad().Add(dqm2);
		awx2.ad().Add(l3);
		A_3.a(awx, atp.a, true, true);
		A_4.a(awx2, atp.a, true, true);
		aru aru = (A_3.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", this.b(), 1f, c9z.a, false, false);
		}
		if (this.i)
		{
			eym.a(A_3.a8() as c5x, (double)aju.bw);
		}
	}

	// Token: 0x040023BC RID: 9148
	private new Guid a;

	// Token: 0x040023BD RID: 9149
	private Guid b;

	// Token: 0x040023BE RID: 9150
	private string c;

	// Token: 0x040023BF RID: 9151
	private bbo d;

	// Token: 0x040023C0 RID: 9152
	private int? e;

	// Token: 0x040023C1 RID: 9153
	private int? f;

	// Token: 0x040023C2 RID: 9154
	private string g;

	// Token: 0x040023C3 RID: 9155
	private string h;

	// Token: 0x040023C4 RID: 9156
	private bool i;
}
