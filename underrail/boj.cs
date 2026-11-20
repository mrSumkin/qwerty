using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001198 RID: 4504
public static class boj
{
	// Token: 0x0600601A RID: 24602 RVA: 0x0029DBF0 File Offset: 0x0029BDF0
	public static c5x a(c5x A_0, string A_1, int A_2, double A_3, bool A_4, bool A_5, Vector3? A_6 = null, int? A_7 = null, float? A_8 = null, float? A_9 = null, bool A_10 = false)
	{
		if (A_0 == null || string.IsNullOrEmpty(A_1) || A_0.Zone == null)
		{
			return null;
		}
		c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\effects\\" + A_1);
		if (c5k == null)
		{
			return null;
		}
		c5x c5x = c5k.a(null, false) as c5x;
		if (c5x == null)
		{
			return null;
		}
		c5x.Layer = aju.x;
		if (A_4)
		{
			Vector3 vector = A_0.aj();
			c5x.Location = new Vector3(vector.X - c5x.Size.X / 2f, vector.Y - c5x.Size.Y / 2f, vector.Z);
		}
		else
		{
			c5x.Location = A_0.Location;
		}
		if (A_6 != null)
		{
			c5x.Location += A_6.Value;
		}
		c5x.VisualDirection = A_0.VisualDirection;
		if (c5x.VisualPriority >= 0)
		{
			c5x.VisualPriority = Math.Max(A_0.VisualPriority + 1, 100);
		}
		else
		{
			c5x.VisualPriority = Math.Min(A_0.VisualPriority - 1, c5x.VisualPriority);
		}
		c5x.x = A_0.x;
		c5x.y = A_0.y;
		dha aspect = c5x.GetAspect<dha>();
		if (aspect != null)
		{
			if (A_7 != null)
			{
				aspect.a(A_7.Value);
			}
			if (A_9 != null)
			{
				aspect.a((int)((float)aspect.d() * A_9.Value));
			}
			if (A_8 != null)
			{
				c5x.ae = new float?(A_8.Value);
			}
			A_0.Area.a(c5x);
			aspect.a(A_5 ? A_0 : null, A_2, A_3);
		}
		if (A_10)
		{
			cd0 aspect2 = c5x.GetAspect<cd0>();
			if (aspect2 != null)
			{
				aspect2.b = new Point(aspect2.b.X, c5x.ac);
			}
		}
		return c5x;
	}

	// Token: 0x0600601B RID: 24603 RVA: 0x0029DE14 File Offset: 0x0029C014
	public static c5x a(aud A_0, Vector3 A_1, HorizontalDirection? A_2, string A_3, int A_4, double A_5, int? A_6 = null, float? A_7 = null, float? A_8 = null, int? A_9 = null)
	{
		if (string.IsNullOrEmpty(A_3) || A_0 == null)
		{
			return null;
		}
		c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\effects\\" + A_3);
		if (c5k == null)
		{
			return null;
		}
		c5x c5x = c5k.a(null, false) as c5x;
		if (c5x == null)
		{
			return null;
		}
		if (A_9 != null)
		{
			boj.a(c5x, A_9.Value);
		}
		c5x.Layer = aju.x;
		c5x.Location = A_1;
		if (A_2 != null)
		{
			c5x.VisualDirection = A_2.Value;
		}
		dha aspect = c5x.GetAspect<dha>();
		if (aspect != null)
		{
			if (A_6 != null)
			{
				aspect.a(A_6.Value);
			}
			if (A_8 != null)
			{
				aspect.a((int)((float)aspect.d() * A_8.Value));
			}
			if (A_7 != null)
			{
				c5x.ae = new float?(A_7.Value);
			}
			A_0.a(c5x);
			aspect.a(null, A_4, A_5);
		}
		return c5x;
	}

	// Token: 0x0600601C RID: 24604 RVA: 0x0029DF34 File Offset: 0x0029C134
	public static bool a(c5x A_0, int A_1)
	{
		if (A_0 != null)
		{
			cd0 aspect = A_0.GetAspect<cd0>();
			if (aspect != null)
			{
				aspect.b.Y = A_1;
				return true;
			}
			alv aspect2 = A_0.GetAspect<alv>();
			if (aspect2 != null)
			{
				foreach (cd0 cd in aspect2.a)
				{
					cd.b.Y = A_1;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600601D RID: 24605 RVA: 0x0029DFC4 File Offset: 0x0029C1C4
	public static bool d(ak1 A_0)
	{
		return A_0 != null && boj.c(A_0.Area, A_0.Location);
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x0029DFE0 File Offset: 0x0029C1E0
	public static bool c(aud A_0, Point A_1)
	{
		return boj.a(A_0, A_1.b());
	}

	// Token: 0x0600601F RID: 24607 RVA: 0x0029DFF4 File Offset: 0x0029C1F4
	public static bool a(aud A_0, Vector2 A_1)
	{
		if (A_0 != null)
		{
			Point a_ = A_1.a();
			ak1 ak = A_0.a(a_);
			if (ak != null && !aw1.a(ak, true, null, l9.b))
			{
				bool result = false;
				Vector3 vector = new Vector3(A_1, 0f);
				foreach (KeyValuePair<string, float> keyValuePair in boj.a(ak, false))
				{
					float value = Convert.ToSingle(0.75 + cuo.a.NextDouble() * 1.0) * dz6.b().GetValueOrDefault(1f);
					float? num;
					if (keyValuePair.Value != 1f)
					{
						num = new float?(keyValuePair.Value);
					}
					else
					{
						num = null;
					}
					Vector3 a_2 = new Vector3(A_1, 0f);
					HorizontalDirection? a_3 = null;
					string a_4 = "WatersplashLarge" + keyValuePair.Key;
					int a_5 = 1;
					double maxValue = double.MaxValue;
					float? num2 = dz6.b();
					float? num3 = num;
					boj.a(A_0, a_2, a_3, a_4, a_5, maxValue, null, num3, num2, null);
					if (dk2.f())
					{
						Vector3 a_6 = vector;
						HorizontalDirection? a_7 = null;
						string a_8 = "xpbl_JetskiWave_BackSplash" + keyValuePair.Key;
						int a_9 = 1;
						double maxValue2 = double.MaxValue;
						num3 = new float?(value);
						num2 = num;
						c5x c5x = boj.a(A_0, a_6, a_7, a_8, a_9, maxValue2, null, num2, num3, null);
						if (c5x != null)
						{
							c5x.Size = new Vector3(0.1f, 0.1f, 0.1f);
							c5x.VisualPriority = -100;
							c5x.ah();
						}
						Vector3 a_10 = vector;
						HorizontalDirection? a_11 = null;
						string a_12 = "xpbl_JetskiWave_WaterDust" + keyValuePair.Key;
						int a_13 = 1;
						double maxValue3 = double.MaxValue;
						num2 = new float?(value);
						num3 = num;
						c5x c5x2 = boj.a(A_0, a_10, a_11, a_12, a_13, maxValue3, null, num3, num2, null);
						if (c5x2 != null)
						{
							c5x2.Size = new Vector3(0.1f, 0.1f, 0.1f);
							c5x2.VisualPriority = -100;
							c5x2.ah();
						}
					}
					result = true;
				}
				return result;
			}
		}
		return false;
	}

	// Token: 0x06006020 RID: 24608 RVA: 0x0029E268 File Offset: 0x0029C468
	public static void a(aud A_0, Point A_1, Point A_2, float A_3)
	{
		int value = (int)bnx.a(A_1.a(), A_2.a());
		double num = 0.7;
		if (A_3 == 0f)
		{
			Vector3 a_ = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ExplosionHE_C_Flame";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? num2 = dz6.b();
			int? num3 = null;
			int? a_5 = num3;
			float? a_6 = null;
			float? a_7 = num2;
			num3 = null;
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num3);
			Vector3 a_8 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_9 = null;
			string a_10 = "ExplosionHE_C_Smoke";
			int a_11 = 1;
			double maxValue2 = double.MaxValue;
			num2 = dz6.b();
			num3 = null;
			int? a_12 = num3;
			float? a_13 = null;
			float? a_14 = num2;
			num3 = null;
			boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, num3);
			return;
		}
		if (A_3 == 1f)
		{
			float? num2;
			int? num3;
			if (cuo.a.NextDouble() < num)
			{
				Vector3 a_15 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
				HorizontalDirection? a_16 = null;
				string a_17 = "ExplosionHE_O_Flame";
				int a_18 = 1;
				double maxValue3 = double.MaxValue;
				num2 = dz6.b();
				num3 = new int?(value);
				boj.a(A_0, a_15, a_16, a_17, a_18, maxValue3, null, null, num2, num3);
				Vector3 a_19 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
				HorizontalDirection? a_20 = null;
				string a_21 = "ExplosionHE_O_Smoke";
				int a_22 = 1;
				double maxValue4 = double.MaxValue;
				num2 = dz6.b();
				num3 = new int?(value);
				boj.a(A_0, a_19, a_20, a_21, a_22, maxValue4, null, null, num2, num3);
				return;
			}
			Vector3 a_23 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_24 = null;
			string a_25 = "ExplosionHE_O_Weak_Flame";
			int a_26 = 1;
			double maxValue5 = double.MaxValue;
			num2 = dz6.b();
			num3 = null;
			int? a_27 = num3;
			float? a_28 = null;
			float? a_29 = num2;
			num3 = null;
			boj.a(A_0, a_23, a_24, a_25, a_26, maxValue5, a_27, a_28, a_29, num3);
			Vector3 a_30 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_31 = null;
			string a_32 = "ExplosionHE_O_Weak_Smoke";
			int a_33 = 1;
			double maxValue6 = double.MaxValue;
			num2 = dz6.b();
			num3 = null;
			int? a_34 = num3;
			float? a_35 = null;
			float? a_36 = num2;
			num3 = null;
			boj.a(A_0, a_30, a_31, a_32, a_33, maxValue6, a_34, a_35, a_36, num3);
			return;
		}
		else
		{
			float? num2;
			int? num3;
			if (cuo.a.NextDouble() < num)
			{
				Vector3 a_37 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
				HorizontalDirection? a_38 = null;
				string a_39 = "ExplosionHE_O_Weak_Flame1";
				int a_40 = 1;
				double maxValue7 = double.MaxValue;
				num2 = dz6.b();
				num3 = new int?(value);
				boj.a(A_0, a_37, a_38, a_39, a_40, maxValue7, null, null, num2, num3);
				Vector3 a_41 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
				HorizontalDirection? a_42 = null;
				string a_43 = "ExplosionHE_O_Weak_Smoke1";
				int a_44 = 1;
				double maxValue8 = double.MaxValue;
				num2 = dz6.b();
				num3 = new int?(value);
				boj.a(A_0, a_41, a_42, a_43, a_44, maxValue8, null, null, num2, num3);
				return;
			}
			Vector3 a_45 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_46 = null;
			string a_47 = "ExplosionHE_O_Weak_Flame";
			int a_48 = 1;
			double maxValue9 = double.MaxValue;
			num2 = dz6.b();
			num3 = null;
			int? a_49 = num3;
			float? a_50 = null;
			float? a_51 = num2;
			num3 = null;
			boj.a(A_0, a_45, a_46, a_47, a_48, maxValue9, a_49, a_50, a_51, num3);
			Vector3 a_52 = new Vector3((float)A_2.X, (float)A_2.Y, 0f);
			HorizontalDirection? a_53 = null;
			string a_54 = "ExplosionHE_O_Weak_Smoke";
			int a_55 = 1;
			double maxValue10 = double.MaxValue;
			num2 = dz6.b();
			num3 = null;
			int? a_56 = num3;
			float? a_57 = null;
			float? a_58 = num2;
			num3 = null;
			boj.a(A_0, a_52, a_53, a_54, a_55, maxValue10, a_56, a_57, a_58, num3);
			return;
		}
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x0029E664 File Offset: 0x0029C864
	public static string c(ak1 A_0)
	{
		if (A_0 != null)
		{
			foreach (b0b b0b in A_0.c.Values)
			{
				c5x c5x = (c5x)b0b;
				if (!c5x.IsFloor)
				{
					break;
				}
				if (c5x.o.b != null && c5x.o.b.a == "Floor\\DirtyWater")
				{
					return "Dirty";
				}
			}
		}
		return string.Empty;
	}

	// Token: 0x06006022 RID: 24610 RVA: 0x0029E710 File Offset: 0x0029C910
	public static bool b(ak1 A_0)
	{
		bool result = true;
		foreach (b0b b0b in A_0.c.Values)
		{
			if (!A_0.Formation.b(64L) || A_0.Formation.c(262272L))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06006023 RID: 24611 RVA: 0x0029E794 File Offset: 0x0029C994
	public static List<KeyValuePair<string, float>> a(ak1 A_0, bool A_1 = false)
	{
		float num = 0f;
		float num2 = 0f;
		if (A_0 != null)
		{
			foreach (b0b b0b in A_0.c.Values)
			{
				c5x c5x = b0b as c5x;
				if (c5x.IsFloor && c5x.o.b != null && c5x.o.b.a != null)
				{
					if (c5x.o.b.a.Equals("Floor\\DirtyWater"))
					{
						num2 = Math.Min(1f, num2 + ((c5x.o.b.d != null) ? c5x.o.b.d.Value : 1f));
					}
					else if (c5x.o.b.a.Equals("Floor\\Water") || c5x.o.b.a.Equals("Floor\\DeepWater"))
					{
						num = Math.Min(1f, num + ((c5x.o.b.d != null) ? c5x.o.b.d.Value : 1f));
					}
				}
			}
		}
		if (A_1 && num < 0.5f && num2 == 0f)
		{
			num = 0.5f;
		}
		List<KeyValuePair<string, float>> list = new List<KeyValuePair<string, float>>();
		num = Math.Max(0f, Math.Min(num, 1f - num2));
		if (num > 0f)
		{
			list.Add(new KeyValuePair<string, float>("", num));
		}
		if (num2 > 0f)
		{
			list.Add(new KeyValuePair<string, float>("Dirty", num2));
		}
		return list;
	}

	// Token: 0x06006024 RID: 24612 RVA: 0x0029E9AC File Offset: 0x0029CBAC
	public static void a(ah7 A_0, int A_1, aud A_2, Vector3 A_3)
	{
		ejt ejt = A_0.g();
		c5x c5x = new c5x();
		c5x.Layer = aju.x;
		c5x.Location = A_3;
		A_2.a(c5x);
		ejt.be(c5x);
		qy qy = new qy();
		qy.ad().Add(new bm3(dz6.b(A_1)));
		List<auv> list = qy.ad();
		c7 c = new c7(c5x, false, false, true, false);
		c.a(true);
		list.Add(c);
		A_2.Zone.ActionManager.g9(qy, atp.a);
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x0029EA30 File Offset: 0x0029CC30
	public static bool b(aud A_0, Point A_1)
	{
		if (A_0 != null)
		{
			ak1 ak = A_0.a(A_1);
			if (ak != null && aw1.a(ak, true, null, l9.b) && aw1.a(ak, true, null, l9.c))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006026 RID: 24614 RVA: 0x0029EA70 File Offset: 0x0029CC70
	public static void a(ak1 A_0)
	{
		if (A_0 != null)
		{
			boj.a(A_0.Area, A_0.Location);
		}
	}

	// Token: 0x06006027 RID: 24615 RVA: 0x0029EA8C File Offset: 0x0029CC8C
	public static void a(aud A_0, Point A_1)
	{
		if (A_0 != null)
		{
			c5x c5x = new c5x();
			c5x.f = true;
			c5x.VisualPriority = 1;
			c5x.Size = new Vector3(1f, 1f, 0.1f);
			c5x.Location = A_1.a();
			c5x.Layer = aju.x;
			c5x.SetAspect<cd0>(new cd0(c5x)
			{
				a = "Floor\\ExplosionDecal",
				b = new Point(cuo.a.Next(3), 0),
				d = new float?(0.5f)
			});
			int a_ = (int)(300000.0 * (0.75 + 0.5 * cuo.a.NextDouble()));
			cm aspect = new cm(c5x, a_, false);
			c5x.SetAspect<cm>(aspect);
			A_0.a(c5x);
		}
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x0029EB68 File Offset: 0x0029CD68
	public static c5x a(float A_0, aud A_1, Point A_2, Point A_3)
	{
		boj.a a;
		a.a = A_2;
		if (A_0 == 0f)
		{
			boj.c(A_1, A_3);
			if (boj.b(A_1, A_3))
			{
				boj.a(A_1, A_3);
				Vector3 a_ = A_3.a() + new Vector3(0.4f, 0.4f, 0f);
				HorizontalDirection? a_2 = null;
				string a_3 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? num = new float?(0.66f);
				int? num2 = null;
				int? a_5 = num2;
				float? a_6 = num;
				float? a_7 = null;
				num2 = null;
				boj.a(A_1, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num2);
			}
		}
		int value = (int)boj.a(A_3, ref a);
		double num3 = 0.7;
		c5x result;
		if (A_0 == 0f)
		{
			Vector3 a_8 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_9 = null;
			string a_10 = "ExplosionHE_C_Flame";
			int a_11 = 1;
			double maxValue2 = double.MaxValue;
			float? num = dz6.b();
			int? num2 = null;
			int? a_12 = num2;
			float? a_13 = null;
			float? a_14 = num;
			num2 = null;
			result = boj.a(A_1, a_8, a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, num2);
			Vector3 a_15 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_16 = null;
			string a_17 = "ExplosionHE_C_Smoke";
			int a_18 = 1;
			double maxValue3 = double.MaxValue;
			num = dz6.b();
			num2 = null;
			int? a_19 = num2;
			float? a_20 = null;
			float? a_21 = num;
			num2 = null;
			boj.a(A_1, a_15, a_16, a_17, a_18, maxValue3, a_19, a_20, a_21, num2);
		}
		else if (A_0 == 1f)
		{
			if (cuo.a.NextDouble() < num3)
			{
				Vector3 a_22 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
				HorizontalDirection? a_23 = null;
				string a_24 = "ExplosionHE_O_Flame";
				int a_25 = 1;
				double maxValue4 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = new int?(value);
				result = boj.a(A_1, a_22, a_23, a_24, a_25, maxValue4, null, null, num, num2);
				Vector3 a_26 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
				HorizontalDirection? a_27 = null;
				string a_28 = "ExplosionHE_O_Smoke";
				int a_29 = 1;
				double maxValue5 = double.MaxValue;
				num = dz6.b();
				num2 = new int?(value);
				boj.a(A_1, a_26, a_27, a_28, a_29, maxValue5, null, null, num, num2);
			}
			else
			{
				Vector3 a_30 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
				HorizontalDirection? a_31 = null;
				string a_32 = "ExplosionHE_O_Weak_Flame";
				int a_33 = 1;
				double maxValue6 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_34 = num2;
				float? a_35 = null;
				float? a_36 = num;
				num2 = null;
				result = boj.a(A_1, a_30, a_31, a_32, a_33, maxValue6, a_34, a_35, a_36, num2);
				Vector3 a_37 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
				HorizontalDirection? a_38 = null;
				string a_39 = "ExplosionHE_O_Weak_Smoke";
				int a_40 = 1;
				double maxValue7 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_41 = num2;
				float? a_42 = null;
				float? a_43 = num;
				num2 = null;
				boj.a(A_1, a_37, a_38, a_39, a_40, maxValue7, a_41, a_42, a_43, num2);
			}
		}
		else if (cuo.a.NextDouble() < num3)
		{
			Vector3 a_44 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_45 = null;
			string a_46 = "ExplosionHE_O_Weak_Flame1";
			int a_47 = 1;
			double maxValue8 = double.MaxValue;
			float? num = dz6.b();
			int? num2 = new int?(value);
			result = boj.a(A_1, a_44, a_45, a_46, a_47, maxValue8, null, null, num, num2);
			Vector3 a_48 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_49 = null;
			string a_50 = "ExplosionHE_O_Weak_Smoke1";
			int a_51 = 1;
			double maxValue9 = double.MaxValue;
			num = dz6.b();
			num2 = new int?(value);
			boj.a(A_1, a_48, a_49, a_50, a_51, maxValue9, null, null, num, num2);
		}
		else
		{
			Vector3 a_52 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_53 = null;
			string a_54 = "ExplosionHE_O_Weak_Flame";
			int a_55 = 1;
			double maxValue10 = double.MaxValue;
			float? num = dz6.b();
			int? num2 = null;
			int? a_56 = num2;
			float? a_57 = null;
			float? a_58 = num;
			num2 = null;
			result = boj.a(A_1, a_52, a_53, a_54, a_55, maxValue10, a_56, a_57, a_58, num2);
			Vector3 a_59 = new Vector3((float)A_3.X, (float)A_3.Y, 0f);
			HorizontalDirection? a_60 = null;
			string a_61 = "ExplosionHE_O_Weak_Smoke";
			int a_62 = 1;
			double maxValue11 = double.MaxValue;
			num = dz6.b();
			num2 = null;
			int? a_63 = num2;
			float? a_64 = null;
			float? a_65 = num;
			num2 = null;
			boj.a(A_1, a_59, a_60, a_61, a_62, maxValue11, a_63, a_64, a_65, num2);
		}
		return result;
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x0029F03C File Offset: 0x0029D23C
	[CompilerGenerated]
	internal static HorizontalDirection a(Point A_0, ref boj.a A_1)
	{
		return bnx.a(A_1.a.a(), A_0.a());
	}

	// Token: 0x02001199 RID: 4505
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	private struct a
	{
		// Token: 0x040028A8 RID: 10408
		public Point a;
	}
}
