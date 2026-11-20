using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x020010B6 RID: 4278
[eiz("Q69")]
[Serializable]
public sealed class b6x : cze, ISerializable
{
	// Token: 0x060059DE RID: 23006 RVA: 0x0026D064 File Offset: 0x0026B264
	private b6x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetString("Q69:AN");
		this.e = (bbo)A_0.GetValue("Q69:O", typeof(bbo));
		di7.ReadList<Guid>("Q69:S", ref this.c, A_0);
		if (ell.a() >= 439)
		{
			this.f = A_0.GetBoolean("Q69:E");
		}
		if (ell.a() >= 581)
		{
			this.g = A_0.GetString("Q69:R");
		}
	}

	// Token: 0x060059DF RID: 23007 RVA: 0x0026D108 File Offset: 0x0026B308
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q69:AN", this.d);
		info.AddValue("Q69:O", this.e);
		di7.WriteList<Guid>("Q69:S", this.c, info);
		info.AddValue("Q69:E", this.f);
		info.AddValue("Q69:R", this.g);
	}

	// Token: 0x060059E0 RID: 23008 RVA: 0x0026D178 File Offset: 0x0026B378
	public List<Guid> c()
	{
		return this.c;
	}

	// Token: 0x060059E1 RID: 23009 RVA: 0x0026D180 File Offset: 0x0026B380
	public void a(List<Guid> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060059E2 RID: 23010 RVA: 0x0026D18C File Offset: 0x0026B38C
	public string d()
	{
		return this.d;
	}

	// Token: 0x060059E3 RID: 23011 RVA: 0x0026D194 File Offset: 0x0026B394
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060059E4 RID: 23012 RVA: 0x0026D1A0 File Offset: 0x0026B3A0
	public bbo a()
	{
		return this.e;
	}

	// Token: 0x060059E5 RID: 23013 RVA: 0x0026D1A8 File Offset: 0x0026B3A8
	public void a(bbo A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060059E6 RID: 23014 RVA: 0x0026D1B4 File Offset: 0x0026B3B4
	public bool e()
	{
		return this.f;
	}

	// Token: 0x060059E7 RID: 23015 RVA: 0x0026D1BC File Offset: 0x0026B3BC
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060059E8 RID: 23016 RVA: 0x0026D1C8 File Offset: 0x0026B3C8
	public string b()
	{
		return this.g;
	}

	// Token: 0x060059E9 RID: 23017 RVA: 0x0026D1D0 File Offset: 0x0026B3D0
	public void b(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060059EA RID: 23018 RVA: 0x0026D1DC File Offset: 0x0026B3DC
	public b6x()
	{
	}

	// Token: 0x060059EB RID: 23019 RVA: 0x0026D1F0 File Offset: 0x0026B3F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = b6q.a(A_0, A_1, A_2, this.d);
		List<ar7> list = b6q.a(aud, this.g, this.c);
		if (list.Count > 0 && list[0].ao() != null)
		{
			if (aud == null)
			{
				aud = list[0].ao().Area;
			}
			ny aspect = list[0].ao().GetAspect<ny>();
			cd0 aspect2 = list[0].ao().GetAspect<cd0>();
			if (aspect != null && aspect2 != null)
			{
				if (this.e == bbo.b)
				{
					if (aspect.a() != null)
					{
						if (aspect.a().Name != "open")
						{
							this.a(aspect, aspect2, list);
							return;
						}
					}
					else if (aspect2.b.X != 3)
					{
						this.a(aspect, aspect2, list);
						return;
					}
				}
				else if (this.e == bbo.c)
				{
					if (aspect.a() != null)
					{
						if (aspect.a().Name != "close")
						{
							this.a(aud, aspect, aspect2, list);
							return;
						}
					}
					else if (aspect2.b.X != 0)
					{
						this.a(aud, aspect, aspect2, list);
						return;
					}
				}
				else if (aspect.a() != null)
				{
					if (aspect.a().Name == "open")
					{
						this.a(aud, aspect, aspect2, list);
						return;
					}
					this.a(aspect, aspect2, list);
					return;
				}
				else
				{
					if (aspect2.b.X < 2)
					{
						this.a(aspect, aspect2, list);
						return;
					}
					this.a(aud, aspect, aspect2, list);
				}
			}
		}
	}

	// Token: 0x060059EC RID: 23020 RVA: 0x0026D390 File Offset: 0x0026B590
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		List<ar7> list = b6q.a(b6q.a(A_0, A_1, A_2, this.d), this.g, this.c);
		if (list.Count > 0 && list[0].ao() != null)
		{
			cd0 aspect = list[0].ao().GetAspect<cd0>();
			ny aspect2 = list[0].ao().GetAspect<ny>();
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

	// Token: 0x060059ED RID: 23021 RVA: 0x0026D43C File Offset: 0x0026B63C
	private void a(ny A_0, cd0 A_1, List<ar7> A_2)
	{
		bool flag = false;
		foreach (ar7 ar in A_2)
		{
			c5x c5x = ar.ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.i.b != null)
			{
				awx awx = new awx("open");
				awx.a(m7.b | m7.k);
				dqm dqm = new dqm(c5x.o.b);
				dqm.c(3 - c5x.o.b.b.X);
				dqm.a(true);
				dqm.b(c5x.o.b.b.X);
				dqm.a(1);
				dqm.a(350.0);
				l6 l = new l6();
				l.a(new ar7(c5x));
				l.a().c(new List<byte>
				{
					0,
					2
				});
				l.a(x3.c);
				l6 l2 = new l6();
				l2.a(new ar7(c5x));
				l2.a().c(new List<byte>
				{
					1
				});
				l2.a(x3.c);
				awx.ad().Add(new bm3(200));
				awx.ad().Add(l);
				awx.ad().Add(dqm);
				awx.ad().Add(l2);
				c5x.i.b.a(awx, atp.a, true, true);
				if (!flag && this.f)
				{
					flag = true;
					eym.a(c5x, (double)aju.bx);
				}
			}
		}
		aru aru = (A_0.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", "SciFiWarehouseGate", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x060059EE RID: 23022 RVA: 0x0026D66C File Offset: 0x0026B86C
	private void a(aud A_0, ny A_1, cd0 A_2, List<ar7> A_3)
	{
		bool flag = false;
		foreach (ar7 ar in A_3)
		{
			c5x c5x = ar.ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.i.b != null)
			{
				awx awx = new awx("close");
				awx.a(m7.b | m7.k);
				clw clw = new clw();
				clw.a(new e6z(A_0));
				clw.a(true);
				if (c5x.o.b.a.EndsWith("y", StringComparison.OrdinalIgnoreCase))
				{
					clw.a(Axis.X);
				}
				else
				{
					clw.a(Axis.Y);
				}
				clw.a().Add(c5x.Location.a());
				clw.e().Add(c5x.qe());
				dqm dqm = new dqm(c5x.o.b);
				dqm.c(c5x.o.b.b.X);
				dqm.a(false);
				dqm.b(c5x.o.b.b.X);
				dqm.a(-1);
				dqm.a(350.0);
				l6 l = new l6();
				l.a(new ar7(c5x));
				l.a().c(new List<byte>
				{
					0,
					2
				});
				l.a(x3.b);
				l6 l2 = new l6();
				l2.a(new ar7(c5x));
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
				c5x.i.b.a(awx, atp.a, true, true);
				if (!flag && this.f)
				{
					flag = true;
					eym.a(c5x, (double)aju.bx);
				}
			}
		}
		aru aru = (A_1.a8() as c5x).c();
		if (aru != null)
		{
			aru.a("open_close", false);
			aru.a("open_close", "SciFiWarehouseGate", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x04002411 RID: 9233
	private new const int a = 350;

	// Token: 0x04002412 RID: 9234
	private const int b = 4;

	// Token: 0x04002413 RID: 9235
	private List<Guid> c = new List<Guid>();

	// Token: 0x04002414 RID: 9236
	private string d;

	// Token: 0x04002415 RID: 9237
	private bbo e;

	// Token: 0x04002416 RID: 9238
	private bool f;

	// Token: 0x04002417 RID: 9239
	private string g;
}
