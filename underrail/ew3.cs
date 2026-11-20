using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020007BF RID: 1983
[eiz("CCUMCTJ")]
[Serializable]
public sealed class ew3 : cze, ISerializable
{
	// Token: 0x060031A3 RID: 12707 RVA: 0x0012FF1C File Offset: 0x0012E11C
	private ew3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CCUMCTJ:R");
		this.b = A_0.GetString("CCUMCTJ:C");
		this.c = A_0.GetString("CCUMCTJ:D");
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x0012FF6C File Offset: 0x0012E16C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCUMCTJ:R", this.a);
		info.AddValue("CCUMCTJ:C", this.b);
		info.AddValue("CCUMCTJ:D", this.c);
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x0012FFB4 File Offset: 0x0012E1B4
	public int b()
	{
		return this.a;
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x0012FFBC File Offset: 0x0012E1BC
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031A7 RID: 12711 RVA: 0x0012FFC8 File Offset: 0x0012E1C8
	public string c()
	{
		return this.b;
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x0012FFD0 File Offset: 0x0012E1D0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x0012FFDC File Offset: 0x0012E1DC
	public string a()
	{
		return this.c;
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x0012FFE4 File Offset: 0x0012E1E4
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x0012FFF0 File Offset: 0x0012E1F0
	public ew3()
	{
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x00130004 File Offset: 0x0012E204
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int)
			{
				this.a--;
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
				{
					this.b
				})) as c5x;
				c5x c5x3 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
				{
					this.b + "_1"
				})) as c5x;
				c5x c5x4 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
				{
					this.b + "_3"
				})) as c5x;
				c5x c5x5 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
				{
					this.b + "_2"
				})) as c5x;
				if (c5x2 != null && c5x3 != null && c5x4 != null && c5x5 != null)
				{
					bmj.a(c5x2, new efj(this.a));
					c5x3.o.b.g = new float?((float)1);
					c5x4.o.b.g = new float?((float)1);
					c5x5.o.b.g = new float?((float)1);
					c5x c5x6 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
					{
						this.c
					})) as c5x;
					if (c5x6 != null)
					{
						cnb cnb = c5x6.s.b as cnb;
						if (cnb != null)
						{
							cnb.d(true);
							d2b aspect = c5x6.GetAspect<d2b>();
							if (aspect != null && aspect.n())
							{
								cid cid = new cid();
								cid.c(true);
								cid.d(false);
								cid.a(new Guid?(c5x6.qe()));
								cid.b(true);
								cid.a(true);
								cid.ym(c5x6, c5x6, null);
							}
						}
					}
					if (this.a >= 9 && this.a <= 12)
					{
						c5x3.ae = new float?((float)1);
						this.a(c5x3, "Electroshock", this.a % 2, 4);
					}
					else if (this.a >= 5 && this.a <= 9)
					{
						this.a(c5x3, "Electroshock", this.a % 2, 4);
						if (this.a % 2 != 0)
						{
							c5x4.ae = new float?((float)1);
							this.a(c5x4, "LaunchElectrobolt", this.a % 3, 8);
						}
					}
					else if (this.a >= 1 && this.a <= 4)
					{
						c5x5.ae = new float?((float)1);
						this.a(c5x3, "Electroshock", this.a % 2, 4);
						if (this.a % 2 != 0)
						{
							c5x4.ae = new float?((float)1);
							this.a(c5x4, "LaunchElectrobolt", this.a % 4, 8);
						}
						this.a(c5x5, "Tazer", this.a % 3, 8);
					}
					if (this.a == 0)
					{
						c5x3.ae = new float?(0f);
						c5x4.ae = new float?(0f);
						c5x5.ae = new float?(0f);
						this.a = cuo.a.Next(14, 23);
						qy qy = new qy();
						if (qy != null)
						{
							qy.b(false);
							qy.c(false);
							ak1 ak = new ak1(c5x2.Area);
							ak.Location = new Point((int)c5x2.Location.X, (int)c5x2.Location.Y);
							dug dug = new dug();
							dug.ty("электромагнитный разряд");
							dug.e(null);
							dug.a(new a1q?(new a1q(DamageType.Electricity, 50, 125)));
							awb awb = new awb(ak, dug, bby.c(), 5f, null);
							awb.r = true;
							awb.a(bby.a());
							awb.b((double)bby.b());
							qy.ad().Add(awb);
							c5x2.Zone.ActionManager.g9(qy, atp.a);
						}
					}
				}
			}
		}
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x00130460 File Offset: 0x0012E660
	public void a(c5x A_0, string A_1, int A_2, int A_3)
	{
		awx awx = new awx();
		if (awx != null)
		{
			awx.b(false);
			awx.c(false);
			bfq bfq = new bfq();
			bfq.c(A_1);
			bfq.a(bvl.c);
			bfq.a((float)cuo.a.Next(3, 8) / 10f);
			awx.ad().Add(new a4s(bfq, null, new ar7(A_0), null));
			for (int i = 0; i < 8; i++)
			{
				if (A_2 == 0 && A_3 == 4)
				{
					awx.ad().Add(new a4s(new cm5(0), null, new ar7(A_0), null));
					if (i <= 3)
					{
						awx.ad().Add(new a4s(new rp(i), null, new ar7(A_0), null));
					}
					else
					{
						awx.ad().Add(new a4s(new rp(i - 4), null, new ar7(A_0), null));
					}
				}
				else if (A_2 == 0)
				{
					awx.ad().Add(new a4s(new cm5(0), null, new ar7(A_0), null));
					awx.ad().Add(new a4s(new rp(i), null, new ar7(A_0), null));
				}
				else if (A_2 != 0)
				{
					awx.ad().Add(new a4s(new cm5(1), null, new ar7(A_0), null));
					awx.ad().Add(new a4s(new rp(i), null, new ar7(A_0), null));
				}
				awx.ad().Add(new bm3(cuo.a.Next(115, 125)));
			}
			if (A_3 == 8)
			{
				List<auv> list = awx.ad();
				ch3 ch = new ch3();
				ch.a(new float?(0f));
				ch.a(new Guid?(A_0.qe()));
				list.Add(new a4s(ch, null, new ar7(A_0), null));
			}
			A_0.Zone.ActionManager.g9(awx, atp.a);
		}
	}

	// Token: 0x04001AB8 RID: 6840
	private new int a = 10;

	// Token: 0x04001AB9 RID: 6841
	private string b;

	// Token: 0x04001ABA RID: 6842
	private string c;
}
