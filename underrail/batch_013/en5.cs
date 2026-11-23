using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000967 RID: 2407
[eiz("CVDCEP")]
[Serializable]
public sealed class en5 : bdw, ISerializable
{
	// Token: 0x06003A96 RID: 14998 RVA: 0x0015B300 File Offset: 0x00159500
	private en5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x0015B308 File Offset: 0x00159508
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x0015B30C File Offset: 0x0015950C
	public en5()
	{
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x0015B318 File Offset: 0x00159518
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cv-dc");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
					int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
					int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
					bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_travelling", new bool?(false)).Value;
					serviceOrThrow.aqu().r()["loc_dc_travelling"] = false;
					c5x c5x = new ar7(new Guid("22035ad9-0812-408d-af09-02e6a7f58dd3"), aud).ao() as c5x;
					bool flag = false;
					float z = 0f;
					if (c5x != null)
					{
						if ((value4 || value2 == 0) && c5x.Location.Z >= 0f)
						{
							flag = true;
							z = -10f;
							if (c5x.s.b != null)
							{
								c5x.s.b.g(false);
							}
							b0e b0e = new EntityAspectReference<b0e, bim>(aud, new Guid("40e5f4e1-9429-4702-95a4-c69757eb67a5")).ao();
							if (b0e != null && b0e.q())
							{
								b0e.g(true);
								b0e.a(null, null, false, false);
								b0e.g(false);
							}
						}
						else if (!value4 && value2 == 1 && value3 == afi.a && c5x.Location.Z < 0f)
						{
							flag = true;
							z = 10f;
							if (c5x.s.b != null)
							{
								c5x.s.b.g(true);
							}
							c5x c5x2 = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), aud).ao() as c5x;
							if (c5x2 != null)
							{
								c5x2.c().a("elevator", false);
								etz etz = c5x2.o.b as etz;
								if (etz != null)
								{
									etz.c(0);
								}
							}
						}
					}
					if (flag)
					{
						serviceOrThrow.aqu().r()["loc_cv_dcElevator_initiated"] = true;
						List<b0b> list = new List<b0b>();
						for (int i = 16; i <= 19; i++)
						{
							for (int j = 12; j <= 15; j++)
							{
								ak1 ak = aud.b(i, j);
								if (ak != null)
								{
									foreach (b0b b0b in ak.c.Values)
									{
										c5x c5x3 = (c5x)b0b;
										if (c5x3.Layer == aju.x && !c5x3.IsPlayer)
										{
											e3l aspect = c5x3.GetAspect<e3l>();
											if (aspect == null || (!aspect.a.Contains("liftStatic") && !aspect.a.Contains("lift")))
											{
												list.Add(c5x3);
											}
										}
									}
								}
							}
						}
						d60 addon = aud.Zone.GetAddon<d60>();
						if (addon != null)
						{
							foreach (b0b b0b2 in Enumerable.Union<b0b>(addon.ab4(new string[]
							{
								"lift"
							}), list))
							{
								((c5x)b0b2).Location += new Vector3(0f, 0f, z);
							}
						}
					}
					if (value4)
					{
						bpo.GetServiceOrThrow<ps>().am3("Cv_ElevatorAscends");
					}
				}
			}
		}
	}
}
