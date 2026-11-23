using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200090C RID: 2316
[eiz("CCPT")]
[Serializable]
public sealed class evb : bdw, ISerializable
{
	// Token: 0x0600391F RID: 14623 RVA: 0x00152324 File Offset: 0x00150524
	private evb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x0015232C File Offset: 0x0015052C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x00152330 File Offset: 0x00150530
	public evb()
	{
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x00152338 File Offset: 0x00150538
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc16");
			if (aud != null)
			{
				string[] array = new string[]
				{
					"94a7f948-a029-4021-9eb2-daf0fcec544a",
					"1f094a13-7c4d-464a-9253-78eb2567d134",
					"d9b9a44e-e888-445b-9a4a-db88bdfad2f9",
					"98d25210-fc17-4c5f-8cd1-36c7ebd04ad2",
					"a8c93609-376f-4570-a676-87bc77ee09ee",
					"23f6a660-c01f-49ea-90fd-39a3712a1e91",
					"bb4b709e-cd52-4770-be2d-161df4d7bed8"
				};
				for (int i = 0; i < array.Length; i++)
				{
					c5x c5x = new ar7(new Guid(array[i]), aud).ao() as c5x;
					if (c5x != null)
					{
						c5x.w();
						c5x.an();
					}
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc16_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				List<Guid> list = new List<Guid>();
				list.Add(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"));
				list.Add(new Guid("4a06e8fb-c9d2-4c18-afad-6e92118ef334"));
				list.Add(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"));
				for (int j = 1; j <= 2; j++)
				{
					csd csd = A_0.g("zoneRat" + j.ToString());
					if (csd != null)
					{
						c5x c5x2 = vq.a("creature\\characters\\support\\cc_zoneRat" + j.ToString(), csd, true);
						if (c5x2 != null)
						{
							list.Add(c5x2.qe());
							if (c5x2.t.b != null)
							{
								c5x2.t.b.y6()[ddq.ay] = new bt4(csd.Name);
							}
							bn5 bn = c5x2.GetAspect<j7>() as bn5;
							if (bn != null)
							{
								bn.b("support\\cc_zr3");
							}
						}
					}
				}
				foreach (Guid a_2 in list)
				{
					c5x c5x3 = new ar7(a_2, aud).ao() as c5x;
					if (c5x3 != null && c5x3.h.b != null)
					{
						if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_robProtWarehouse_playerBroughOwnShields", new bool?(false)).Value)
						{
							List<cgd> classPropertyValue = A_1.r().GetClassPropertyValue<List<cgd>>("quest_cc_robProtWarehouse_shieldItemList");
							if (Enumerable.Any<cgd>(classPropertyValue))
							{
								cgd cgd = Enumerable.FirstOrDefault<cgd>(classPropertyValue);
								if (cgd != null)
								{
									classPropertyValue.RemoveAt(0);
									cgd.Battery = (double)cgd.MaxBattery;
									c5x3.h.b.aa().Gear.h().a(cgd, true);
									A_1.r()["quest_cc_robProtWarehouse_shieldItemList"] = classPropertyValue;
								}
							}
						}
						else
						{
							xm xm = new xm();
							xm.na(12);
							xm.nc(14);
							cgd cgd2 = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
							if (cgd2 != null)
							{
								cgd2.Battery = (double)cgd2.MaxBattery;
								c5x3.h.b.aa().Gear.h().a(cgd2, true);
							}
						}
					}
				}
				c5x c5x4 = new ar7(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"), aud).ao() as c5x;
				foreach (c5x c5x5 in new c5x[]
				{
					c5x4
				})
				{
					if (c5x5 != null && c5x5.h.b != null)
					{
						c5x5.h.b.aa().FactionId = asp.dw;
					}
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					cno cno = aud.Divinations.a("div1");
					if (cno != null)
					{
						cno.b(serviceOrThrow.aqu().v().c());
					}
				}
			}
		}
	}
}
