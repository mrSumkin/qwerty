using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02001145 RID: 4421
public sealed class cjv : cm9
{
	// Token: 0x06005EB3 RID: 24243 RVA: 0x00281364 File Offset: 0x0027F564
	public double ot()
	{
		return 33.0;
	}

	// Token: 0x06005EB4 RID: 24244 RVA: 0x00281370 File Offset: 0x0027F570
	public void ou(cnk A_0)
	{
		ps service = bpo.GetService<ps>();
		dd7 service2 = bpo.GetService<dd7>();
		if (service != null && A_0.aqu() != null && A_0.aqu().v() != null && !A_0.aqu().v().Dead)
		{
			au2 au = A_0.aqu().v();
			y4 y = Enumerable.FirstOrDefault<y4>(A_0.aqu().v().StatusEffects.Get<y4>());
			if (y != null)
			{
				if (y.e == null || (y.g -= this.ot()) <= 0.0)
				{
					string e;
					while ((e = this.a()) == y.e)
					{
					}
					y.e = e;
					y.g = (3.0 + 10.0 * cuo.a.NextDouble()) * 1000.0;
				}
				Vector3 zero = Vector3.Zero;
				this.a(y.e, "r", 0, ref zero.X);
				this.a(y.e, "g", 0, ref zero.Y);
				this.a(y.e, "b", 0, ref zero.Z);
				Vector3 f = y.f;
				if (!service.ak4())
				{
					float num = Convert.ToSingle(this.ot() * 5E-05 * (double)((float)y.Stacks / 30f));
					f.X = d05.b(0.3f, f.X + zero.X * num, 1f);
					f.Y = d05.b(0.3f, f.Y + zero.Y * num, 1f);
					f.Z = d05.b(0.3f, f.Z + zero.Z * num, 1f);
					y.f = f;
				}
				if (service != null)
				{
					if (A_0.aqu().v().Gear.g().Item != null && !string.IsNullOrEmpty(A_0.aqu().v().Gear.g().Item.fu().a5()) && A_0.aqu().v().Gear.g().Item.fu().a5() == "perceptualIsolationHelmet")
					{
						service.and(null);
					}
					else
					{
						service.and(new Color?(new Color(f)));
					}
				}
				if (service2 != null)
				{
					TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
					double num2 = 30000.0;
					double num3 = num2 / 2.0;
					double num4 = timeSpan.TotalMilliseconds % num2;
					double num5 = 0.3 * (double)((float)y.Stacks / (float)Math.Max(1, y.MaxStacks));
					double value;
					if (num4 < num3)
					{
						value = 1.0 - num5 + 2.0 * num5 * (num4 / num3);
					}
					else
					{
						num4 -= num3;
						value = 1.0 + num5 - 2.0 * num5 * (num4 / num3);
					}
					service2.ady(new float?(Convert.ToSingle(value)));
				}
				if (au.Feats.Contains<acy>())
				{
					au.CustomProperties["timeWithoutMotion"] = 0;
				}
				return;
			}
			if (!dz6.e() && !service.alk())
			{
				double? num6 = au.CustomProperties.GetPrimitivePropertyValue<double>("mindFogCache", null);
				if (num6 == null)
				{
					au.CustomProperties["mindFogCache"] = this.b();
				}
				else
				{
					byf byf = Enumerable.FirstOrDefault<byf>(au.StatusEffects.Get<byf>());
					eyr eyr = Enumerable.FirstOrDefault<eyr>(au.StatusEffects.Get<eyr>());
					due due = Enumerable.FirstOrDefault<due>(au.StatusEffects.Get<due>());
					if (byf == null && eyr == null && due == null)
					{
						num6 -= this.ot();
						if (num6.Value <= 0.0)
						{
							au.CustomProperties["mindFogCache"] = this.b();
							if (!au.Feats.Contains<acy>())
							{
								int num7 = au.CustomProperties.GetPrimitivePropertyValue<int>("motionDrags", new int?(0)).Value;
								num7 = Math.Max(0, num7 - 3);
								au.CustomProperties["motionDrags"] = num7;
								Random random;
								if (A_0.aqu() != null)
								{
									random = new Random(A_0.aqu().l() + "motion".GetHashCode());
								}
								else
								{
									random = cuo.a;
								}
								int num8 = 100 + random.Next(120);
								if (num7 > num8)
								{
									c93 c = new c93();
									c.a(true);
									c.a("Motioner");
									c.ym(null, null, null);
								}
							}
							else if (cuo.a.NextDouble() < cjv.b)
							{
								byf = new byf();
								byf.Stacks = cuo.a.Next(byf.MaxStacks + 1);
								au.StatusEffects.a(byf, false, false, false);
							}
							else
							{
								due = new due((5 + cuo.a.Next(6)) * 60 * 1000);
								au.StatusEffects.a(due, false, false, false);
							}
						}
						else
						{
							au.CustomProperties["mindFogCache"] = num6.Value;
						}
					}
					if (au.Feats.Contains<acy>())
					{
						double num9 = au.CustomProperties.GetPrimitivePropertyValue<double>("timeWithoutMotion", new double?(0.0)).Value;
						num9 += this.ot();
						Random random2 = new Random(A_0.aqu().l() + "motionRehab".GetHashCode());
						int num10 = 5 + random2.Next(4) * 60 * 60 * 1000;
						if (num9 >= (double)num10 && byf == null && eyr == null && due == null)
						{
							num9 = 0.0;
							a9w a9w = new a9w();
							a9w.a(true);
							a9w.a("Motioner");
							a9w.ym(null, null, null);
							au.CustomProperties["motionDrags"] = 0;
						}
						au.CustomProperties["timeWithoutMotion"] = num9;
					}
				}
			}
		}
		if (service != null && !service.alk())
		{
			service.and(null);
		}
		if ((service == null || !service.alk()) && service2 != null)
		{
			service2.ady(null);
		}
	}

	// Token: 0x06005EB5 RID: 24245 RVA: 0x00281AB8 File Offset: 0x0027FCB8
	private double b()
	{
		return (double)(cjv.a / 2 + cuo.a.Next(cjv.a));
	}

	// Token: 0x06005EB6 RID: 24246 RVA: 0x00281AD4 File Offset: 0x0027FCD4
	private void a(string A_0, string A_1, int A_2, ref float A_3)
	{
		if (A_0.Contains(A_1))
		{
			A_3 = 1f;
			return;
		}
		A_3 = -1f;
	}

	// Token: 0x06005EB7 RID: 24247 RVA: 0x00281AF4 File Offset: 0x0027FCF4
	private string a()
	{
		string text = this.c[cuo.a.Next(this.c.Length)];
		if (cuo.a.NextDouble() < 0.75)
		{
			string str = this.c[cuo.a.Next(this.c.Length)];
			if (str != text)
			{
				text += str;
			}
		}
		return text;
	}

	// Token: 0x0400259C RID: 9628
	private static readonly int a = 900000;

	// Token: 0x0400259D RID: 9629
	private static readonly double b = 0.15;

	// Token: 0x0400259E RID: 9630
	private string[] c = new string[]
	{
		"r",
		"g",
		"b"
	};
}
