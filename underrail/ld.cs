using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200054F RID: 1359
public static class ld
{
	// Token: 0x060022C4 RID: 8900 RVA: 0x000B82D8 File Offset: 0x000B64D8
	public static bool b(c1a A_0, string A_1, bool A_2 = false)
	{
		if (A_0 == null || string.IsNullOrEmpty(A_1))
		{
			return false;
		}
		if (bpo.GetServiceOrThrow<cnk>().aqu() == null)
		{
			return false;
		}
		csd csd = A_0.g(A_1);
		if (csd == null || csd.Area == null)
		{
			return false;
		}
		c1a c1a = new c1a("train");
		c1a.Playfield = A_0.Playfield;
		aud aud = new aud(Guid.NewGuid(), "train", ld.a, false);
		aud.FillTiles<ak1>();
		aud.Zone = c1a;
		HashSet<ya> hashSet = new HashSet<ya>();
		Point a_ = csd.Location.a();
		for (int i = 0; i < ld.a.d; i++)
		{
			for (int j = 0; j < ld.a.c; j++)
			{
				float num;
				float num2;
				ld.b((float)j, (float)i, a_, A_2, out num, out num2);
				ak1 ak = csd.Area.b((int)num, (int)num2);
				if (ak != null)
				{
					foreach (bqt bqt in ak.TriggerProxies)
					{
						if (bqt.Trigger != null && bqt.Trigger.Layer == 1)
						{
							hashSet.Add(bqt.Trigger);
						}
					}
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.Layer == 1 && !c5x.a("railcarParts") && !c5x.a("underRailcar"))
						{
							if (c5x.y8() == "Пси-двойник" && !c5x.IsPlayer)
							{
								c5x.w();
								c5x.an();
							}
							else
							{
								c5x.an();
								if (!(c5x.r.b is ed2) && c5x.GetAspect<dd9>() == null && c5x.GetAspect<arn>() == null && c5x.GetAspect<cry>() == null && !(c5x.s.b is yp) && c5x.GetAspect<e11>() == null && c5x.GetAspect<ey7>() == null && c5x.GetAspect<d16>() == null)
								{
									a3f aspect = c5x.GetAspect<a3f>();
									if ((aspect == null || aspect.a() == null || aspect.a().GetClassPropertyValue<string>("GasEntityType") == null) && (c5x.o.b == null || c5x.o.b.a == null || !c5x.o.b.a.StartsWith("Effects\\GroundFireBack", StringComparison.OrdinalIgnoreCase)))
									{
										float x;
										float y;
										ld.a(c5x.Location.X, c5x.Location.Y, a_, A_2, out x, out y);
										c5x.Location = new Vector3(x, y, c5x.Location.Z);
										aud.a(c5x);
									}
								}
							}
						}
					}
				}
			}
		}
		foreach (ya ya in hashSet)
		{
			ya.o();
			if (!(ya is cos) && !(ya is oe) && !(ya is ee7) && !(ya is djd) && !(ya is ed0) && !(ya is sl) && !(ya is s8) && !ya.Name.Equals("RailcarVisibility"))
			{
				float value;
				float value2;
				ld.a((float)ya.Location.X, (float)ya.Location.Y, a_, A_2, out value, out value2);
				ya.Location = new Point(Convert.ToInt32(value), Convert.ToInt32(value2));
				if (A_2)
				{
					ya.Size = new esj(ya.Size.d, ya.Size.c);
				}
				aud.b(ya);
			}
		}
		bmg.b().PutItemCompressed<aud>(ld.b, aud, true);
		return true;
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x000B87A4 File Offset: 0x000B69A4
	public static bool a(c1a A_0, string A_1, bool A_2 = false)
	{
		if (A_0 == null || string.IsNullOrEmpty(A_1))
		{
			return false;
		}
		if (bpo.GetServiceOrThrow<cnk>().aqu() == null)
		{
			return false;
		}
		csd csd = A_0.g(A_1);
		if (csd == null || csd.Area == null)
		{
			return false;
		}
		Point a_ = csd.Location.a();
		aud itemCompressed = bmg.b().GetItemCompressed<aud>(ld.b, false);
		if (itemCompressed == null)
		{
			return false;
		}
		for (int i = 0; i < ld.a.d; i++)
		{
			for (int j = 0; j < ld.a.c; j++)
			{
				ak1 ak = itemCompressed.b(j, i);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.y8() == "Пси-двойник" && !c5x.IsPlayer)
						{
							c5x.w();
							c5x.an();
						}
						else
						{
							c5x.an();
							float x;
							float y;
							ld.b(c5x.Location.X, c5x.Location.Y, a_, A_2, out x, out y);
							c5x.Location = new Vector3(x, y, c5x.Location.Z);
							csd.Area.a(c5x);
						}
					}
				}
			}
		}
		foreach (ya ya in Enumerable.ToList<ya>(itemCompressed.Triggers))
		{
			if (!(ya is et4))
			{
				ya.o();
				float num;
				float num2;
				ld.b((float)ya.Location.X, (float)ya.Location.Y, a_, A_2, out num, out num2);
				ya.Location = new Point((int)num, (int)num2);
				if (A_2)
				{
					ya.Size = new esj(ya.Size.d, ya.Size.c);
				}
				l2 l = ya as l2;
				if (l != null)
				{
					l.jl(csd.Area);
				}
				csd.Area.b(ya);
			}
		}
		return true;
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x000B8A2C File Offset: 0x000B6C2C
	private static void b(float A_0, float A_1, Point A_2, bool A_3, out float A_4, out float A_5)
	{
		if (A_3)
		{
			A_4 = (float)A_2.X - A_1;
			A_5 = (float)A_2.Y + A_0;
			return;
		}
		A_4 = (float)A_2.X + A_0;
		A_5 = (float)A_2.Y + A_1;
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x000B8A68 File Offset: 0x000B6C68
	private static void a(float A_0, float A_1, Point A_2, bool A_3, out float A_4, out float A_5)
	{
		if (A_3)
		{
			A_4 = A_1 - (float)A_2.Y;
			A_5 = (float)A_2.X - A_0;
			return;
		}
		A_4 = A_0 - (float)A_2.X;
		A_5 = A_1 - (float)A_2.Y;
	}

	// Token: 0x04001487 RID: 5255
	private static readonly esj a = new esj(2, 9);

	// Token: 0x04001488 RID: 5256
	private static readonly string b = "xphw_train_area";
}
