using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x020010E6 RID: 4326
[eiz("Q99")]
[Serializable]
public sealed class crx : cze, ISerializable
{
	// Token: 0x06005B4C RID: 23372 RVA: 0x00273DA8 File Offset: 0x00271FA8
	private crx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetString("Q99:AN");
		this.e = (bbo)A_0.GetValue("Q99:O", typeof(bbo));
		di7.ReadList<Guid>("Q99:S", ref this.c, A_0);
		if (ell.a() >= 439)
		{
			this.f = A_0.GetBoolean("Q99:E");
		}
		if (ell.a() >= 581)
		{
			this.g = A_0.GetString("Q99:R");
		}
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x00273E4C File Offset: 0x0027204C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q99:AN", this.d);
		info.AddValue("Q99:O", this.e);
		di7.WriteList<Guid>("Q99:S", this.c, info);
		info.AddValue("Q99:E", this.f);
		info.AddValue("Q99:R", this.g);
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x00273EBC File Offset: 0x002720BC
	public List<Guid> c()
	{
		return this.c;
	}

	// Token: 0x06005B4F RID: 23375 RVA: 0x00273EC4 File Offset: 0x002720C4
	public void a(List<Guid> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B50 RID: 23376 RVA: 0x00273ED0 File Offset: 0x002720D0
	public string d()
	{
		return this.d;
	}

	// Token: 0x06005B51 RID: 23377 RVA: 0x00273ED8 File Offset: 0x002720D8
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B52 RID: 23378 RVA: 0x00273EE4 File Offset: 0x002720E4
	public bbo a()
	{
		return this.e;
	}

	// Token: 0x06005B53 RID: 23379 RVA: 0x00273EEC File Offset: 0x002720EC
	public void a(bbo A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005B54 RID: 23380 RVA: 0x00273EF8 File Offset: 0x002720F8
	public bool e()
	{
		return this.f;
	}

	// Token: 0x06005B55 RID: 23381 RVA: 0x00273F00 File Offset: 0x00272100
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005B56 RID: 23382 RVA: 0x00273F0C File Offset: 0x0027210C
	public string b()
	{
		return this.g;
	}

	// Token: 0x06005B57 RID: 23383 RVA: 0x00273F14 File Offset: 0x00272114
	public void b(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005B58 RID: 23384 RVA: 0x00273F20 File Offset: 0x00272120
	public crx()
	{
	}

	// Token: 0x06005B59 RID: 23385 RVA: 0x00273F34 File Offset: 0x00272134
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
					else if (aspect2.b.X != 5)
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
					if (aspect2.b.X < 3)
					{
						this.a(aspect, aspect2, list);
						return;
					}
					this.a(aud, aspect, aspect2, list);
				}
			}
		}
	}

	// Token: 0x06005B5A RID: 23386 RVA: 0x002740D4 File Offset: 0x002722D4
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

	// Token: 0x06005B5B RID: 23387 RVA: 0x00274180 File Offset: 0x00272380
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
				dqm.c(5 - c5x.o.b.b.X);
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
			aru.a("open_close", "WarehouseGate", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x06005B5C RID: 23388 RVA: 0x002743B0 File Offset: 0x002725B0
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
			aru.a("open_close", "WarehouseGate", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x04002478 RID: 9336
	private new const int a = 350;

	// Token: 0x04002479 RID: 9337
	private const int b = 6;

	// Token: 0x0400247A RID: 9338
	private List<Guid> c = new List<Guid>();

	// Token: 0x0400247B RID: 9339
	private string d;

	// Token: 0x0400247C RID: 9340
	private bbo e;

	// Token: 0x0400247D RID: 9341
	private bool f;

	// Token: 0x0400247E RID: 9342
	private string g;
}
