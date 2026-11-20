using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000954 RID: 2388
[eiz("CCGLG")]
[Serializable]
public sealed class cbf : bdw, ISerializable
{
	// Token: 0x06003A4A RID: 14922 RVA: 0x00159590 File Offset: 0x00157790
	private cbf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x00159598 File Offset: 0x00157798
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x0015959C File Offset: 0x0015779C
	public cbf()
	{
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x001595A4 File Offset: 0x001577A4
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_enterGauntlet");
		if (aud != null)
		{
			if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_gauntlet_didFirstRun", new bool?(false)).Value)
			{
				if (dk2.b("xpbl") && !A_1.r().GetPrimitivePropertyValue<bool>("loc_cc_enterGauntlet_xpbl_gearGenerated", new bool?(false)).Value)
				{
					c5x c5x = new ar7(new Guid("5662474d-b5a7-439e-9808-e9d2f04095c9"), aud).ao() as c5x;
					c7j c7j = c5x.s.b as c7j;
					if (c5x != null)
					{
						for (int i = 0; i < 3; i++)
						{
							cob cob = new cob();
							cob.na(14);
							cob.nc(20);
							cob.a(new bool?(false));
							foreach (coh a_ in cob.np())
							{
								c7j.ItemContainer.z3(a_, true);
							}
							cob cob2 = new cob();
							cob2.na(14);
							cob2.nc(20);
							cob2.a(new bool?(true));
							foreach (coh a_2 in cob2.np())
							{
								c7j.ItemContainer.z3(a_2, true);
							}
						}
						for (int j = 0; j < 4; j++)
						{
							cpj cpj = new cpj();
							cpj.na(14);
							cpj.nc(20);
							foreach (coh a_3 in cpj.np())
							{
								c7j.ItemContainer.z3(a_3, true);
							}
							b5e b5e = new b5e();
							b5e.na(14);
							b5e.nc(20);
							foreach (coh a_4 in b5e.np())
							{
								c7j.ItemContainer.z3(a_4, true);
							}
						}
						coh a_5 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_6"))
						{
							Stacks = 50
						};
						c7j.ItemContainer.z3(a_5, true);
						coh a_6 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_12"))
						{
							Stacks = 50
						};
						c7j.ItemContainer.z3(a_6, true);
						coh a_7 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_20"))
						{
							Stacks = 50
						};
						c7j.ItemContainer.z3(a_7, true);
						A_1.r()["loc_cc_enterGauntlet_xpbl_gearGenerated"] = true;
					}
				}
				if (dk2.b("xphw") && !A_1.r().GetPrimitivePropertyValue<bool>("loc_cc_enterGauntlet_xphw_gearGenerated", new bool?(false)).Value)
				{
					c7j c7j2 = (new ar7(new Guid("5662474d-b5a7-439e-9808-e9d2f04095c9"), aud).ao() as c5x).s.b as c7j;
					for (int k = 0; k < 3; k++)
					{
						auy auy = new auy();
						auy.na(14);
						auy.nc(20);
						auy.a(new GrenadeLauncherBarrelType?(GrenadeLauncherBarrelType.Caliber_40));
						foreach (coh a_8 in auy.np())
						{
							c7j2.ItemContainer.z3(a_8, true);
						}
						auy auy2 = new auy();
						auy2.na(14);
						auy2.nc(20);
						auy2.a(new GrenadeLauncherBarrelType?(GrenadeLauncherBarrelType.Caliber_25));
						foreach (coh a_9 in auy2.np())
						{
							c7j2.ItemContainer.z3(a_9, true);
						}
					}
					coh a_10 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_25_Frag"))
					{
						Stacks = 20
					};
					c7j2.ItemContainer.z3(a_10, true);
					coh a_11 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_25_He"))
					{
						Stacks = 20
					};
					c7j2.ItemContainer.z3(a_11, true);
					coh a_12 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_40_Frag"))
					{
						Stacks = 20
					};
					c7j2.ItemContainer.z3(a_12, true);
					coh a_13 = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_40_He"))
					{
						Stacks = 20
					};
					c7j2.ItemContainer.z3(a_13, true);
					for (int l = 0; l < 4; l++)
					{
						c3m c3m = new c3m();
						c3m.na(14);
						c3m.nc(20);
						c3m.d(150);
						foreach (coh a_14 in c3m.np())
						{
							c7j2.ItemContainer.z3(a_14, true);
						}
					}
					for (int m = 0; m < 2; m++)
					{
						e65 e = new e65();
						e.na(15);
						e.nc(20);
						e.d(150);
						foreach (coh a_15 in e.np())
						{
							c7j2.ItemContainer.z3(a_15, true);
						}
					}
					A_1.r()["loc_cc_enterGauntlet_xphw_gearGenerated"] = true;
				}
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_gauntlet_didFirstRun", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_gauntlet_cleanedStartingArea", new bool?(false)).Value)
			{
				for (int n = 5; n <= 8; n++)
				{
					for (int num = 1; num <= 4; num++)
					{
						ak1 ak = aud.b(n, num);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
							{
								c5x c5x2 = (c5x)b0b;
								if (c5x2.Layer == aju.x)
								{
									if (c5x2.o.b != null && c5x2.o.b.a == "Objects\\Containers\\Remains\\Default")
									{
										c5x2.w();
										c5x2.an();
									}
									else if (c5x2.s.b is c7j)
									{
										c7j c7j3 = c5x2.GetAspect<bim>() as c7j;
										if (c7j3 != null)
										{
											c7j3.ItemContainer.z7();
										}
									}
								}
							}
						}
					}
				}
				A_1.r()["quest_cc_gauntlet_cleanedStartingArea"] = true;
			}
		}
	}
}
