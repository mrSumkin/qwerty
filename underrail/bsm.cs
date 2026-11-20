using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000F79 RID: 3961
[eiz("TDCEA")]
[Serializable]
public sealed class bsm : Aspect<c5x>, bp1, cmm, chb
{
	// Token: 0x06005094 RID: 20628 RVA: 0x00243730 File Offset: 0x00241930
	private bsm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.h = A_0.GetDouble("TDCEA:A");
		this.i = (bsm.c)A_0.GetValue("TDCEA:B", typeof(bsm.c));
		this.j = A_0.GetInt32("TDCEA:C");
		this.k = A_0.GetInt32("TDCEA:D");
		this.l = A_0.GetInt32("TDCEA:F");
		this.m = (TimeSpan?)A_0.GetValue("TDCEA:G", typeof(TimeSpan?));
		this.n = (TimeSpan?)A_0.GetValue("TDCEA:L", typeof(TimeSpan?));
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x002437F8 File Offset: 0x002419F8
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("TDCEA:A", this.h);
		info.AddValue("TDCEA:B", this.i);
		info.AddValue("TDCEA:C", this.j);
		info.AddValue("TDCEA:D", this.k);
		info.AddValue("TDCEA:F", this.l);
		info.AddValue("TDCEA:G", this.m);
		info.AddValue("TDCEA:L", this.n);
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x00243894 File Offset: 0x00241A94
	static bsm()
	{
		bsm.c = new bsm.b[3][];
		bsm.b[][] array = bsm.c;
		int num = 0;
		bsm.b[] array2 = new bsm.b[7];
		array2[0] = new bsm.b("a1", null, null, null, null);
		int num2 = 1;
		string a_ = "a2";
		int? a_2 = null;
		int? num3 = null;
		array2[num2] = new bsm.b(a_, a_2, num3, null, null);
		int num4 = 2;
		string a_3 = "a3";
		num3 = new int?(5);
		array2[num4] = new bsm.b(a_3, null, num3, null, null);
		array2[3] = new bsm.b("a4", new int?(3), new int?(5), new Guid?(new Guid("ced96a6d-1612-4299-af8c-a738a22e1386")), new Guid?(new Guid("2c1ee32b-79ee-4e29-b59a-0abb17896035")));
		array2[4] = new bsm.b("a5", new int?(3), null, null, null);
		array2[5] = new bsm.b("a6", null, null, null, null);
		array2[6] = new bsm.b("a7", null, null, null, null);
		array[num] = array2;
		bsm.b[][] array3 = bsm.c;
		int num5 = 1;
		bsm.b[] array4 = new bsm.b[11];
		array4[0] = new bsm.b("a1", null, null, null, null);
		array4[1] = new bsm.b("a2", null, null, null, null);
		int num6 = 2;
		string a_4 = "a3";
		int? a_5 = null;
		num3 = null;
		int? a_6 = num3;
		Guid? a_7 = null;
		Guid? guid = null;
		array4[num6] = new bsm.b(a_4, a_5, a_6, a_7, guid);
		int num7 = 3;
		string a_8 = "b1";
		num3 = new int?(6);
		guid = new Guid?(new Guid("26c4da33-2c87-43ba-9bca-edc8e5775381"));
		array4[num7] = new bsm.b(a_8, null, num3, null, guid);
		int num8 = 4;
		string a_9 = "b2";
		int? a_10 = new int?(4);
		int? a_11 = new int?(6);
		guid = new Guid?(new Guid("d69f1847-e35e-471c-905b-37a34e20c549"));
		array4[num8] = new bsm.b(a_9, a_10, a_11, null, guid);
		array4[5] = new bsm.b("b3", new int?(4), null, null, null);
		array4[6] = new bsm.b("b4", null, null, null, null);
		array4[7] = new bsm.b("b5", null, null, null, null);
		array4[8] = new bsm.b("a5", null, null, null, null);
		array4[9] = new bsm.b("a6", null, null, null, null);
		array4[10] = new bsm.b("a7", null, null, null, null);
		array3[num5] = array4;
		bsm.b[][] array5 = bsm.c;
		int num9 = 2;
		bsm.b[] array6 = new bsm.b[13];
		array6[0] = new bsm.b("a1", null, null, null, null);
		array6[1] = new bsm.b("a2", null, null, null, null);
		array6[2] = new bsm.b("a3", null, null, null, null);
		int num10 = 3;
		string a_12 = "b1";
		int? a_13 = null;
		int? a_14 = null;
		Guid? a_15 = null;
		guid = null;
		array6[num10] = new bsm.b(a_12, a_13, a_14, a_15, guid);
		int num11 = 4;
		string a_16 = "c1";
		guid = new Guid?(new Guid("e0c7f748-a86b-4d28-87b8-7edbd1d09820"));
		array6[num11] = new bsm.b(a_16, null, null, null, guid);
		int num12 = 5;
		string a_17 = "c2";
		int? a_18 = null;
		int? a_19 = null;
		Guid? a_20 = null;
		guid = null;
		array6[num12] = new bsm.b(a_17, a_18, a_19, a_20, guid);
		int num13 = 6;
		string a_21 = "c3";
		guid = new Guid?(new Guid("4d2e32cd-3ef0-46d0-83d2-00b66a149215"));
		array6[num13] = new bsm.b(a_21, null, null, guid, null);
		array6[7] = new bsm.b("c4", null, null, null, null);
		array6[8] = new bsm.b("b4", null, null, null, null);
		array6[9] = new bsm.b("b5", null, null, null, null);
		array6[10] = new bsm.b("a5", null, null, null, null);
		array6[11] = new bsm.b("a6", null, null, null, null);
		array6[12] = new bsm.b("a7", null, null, null, null);
		array5[num9] = array6;
		bsm.d = new List<Guid>
		{
			new Guid("38a5193a-8b47-4987-bef8-b9005ff6a51b"),
			new Guid("1b75e17f-2e49-4ae1-9172-53eb6f366c1d"),
			new Guid("873068a6-b78a-4450-9d1c-626d4c547415"),
			new Guid("d1444d68-d089-48ea-862a-c437eade980e")
		};
	}

	// Token: 0x06005097 RID: 20631 RVA: 0x00243F84 File Offset: 0x00242184
	public bsm(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005098 RID: 20632 RVA: 0x00243F9C File Offset: 0x0024219C
	public void c9(TimeSpan A_0)
	{
		if (A_0 > bsm.g)
		{
			foreach (Guid a_ in bsm.d)
			{
				c5x c5x = new ar7(a_, base.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					aw aspect = c5x.GetAspect<aw>();
					if (aspect != null)
					{
						aspect.b(true);
					}
				}
			}
			if (this.i != bsm.c.f)
			{
				c5x c5x2 = new ar7(bsm.a, base.a8().Area).ao() as c5x;
				if (c5x2 == null)
				{
					return;
				}
				c5x2.k();
				if (c5x2.h.b == null || c5x2.k.b == null || c5x2.i.b == null || c5x2.t.b == null)
				{
					return;
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_metAgain", new bool?(false)).Value)
				{
					bool flag = (double)((int)serviceOrThrow.aqu().o().TotalMinutes) % (bsm.e.TotalMinutes + bsm.f.TotalMinutes) < bsm.e.TotalMinutes;
					if (flag && this.i == bsm.c.a)
					{
						c5x2.i.b.a(true, false);
						c5x2.t.b.y6()[ddq.ay] = null;
						c5x2.t.b.t();
						this.i = bsm.c.d;
						a0l.a(c5x2, "jogStart", true);
						this.k = 1;
						this.j = 0;
						this.l = 0;
						return;
					}
					if (!flag && this.i != bsm.c.a)
					{
						c5x2.i.b.a(true, false);
						c5x2.t.b.y6()[ddq.ay] = null;
						c5x2.t.b.t();
						this.i = bsm.c.a;
						a0l.a(c5x2, "toddRest", true);
					}
				}
			}
		}
	}

	// Token: 0x06005099 RID: 20633 RVA: 0x0024420C File Offset: 0x0024240C
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x0600509A RID: 20634 RVA: 0x00244210 File Offset: 0x00242410
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.h += A_0.b.TotalMilliseconds) >= (double)bsm.b)
			{
				this.h -= (double)bsm.b;
				this.b();
				return;
			}
		}
		else
		{
			this.h = 0.0;
		}
	}

	// Token: 0x0600509B RID: 20635 RVA: 0x00244278 File Offset: 0x00242478
	public void c()
	{
		this.b();
		this.h = 0.0;
	}

	// Token: 0x0600509C RID: 20636 RVA: 0x00244290 File Offset: 0x00242490
	public void mx()
	{
	}

	// Token: 0x0600509D RID: 20637 RVA: 0x00244294 File Offset: 0x00242494
	public void my()
	{
	}

	// Token: 0x0600509E RID: 20638 RVA: 0x0024429C File Offset: 0x0024249C
	private void b()
	{
		bsm.a a = new bsm.a();
		c5x c5x = new ar7(bsm.a, base.a8().Area).ao() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.k.b == null || c5x.i.b == null || c5x.t.b == null)
		{
			return;
		}
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a.aqu() == null)
		{
			return;
		}
		if (this.i != bsm.c.f)
		{
			if (a.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_afraid", new bool?(false)).Value)
			{
				c5x.i.b.a(true, false);
				c5x.t.b.y6()[ddq.ay] = null;
				c5x.t.b.t();
				this.i = bsm.c.f;
				return;
			}
			cky cky = (a.a.aqu().ac() as bv9).abu(asp.a, asp.f3);
			if (cky != null && cky.a <= global::h.b)
			{
				c5x.i.b.a(true, false);
				c5x.t.b.y6()[ddq.ay] = null;
				c5x.t.b.t();
				this.i = bsm.c.f;
				a.a.aqu().r()["npc_xpbl_as_todd_afraid"] = true;
				return;
			}
		}
		if (this.i == bsm.c.a || this.i == bsm.c.b || this.i == bsm.c.f)
		{
			if (this.i == bsm.c.a || this.i == bsm.c.b)
			{
				c5x.h.b.@as = null;
				c5x.h.b.ap = null;
			}
			b18 b = new b18();
			b.b("todd");
			b.c("PantingLoopMale");
			b.a(new Guid?(c5x.qe()));
			b.a("xpbl_ds2");
			b.ym(c5x, null, null);
			this.o = false;
		}
		else
		{
			c5x.h.b.@as = new CharacterState?(CharacterState.Custom1);
			c5x.h.b.ap = new CharacterState?(CharacterState.Custom3);
			if (!this.o)
			{
				bfq bfq = new bfq("todd", "PantingLoopMale");
				bfq.a(false);
				bfq.a(c9z.a);
				bfq.d(true);
				bfq.a("xpbl_ds2");
				bfq.a(new Guid?(c5x.qe()));
				bfq.a(0.3f);
				bfq.ym(c5x, null, null);
				this.o = true;
			}
		}
		if (this.i == bsm.c.e)
		{
			c5x.t.b.y6()[ddq.ay] = null;
			c5x.t.b.y6()[ddq.az] = null;
			if (this.m == null)
			{
				this.i = bsm.c.d;
			}
			else
			{
				if (!(c5x.Zone.ElapsedZoneTime >= this.m.Value))
				{
					return;
				}
				this.i = bsm.c.d;
				this.m = new TimeSpan?(base.a8().Zone.ElapsedZoneTime + TimeSpan.FromSeconds(2.0));
			}
		}
		c5x.t.b.y6()[ddq.b1] = null;
		if (this.i == bsm.c.f)
		{
			c5x.h.b.@as = new CharacterState?(CharacterState.Custom4);
			c5x.h.b.ap = null;
			c5x.h.b.aa().BaseMovementSpeed = 1.5f;
			c5x.h.b.aa().bl();
			c5x.t.b.y6()[ddq.az] = null;
			if (a.a.aqu() != null && a.a.aqu().v() != null && a.a.aqu().v().b() != null && a.a.aqu().v().b().j == cgy.b && c5x.t.b.b(a.a.aqu().v().b().GetAspect<amc>(), false))
			{
				csd csd = Enumerable.FirstOrDefault<csd>(Enumerable.OrderByDescending<csd, double>(Enumerable.ToList<csd>(Enumerable.Where<csd>(base.a8().Area.Zone.Waypoints, new Func<csd, bool>(bsm.d.a.a))), new Func<csd, double>(a.a)));
				c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
			}
			return;
		}
		if (this.i == bsm.c.a)
		{
			if (this.n == null)
			{
				this.n = new TimeSpan?(a.a.aqu().o() + bsm.f);
			}
			else if (a.a.aqu().o() >= this.n)
			{
				this.i = bsm.c.b;
				this.n = null;
				return;
			}
			c5x.t.b.y6()[ddq.ay] = new bt4("toddRest");
			c5x.t.b.y6()[ddq.az] = null;
			return;
		}
		if (this.i == bsm.c.b)
		{
			if (aw1.a(c5x, new bt4("jogStart"), false))
			{
				this.i = bsm.c.c;
				this.n = null;
				return;
			}
			c5x.t.b.y6()[ddq.ay] = new bt4("jogStart");
			c5x.t.b.y6()[ddq.az] = null;
			return;
		}
		else
		{
			if (this.i != bsm.c.c)
			{
				if (this.i == bsm.c.d)
				{
					if (this.n == null)
					{
						if (a.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_metAgain", new bool?(false)).Value)
						{
							this.n = new TimeSpan?(a.a.aqu().o() + TimeSpan.FromSeconds(bsm.e.TotalSeconds / 2.0));
						}
					}
					else if (a.a.aqu().o() >= this.n)
					{
						c5x.i.b.a(true, false);
						c5x.t.b.y6()[ddq.ay] = null;
						c5x.t.b.t();
						this.i = bsm.c.a;
						this.n = null;
						return;
					}
				}
				bsm.b[] array = bsm.c[this.j];
				string a_ = array[this.l].a;
				csd csd2 = base.a8().Zone.g(a_);
				if (c5x.aj().a() == csd2.Location.a())
				{
					this.l += this.k;
					if (this.l >= array.Length)
					{
						this.l = 0;
					}
					if (this.l < 0)
					{
						this.l = array.Length - 1;
					}
				}
				this.a();
				this.a(c5x);
				return;
			}
			if (this.n == null)
			{
				this.n = new TimeSpan?(a.a.aqu().o() + TimeSpan.FromSeconds(5.0));
				return;
			}
			if (a.a.aqu().o() >= this.n)
			{
				this.i = bsm.c.d;
				this.j = 0;
				this.l = 0;
				this.k = 1;
				this.n = null;
			}
			return;
		}
	}

	// Token: 0x0600509F RID: 20639 RVA: 0x00244BBC File Offset: 0x00242DBC
	private void a()
	{
		bsm.b[] array = bsm.c[this.j];
		string a_ = array[this.l].a;
		csd csd = base.a8().Zone.g(a_);
		c5x c5x = new ar7(bsm.a, base.a8().Area).ao() as c5x;
		fk fk = new fk(c5x.k.b, csd.Tile, null, false, 0);
		fk.l();
		czp czp = fk.g();
		czp.n.a = false;
		czp.p = true;
		czp.q = true;
		d25 d = czp.l as d25;
		if (d == null)
		{
			d = new d25();
			czp.l = d;
		}
		d.b = true;
		d.c = true;
		c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, c5x.Playfield.PathProcessor, eso.d);
		c5w.au1();
		bool flag = false;
		if (c5w.aun() == dv8.d)
		{
			double num = aw1.a(c5x, csd.Tile);
			using (List<yz>.Enumerator enumerator = c5w.aus().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					yz yz = enumerator.Current;
					if ((double)bnx.a(new Point((int)yz.a.a.X / 4, (int)yz.a.a.Y / 4), csd.Tile.Location) - num >= 2.0)
					{
						flag = true;
						break;
					}
				}
				goto IL_1A2;
			}
		}
		flag = true;
		IL_1A2:
		if (flag)
		{
			if (this.m == null || this.m.Value <= base.a8().Zone.ElapsedZoneTime)
			{
				Guid? guid = null;
				if (this.k == 1)
				{
					guid = array[this.l].d;
				}
				else
				{
					guid = array[this.l].e;
				}
				if (guid != null)
				{
					c5x c5x2 = new ar7(guid.Value, base.a8().Area).ao() as c5x;
					if (c5x2 != null && c5x2.a() && c5x2.s.b != null)
					{
						clr clr = Enumerable.FirstOrDefault<clr>(Enumerable.OfType<clr>(c5x2.s.b.s()));
						if (clr != null && clr.OverrideTargetId != null)
						{
							c5x c5x3 = new ar7(clr.OverrideTargetId.Value, base.a8().Area).ao() as c5x;
							if (c5x3 != null)
							{
								aw aspect = c5x3.GetAspect<aw>();
								if (aspect != null)
								{
									if (aspect.d() != 7)
									{
										c5x.t.b.y6()[ddq.b1] = new ar7(c5x2);
										this.i = bsm.c.e;
										this.m = new TimeSpan?(base.a8().Zone.ElapsedZoneTime + TimeSpan.FromSeconds(3.5));
										return;
									}
									if (aspect.f() < 7)
									{
										this.i = bsm.c.e;
										this.m = new TimeSpan?(base.a8().Zone.ElapsedZoneTime + TimeSpan.FromSeconds((double)((7 - aspect.f()) / 2)));
										return;
									}
								}
							}
						}
					}
				}
			}
			int? num2 = null;
			if (this.k == 1)
			{
				num2 = array[this.l].b;
			}
			else
			{
				num2 = array[this.l].c;
			}
			if (num2 != null)
			{
				this.j++;
				this.l = num2.Value;
				this.a(c5x);
			}
			else
			{
				this.k = -this.k;
				this.l += this.k;
				if (this.l >= array.Length)
				{
					this.l = 0;
				}
				if (this.l < 0)
				{
					this.l = array.Length - 1;
				}
			}
			this.a(c5x);
		}
	}

	// Token: 0x060050A0 RID: 20640 RVA: 0x00245034 File Offset: 0x00243234
	private void a(c5x A_0)
	{
		if (this.j > 0 && this.l == 0)
		{
			this.j = 0;
		}
		string a_ = bsm.c[this.j][this.l].a;
		A_0.t.b.y6()[ddq.ay] = new bt4(a_);
		A_0.t.b.y6()[ddq.az] = false;
	}

	// Token: 0x040020F4 RID: 8436
	private static readonly Guid a = new Guid("8b993b71-2472-446c-a9ba-30099404c50d");

	// Token: 0x040020F5 RID: 8437
	private static readonly int b = 50;

	// Token: 0x040020F6 RID: 8438
	private static readonly bsm.b[][] c;

	// Token: 0x040020F7 RID: 8439
	private static List<Guid> d;

	// Token: 0x040020F8 RID: 8440
	private static readonly TimeSpan e = TimeSpan.FromMinutes(4.0);

	// Token: 0x040020F9 RID: 8441
	private static readonly TimeSpan f = TimeSpan.FromMinutes(2.0);

	// Token: 0x040020FA RID: 8442
	private static readonly TimeSpan g = TimeSpan.FromMinutes(10.0);

	// Token: 0x040020FB RID: 8443
	private double h;

	// Token: 0x040020FC RID: 8444
	private bsm.c i = bsm.c.d;

	// Token: 0x040020FD RID: 8445
	private int j;

	// Token: 0x040020FE RID: 8446
	private int k = 1;

	// Token: 0x040020FF RID: 8447
	private int l;

	// Token: 0x04002100 RID: 8448
	private TimeSpan? m;

	// Token: 0x04002101 RID: 8449
	private TimeSpan? n;

	// Token: 0x04002102 RID: 8450
	private bool o;

	// Token: 0x02000F7A RID: 3962
	private sealed class b
	{
		// Token: 0x060050A1 RID: 20641 RVA: 0x002450C0 File Offset: 0x002432C0
		public b(string A_0, int? A_1 = null, int? A_2 = null, Guid? A_3 = null, Guid? A_4 = null)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
		}

		// Token: 0x04002103 RID: 8451
		public string a;

		// Token: 0x04002104 RID: 8452
		public int? b;

		// Token: 0x04002105 RID: 8453
		public int? c;

		// Token: 0x04002106 RID: 8454
		public Guid? d;

		// Token: 0x04002107 RID: 8455
		public Guid? e;
	}

	// Token: 0x02000F7B RID: 3963
	[eiz("TDCEAtp")]
	[Serializable]
	private enum c
	{
		// Token: 0x04002109 RID: 8457
		a,
		// Token: 0x0400210A RID: 8458
		b,
		// Token: 0x0400210B RID: 8459
		c,
		// Token: 0x0400210C RID: 8460
		d,
		// Token: 0x0400210D RID: 8461
		e,
		// Token: 0x0400210E RID: 8462
		f
	}

	// Token: 0x02000F7C RID: 3964
	[CompilerGenerated]
	[Serializable]
	private sealed class d
	{
		// Token: 0x060050A4 RID: 20644 RVA: 0x00245104 File Offset: 0x00243304
		internal bool a(csd A_0)
		{
			return A_0.Name.StartsWith("hide", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0400210F RID: 8463
		public static readonly bsm.d a = new bsm.d();

		// Token: 0x04002110 RID: 8464
		public static Func<csd, bool> b;
	}

	// Token: 0x02000F7D RID: 3965
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060050A6 RID: 20646 RVA: 0x00245120 File Offset: 0x00243320
		internal double a(csd A_0)
		{
			return aw1.a(this.a.aqu().v().b(), A_0.Tile);
		}

		// Token: 0x04002111 RID: 8465
		public cnk a;
	}
}
