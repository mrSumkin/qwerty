using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000966 RID: 2406
[eiz("DCDCEP")]
[Serializable]
public sealed class dw6 : bdw, ISerializable
{
	// Token: 0x06003A92 RID: 14994 RVA: 0x0015AEE8 File Offset: 0x001590E8
	private dw6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x0015AEF0 File Offset: 0x001590F0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x0015AEF4 File Offset: 0x001590F4
	public dw6()
	{
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x0015AF00 File Offset: 0x00159100
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("dc-cve");
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
					c5x c5x = new ar7(new Guid("41282c44-b4c4-4c87-9f2c-8d2a60e847b1"), aud).ao() as c5x;
					bool flag = false;
					float z = 0f;
					if (c5x != null)
					{
						if ((value4 || value2 == 1) && c5x.Location.Z <= 0f)
						{
							flag = true;
							z = 5f;
							if (c5x.s.b != null)
							{
								c5x.s.b.g(false);
							}
							b0e b0e = new EntityAspectReference<b0e, bim>(aud, new Guid("1d126757-20f1-4fbc-89d6-b51fb843b45b")).ao();
							if (b0e != null && b0e.q())
							{
								b0e.g(true);
								b0e.a(null, null, false, false);
								b0e.g(false);
							}
						}
						else if (!value4 && value2 == 0 && value3 == 0 && c5x.Location.Z > 0f)
						{
							flag = true;
							z = -5f;
							if (c5x.s.b != null)
							{
								c5x.s.b.g(true);
							}
							c5x c5x2 = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), aud).ao() as c5x;
							if (c5x2 != null)
							{
								c5x2.c().a("elevator", false);
							}
						}
					}
					if (flag)
					{
						serviceOrThrow.aqu().r()["loc_cv_dcElevator_initiated"] = true;
						List<b0b> list = new List<b0b>();
						for (int i = 7; i <= 10; i++)
						{
							for (int j = 4; j <= 7; j++)
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
						bpo.GetServiceOrThrow<ps>().am3("Dc_ElevatorDescends");
					}
				}
			}
		}
	}
}
