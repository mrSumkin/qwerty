using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000FF3 RID: 4083
public static class bkt
{
	// Token: 0x06005410 RID: 21520 RVA: 0x00253080 File Offset: 0x00251280
	public static void a(aud A_0, Point A_1, b0b A_2)
	{
		int num = 200;
		if (A_2 != null)
		{
			a3f aspect = A_2.GetAspect<a3f>();
			if (aspect != null)
			{
				num = aspect.a().GetPrimitivePropertyValue<int>("TransitionSpeed", new int?(num)).Value;
			}
		}
		c5x c5x = vq.a("wall\\ElectricCreepWall", A_0.Zone, new bt4(A_0.y8(), new Vector3((float)A_1.X, (float)A_1.Y, 0f)), false);
		c5x.TileFormationModifiers.c();
		if (c5x != null)
		{
			ah7 ah = A_0.Zone.i("Electricity");
			if (ah != null)
			{
				ah.g().be(c5x);
			}
			c5x.q("electrocutionEffect");
			c5x.IsGround = true;
			c5x.VisualPriority = 10;
			c5x.TileFormationModifiers.c();
			c5x.z();
			dm dm = new dm(c5x);
			dm.d().Add(new eyq());
			c5x.SetAspect<dm>(dm);
			t6 t = new t6(c5x);
			t.b(1);
			t.c(num);
			t.d().Add(new a4v());
			c5x.SetAspect<t6>(t);
			a3f a3f = new a3f(c5x);
			a3f.a()["ControllerRef"] = new ar7(A_2);
			c5x.SetAspect<a3f>(a3f);
			a7c a7c = new a7c();
			a7c.Name = "electrocutionTrigger" + Guid.NewGuid().ToString();
			a7c.Layer = aju.x;
			a7c.h().Add(new n0());
			a7c.a().Add(new n0());
			a7c.Location = A_1;
			a7c.Size = new esj(1, 1);
			a7c.b(true);
			a7c.d(false);
			A_0.b(a7c);
			if (dz6.e())
			{
				new eyq().ym(null, c5x, null);
			}
			a3f aspect2 = A_2.GetAspect<a3f>();
			if (aspect2 != null)
			{
				HashSet<Point> hashSet = aspect2.a().GetClassPropertyValue<HashSet<Point>>("ProcessedLocations");
				if (hashSet == null)
				{
					hashSet = new HashSet<Point>();
				}
				hashSet.Add(A_1);
				aspect2.a()["ProcessedLocations"] = hashSet;
			}
		}
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x002532C4 File Offset: 0x002514C4
	public static void a(b0b A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			aspect.a()["ProcessedLocations"] = new HashSet<Point>();
		}
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x002532F4 File Offset: 0x002514F4
	public static void a(c5x A_0)
	{
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null)
			{
				ar7 ar = aspect.a()["ControllerRef"] as ar7;
				if (ar != null && ar.ao() != null)
				{
					c5x c5x = ar.ao() as c5x;
					a3f aspect2 = c5x.GetAspect<a3f>();
					if (aspect2 != null)
					{
						HashSet<Point> hashSet = aspect2.a().GetClassPropertyValue<HashSet<Point>>("ProcessedLocations");
						if (hashSet == null)
						{
							hashSet = new HashSet<Point>();
						}
						foreach (ak1 ak in aw1.a(A_0, true))
						{
							if (!hashSet.Contains(ak.Location))
							{
								if (Enumerable.FirstOrDefault<c5x>(Enumerable.Where<c5x>(Enumerable.OfType<c5x>(ak.c.Values), new Func<c5x, bool>(bkt.a.a.a))) != null)
								{
									bkt.a(ak.Area, ak.Location, c5x);
								}
							}
						}
					}
				}
			}
			ak1 ak2 = Enumerable.FirstOrDefault<ak1>(A_0.l);
			if (ak2 != null)
			{
				foreach (bqt bqt in Enumerable.ToList<bqt>(ak2.TriggerProxies))
				{
					if (bqt.Trigger is a7c)
					{
						bqt.Trigger.o();
					}
				}
			}
			c7 c = new c7(A_0, false, false, true, false);
			c.a(true);
			c7 a_ = c;
			A_0.Zone.ActionManager.g9(a_, atp.a);
		}
	}

	// Token: 0x02000FF4 RID: 4084
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005415 RID: 21525 RVA: 0x002534DC File Offset: 0x002516DC
		internal bool a(c5x A_0)
		{
			return A_0.o.b != null && (A_0.o.b.a == "Floor\\Grate" || A_0.o.b.a == "Floor\\Grate-Gray");
		}

		// Token: 0x04002252 RID: 8786
		public static readonly bkt.a a = new bkt.a();

		// Token: 0x04002253 RID: 8787
		public static Func<c5x, bool> b;
	}
}
