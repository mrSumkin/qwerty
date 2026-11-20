using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules;

// Token: 0x02000F73 RID: 3955
[eiz("XSACEA")]
[Serializable]
public sealed class bvw : Aspect<c5x>, bp1, chb, c98
{
	// Token: 0x06005064 RID: 20580 RVA: 0x002415F8 File Offset: 0x0023F7F8
	private bvw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.o = A_0.GetDouble("XSACEA:C");
	}

	// Token: 0x06005065 RID: 20581 RVA: 0x00241614 File Offset: 0x0023F814
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XSACEA:C", this.o);
	}

	// Token: 0x06005066 RID: 20582 RVA: 0x00241630 File Offset: 0x0023F830
	public bvw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005067 RID: 20583 RVA: 0x0024163C File Offset: 0x0023F83C
	public void r7(eds A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool flag = false;
		if (serviceOrThrow.aqu() != null)
		{
			flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.k, new bool?(false)).Value;
		}
		if (!dz6.e() || flag)
		{
			if ((this.o += A_0.b.TotalMilliseconds) >= (double)bvw.b)
			{
				this.o -= (double)bvw.b;
				this.i();
			}
		}
		else
		{
			this.o = 0.0;
		}
		this.b();
		this.a();
	}

	// Token: 0x06005068 RID: 20584 RVA: 0x002416F0 File Offset: 0x0023F8F0
	public void c()
	{
		int num = d0u.b / bvw.b;
		for (int i = 0; i < num; i++)
		{
			this.i();
			this.b();
			this.a();
		}
		this.o = 0.0;
	}

	// Token: 0x06005069 RID: 20585 RVA: 0x0024173C File Offset: 0x0023F93C
	public void mx()
	{
		this.b();
		this.a();
	}

	// Token: 0x0600506A RID: 20586 RVA: 0x0024174C File Offset: 0x0023F94C
	public void my()
	{
	}

	// Token: 0x0600506B RID: 20587 RVA: 0x00241754 File Offset: 0x0023F954
	private void i()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			double num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>(bvw.h, new double?(0.0)).Value;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.i, new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.j, new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.l, new bool?(false)).Value;
			bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.k, new bool?(false)).Value;
			bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bvw.m, new bool?(false)).Value;
			double num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>(bvw.n, new double?(0.0)).Value;
			if (!value4 && value && num < bvw.a)
			{
				double val;
				if (value5 || value3)
				{
					val = bvw.a;
				}
				else
				{
					val = bvw.a * bvw.e;
				}
				double num3;
				if (value2)
				{
					c5x c5x = serviceOrThrow.aqw().a().ab5("shadowlith") as c5x;
					if (c5x != null && c5x.s.b != null)
					{
						c5x.s.b.g(false);
					}
					num3 = 50.0;
				}
				else
				{
					num3 = 0.5;
				}
				double num4 = num3 / (double)(1000 / bvw.b);
				num = Math.Min(val, num + num4);
			}
			else if (value4 && num > 0.0)
			{
				double num5 = 33.0 / (double)(1000 / bvw.b);
				num = Math.Max(0.0, num - num5);
			}
			else if (num == bvw.a && !value4)
			{
				num2 += (double)bvw.b / 1000.0;
				serviceOrThrow.aqu().r()[bvw.n] = num2;
				if ((int)(num2 * 10.0) % 50 == 0)
				{
					int count = base.a8().Zone.a().ab4(new string[]
					{
						"spaceSnake"
					}).Count;
					int num6 = d05.a(this.f(), this.f() + (int)num2 / this.h(), this.g());
					if (count < num6)
					{
						this.d();
					}
				}
			}
			serviceOrThrow.aqu().r()[bvw.h] = num;
			c5x c5x2 = base.a8().Zone.a().ab5("shadowlithParticleSpawner") as c5x;
			if (c5x2 != null)
			{
				dmu aspect = c5x2.GetAspect<dmu>();
				if (aspect != null)
				{
					if (value4)
					{
						aspect.a(0.0);
					}
					else
					{
						aspect.a(1.0 + num / bvw.a);
					}
				}
			}
			foreach (b0b b0b in base.a8().Zone.a().ab4(new string[]
			{
				"voidPortalParticleSpawner"
			}))
			{
				dmu aspect2 = ((c5x)b0b).GetAspect<dmu>();
				if (aspect2 != null)
				{
					aspect2.a(num / bvw.a);
				}
			}
		}
	}

	// Token: 0x0600506C RID: 20588 RVA: 0x00241B58 File Offset: 0x0023FD58
	private int h()
	{
		switch (this.e())
		{
		case GameDifficulty.Easy:
			return 25;
		case GameDifficulty.Hard:
			return 10;
		case GameDifficulty.Dominating:
			return 5;
		}
		return 15;
	}

	// Token: 0x0600506D RID: 20589 RVA: 0x00241B94 File Offset: 0x0023FD94
	private int g()
	{
		switch (this.e())
		{
		case GameDifficulty.Easy:
			return 10;
		case GameDifficulty.Hard:
			return 25;
		case GameDifficulty.Dominating:
			return 30;
		}
		return 20;
	}

	// Token: 0x0600506E RID: 20590 RVA: 0x00241BD0 File Offset: 0x0023FDD0
	private int f()
	{
		switch (this.e())
		{
		case GameDifficulty.Easy:
			return 3;
		case GameDifficulty.Hard:
			return 6;
		case GameDifficulty.Dominating:
			return 8;
		}
		return 4;
	}

	// Token: 0x0600506F RID: 20591 RVA: 0x00241C08 File Offset: 0x0023FE08
	private GameDifficulty e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			return serviceOrThrow.aqu().ae();
		}
		return GameDifficulty.Normal;
	}

	// Token: 0x06005070 RID: 20592 RVA: 0x00241C34 File Offset: 0x0023FE34
	private void d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			bvw.a a = new bvw.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.t.b != null)
			{
				List<csd> list = new List<csd>();
				foreach (csd csd in base.a8().Zone.Waypoints)
				{
					if (((csd.Tile != null && csd.Name != null && csd.Name.StartsWith("portalExit")) || csd.Name.StartsWith("windowExit")) && !aw1.a(csd.Tile, false, null, l9.a))
					{
						list.Add(csd);
					}
				}
				list = Enumerable.ToList<csd>(Enumerable.OrderBy<csd, double>(list, new Func<csd, double>(a.a)));
				if (list.Count > 0)
				{
					List<csd> list2 = new List<csd>();
					foreach (csd csd2 in list)
					{
						if (csd2.Tile != null && a.a.t.b.ai() && a.a.t.b.a(csd2.Tile))
						{
							list2.Add(csd2);
						}
					}
					List<csd> list3;
					if (list2.Count > 0)
					{
						list3 = list2;
					}
					else
					{
						list3 = list;
					}
					csd a_ = list3[0];
					c5x c5x = vq.a("Creature\\Critters\\Xpbl\\SpaceSnake", a_, false);
					if (c5x != null && c5x.h.b != null)
					{
						c5x.h.b.a(string.Format("xpbl_ss{0}", cuo.a.Next(1, 4)));
						c5x.h.b.aa().StatusEffects.a(new cyf(0), false, false, false);
						dm dm = new dm(c5x);
						dm.d().Add(new cmf());
						dm.a(new int?(cuo.a.Next(3, 5) * d0u.b));
						c5x.SetAspect<dm>(dm);
						c5x.b("spaceSnake");
						c5x.ae = new float?(0f);
						if (eh5.a(cwy.a))
						{
							ad6 ad = new ad6(c5x);
							ad.a(dz6.a(0.0015));
							base.a8().Zone.ActionManager.g9(ad, atp.a);
						}
						else
						{
							ad6 ad2 = new ad6(c5x);
							ad2.c(0.05000000074505806);
							ad2.a(dz6.a(ad2.d() / 666.0));
							base.a8().Zone.ActionManager.g9(ad2, atp.a);
							c5x.h.b.aa().EtherealBase = true;
							c5x.h.b.aa().bl();
						}
						aex.b(c5x.Area, c5x.aj(), 300, 500, 2f, 4.25f, true, true);
						c5x.c().a("Xpbl_SpaceSnakeSpawn");
					}
				}
			}
		}
	}

	// Token: 0x06005071 RID: 20593 RVA: 0x00242008 File Offset: 0x00240208
	private void b()
	{
		cnk service = bpo.GetService<cnk>();
		bool flag = service != null && service.aqu() != null && service.aqu().r().GetPrimitivePropertyValue<bool>(bvw.k, new bool?(false)).Value;
		if (service != null && service.aqu() != null && service.aqw() != null && base.a8() != null && base.a8().Zone != null)
		{
			double value = service.aqu().r().GetPrimitivePropertyValue<double>(bvw.h, new double?(0.0)).Value;
			double num = 1.0 - value / bvw.a * bvw.d;
			float num2;
			if (flag)
			{
				num2 = 1.25f;
			}
			else
			{
				num2 = 1f;
			}
			int r = Convert.ToInt32((double)bvw.c * num * (double)num2);
			Color a_ = new Color(r, r, r);
			foreach (aud aud in base.a8().Zone.Areas)
			{
				if (aud.StartingLightning != a_)
				{
					aud.StartingLightning = a_;
					for (int i = 0; i < aud.Size.c; i++)
					{
						for (int j = 0; j < aud.Size.d; j++)
						{
							ak1 ak = aud.b(i, j);
							if (ak != null)
							{
								ak.e();
							}
						}
					}
				}
			}
			double num3;
			if (value > bvw.a * bvw.e)
			{
				num3 = Math.Min(1.0, 1.0 - (bvw.a - value) / (bvw.a * 0.35));
			}
			else
			{
				num3 = 0.0;
			}
			ah7 ah = service.aqw().i("windowLight");
			ah7 ah2 = service.aqw().i("voidWindowLight");
			ah7 ah3 = service.aqw().i("ShadowlithUnlight");
			if (ah != null)
			{
				float num4 = Convert.ToSingle((1.0 - num3) * bvw.f);
				if (num4 > 0f)
				{
					if (!ah.Enabled || ah.Light.c() != num4)
					{
						ah.Light = new ae8(ah.Light.d(), num4, LightType.Increment);
						ah.Enabled = true;
						ah.d();
					}
				}
				else
				{
					ah.Enabled = false;
					ah.d();
				}
			}
			if (ah2 != null)
			{
				float num5 = Convert.ToSingle(num3 * bvw.g);
				if (num5 > 0f)
				{
					if (!ah2.Enabled || ah2.Light.c() != num5)
					{
						ah2.Light = new ae8(ah2.Light.d(), num5, LightType.Increment);
						ah2.Enabled = true;
						ah2.d();
					}
				}
				else
				{
					ah2.Enabled = false;
					ah2.d();
				}
			}
			if (ah3 != null && flag)
			{
				float a_2 = Convert.ToSingle(num3 * 0.12999999523162842);
				ah3.Light = new ae8(ah3.Light.d(), a_2, LightType.Decrement);
			}
			foreach (b0b b0b in service.aqw().a().ab4(new string[]
			{
				"voidWindow",
				"voidPortal"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (num3 == 1.0)
				{
					c5x.ae = null;
				}
				else
				{
					c5x.ae = new float?(Convert.ToSingle(num3));
				}
			}
			List<b0b> list = service.aqw().a().ab4(new string[]
			{
				"voidCaustics"
			});
			double num6 = 1.0 - num3;
			foreach (b0b b0b2 in list)
			{
				c5x c5x2 = (c5x)b0b2;
				if (num6 == 1.0)
				{
					c5x2.ae = null;
				}
				else
				{
					c5x2.ae = new float?(Convert.ToSingle(num6));
				}
			}
			c5x c5x3 = service.aqw().a().ab5("snakePainting") as c5x;
			if (c5x3 != null)
			{
				if (c5x3.p.b != null && c5x3.p.b.a.Count >= 3)
				{
					c5x3.p.b.a[1].d = new float?(Convert.ToSingle(1.0 - num3));
					c5x3.p.b.a[2].d = new float?(Convert.ToSingle(num3));
				}
				d85 d = c5x3.GetAspect<bim>() as d85;
				if (d != null && Enumerable.Any<string>(d.a()))
				{
					if (num3 == 1.0 && !d.a()[0].Contains("Флотсоурмир"))
					{
						d.a().Clear();
						d.a().Add("На ней изображён огромный змей, пожирающий Вселенную. Подпись:  \"Флотсоурмир.\"");
						c4f c4f = new c4f();
						c4f.Properties["global_xpbl_knowFlottsormir"] = true;
						d.s().Add(c4f);
					}
					else if (num3 != 1.0 && !d.a()[0].Contains("gigantic"))
					{
						d.a().Clear();
						d.a().Add("Здесь изображён гигантский змей, пожирающий звезду.");
						d.s().Clear();
					}
				}
			}
			foreach (b0b b0b3 in service.aqw().a().ab4(new string[]
			{
				"voidObjects"
			}))
			{
				c5x c5x4 = (c5x)b0b3;
				if (c5x4.p.b != null)
				{
					c5x4.p.b.a[1].d = new float?(Convert.ToSingle(num3));
				}
			}
		}
	}

	// Token: 0x06005072 RID: 20594 RVA: 0x00242730 File Offset: 0x00240930
	private void a()
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && service.aqw() != null && base.a8() != null && base.a8().Zone != null)
		{
			double value = service.aqu().r().GetPrimitivePropertyValue<double>(bvw.h, new double?(0.0)).Value;
			List<b0b> list = service.aqw().a().ab4(new string[]
			{
				"voidPortal"
			});
			if (value > bvw.a * bvw.e)
			{
				new dvn("xpbl_ds3", "xpbl_AbyssalStationEldritch").ym(null, null, null);
			}
			else
			{
				new dvn("xpbl_ds3", null).ym(null, null, null);
			}
			foreach (b0b b0b in list)
			{
				c5x a_ = (c5x)b0b;
				if (value > bvw.a * bvw.e)
				{
					SoundState? soundState = a_.c().b("portal");
					SoundState soundState2 = SoundState.Playing;
					if (!(soundState.GetValueOrDefault() == soundState2 & soundState != null))
					{
						a_.c().a("portal", "xpbl_VoidRift", 1f, c9z.a, false, false);
					}
				}
				else
				{
					SoundState? soundState = a_.c().b("portal");
					SoundState soundState2 = SoundState.Playing;
					if (soundState.GetValueOrDefault() == soundState2 & soundState != null)
					{
						a_.c().a("portal", false);
					}
				}
			}
		}
	}

	// Token: 0x040020DA RID: 8410
	private static readonly double a = 100.0;

	// Token: 0x040020DB RID: 8411
	private static readonly int b = 100;

	// Token: 0x040020DC RID: 8412
	private static readonly int c = 70;

	// Token: 0x040020DD RID: 8413
	private static readonly double d = 0.65;

	// Token: 0x040020DE RID: 8414
	private static readonly double e = 0.66;

	// Token: 0x040020DF RID: 8415
	private static readonly double f = 0.15;

	// Token: 0x040020E0 RID: 8416
	private static readonly double g = 0.25;

	// Token: 0x040020E1 RID: 8417
	public static readonly string h = "xpbl_ds3_darkeningPosition";

	// Token: 0x040020E2 RID: 8418
	public static readonly string i = "xpbl_ds3_darkeningTriggered";

	// Token: 0x040020E3 RID: 8419
	public static readonly string j = "xpbl_ds3_snakeSpawningTriggered";

	// Token: 0x040020E4 RID: 8420
	public static readonly string k = "xpbl_ds3_shadowlithDestroyed";

	// Token: 0x040020E5 RID: 8421
	public static readonly string l = "xpbl_ds3_shadowlithDamaged";

	// Token: 0x040020E6 RID: 8422
	public static readonly string m = "xpbl_ds3_acornTaken";

	// Token: 0x040020E7 RID: 8423
	public static readonly string n = "xpbl_ds3_assaultDuration";

	// Token: 0x040020E8 RID: 8424
	private double o;

	// Token: 0x02000F74 RID: 3956
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06005075 RID: 20597 RVA: 0x002429A0 File Offset: 0x00240BA0
		internal double a(csd A_0)
		{
			return aw1.a(this.a, A_0.Tile);
		}

		// Token: 0x040020E9 RID: 8425
		public c5x a;
	}
}
