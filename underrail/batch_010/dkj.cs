using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A92 RID: 2706
[eiz("LUUMBFJ")]
[Serializable]
public sealed class dkj : cze, ISerializable
{
	// Token: 0x06003F7C RID: 16252 RVA: 0x00180F98 File Offset: 0x0017F198
	private dkj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x00180FA4 File Offset: 0x0017F1A4
	public dkj()
	{
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x00180FB0 File Offset: 0x0017F1B0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("lux-md");
			if (aud != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lux-md_freezerDisabled", new bool?(false)).Value;
				string[] array = new string[]
				{
					"1587f2a0-039f-419c-8177-1563985bfb12",
					"48916f98-aca4-49dd-86cc-512f05253f36",
					"623b0973-b495-46f0-9b7f-840b020b5904",
					"8cb7d6e9-92c6-42a7-8d2e-7b447facf8f8",
					"ad521d29-72ed-439c-b191-710b2c02c607",
					"eb016133-678a-4285-9d43-0b2e71f0d8d4",
					"76624f59-4b43-49b4-bda7-09a9c80670be"
				};
				string[] array2 = new string[]
				{
					"2f548ae9-b0d5-48ce-9117-67aa472d5133",
					"2cfc0a92-6cc3-4d58-a111-73db90689764",
					"bbaf7969-5128-4cc1-8287-6cc565db0e54",
					"cdc5ef7c-0ccd-420b-a18e-1fb06a2e239b",
					"f36502fa-2df6-482a-a93a-d9edc8d4cef6",
					"64baf23a-1700-4c62-ac69-fac84e9f8674"
				};
				foreach (string g in array)
				{
					EntityAspectReference<dxv, dxv> entityAspectReference = new EntityAspectReference<dxv, dxv>(aud, new Guid(g));
					if (entityAspectReference.ao() != null)
					{
						entityAspectReference.ao().a(!value);
					}
				}
				float? num = null;
				for (int j = 23; j <= 38; j++)
				{
					for (int k = 1; k <= 8; k++)
					{
						ak1 ak = aud.b(j, k);
						if (ak != null)
						{
							foreach (b0b b0b in ak.c.Values)
							{
								c5x c5x = (c5x)b0b;
								if (c5x.Layer == aju.x && c5x.o.b != null && c5x.o.b.d != null)
								{
									float? num2 = null;
									if (c5x.o.b.a == "Effects\\ColdWallSmoke")
									{
										num2 = new float?(0.7f);
									}
									else if (c5x.o.b.a == "Objects\\WallDecorations\\WallIce")
									{
										num2 = new float?(0.6f);
									}
									if (num2 != null)
									{
										if (value)
										{
											if (c5x.o.b.d.Value > 0f)
											{
												c5x.o.b.d = new float?(Math.Max(0f, c5x.o.b.d.Value - 0.01f));
											}
										}
										else if (c5x.o.b.d.Value < num2.Value)
										{
											c5x.o.b.d = new float?(Math.Min(num2.Value, c5x.o.b.d.Value + 0.01f));
										}
										if (num == null)
										{
											num = c5x.o.b.d;
										}
									}
								}
							}
						}
					}
				}
				bool? flag = null;
				if (num != null)
				{
					if (num.Value >= 0.59f)
					{
						flag = new bool?(true);
					}
					else if (num.Value <= 0.2f)
					{
						flag = new bool?(false);
					}
				}
				if (flag != null)
				{
					foreach (string g2 in array2)
					{
						EntityAspectReference<amc, amc> entityAspectReference2 = new EntityAspectReference<amc, amc>(aud, new Guid(g2));
						if (entityAspectReference2.ao() != null && !entityAspectReference2.ao().aa().IsInCombat)
						{
							a2 a = Enumerable.FirstOrDefault<a2>(entityAspectReference2.ao().aa().StatusEffects.Get<a2>());
							if (flag.Value)
							{
								if (a == null || a.Duration != 0)
								{
									entityAspectReference2.ao().u();
									entityAspectReference2.ao().aa().StatusEffects.d(a);
									entityAspectReference2.ao().aa().StatusEffects.a(new a2(0, new double?(co4.b)), false, false, false);
									awq.e(entityAspectReference2.ao());
									awq.b(entityAspectReference2.ao());
									entityAspectReference2.ao().aa().PersonalAttitudes.Clear();
									entityAspectReference2.ao().aa().FactionId = asp.a3;
								}
							}
							else
							{
								if (a != null && a.Duration == 0)
								{
									entityAspectReference2.ao().aa().StatusEffects.d(a);
								}
								entityAspectReference2.ao().aa().FactionId = asp.@as;
							}
						}
					}
				}
				EntityAspectReference<cnb, bim> entityAspectReference3 = new EntityAspectReference<cnb, bim>(aud, new Guid("9d582189-9d8d-4a75-96dd-24aae4146ebf"));
				EntityAspectReference<d2b, d2b> entityAspectReference4 = new EntityAspectReference<d2b, d2b>(aud, new Guid("9d582189-9d8d-4a75-96dd-24aae4146ebf"));
				EntityAspectReference<cd0, cd0> entityAspectReference5 = new EntityAspectReference<cd0, cd0>(aud, new Guid("692fcc3f-8a24-4ece-8557-08c9fb4fa45c"));
				if (entityAspectReference3.ao() != null && entityAspectReference5.ao() != null && entityAspectReference4.ao() != null)
				{
					float? d = entityAspectReference5.ao().d;
					double? num3 = (d != null) ? new double?((double)d.GetValueOrDefault()) : null;
					if (entityAspectReference3.ao().q())
					{
						entityAspectReference5.ao().d = new float?(0f);
					}
					if (entityAspectReference3.ao().q() || (num3 != null && num3.Value <= 0.10000000149011612))
					{
						entityAspectReference4.ao().a(null);
						entityAspectReference4.ao().e(false);
						return;
					}
					if (!entityAspectReference3.ao().q() && num3 != null && num3.Value >= 0.44999998807907104)
					{
						entityAspectReference4.ao().a("Frozen shut");
						entityAspectReference4.ao().e(true);
					}
				}
			}
		}
	}
}
