using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200114A RID: 4426
[eiz("IVC")]
[Serializable]
public sealed class ae4 : ISerializable
{
	// Token: 0x06005EDE RID: 24286 RVA: 0x00282AC4 File Offset: 0x00280CC4
	private ae4(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("IVC:C");
		if (ell.a() >= 402)
		{
			di7.ReadList<ar7>("IVC:E", ref this.b, A_0);
			this.c = A_0.GetDouble("IVC:D");
		}
		else
		{
			this.b = new List<ar7>();
		}
		if (ell.a() >= 403)
		{
			this.d = A_0.GetDouble("IVC:L");
		}
	}

	// Token: 0x06005EDF RID: 24287 RVA: 0x00282B64 File Offset: 0x00280D64
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IVC:C", this.a);
		di7.WriteList<ar7>("IVC:E", this.b, info);
		info.AddValue("IVC:D", this.c);
		info.AddValue("IVC:L", this.d);
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x00282BB8 File Offset: 0x00280DB8
	public ae4()
	{
	}

	// Token: 0x06005EE1 RID: 24289 RVA: 0x00282BDC File Offset: 0x00280DDC
	public void a(c5x A_0)
	{
		this.a = 750.0;
		foreach (ar7 ar in this.b)
		{
			if (ar.ao() != null && ar.ao().j == cgy.b)
			{
				cix cix = ar.ao().Zone.ActionManager;
				c7 c = new c7(ar.ao(), false, false, false, false);
				c.a(true);
				cix.g9(c, atp.a);
			}
		}
	}

	// Token: 0x06005EE2 RID: 24290 RVA: 0x00282C88 File Offset: 0x00280E88
	public void a(c5x A_0, bcx A_1, double A_2)
	{
		this.a(A_0, A_1.y(), A_2);
	}

	// Token: 0x06005EE3 RID: 24291 RVA: 0x00282C98 File Offset: 0x00280E98
	public void a(c5x A_0, bws A_1, double A_2)
	{
		this.c = 0.0;
		this.d = 0.0;
		if (A_1 == bws.b || A_1 == bws.a)
		{
			if (A_0 != null)
			{
				if (A_0.i.b != null && A_0.i.b.a() != null && A_0.i.b.a().Name == "rampJump")
				{
					return;
				}
				as7 @as = A_0.GetAspect<bdf>() as as7;
				if (@as != null && @as.a())
				{
					return;
				}
			}
			if ((this.a += A_2) > 1000.0)
			{
				this.a = 0.0;
				foreach (KeyValuePair<string, float> keyValuePair in boj.a(Enumerable.FirstOrDefault<ak1>(A_0.l), false))
				{
					c5x c5x;
					if (keyValuePair.Value == 1f)
					{
						c5x = boj.a(A_0, "xpbl_JetskiWave_Standing" + keyValuePair.Key, 1, double.MaxValue, false, false, null, null, null, null, false);
					}
					else
					{
						string a_ = "xpbl_JetskiWave_Standing" + keyValuePair.Key;
						int a_2 = 1;
						double maxValue = double.MaxValue;
						bool a_3 = false;
						bool a_4 = false;
						float? a_5 = new float?(keyValuePair.Value);
						c5x = boj.a(A_0, a_, a_2, maxValue, a_3, a_4, null, null, a_5, null, false);
					}
					if (c5x != null)
					{
						if (c5x.o.b != null)
						{
							c5x.o.b.b = new Point(0, A_0.ac);
						}
						c5x.x = true;
						c5x.y = true;
						dha aspect = c5x.GetAspect<dha>();
						if (aspect != null)
						{
							aspect.b(true);
						}
						this.b.Add(new ar7(c5x));
						if (A_0 != null && A_0.IsPlayer)
						{
							c5x.b(aju.b3);
						}
					}
				}
			}
		}
		this.a();
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x00282F18 File Offset: 0x00281118
	public void a(amc A_0, int A_1)
	{
		if (A_0 != null && aya.a(A_0))
		{
			A_0.aa().Vehicle;
			c5x c5x = A_0.a8();
			List<KeyValuePair<string, float>> list = boj.a(Enumerable.FirstOrDefault<ak1>(c5x.l), false);
			int num = -list.Count;
			foreach (KeyValuePair<string, float> keyValuePair in list)
			{
				num++;
				float? num2;
				if (keyValuePair.Value != 1f)
				{
					num2 = new float?(keyValuePair.Value);
				}
				else
				{
					num2 = null;
				}
				string key = keyValuePair.Key;
				for (int i = 0; i < A_1; i++)
				{
					float num3 = Convert.ToSingle(0.75 + cuo.a.NextDouble() * 1.0) * dz6.b().GetValueOrDefault(1f);
					if (dz6.a() != null)
					{
						num3 *= dz6.a().Value;
					}
					Vector3 value = new Vector3((float)i / (float)A_1, 0f, 0f) + new Vector3(0.22f, 0.22f, 0f) * Convert.ToSingle(cuo.a.NextDouble());
					c5x a_ = c5x;
					string a_2 = "xpbl_JetskiWave_BackSplash" + key;
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = false;
					bool a_5 = false;
					Vector3? a_6 = new Vector3?(value);
					float? num4 = new float?(num3);
					float? num5 = num2;
					c5x c5x2 = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, num5, num4, false);
					c5x2.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x2.VisualPriority = -100;
					c5x2.ah();
					c5x a_7 = c5x;
					string a_8 = "xpbl_JetskiWave_WaterDust" + key;
					int a_9 = 1;
					double maxValue2 = double.MaxValue;
					bool a_10 = false;
					bool a_11 = false;
					Vector3? a_12 = new Vector3?(value);
					num5 = new float?(num3);
					num4 = num2;
					c5x c5x3 = boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, a_12, null, num4, num5, false);
					c5x3.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x3.VisualPriority = -100;
					c5x3.ah();
					value = new Vector3((float)i / (float)A_1, 0.75f, 0f) + new Vector3(0.22f, 0.22f, 0f) * Convert.ToSingle(cuo.a.NextDouble());
					c5x a_13 = c5x;
					string a_14 = "xpbl_JetskiWave_BackSplash" + key;
					int a_15 = 1;
					double maxValue3 = double.MaxValue;
					bool a_16 = false;
					bool a_17 = false;
					Vector3? a_18 = new Vector3?(value);
					num4 = new float?(num3);
					num5 = num2;
					c5x c5x4 = boj.a(a_13, a_14, a_15, maxValue3, a_16, a_17, a_18, null, num5, num4, false);
					c5x4.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x4.VisualPriority = 100;
					c5x4.x = true;
					c5x4.y = true;
					c5x4.ah();
					c5x a_19 = c5x;
					string a_20 = "xpbl_JetskiWave_WaterDust" + key;
					int a_21 = 1;
					double maxValue4 = double.MaxValue;
					bool a_22 = false;
					bool a_23 = false;
					Vector3? a_24 = new Vector3?(value);
					num5 = new float?(num3);
					num4 = num2;
					c5x c5x5 = boj.a(a_19, a_20, a_21, maxValue4, a_22, a_23, a_24, null, num4, num5, false);
					c5x5.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x5.VisualPriority = 100;
					c5x5.x = true;
					c5x5.y = true;
					c5x5.ah();
				}
				for (int j = 0; j < A_1; j++)
				{
					float num6 = Convert.ToSingle(0.75 + cuo.a.NextDouble() * 1.0);
					if (dz6.a() != null)
					{
						num6 *= dz6.a().Value;
					}
					Vector3 value2 = new Vector3(0f, (float)j / (float)A_1, 0f) + new Vector3(0.22f, 0.22f, 0f) * Convert.ToSingle(cuo.a.NextDouble());
					c5x a_25 = c5x;
					string a_26 = "xpbl_JetskiWave_BackSplash" + key;
					int a_27 = 1;
					double maxValue5 = double.MaxValue;
					bool a_28 = false;
					bool a_29 = false;
					Vector3? a_30 = new Vector3?(value2);
					float? num4 = new float?(num6);
					float? num5 = num2;
					c5x c5x6 = boj.a(a_25, a_26, a_27, maxValue5, a_28, a_29, a_30, null, num5, num4, false);
					c5x6.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x6.VisualPriority = -100;
					c5x6.ah();
					c5x a_31 = c5x;
					string a_32 = "xpbl_JetskiWave_WaterDust" + key;
					int a_33 = 1;
					double maxValue6 = double.MaxValue;
					bool a_34 = false;
					bool a_35 = false;
					Vector3? a_36 = new Vector3?(value2);
					num5 = new float?(num6);
					num4 = num2;
					c5x c5x7 = boj.a(a_31, a_32, a_33, maxValue6, a_34, a_35, a_36, null, num4, num5, false);
					c5x7.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x7.VisualPriority = -100;
					c5x7.ah();
					value2 = new Vector3(0.75f, (float)j / (float)A_1, 0f) + new Vector3(0.22f, 0.22f, 0f) * Convert.ToSingle(cuo.a.NextDouble());
					c5x a_37 = c5x;
					string a_38 = "xpbl_JetskiWave_BackSplash" + key;
					int a_39 = 1;
					double maxValue7 = double.MaxValue;
					bool a_40 = false;
					bool a_41 = false;
					Vector3? a_42 = new Vector3?(value2);
					num4 = new float?(num6);
					num5 = num2;
					c5x c5x8 = boj.a(a_37, a_38, a_39, maxValue7, a_40, a_41, a_42, null, num5, num4, false);
					c5x8.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x8.VisualPriority = 100;
					c5x8.x = true;
					c5x8.y = true;
					c5x8.ah();
					c5x a_43 = c5x;
					string a_44 = "xpbl_JetskiWave_WaterDust" + key;
					int a_45 = 1;
					double maxValue8 = double.MaxValue;
					bool a_46 = false;
					bool a_47 = false;
					Vector3? a_48 = new Vector3?(value2);
					num5 = new float?(num6);
					num4 = num2;
					c5x c5x9 = boj.a(a_43, a_44, a_45, maxValue8, a_46, a_47, a_48, null, num4, num5, false);
					c5x9.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x9.VisualPriority = 100;
					c5x9.x = true;
					c5x9.y = true;
					c5x9.ah();
				}
			}
		}
	}

	// Token: 0x06005EE5 RID: 24293 RVA: 0x00283548 File Offset: 0x00281748
	public void a(amc A_0, float A_1, c5x A_2 = null, bcx A_3 = null)
	{
		if (A_0 != null && aya.a(A_0))
		{
			bcx bcx;
			if (A_3 != null)
			{
				bcx = A_3;
			}
			else
			{
				bcx = A_0.aa().Vehicle;
			}
			c5x c5x;
			if (A_2 != null)
			{
				c5x = A_2;
			}
			else
			{
				c5x = A_0.a8();
			}
			if ((this.c += (double)A_1) > 0.2)
			{
				this.c -= 0.15 + cuo.a.NextDouble() * 0.1;
				double num = A_0.aa().Vehicle.m();
				float num2 = 1.25f;
				float num3 = 0.7f + bcx.an().h();
				float num4 = 1.76f + bcx.an().a();
				float num5 = num3 * 1f;
				float num6 = 1.85f + bcx.an().c();
				float num7 = num6 * 0.8f;
				float num8 = num4 * 0.8f;
				bool flag = false;
				Vector2 value;
				Vector2 value2;
				Vector2 value3;
				switch (c5x.VisualDirection)
				{
				case HorizontalDirection.North:
					value = new Vector2(-num3, -num2);
					value2 = new Vector2(num3, -num2);
					value3 = new Vector2(0f, num6);
					flag = true;
					goto IL_2A5;
				case HorizontalDirection.Northeast:
					value = new Vector2(num4 - num5, -num4);
					value2 = new Vector2(num4, -num4 + num5);
					value3 = new Vector2(-num8, num7);
					flag = true;
					goto IL_2A5;
				case HorizontalDirection.East:
					value = new Vector2(num2, -num3);
					value2 = new Vector2(num2, num3);
					value3 = new Vector2(-num6, 0f);
					goto IL_2A5;
				case HorizontalDirection.Southeast:
					value = new Vector2(num4 - num5, num4);
					value2 = new Vector2(num4, num4 - num5);
					value3 = new Vector2(-num8, -num8);
					goto IL_2A5;
				case HorizontalDirection.South:
					value = new Vector2(-num3, num2);
					value2 = new Vector2(num3, num2);
					value3 = new Vector2(0f, -num6);
					goto IL_2A5;
				case HorizontalDirection.Southwest:
					value = new Vector2(-num4, num4 - num5);
					value2 = new Vector2(-num4 + num5, num4);
					value3 = new Vector2(num7, -num8);
					flag = true;
					goto IL_2A5;
				case HorizontalDirection.Northwest:
					value = new Vector2(-num4, -num4 + num5);
					value2 = new Vector2(-num4 + num5, -num4);
					value3 = new Vector2(num7, num7);
					flag = true;
					goto IL_2A5;
				}
				value = new Vector2(-num2, -num3);
				value2 = new Vector2(-num2, num3);
				value3 = new Vector2(num6, 0f);
				flag = true;
				IL_2A5:
				string str = "xpbl_JetskiWave_SideSplash";
				string str2 = "xpbl_JetskiWave_SideSplash";
				if (num >= 2.5)
				{
					double num9 = d05.b(0.1, 0.15 + num / 25.0, 0.75);
					if (cuo.a.NextDouble() < num9)
					{
						str += "Big";
					}
					if (cuo.a.NextDouble() < num9)
					{
						str2 += "Big";
					}
				}
				double num10 = cuo.a.NextDouble();
				double num11 = cuo.a.NextDouble();
				double num12 = cuo.a.NextDouble();
				double num13 = cuo.a.NextDouble();
				float scaleFactor = this.b();
				float scaleFactor2 = this.b();
				float scaleFactor3 = this.b();
				float scaleFactor4 = this.b();
				float scaleFactor5 = this.b();
				float scaleFactor6 = this.b();
				List<KeyValuePair<string, float>> list = boj.a(Enumerable.FirstOrDefault<ak1>(c5x.l), false);
				int num14 = -list.Count;
				foreach (KeyValuePair<string, float> keyValuePair in list)
				{
					num14++;
					float? num15;
					if (keyValuePair.Value != 1f)
					{
						num15 = new float?(keyValuePair.Value);
					}
					else
					{
						num15 = null;
					}
					string key = keyValuePair.Key;
					string text = str + key;
					string text2 = str2 + key;
					c5x a_ = c5x;
					string a_2 = text;
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = false;
					bool a_5 = false;
					Vector3? a_6 = new Vector3?((value * scaleFactor).b());
					float? num16 = dz6.a();
					float? num17 = num15;
					c5x c5x2 = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, num17, num16, false);
					this.a(c5x2, c5x, true, false);
					c5x2.VisualPriority = -98 + num14;
					if (num10 < 0.5)
					{
						c5x a_7 = c5x;
						string a_8 = "xpbl_JetskiWave_WaterDust" + key;
						int a_9 = 1;
						double maxValue2 = double.MaxValue;
						bool a_10 = false;
						bool a_11 = false;
						Vector3? a_12 = new Vector3?((value * scaleFactor2).b());
						num17 = dz6.a();
						num16 = num15;
						c5x c5x3 = boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, a_12, null, num16, num17, false);
						this.a(c5x3, c5x, false, false);
						c5x3.VisualPriority = -98 + num14;
					}
					c5x a_13 = c5x;
					string a_14 = text2;
					int a_15 = 1;
					double maxValue3 = double.MaxValue;
					bool a_16 = false;
					bool a_17 = false;
					Vector3? a_18 = new Vector3?((value2 * scaleFactor3).b());
					num16 = dz6.a();
					num17 = num15;
					c5x c5x4 = boj.a(a_13, a_14, a_15, maxValue3, a_16, a_17, a_18, null, num17, num16, false);
					this.a(c5x4, c5x, true, true);
					c5x4.VisualPriority = 98 + num14;
					if (num11 < 0.5)
					{
						c5x a_19 = c5x;
						string a_20 = "xpbl_JetskiWave_WaterDust" + key;
						int a_21 = 1;
						double maxValue4 = double.MaxValue;
						bool a_22 = false;
						bool a_23 = false;
						Vector3? a_24 = new Vector3?((value2 * scaleFactor4).b());
						num17 = dz6.a();
						num16 = num15;
						c5x c5x5 = boj.a(a_19, a_20, a_21, maxValue4, a_22, a_23, a_24, null, num16, num17, false);
						this.a(c5x5, c5x, false, true);
						c5x5.VisualPriority = -98 + num14;
					}
					if (A_2 == null && num >= 0.5 && num12 < 0.8)
					{
						c5x a_25 = c5x;
						string a_26 = "xpbl_JetskiWave_BackSplash" + key;
						int a_27 = 1;
						double maxValue5 = double.MaxValue;
						bool a_28 = false;
						bool a_29 = false;
						Vector3? a_30 = new Vector3?((value3 * scaleFactor5).b());
						num16 = dz6.a();
						num17 = num15;
						c5x a_31 = boj.a(a_25, a_26, a_27, maxValue5, a_28, a_29, a_30, null, num17, num16, false);
						this.a(a_31, c5x, false, flag);
						c5x4.VisualPriority = (flag ? 97 : -97) + num14;
						if (num13 < 0.3)
						{
							c5x a_32 = c5x;
							string a_33 = "xpbl_JetskiWave_WaterDust" + key;
							int a_34 = 1;
							double maxValue6 = double.MaxValue;
							bool a_35 = false;
							bool a_36 = false;
							Vector3? a_37 = new Vector3?((value2 * scaleFactor6).b());
							num17 = dz6.a();
							num16 = num15;
							c5x c5x6 = boj.a(a_32, a_33, a_34, maxValue6, a_35, a_36, a_37, null, num16, num17, false);
							this.a(c5x6, c5x, false, flag);
							c5x6.VisualPriority = (flag ? 97 : -97) + num14;
						}
					}
				}
			}
			if ((this.d += (double)A_1) > 0.75)
			{
				List<KeyValuePair<string, float>> list2 = boj.a(Enumerable.FirstOrDefault<ak1>(c5x.l), false);
				int num18 = -list2.Count;
				foreach (KeyValuePair<string, float> keyValuePair2 in list2)
				{
					num18++;
					string key2 = keyValuePair2.Key;
					float? num19;
					if (keyValuePair2.Value != 1f)
					{
						num19 = new float?(keyValuePair2.Value);
					}
					else
					{
						num19 = null;
					}
					this.d -= 0.75;
					c5x a_38 = c5x;
					string a_39 = "xpbl_JetskiWave_BackWave" + key2;
					int a_40 = 1;
					double maxValue7 = double.MaxValue;
					bool a_41 = true;
					bool a_42 = false;
					float? num16 = dz6.a();
					float? num17 = num19;
					c5x c5x7 = boj.a(a_38, a_39, a_40, maxValue7, a_41, a_42, null, null, num17, num16, false);
					this.a(c5x7, c5x, true, false);
					c5x7.Location = new Vector3(c5x7.Location.X, c5x7.Location.Y, -0.2f);
					c5x7.VisualPriority = -101 + num18;
					c5x7.x = true;
					c5x7.ah();
					dha aspect = c5x7.GetAspect<dha>();
					if (aspect != null)
					{
						aspect.b(true);
					}
				}
			}
		}
	}

	// Token: 0x06005EE6 RID: 24294 RVA: 0x00283DD8 File Offset: 0x00281FD8
	private float b()
	{
		return (float)(0.45 + cuo.a.NextDouble() * 0.1);
	}

	// Token: 0x06005EE7 RID: 24295 RVA: 0x00283DFC File Offset: 0x00281FFC
	private void a(c5x A_0, c5x A_1, bool A_2, bool A_3)
	{
		if (A_0 != null)
		{
			A_0.Size = new Vector3(0.1f, 0.1f, 0.1f);
			if (A_2 && A_0.o.b != null)
			{
				A_0.o.b.b = new Point(0, A_1.ac);
			}
			A_0.x = false;
			A_0.y = false;
			A_0.ah();
			if (A_1 != null && A_1.IsPlayer)
			{
				A_0.b(aju.b3);
			}
		}
	}

	// Token: 0x06005EE8 RID: 24296 RVA: 0x00283E8C File Offset: 0x0028208C
	private void a()
	{
		if (this.b.Count > 0)
		{
			for (int i = this.b.Count - 1; i >= 0; i--)
			{
				ar7 ar = this.b[i];
				if (ar.ao() == null || ar.ao().j != cgy.b)
				{
					this.b.RemoveAt(i);
				}
			}
		}
	}

	// Token: 0x040025AA RID: 9642
	private double a = 750.0;

	// Token: 0x040025AB RID: 9643
	private List<ar7> b = new List<ar7>();

	// Token: 0x040025AC RID: 9644
	private double c;

	// Token: 0x040025AD RID: 9645
	private double d;
}
