using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001166 RID: 4454
public class dd5
{
	// Token: 0x06005F41 RID: 24385 RVA: 0x002867B4 File Offset: 0x002849B4
	public static void d(c5x A_0)
	{
		if (A_0 != null && A_0.Zone != null && A_0.Layer == aju.x)
		{
			if (Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_0.RaysEmitters), new Func<bsf, bool>(dd5.a.a.b))) == null)
			{
				ah7 ah = A_0.Zone.i("characterBurningLantern");
				if (ah == null)
				{
					ah = new ah7("characterBurningLantern", A_0.Zone);
					ah.Layer = aju.x;
					ah.Light = new ae8(new Color(255, 150, 100), 0.6f, LightType.Increment);
					ah.Range = 4f;
					ah.LightFadeRate = 0.1f;
					A_0.Zone.a(ah);
				}
				ah.g().be(A_0);
				aru aru = A_0.c();
				aru.a("burning", false);
				aru.a("burning", "CharacterBurning", 1f, c9z.a, true, false);
			}
		}
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x002868CC File Offset: 0x00284ACC
	public static void c(c5x A_0)
	{
		if (A_0 != null && A_0.Zone != null && A_0.Layer == aju.x)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_0.RaysEmitters), new Func<bsf, bool>(dd5.a.a.a)));
			if (bsf != null)
			{
				bsf.ig();
			}
			A_0.c().a("burning", false);
		}
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x00286950 File Offset: 0x00284B50
	public static void a(ak1 A_0, double A_1)
	{
		c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(A_0.c.Values, new Func<b0b, bool>(dd5.a.a.b))) as c5x;
		if (c5x != null)
		{
			dd9 aspect = c5x.GetAspect<dd9>();
			if (aspect != null)
			{
				aspect.a(A_1);
			}
		}
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x002869B4 File Offset: 0x00284BB4
	public static void b(ak1 A_0)
	{
		c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(A_0.c.Values, new Func<b0b, bool>(dd5.a.a.c))) as c5x;
		if (c5x != null)
		{
			dd9 aspect = c5x.GetAspect<dd9>();
			if (aspect != null)
			{
				aspect.a(double.MaxValue);
			}
		}
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x00286A20 File Offset: 0x00284C20
	public static c5x a(amc A_0, ak1 A_1, double A_2 = 1.0, int A_3 = 2147483647, bool A_4 = false)
	{
		if (A_1 != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(A_1.c.Values, new Func<b0b, bool>(dd5.a.a.a))) as c5x;
			if (c5x == null)
			{
				c5x c5x2 = new c5x();
				c5x2.Location = A_1.Location.a();
				c5x2.Size = new Vector3(1f, 1f, 1f);
				c5x2.VisualPriority = -50;
				c5x2.Layer = aju.x;
				etz etz = new etz(c5x2);
				etz.a = "Effects\\GroundFireBack";
				etz.c = new Color?(Color.White);
				etz.a(true);
				if (cuo.a.NextDouble() < 0.5)
				{
					etz etz2 = etz;
					etz2.a += "Var1";
				}
				etz.c = new Color?(new Color(255, 255, 255, 255));
				etz.a(0);
				etz.c(4);
				etz.d(100);
				etz.b(1);
				c5x2.SetAspect<cd0>(etz);
				A_1.Area.a(c5x2);
				c5x = new c5x();
				c5x.Location = A_1.Location.a();
				c5x.Size = new Vector3(1f, 1f, 1f);
				c5x.VisualPriority = 50;
				c5x.Layer = aju.x;
				c5x.TileFormationModifiers.s3(13);
				etz etz3 = new etz(c5x);
				etz3.a = "Effects\\GroundFire";
				etz3.c = new Color?(Color.White);
				etz3.a(true);
				if (cuo.a.NextDouble() < 0.5)
				{
					etz etz4 = etz3;
					etz4.a += "Var1";
				}
				etz3.c = new Color?(new Color(255, 255, 255, 255));
				etz3.a(0);
				etz3.c(4);
				etz3.d(100);
				etz3.b(1);
				c5x.SetAspect<cd0>(etz3);
				c5x.SetAspect<dd9>(new dd9(c5x, (A_0 != null) ? A_0.aa().FactionId : null, new Guid?(c5x2.qe())));
				ny aspect = new ny(c5x);
				c5x.SetAspect<ny>(aspect);
				A_1.Area.a(c5x);
				c5x.c().a("горению", "GroundFire", 0.4f + Convert.ToSingle(Math.Min(4.0, A_2)) * 0.15f, c9z.b, true, false);
				ah7 ah = new ah7("burningGround" + c5x.qe().ToString(), c5x.Zone);
				ah.Layer = aju.x;
				ah.Light = new ae8(new Color(255, 150, 100), 0.3f, LightType.Increment);
				ah.Range = 4f;
				ah.LightFadeRate = 0.1f;
				ah.g().be(c5x);
				dxo aspect2 = new dxo(c5x, ah.Name, 0f, 0.4f, 0.0004);
				c5x.SetAspect<dxo>(aspect2);
				oe oe = new oe(c5x.GetAspect<dd9>());
				oe.Location = A_1.Location;
				oe.Size = new esj(1, 1);
				oe.Layer = aju.x;
				A_1.Area.b(oe);
				A_1.Zone.ActionManager.g9(new eu8(c5x, d8o.g, A_1, 5, d0u.b * 2, null), atp.a);
			}
			dd9 aspect3 = c5x.GetAspect<dd9>();
			if (aspect3 != null)
			{
				aspect3.a(A_4);
				if (aspect3.d() < A_3)
				{
					aspect3.b(A_2);
				}
			}
			return c5x;
		}
		return null;
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x00286E18 File Offset: 0x00285018
	public static int b(c5x A_0)
	{
		int num = 0;
		foreach (ak1 ak in A_0.l)
		{
			if (ak.Formation.c(8192L))
			{
				num = Math.Max(num, dd5.a(ak));
			}
		}
		return num;
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x00286E90 File Offset: 0x00285090
	public static int a(ak1 A_0)
	{
		int num = 0;
		if (A_0.Formation.c(8192L))
		{
			foreach (b0b b0b in A_0.c.Values)
			{
				c5x c5x = (c5x)b0b;
				dd9 aspect = c5x.GetAspect<dd9>();
				if (aspect != null && !aspect.e())
				{
					num = Math.Max(num, aspect.d());
				}
				eks eks = c5x.GetAspect<bim>() as eks;
				if (eks != null)
				{
					num = Math.Max(num, eks.j());
				}
			}
		}
		return num;
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x00286F44 File Offset: 0x00285144
	public static int a(amc A_0)
	{
		if (A_0 == null)
		{
			return 0;
		}
		if (A_0.a8() != null && A_0.a8().k != null && A_0.a8().k.b != null && A_0.a8().k.b.c)
		{
			return 1000;
		}
		double num = A_0.aa().Defense.af()[DamageType.Heat].c();
		int num2 = A_0.aa().Defense.af()[DamageType.Heat].a();
		if (num >= 0.9 || num2 >= 60)
		{
			return 4;
		}
		float num3 = euf.f(A_0.aa());
		if (num > 0.4 || num2 > 5)
		{
			int val = (int)((num - 0.5) / 0.1);
			int val2 = (int)((num - 15.0) / 10.0);
			return Math.Max(val, val2);
		}
		if ((double)num3 < 0.5)
		{
			return 0;
		}
		return (int)((num3 - 0.5f) / 0.1f);
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x0028707C File Offset: 0x0028527C
	public static void a(c5x A_0)
	{
		if (A_0 != null)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(A_0.l);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
				{
					c5x c5x = (c5x)b0b;
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null && aspect.a().GetClassPropertyValue<string>("GasEntityType") == "cryogas")
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}

	// Token: 0x06005F4A RID: 24394 RVA: 0x00287130 File Offset: 0x00285330
	public static void a(bk9 A_0, efk A_1, int A_2, int A_3)
	{
		ap9 a_ = (A_1 != null) ? new ap9(A_1) : null;
		dd5.a(A_0, a_, A_2, A_3);
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x0028715C File Offset: 0x0028535C
	public static void a(bk9 A_0, ap9 A_1, int A_2, int A_3)
	{
		int num = Convert.ToInt32(Math.Max(A_0.TimeLeft, (double)A_3));
		double num2 = A_0.TimeLeft / (double)num;
		double num3 = Convert.ToDouble(A_3) / (double)num;
		int a_ = Math.Max(1, Convert.ToInt32((double)A_0.Damage * num2)) + Math.Max(1, Convert.ToInt32((double)A_2 * num3));
		A_0.a(A_1, a_);
		A_0.Duration = num;
		A_0.TimeLeft = (double)A_0.Duration;
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x002871D4 File Offset: 0x002853D4
	public static void a(efk A_0)
	{
		if (A_0 != null && !A_0.Passive && !(A_0 is e3q) && !A_0.b(d8o.e) && !A_0.d(CharacterImmunities.Fear))
		{
			A_0.StatusEffects.a(new axo(2 * d0u.b, null), false, false, false);
		}
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x00287238 File Offset: 0x00285438
	public static void a(qy A_0, amc A_1)
	{
		if (A_1 != null && !A_1.aa().Passive && !(A_1.aa() is e3q) && !A_1.aa().b(d8o.e) && !A_1.aa().d(CharacterImmunities.Fear))
		{
			A_0.ad().Add(new amd(A_1, new els[]
			{
				new axo(2 * d0u.b, null)
			}));
		}
	}

	// Token: 0x02001167 RID: 4455
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005F51 RID: 24401 RVA: 0x002872D8 File Offset: 0x002854D8
		internal bool b(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "characterBurningLantern";
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x002872FC File Offset: 0x002854FC
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "characterBurningLantern";
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x00287320 File Offset: 0x00285520
		internal bool b(b0b A_0)
		{
			return A_0.GetAspect<dd9>() != null && !A_0.GetAspect<dd9>().e();
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x00287340 File Offset: 0x00285540
		internal bool c(b0b A_0)
		{
			return A_0.GetAspect<dd9>() != null && !A_0.GetAspect<dd9>().e();
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00287360 File Offset: 0x00285560
		internal bool a(b0b A_0)
		{
			return A_0.GetAspect<dd9>() != null && !A_0.GetAspect<dd9>().e();
		}

		// Token: 0x040025E2 RID: 9698
		public static readonly dd5.a a = new dd5.a();

		// Token: 0x040025E3 RID: 9699
		public static Func<bsf, bool> b;

		// Token: 0x040025E4 RID: 9700
		public static Func<bsf, bool> c;

		// Token: 0x040025E5 RID: 9701
		public static Func<b0b, bool> d;

		// Token: 0x040025E6 RID: 9702
		public static Func<b0b, bool> e;

		// Token: 0x040025E7 RID: 9703
		public static Func<b0b, bool> f;
	}
}
