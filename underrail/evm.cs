using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;

// Token: 0x02001092 RID: 4242
[eiz("OLHGJ")]
[Serializable]
public sealed class evm : cze, ISerializable
{
	// Token: 0x060058A3 RID: 22691 RVA: 0x00266594 File Offset: 0x00264794
	private evm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("OLHGJ:LSEI", typeof(Guid));
		this.b = (Guid)A_0.GetValue("OLHGJ:RSEI", typeof(Guid));
		this.c = A_0.GetString("OLHGJ:AN");
		this.d = (bbo)A_0.GetValue("OLHGJ:O", typeof(bbo));
		this.e = (A_0.GetValue("OLHGJ:TF", typeof(int?)) as int?);
		this.f = (A_0.GetValue("OLHGJ:AS", typeof(int?)) as int?);
		this.g = A_0.GetString("OLHGJ:OS");
		this.h = A_0.GetString("OLHGJ:CS");
		if (ell.a() >= 439)
		{
			this.i = A_0.GetBoolean("OLHGJ:E");
		}
	}

	// Token: 0x060058A4 RID: 22692 RVA: 0x002666A8 File Offset: 0x002648A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OLHGJ:LSEI", this.a);
		info.AddValue("OLHGJ:RSEI", this.b);
		info.AddValue("OLHGJ:AN", this.c);
		info.AddValue("OLHGJ:O", this.d);
		info.AddValue("OLHGJ:TF", this.e);
		info.AddValue("OLHGJ:AS", this.f);
		info.AddValue("OLHGJ:OS", this.g);
		info.AddValue("OLHGJ:CS", this.h);
		info.AddValue("OLHGJ:E", this.i);
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x00266770 File Offset: 0x00264970
	private int d()
	{
		return this.e.GetValueOrDefault(6);
	}

	// Token: 0x060058A6 RID: 22694 RVA: 0x00266780 File Offset: 0x00264980
	private int c()
	{
		return this.f.GetValueOrDefault(300);
	}

	// Token: 0x060058A7 RID: 22695 RVA: 0x00266794 File Offset: 0x00264994
	private string b()
	{
		return this.h ?? "LargeDoor";
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x002667A8 File Offset: 0x002649A8
	private string a()
	{
		return this.g ?? "LargeDoor";
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x002667BC File Offset: 0x002649BC
	public int? h()
	{
		return this.e;
	}

	// Token: 0x060058AA RID: 22698 RVA: 0x002667C4 File Offset: 0x002649C4
	public void a(int? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060058AB RID: 22699 RVA: 0x002667D0 File Offset: 0x002649D0
	public int? i()
	{
		return this.f;
	}

	// Token: 0x060058AC RID: 22700 RVA: 0x002667D8 File Offset: 0x002649D8
	public void b(int? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060058AD RID: 22701 RVA: 0x002667E4 File Offset: 0x002649E4
	public string g()
	{
		return this.g;
	}

	// Token: 0x060058AE RID: 22702 RVA: 0x002667EC File Offset: 0x002649EC
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060058AF RID: 22703 RVA: 0x002667F8 File Offset: 0x002649F8
	public string j()
	{
		return this.h;
	}

	// Token: 0x060058B0 RID: 22704 RVA: 0x00266800 File Offset: 0x00264A00
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060058B1 RID: 22705 RVA: 0x0026680C File Offset: 0x00264A0C
	public Guid l()
	{
		return this.a;
	}

	// Token: 0x060058B2 RID: 22706 RVA: 0x00266814 File Offset: 0x00264A14
	public void b(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060058B3 RID: 22707 RVA: 0x00266820 File Offset: 0x00264A20
	public Guid m()
	{
		return this.b;
	}

	// Token: 0x060058B4 RID: 22708 RVA: 0x00266828 File Offset: 0x00264A28
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060058B5 RID: 22709 RVA: 0x00266834 File Offset: 0x00264A34
	public string k()
	{
		return this.c;
	}

	// Token: 0x060058B6 RID: 22710 RVA: 0x0026683C File Offset: 0x00264A3C
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060058B7 RID: 22711 RVA: 0x00266848 File Offset: 0x00264A48
	public bbo e()
	{
		return this.d;
	}

	// Token: 0x060058B8 RID: 22712 RVA: 0x00266850 File Offset: 0x00264A50
	public void a(bbo A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060058B9 RID: 22713 RVA: 0x0026685C File Offset: 0x00264A5C
	public bool f()
	{
		return this.i;
	}

	// Token: 0x060058BA RID: 22714 RVA: 0x00266864 File Offset: 0x00264A64
	public void a(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060058BB RID: 22715 RVA: 0x00266870 File Offset: 0x00264A70
	public evm()
	{
	}

	// Token: 0x060058BC RID: 22716 RVA: 0x00266878 File Offset: 0x00264A78
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

	// Token: 0x060058BD RID: 22717 RVA: 0x00266B30 File Offset: 0x00264D30
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

	// Token: 0x060058BE RID: 22718 RVA: 0x00266C94 File Offset: 0x00264E94
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

	// Token: 0x060058BF RID: 22719 RVA: 0x00266F5C File Offset: 0x0026515C
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

	// Token: 0x040023B3 RID: 9139
	private new Guid a;

	// Token: 0x040023B4 RID: 9140
	private Guid b;

	// Token: 0x040023B5 RID: 9141
	private string c;

	// Token: 0x040023B6 RID: 9142
	private bbo d;

	// Token: 0x040023B7 RID: 9143
	private int? e;

	// Token: 0x040023B8 RID: 9144
	private int? f;

	// Token: 0x040023B9 RID: 9145
	private string g;

	// Token: 0x040023BA RID: 9146
	private string h;

	// Token: 0x040023BB RID: 9147
	private bool i;
}
