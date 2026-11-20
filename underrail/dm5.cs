using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001107 RID: 4359
[eiz("J01")]
[Serializable]
public sealed class dm5 : cze
{
	// Token: 0x06005C73 RID: 23667 RVA: 0x00278254 File Offset: 0x00276454
	private dm5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("J01:S");
		this.b = A_0.GetString("J01:E");
		di7.ReadList<a1q>("J01:D", ref this.c, A_0);
		if (ell.a() >= 105)
		{
			this.e = A_0.GetInt32("J01:L");
		}
		if (ell.a() >= 107)
		{
			this.d = A_0.GetBoolean("J01:F");
		}
		else
		{
			this.d = true;
		}
		if (ell.a() >= 142)
		{
			this.f = A_0.GetString("J01:A");
			this.g = A_0.GetString("J01:AF");
		}
		if (ell.a() >= 147)
		{
			this.h = A_0.GetDouble("J01:C");
		}
		if (ell.a() >= 219)
		{
			this.i = (A_0.GetValue("J01:P", typeof(PropertyCollection)) as PropertyCollection);
		}
		else
		{
			this.i = new PropertyCollection();
		}
		if (ell.a() >= 220)
		{
			di7.ReadList<enp>("J01:B", ref this.j, A_0);
			this.k = (A_0.GetValue("J01:R", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		}
		else
		{
			this.j = new List<enp>();
		}
		if (ell.a() >= 263)
		{
			this.l = A_0.GetInt32("J01:RD");
		}
		else
		{
			this.l = 3;
		}
		if (ell.a() >= 300)
		{
			this.m = (A_0.GetValue("J01:N", typeof(float?)) as float?);
		}
		if (ell.a() >= 504)
		{
			this.n = (A_0.GetValue("J01:AM", typeof(AmmoType?)) as AmmoType?);
		}
		if (ell.a() >= 524)
		{
			this.o = A_0.GetBoolean("J01:UV");
		}
		if (ell.a() >= 600)
		{
			this.p = A_0.GetBoolean("J01:SCB");
		}
		if (ell.a() >= 611)
		{
			this.q = A_0.GetBoolean("J01:SF");
			this.r = A_0.GetInt32("J01:MF");
			this.s = A_0.GetInt32("J01:XF");
		}
		if (ell.a() >= 612)
		{
			this.a(A_0.GetSingle("J01:BC"));
			this.b(A_0.GetSingle("J01:BA"));
		}
		if (ell.a() >= 616)
		{
			this.a(A_0.GetBoolean("J01:TR"));
		}
		if (ell.a() >= 658)
		{
			this.w = (A_0.GetValue("J01:AA", typeof(Action<cwt, amc, float>)) as Action<cwt, amc, float>);
			this.x = (A_0.GetValue("J01:AX", typeof(Action<cwt, cru, amc, float>)) as Action<cwt, cru, amc, float>);
		}
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x002785C8 File Offset: 0x002767C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("J01:S", this.a);
		info.AddValue("J01:E", this.b);
		di7.WriteList<a1q>("J01:D", this.c, info);
		info.AddValue("J01:L", this.e);
		info.AddValue("J01:F", this.d);
		info.AddValue("J01:A", this.f);
		info.AddValue("J01:AF", this.g);
		info.AddValue("J01:C", this.h);
		info.AddValue("J01:P", this.i);
		di7.WriteList<enp>("J01:B", this.j, info);
		info.AddValue("J01:R", this.k);
		info.AddValue("J01:RD", this.l);
		info.AddValue("J01:N", this.m);
		info.AddValue("J01:AM", this.n);
		info.AddValue("J01:UV", this.o);
		info.AddValue("J01:SCB", this.p);
		info.AddValue("J01:SF", this.q);
		info.AddValue("J01:MF", this.r);
		info.AddValue("J01:XF", this.s);
		info.AddValue("J01:BC", this.g());
		info.AddValue("J01:BA", this.j());
		info.AddValue("J01:TR", this.h());
		info.AddValue("J01:AA", this.w);
		info.AddValue("J01:AX", this.x);
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x00278780 File Offset: 0x00276980
	[CompilerGenerated]
	public float g()
	{
		return this.t;
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x00278788 File Offset: 0x00276988
	[CompilerGenerated]
	public void a(float A_0)
	{
		this.t = A_0;
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x00278794 File Offset: 0x00276994
	[CompilerGenerated]
	public float j()
	{
		return this.u;
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x0027879C File Offset: 0x0027699C
	[CompilerGenerated]
	public void b(float A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x002787A8 File Offset: 0x002769A8
	[CompilerGenerated]
	public bool h()
	{
		return this.v;
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x002787B0 File Offset: 0x002769B0
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.v = A_0;
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x002787BC File Offset: 0x002769BC
	public string k()
	{
		return this.a;
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x002787C4 File Offset: 0x002769C4
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x002787D0 File Offset: 0x002769D0
	public string m()
	{
		return this.b;
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x002787D8 File Offset: 0x002769D8
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x002787E4 File Offset: 0x002769E4
	public List<a1q> s()
	{
		return this.c;
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x002787EC File Offset: 0x002769EC
	public void a(List<a1q> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x002787F8 File Offset: 0x002769F8
	public int q()
	{
		return this.e;
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x00278800 File Offset: 0x00276A00
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x0027880C File Offset: 0x00276A0C
	public bool e()
	{
		return this.d;
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x00278814 File Offset: 0x00276A14
	public void d(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x00278820 File Offset: 0x00276A20
	public string v()
	{
		return this.f;
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x00278828 File Offset: 0x00276A28
	public void d(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x00278834 File Offset: 0x00276A34
	public string d()
	{
		return this.g;
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x0027883C File Offset: 0x00276A3C
	public void a(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x00278848 File Offset: 0x00276A48
	public double p()
	{
		return this.h;
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x00278850 File Offset: 0x00276A50
	public void a(double A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x0027885C File Offset: 0x00276A5C
	public PropertyCollection i()
	{
		return this.i;
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x00278864 File Offset: 0x00276A64
	public List<enp> f()
	{
		return this.j;
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x0027886C File Offset: 0x00276A6C
	public EntityAspectReference<amc, amc> w()
	{
		return this.k;
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x00278874 File Offset: 0x00276A74
	public void a(EntityAspectReference<amc, amc> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x00278880 File Offset: 0x00276A80
	public int l()
	{
		return this.l;
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x00278888 File Offset: 0x00276A88
	public void a(int A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x00278894 File Offset: 0x00276A94
	public float? t()
	{
		return this.m;
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x0027889C File Offset: 0x00276A9C
	public void a(float? A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x002788A8 File Offset: 0x00276AA8
	public AmmoType? c()
	{
		return this.n;
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x002788B0 File Offset: 0x00276AB0
	public void a(AmmoType? A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x002788BC File Offset: 0x00276ABC
	public bool b()
	{
		return this.o;
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x002788C4 File Offset: 0x00276AC4
	public void c(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x002788D0 File Offset: 0x00276AD0
	public bool u()
	{
		return this.p;
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x002788D8 File Offset: 0x00276AD8
	public void b(bool A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x002788E4 File Offset: 0x00276AE4
	public bool n()
	{
		return this.q;
	}

	// Token: 0x06005C9A RID: 23706 RVA: 0x002788EC File Offset: 0x00276AEC
	public void e(bool A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x002788F8 File Offset: 0x00276AF8
	public int o()
	{
		return this.r;
	}

	// Token: 0x06005C9C RID: 23708 RVA: 0x00278900 File Offset: 0x00276B00
	public void c(int A_0)
	{
		this.r = A_0;
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x0027890C File Offset: 0x00276B0C
	public int r()
	{
		return this.s;
	}

	// Token: 0x06005C9E RID: 23710 RVA: 0x00278914 File Offset: 0x00276B14
	public void d(int A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x00278920 File Offset: 0x00276B20
	public dm5()
	{
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x00278984 File Offset: 0x00276B84
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			ak1 ak = A_1.Area.a(A_1.aj().a());
			if (ak != null)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				b0b b0b = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(dm5.b.a.a)));
				if (b0b != null)
				{
					bfq bfq = new bfq();
					bfq.b(Guid.NewGuid().ToString());
					bfq.c(this.a);
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(b0b), null));
					float num;
					if (this.m != null)
					{
						num = this.m.Value;
					}
					else
					{
						num = aju.a2;
					}
					if (num > 0f)
					{
						eym.a(qy, b0b as c5x, (double)num);
					}
				}
				if (this.e > 0)
				{
					qy.ad().Add(new bm3(dz6.b(this.e)));
				}
				blv blv = this.a();
				cwt a_ = null;
				if (A_2 != null && A_2.ContainsKey("killingBlow"))
				{
					a_ = (A_2["killingBlow"] as cwt);
				}
				awb awb = new awb(ak, new dm5.a(this, A_1.y8(), a_), new ae8?(blv.a.Light), (float)this.l, null, null, false);
				awb.b(100.0);
				awb.c(blv.b);
				awb.b(blv.c);
				awb.a(blv.d);
				awb.r = this.o;
				awb.s = this.p;
				qy.ad().Add(awb);
				if (b0b != null && this.d)
				{
					eu8 item = new eu8(b0b as c5x, d8o.g, ak, 8, d0u.b * 2, null);
					qy.ad().Add(item);
				}
				A_1.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x00278BD8 File Offset: 0x00276DD8
	private blv a()
	{
		return new blv
		{
			a = new ah7("explosionJobLantern", null),
			a = 
			{
				LightFadeRate = 0.15f,
				Range = 5f,
				Light = new ae8(Color.White, 1f, LightType.Increment)
			},
			b = 0.2f,
			c = 0.15f,
			d = (float)(this.l + 4)
		};
	}

	// Token: 0x040024DC RID: 9436
	private new string a = "HeGrenadeExplode";

	// Token: 0x040024DD RID: 9437
	private string b = "ScorchGround";

	// Token: 0x040024DE RID: 9438
	private List<a1q> c = new List<a1q>();

	// Token: 0x040024DF RID: 9439
	private bool d;

	// Token: 0x040024E0 RID: 9440
	private int e;

	// Token: 0x040024E1 RID: 9441
	private string f;

	// Token: 0x040024E2 RID: 9442
	private string g;

	// Token: 0x040024E3 RID: 9443
	private double h;

	// Token: 0x040024E4 RID: 9444
	private PropertyCollection i = new PropertyCollection();

	// Token: 0x040024E5 RID: 9445
	private List<enp> j = new List<enp>();

	// Token: 0x040024E6 RID: 9446
	private EntityAspectReference<amc, amc> k;

	// Token: 0x040024E7 RID: 9447
	private int l = 3;

	// Token: 0x040024E8 RID: 9448
	private float? m;

	// Token: 0x040024E9 RID: 9449
	private AmmoType? n;

	// Token: 0x040024EA RID: 9450
	private bool o;

	// Token: 0x040024EB RID: 9451
	private bool p;

	// Token: 0x040024EC RID: 9452
	private bool q;

	// Token: 0x040024ED RID: 9453
	private int r;

	// Token: 0x040024EE RID: 9454
	private int s = 4;

	// Token: 0x040024EF RID: 9455
	[CompilerGenerated]
	private float t;

	// Token: 0x040024F0 RID: 9456
	[CompilerGenerated]
	private float u = 1f;

	// Token: 0x040024F1 RID: 9457
	[CompilerGenerated]
	private bool v;

	// Token: 0x040024F2 RID: 9458
	public Action<cwt, amc, float> w;

	// Token: 0x040024F3 RID: 9459
	public Action<cwt, cru, amc, float> x;

	// Token: 0x02001108 RID: 4360
	[eiz("A05")]
	[Serializable]
	private new sealed class a : cci, ISerializable
	{
		// Token: 0x06005CA2 RID: 23714 RVA: 0x00278C5C File Offset: 0x00276E5C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("A05:P", typeof(dm5)) as dm5);
			this.b = A_0.GetString("A05:A");
			di7.ReadList<Guid>("A05:E", ref this.c, A_0);
			if (ell.a() >= 467)
			{
				this.d = (A_0.GetValue("A05:O", typeof(cwt)) as cwt);
			}
			if (ell.a() >= 600)
			{
				this.e = (A_0.GetValue("A05:ES", typeof(Point?)) as Point?);
			}
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00278D20 File Offset: 0x00276F20
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("A05:P", this.a);
			info.AddValue("A05:A", this.b);
			di7.WriteList<Guid>("A05:E", this.c, info);
			info.AddValue("A05:O", this.d);
			info.AddValue("A05:ES", this.e);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x00278D88 File Offset: 0x00276F88
		public a(dm5 A_0, string A_1, cwt A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.d = A_2;
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x00278DB4 File Offset: 0x00276FB4
		public void cq(aud A_0, Point A_1, float A_2)
		{
			c5x c5x;
			if (string.IsNullOrWhiteSpace(this.a.b) || this.a.m() == "ScorchGround")
			{
				if (A_2 == 0f)
				{
					this.e = new Point?(A_1);
				}
				c5x = boj.a(A_2, A_0, (this.e != null) ? this.e.Value : A_1, A_1);
			}
			else
			{
				Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_2 = null;
				string a_3 = this.a.b;
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? a_5 = dz6.b();
				c5x = boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
			}
			if (this.a.h() && c5x != null)
			{
				new ah7("explosionJobLantern", null)
				{
					Light = new ae8(Color.White, 0.25f, LightType.Increment),
					LightFadeRate = 0.1f,
					Range = 2f
				}.g().be(c5x);
				if (cuo.a.NextDouble() < 0.4000000059604645)
				{
					c5x.c().a("novaTravel", "TravelingFireNova", 1f, c9z.a, true, false);
				}
			}
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x2 = b0b as c5x;
					if (c5x2 != null)
					{
						if (c5x2.h.b != null && !this.c.Contains(b0b.qe()))
						{
							this.a(c5x2.h.b, A_2);
							this.c.Add(c5x2.qe());
						}
						if (c5x2.y.b != null)
						{
							c5x2.y.b.a(null);
							this.c.Add(c5x2.qe());
						}
					}
				}
				if (this.a.q && this.a.s > this.a.r && aw1.b(ak))
				{
					int num = cuo.a.Next(this.a.r, this.a.s + 1);
					dd5.a(null, ak, (double)num, int.MaxValue, false);
				}
			}
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x00279090 File Offset: 0x00277290
		private void a(amc A_0, float A_1)
		{
			if (this.a.s().Count > 0)
			{
				cwt cwt = new cwt();
				double num;
				if (A_1 > 1f && this.a.h != 0.0)
				{
					num = Math.Min(c18.az, (double)(A_1 - 1f) * this.a.h);
				}
				else
				{
					num = 0.0;
				}
				foreach (a1q a_ in this.a.s())
				{
					cwt.f.Add(euf.a(a_, 1.0 - num));
				}
				string a_2;
				if (this.a.g == "*")
				{
					if (this.d != null && this.d.i != null)
					{
						a_2 = this.d.i.b;
					}
					else
					{
						a_2 = "";
					}
				}
				else
				{
					a_2 = this.a.g;
				}
				cwt.i = new ap9(this.a.f, a_2);
				cwt.b = true;
				cwt.q = true;
				cwt.h = ImpactSpeed.High;
				cwt.ad = this.a.i.Clone();
				cwt.ad["IsExplosion"] = true;
				if (this.a.n != null)
				{
					cwt.x = this.a.n.Value;
				}
				Action<cwt, amc, float> w = this.a.w;
				if (w != null)
				{
					w(cwt, A_0, A_1);
				}
				cru cru = A_0.aa().Defense.a(cwt);
				Action<cwt, cru, amc, float> x = this.a.x;
				if (x != null)
				{
					x(cwt, cru, A_0, A_1);
				}
				if (a_2 == asp.a)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
					{
						awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0.a8(), false, false, true, true, false, false);
					}
				}
				if (cru != null && cru.a != null && this.a.g() > 0f && this.a.j() > 0f && cuo.a.NextDouble() < (double)this.a.g())
				{
					int num2 = 3;
					int num3 = Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(dm5.a.a.a.b)), new Func<csk, int>(dm5.a.a.a.a));
					if (num3 > 0)
					{
						awq.a(A_0, true);
					}
					if (num3 > num2)
					{
						if (A_0.aa().d(CharacterImmunities.Burning))
						{
							etm a_3 = new etm(new ap9(A_0.aa()), "burning");
							bey.a(a_3, cwt, A_0);
							a7v.a(a_3);
							bmj.a(A_0.a8(), new ba0());
						}
						else
						{
							int a_4 = Math.Max(1, Convert.ToInt32((float)num3 * this.a.j()) / num2);
							bk9 bk = Enumerable.FirstOrDefault<bk9>(A_0.aa().StatusEffects.Get<bk9>());
							if (bk != null)
							{
								dd5.a(bk, cwt.i, a_4, num2 * d0u.b);
							}
							else
							{
								bk = new bk9(cwt.i, num2 * d0u.b, a_4, false);
								A_0.aa().StatusEffects.a(bk, false, false, false);
								dd5.a(A_0.aa());
							}
						}
					}
				}
				foreach (enp enp in this.a.j)
				{
					enp.af((this.a.k != null) ? this.a.k.ao() : null, A_0, cwt, cru);
				}
			}
		}

		// Token: 0x040024F4 RID: 9460
		private dm5 a;

		// Token: 0x040024F5 RID: 9461
		private string b;

		// Token: 0x040024F6 RID: 9462
		private List<Guid> c = new List<Guid>();

		// Token: 0x040024F7 RID: 9463
		private cwt d;

		// Token: 0x040024F8 RID: 9464
		private Point? e;

		// Token: 0x0200110A RID: 4362
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06005CAA RID: 23722 RVA: 0x00279554 File Offset: 0x00277754
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Heat;
			}

			// Token: 0x06005CAB RID: 23723 RVA: 0x00279560 File Offset: 0x00277760
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040024F9 RID: 9465
			public static readonly dm5.a.a a = new dm5.a.a();

			// Token: 0x040024FA RID: 9466
			public static Func<csk, bool> b;

			// Token: 0x040024FB RID: 9467
			public static Func<csk, int> c;
		}
	}

	// Token: 0x0200110B RID: 4363
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06005CAE RID: 23726 RVA: 0x00279580 File Offset: 0x00277780
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040024FC RID: 9468
		public static readonly dm5.b a = new dm5.b();

		// Token: 0x040024FD RID: 9469
		public static Func<b0b, bool> b;
	}
}
