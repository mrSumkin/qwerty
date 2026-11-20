using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x020010AC RID: 4268
[eiz("Q94")]
[Serializable]
public sealed class esv : cze, ISerializable
{
	// Token: 0x06005999 RID: 22937 RVA: 0x0026B300 File Offset: 0x00269500
	private esv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetString("Q94:AN");
		this.e = (bbo)A_0.GetValue("Q94:O", typeof(bbo));
		di7.ReadList<Guid>("Q94:S", ref this.c, A_0);
		if (ell.a() >= 439)
		{
			this.f = A_0.GetBoolean("Q94:E");
		}
		if (ell.a() >= 581)
		{
			this.g = A_0.GetString("Q94:R");
		}
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x0026B3A4 File Offset: 0x002695A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q94:AN", this.d);
		info.AddValue("Q94:O", this.e);
		di7.WriteList<Guid>("Q94:S", this.c, info);
		info.AddValue("Q94:E", this.f);
		info.AddValue("Q94:R", this.g);
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x0026B414 File Offset: 0x00269614
	public List<Guid> c()
	{
		return this.c;
	}

	// Token: 0x0600599C RID: 22940 RVA: 0x0026B41C File Offset: 0x0026961C
	public void a(List<Guid> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600599D RID: 22941 RVA: 0x0026B428 File Offset: 0x00269628
	public string d()
	{
		return this.d;
	}

	// Token: 0x0600599E RID: 22942 RVA: 0x0026B430 File Offset: 0x00269630
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600599F RID: 22943 RVA: 0x0026B43C File Offset: 0x0026963C
	public bbo a()
	{
		return this.e;
	}

	// Token: 0x060059A0 RID: 22944 RVA: 0x0026B444 File Offset: 0x00269644
	public void a(bbo A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060059A1 RID: 22945 RVA: 0x0026B450 File Offset: 0x00269650
	public bool e()
	{
		return this.f;
	}

	// Token: 0x060059A2 RID: 22946 RVA: 0x0026B458 File Offset: 0x00269658
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060059A3 RID: 22947 RVA: 0x0026B464 File Offset: 0x00269664
	public string b()
	{
		return this.g;
	}

	// Token: 0x060059A4 RID: 22948 RVA: 0x0026B46C File Offset: 0x0026966C
	public void b(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060059A5 RID: 22949 RVA: 0x0026B478 File Offset: 0x00269678
	public esv()
	{
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x0026B48C File Offset: 0x0026968C
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
			alv aspect2 = list[0].ao().GetAspect<alv>();
			if (aspect != null && aspect2 != null && aspect2.a.Count > 0)
			{
				if (this.e == bbo.b)
				{
					if (aspect.a() != null)
					{
						if (aspect.a().Name != "open")
						{
							this.a(aspect, list);
							return;
						}
					}
					else if (aspect2.a[0].b.X != 5)
					{
						this.a(aspect, list);
						return;
					}
				}
				else if (this.e == bbo.c)
				{
					if (aspect.a() != null)
					{
						if (aspect.a().Name != "close")
						{
							this.a(aud, aspect, list);
							return;
						}
					}
					else if (aspect2.a[0].b.X != 0)
					{
						this.a(aud, aspect, list);
						return;
					}
				}
				else if (aspect.a() != null)
				{
					if (aspect.a().Name == "open")
					{
						this.a(aud, aspect, list);
						return;
					}
					this.a(aspect, list);
					return;
				}
				else
				{
					if (aspect2.a[0].b.X < 3)
					{
						this.a(aspect, list);
						return;
					}
					this.a(aud, aspect, list);
				}
			}
		}
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x0026B658 File Offset: 0x00269858
	public bool a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		List<ar7> list = b6q.a(b6q.a(A_0, A_1, A_2, this.d), this.g, this.c);
		if (list[0].ao() != null)
		{
			alv aspect = list[0].ao().GetAspect<alv>();
			ny aspect2 = list[0].ao().GetAspect<ny>();
			if (aspect2 != null)
			{
				if (aspect2.a() != null)
				{
					return aspect2.a().Name == "close";
				}
				if (aspect != null && aspect.a.Count > 0)
				{
					return aspect.a[0].b.X == 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x0026B714 File Offset: 0x00269914
	private void a(ny A_0, List<ar7> A_1)
	{
		bool flag = false;
		foreach (ar7 ar in A_1)
		{
			c5x c5x = ar.ao() as c5x;
			if (c5x != null && c5x.p.b != null && c5x.i.b != null)
			{
				awx awx = new awx("open");
				awx.a(m7.b | m7.k);
				ddg ddg = new ddg(c5x.p.b);
				ddg.c(5 - c5x.p.b.a[0].b.X);
				ddg.a(true);
				ddg.b(c5x.p.b.a[0].b.X);
				ddg.a(1);
				ddg.a(350.0);
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
				awx.ad().Add(ddg);
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

	// Token: 0x060059A9 RID: 22953 RVA: 0x0026B95C File Offset: 0x00269B5C
	private void a(aud A_0, ny A_1, List<ar7> A_2)
	{
		bool flag = false;
		foreach (ar7 ar in A_2)
		{
			c5x c5x = ar.ao() as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count > 0 && c5x.i.b != null)
			{
				awx awx = new awx("close");
				awx.a(m7.b | m7.k);
				clw clw = new clw();
				clw.a(new e6z(A_0));
				clw.a(true);
				if (c5x.p.b.a[0].a.EndsWith("y", StringComparison.OrdinalIgnoreCase))
				{
					clw.a(Axis.X);
				}
				else
				{
					clw.a(Axis.Y);
				}
				clw.a().Add(c5x.Location.a());
				clw.e().Add(c5x.qe());
				ddg ddg = new ddg(c5x.p.b);
				ddg.c(c5x.p.b.a[0].b.X);
				ddg.a(false);
				ddg.b(c5x.p.b.a[0].b.X);
				ddg.a(-1);
				ddg.a(350.0);
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
				awx.ad().Add(ddg);
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

	// Token: 0x040023FC RID: 9212
	private new const int a = 350;

	// Token: 0x040023FD RID: 9213
	private const int b = 6;

	// Token: 0x040023FE RID: 9214
	private List<Guid> c = new List<Guid>();

	// Token: 0x040023FF RID: 9215
	private string d;

	// Token: 0x04002400 RID: 9216
	private bbo e;

	// Token: 0x04002401 RID: 9217
	private bool f;

	// Token: 0x04002402 RID: 9218
	private string g;
}
