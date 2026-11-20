using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A17 RID: 2583
[eiz("XPBLF1KP")]
[Serializable]
public sealed class c7k : bdw, ISerializable
{
	// Token: 0x06003D7E RID: 15742 RVA: 0x00170168 File Offset: 0x0016E368
	private c7k(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D7F RID: 15743 RVA: 0x00170170 File Offset: 0x0016E370
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x00170174 File Offset: 0x0016E374
	public c7k()
	{
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x00170180 File Offset: 0x0016E380
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud a_ = A_0.n("xpbl_f1");
			if (serviceOrThrow != null)
			{
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_f1_plantsPlanted", new bool?(false)).Value)
				{
					Random random = new Random(A_1.l());
					int num = random.Next(0, 101);
					int num2 = random.Next(0, 101);
					if (num <= 20)
					{
						c5x c5x = new ar7(new Guid("1fc62617-aa6e-4fef-8b57-87d913994789"), a_).ao() as c5x;
						if (c5x != null)
						{
							c5x.Location = new Vector3(15.5f, 34.5f, 0f);
							c5x.ah();
						}
					}
					else if (num > 20 && num <= 40)
					{
						c5x c5x2 = new ar7(new Guid("4dc55324-91a9-450e-85e0-39f240f61dcc"), a_).ao() as c5x;
						if (c5x2 != null)
						{
							c5x2.Location = new Vector3(15.5f, 34.5f, 0f);
							c5x2.ah();
						}
					}
					else if (num > 40 && num <= 60)
					{
						c5x c5x3 = new ar7(new Guid("5fa19597-e045-4e55-acd2-6534776d0352"), a_).ao() as c5x;
						if (c5x3 != null)
						{
							c5x3.Location = new Vector3(15.5f, 34.5f, 0f);
							c5x3.ah();
						}
					}
					if (num2 <= 30)
					{
						c5x c5x4 = new ar7(new Guid("2381fca8-8d4a-4fae-8f9f-9d7f6a02aec3"), a_).ao() as c5x;
						if (c5x4 != null)
						{
							c5x4.Location = new Vector3(17.5f, 34.5f, 0f);
							c5x4.ah();
						}
					}
					else if (num2 > 30 && num2 <= 70)
					{
						c5x c5x5 = new ar7(new Guid("99d583b4-c5f2-4e2d-8d2c-573b9df537c1"), a_).ao() as c5x;
						if (c5x5 != null)
						{
							c5x5.Location = new Vector3(17.5f, 34.5f, 0f);
							c5x5.ah();
						}
					}
					A_1.r()["loc_xpbl_f1_plantsPlanted"] = true;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_died", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_f1_meltedIceBlock", new bool?(false)).Value)
				{
					aud a_2 = A_0.n("xpbl_f1_cave");
					foreach (c5x c5x6 in new List<c5x>
					{
						new ar7(new Guid("42f9802b-4bfb-41f1-b7d2-542a50c03b9b"), a_2).ao() as c5x,
						new ar7(new Guid("19a5024f-9993-419c-83e4-70dc779a3fab"), a_2).ao() as c5x,
						new ar7(new Guid("a252eb6c-f756-4728-8195-e86bbe81163c"), a_2).ao() as c5x,
						new ar7(new Guid("48af707c-b102-47a6-91b4-8dfbf0050160"), a_2).ao() as c5x,
						new ar7(new Guid("dbcc0ee0-fc4e-4db9-a71c-625022757d52"), a_2).ao() as c5x,
						new ar7(new Guid("72b0ab7e-f1ac-4401-b355-17f3ddc8a1d4"), a_2).ao() as c5x,
						new ar7(new Guid("c3739275-153f-4203-9922-6e97cfa7a70a"), a_2).ao() as c5x
					})
					{
						if (c5x6 != null)
						{
							c5x6.w();
							c5x6.an();
						}
					}
					c5x c5x7 = new ar7(new Guid("170cdab4-c48f-4cda-a7e4-08fca51845a0"), a_2).ao() as c5x;
					if (c5x7 != null)
					{
						if (c5x7.o.b != null)
						{
							c5x7.o.b.a = "Creatures\\xpbl_pr2\\di";
						}
						c7j c7j = c5x7.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							c7j.g(true);
						}
					}
					foreach (c5x c5x8 in new List<c5x>
					{
						new ar7(new Guid("009f6bea-d8c9-470a-a9ef-c3c774e667c1"), a_2).ao() as c5x,
						new ar7(new Guid("c4d3f723-f214-4ffd-a3b9-3d86c8ebfaa4"), a_2).ao() as c5x,
						new ar7(new Guid("f927af07-7296-479d-87cc-97b58224df18"), a_2).ao() as c5x,
						new ar7(new Guid("3aa4df89-f9bc-48eb-b82b-75f895a6f389"), a_2).ao() as c5x,
						new ar7(new Guid("fcca42ca-5e12-4471-b7e7-c901be409991"), a_2).ao() as c5x,
						new ar7(new Guid("89add946-e292-42fa-8954-a3fc3c4cb795"), a_2).ao() as c5x
					})
					{
						if (c5x8 != null)
						{
							float? ae = c5x8.ae;
							float num3 = 0f;
							if (ae.GetValueOrDefault() == num3 & ae != null)
							{
								c5x8.ae = new float?((float)1);
							}
						}
					}
					A_1.r()["loc_xpbl_f1_meltedIceBlock"] = true;
				}
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_died", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_talkedInCave", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_returnedFromCave", new bool?(false)).Value)
				{
					c5x c5x9 = new ar7(new Guid("5c4e9e80-fa71-4977-82bc-93ca150844ee"), A_0.n("xpbl_f1_cave")).ao() as c5x;
					if (c5x9 != null)
					{
						if (c5x9.t.b != null)
						{
							List<string> classPropertyValue = c5x9.t.b.y6().GetClassPropertyValue<List<string>>("UnusedPatrolRoute");
							if (classPropertyValue != null && Enumerable.Any<string>(classPropertyValue))
							{
								c5x9.t.b.y6()[ddq.k] = classPropertyValue;
								c5x9.t.b.y6().RemoveProperty(ddq.ay);
								c5x9.t.b.y6().RemoveProperty("UnusedPatrolRoute");
								a0l.a(c5x9, "katya1", true);
							}
							else
							{
								a0l.a(c5x9, "katya_home", true);
								c5x9.t.b.y6()[ddq.ay] = new bt4("katya_home");
							}
						}
						if (c5x9.h.b != null)
						{
							c5x9.h.b.aa().HostilityBroadcastMode = c2n.d;
						}
					}
					serviceOrThrow.aqu().r()["npc_xpbl_pir_katya_returnedFromCave"] = true;
				}
			}
		}
	}
}
