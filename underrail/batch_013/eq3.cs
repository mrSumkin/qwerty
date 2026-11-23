using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000B1F RID: 2847
[eiz("XPBLCA")]
[Serializable]
public sealed class eq3 : cze, ISerializable
{
	// Token: 0x060041BE RID: 16830 RVA: 0x00195CB8 File Offset: 0x00193EB8
	private eq3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x00195CC4 File Offset: 0x00193EC4
	public eq3()
	{
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x00195CD0 File Offset: 0x00193ED0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value;
				if (value)
				{
					bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_invasionStarted", new bool?(false)).Value;
					bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_enteredArea", new bool?(false)).Value;
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_invasionEnded", new bool?(false)).Value;
					bool flag2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_invasionPrepDone", new bool?(false)).Value;
					int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_wavesDone", new int?(0)).Value;
					int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_turnsTillNextWave", new int?(0)).Value;
					int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfWaves", new int?(0)).Value;
					int value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_turnsBetweenWaves", new int?(0)).Value;
					int value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfSpecialAttackers", new int?(0)).Value;
					int num3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_specialAttackersCounter", new int?(0)).Value;
					int value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
					int value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfInvaders", new int?(0)).Value;
					int value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_invadersKilled", new int?(0)).Value;
					int num4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_invadersLanded", new int?(0)).Value;
					bool flag3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_allInvadersKilled", new bool?(false)).Value;
					string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType");
					List<int> classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<List<int>>("loc_xpbl_e5_specialCaseIndexes");
					List<string> classPropertyValue3 = serviceOrThrow.aqu().r().GetClassPropertyValue<List<string>>("loc_xpbl_e5_skaerderBlueprintList");
					bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_invasion_shieldsTurnedOn", new bool?(false)).Value;
					if (value && !flag)
					{
						this.a(serviceOrThrow, value7, value8, value4, value6);
						flag = true;
						serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionStarted"] = flag;
						num2 = 6;
						serviceOrThrow.aqu().r()["loc_xpbl_e5_turnsTillNextWave"] = num2;
						flag3 = false;
						serviceOrThrow.aqu().r()["loc_xpbl_e5_allInvadersKilled"] = flag3;
					}
					if (value3 && !flag3 && (value9 >= num4 || value9 >= value8 * value4))
					{
						flag3 = true;
						serviceOrThrow.aqu().r()["loc_xpbl_e5_allInvadersKilled"] = flag3;
						new hn().ym(A_0, A_1, null);
						new dvn("xpbl_e5", "xpbl_BlackSea").ym(null, null, null);
						flag2 = false;
					}
					if (!flag3)
					{
						this.a(aud);
					}
					if (flag && !value3)
					{
						gx gx = new gx();
						List<csd> list = new List<csd>();
						foreach (csd csd in Enumerable.ToList<csd>(aud.Zone.Waypoints))
						{
							if (csd != null && csd.Name.StartsWith("invader", StringComparison.OrdinalIgnoreCase) && !csd.Name.Contains("guard") && aw1.a(new bt4(csd.Name), aud, l9.a))
							{
								list.Add(csd);
							}
						}
						list = Enumerable.ToList<csd>(Enumerable.OrderBy<csd, int>(list, new Func<csd, int>(eq3.a.a.a)));
						if (--num2 <= 0)
						{
							if (!flag2)
							{
								num2 = value5;
								flag2 = true;
								serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionPrepDone"] = flag2;
							}
							if (num >= value4)
							{
								serviceOrThrow.aqu().r()["loc_xpbl_e5_invasionEnded"] = true;
							}
							else
							{
								serviceOrThrow.aqu().r()["loc_xpbl_e5_wavesDone"] = ++num;
								if (!value10)
								{
									foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
									{
										c5x c5x = (c5x)b0b;
										if (c5x != null && !c5x.IsPlayer && c5x.h.b != null && c5x.h.b.aa().Gear.h().Item != null)
										{
											c5x.h.b.aa().Defense.a(true);
										}
									}
									this.a(aud.Zone, classPropertyValue);
									serviceOrThrow.aqu().r()["loc_xpbl_e5_invasion_shieldsTurnedOn"] = true;
								}
								for (int i = 0; i < Math.Min(value8, list.Count); i++)
								{
									if (list.Count >= i && list[i] != null)
									{
										c5x c5x2;
										if (classPropertyValue == "Pirates")
										{
											c5x2 = gx.a(list[i], new int?(15), classPropertyValue, null, null, null, null, false, null, false);
										}
										else if (classPropertyValue2 != null && num3 < classPropertyValue2.Count && i + (num - 1) * value8 == classPropertyValue2[num3])
										{
											c5x2 = this.a(serviceOrThrow, list[i], value7, num3, value6, classPropertyValue3);
											num3++;
											serviceOrThrow.aqu().r()["loc_xpbl_e5_specialAttackersCounter"] = num3;
										}
										else
										{
											c5x2 = gx.a(list[i], new int?(15), classPropertyValue, null, null, null, null, false, null, false);
										}
										if (c5x2 != null && c5x2.h.b != null)
										{
											a6p aspect = c5x2.GetAspect<a6p>();
											if (aspect != null)
											{
												aspect.d().Add("-jobs");
											}
											List<cze> list2 = c5x2.h.b.ay();
											x6 x = new x6();
											x.a("loc_xpbl_e5_invadersKilled");
											list2.Add(x);
											serviceOrThrow.aqu().r()["loc_xpbl_e5_invadersLanded"] = ++num4;
											if (c5x2.t.b != null)
											{
												c5x2.t.b.y6()[ddq.ay] = new bt4("invader_guard" + i.ToString());
												if (!c5x2.h.b.am().Contains("xpbl_svgt") && euf.d(c5x2.h.b.aa().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sledgehammer)
												{
													c5x2.t.b.y6()[ddq.a5] = new List<Guid>
													{
														new Guid("49ab1f71-bd37-4dbc-b169-7aae2fd2ab21"),
														new Guid("f99444a9-0ce8-4fbb-8f7a-ebdd19473e11")
													};
												}
											}
											this.a(serviceOrThrow, c5x2, value7);
										}
									}
								}
								num2 = value5;
							}
						}
						serviceOrThrow.aqu().r()["loc_xpbl_e5_turnsTillNextWave"] = num2;
					}
				}
			}
		}
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x001965B0 File Offset: 0x001947B0
	private void a(aud A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
		int num = 0;
		List<string> list = new List<string>();
		if (value > 0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.f5 && c5x.h.b.aa().Attributes != d8o.e)
				{
					num++;
					if (c5x.t.b != null && c5x.y8().Contains("Aegis") && c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) != null)
					{
						list.Add(c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b());
					}
				}
			}
			if (num < 5)
			{
				if (value - num > 0)
				{
					gx gx = new gx();
					for (int i = 1; i <= 5; i++)
					{
						if (!list.Contains("aegisTrooper" + i.ToString()))
						{
							bt4 bt = new bt4("reinforcements" + i.ToString());
							if (aw1.a(bt, A_0, l9.a))
							{
								c5x c5x2 = null;
								if (bt.b() != null)
								{
									csd a_ = A_0.Zone.g(bt.b());
									c5x2 = gx.a(a_, new int?(10), "Aegis", null, null, null, null, false, null, false);
								}
								if (c5x2 != null)
								{
									c5x2 = bh8.a(c5x2, "aegisTrooper" + i.ToString());
									c5x2 = bh8.b(c5x2);
								}
							}
						}
					}
					return;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value)
				{
					bh8.a(serviceOrThrow, num, A_0, false);
					return;
				}
			}
			else if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value)
			{
				bh8.a(serviceOrThrow, num, A_0, false);
			}
		}
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x00196858 File Offset: 0x00194A58
	private void a(cnk A_0, int A_1, int A_2, int A_3, int A_4)
	{
		if (A_4 != 0)
		{
			bpo.GetService<bu6>();
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			int num;
			if (A_1 < 3 && A_3 > 1)
			{
				num = 1;
			}
			else
			{
				num = 0;
			}
			Random random = new Random();
			for (int i = A_2 * num; i < A_3 * A_2; i++)
			{
				list.Add(i);
			}
			list.Reverse();
			for (int j = 0; j < A_3 - num; j++)
			{
				for (int k = A_2; k > 1; k--)
				{
					int index = random.Next(k + A_2 * j);
					int value = list[k + A_2 * j - 1];
					list[k + A_2 * j - 1] = list[index];
					list[index] = value;
				}
			}
			int num2 = 0;
			int num3 = 0;
			for (int l = 0; l < A_4; l++)
			{
				if (num3 + num2 * A_2 >= list.Count)
				{
					num3++;
					num2 = 0;
				}
				list2.Add(list[num3 + num2 * A_2]);
				num2++;
			}
			list2.Sort();
			if (A_0 != null)
			{
				A_0.aqu().r()["loc_xpbl_e5_specialCaseIndexes"] = list2;
			}
			this.a(A_0, random, A_1);
		}
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x001969A8 File Offset: 0x00194BA8
	private void a(cnk A_0, Random A_1, int A_2)
	{
		List<string> value = new List<string>();
		if (A_2 > 3)
		{
			value = @is.a(true);
		}
		else
		{
			value = @is.a(false);
		}
		A_0.aqu().r()["loc_xpbl_e5_skaerderBlueprintList"] = value;
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x001969EC File Offset: 0x00194BEC
	private c5x a(cnk A_0, csd A_1, int A_2, int A_3, int A_4, List<string> A_5)
	{
		bu6 service = bpo.GetService<bu6>();
		c5x c5x = null;
		Random random = new Random();
		if (service != null)
		{
			if (random.Next(0, 101) > 90 - A_2 * 2 && !A_0.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_shamansKilled", new bool?(false)).Value)
			{
				if (A_2 == 5 && random.Next(0, 101) > 80)
				{
					c5x = vq.a("creatures\\genericHumans\\xpbl\\savageShamanGreater", A_1, false);
				}
				else
				{
					c5x = vq.a("creatures\\generichumans\\xpbl\\savageShaman", A_1, false);
				}
				if (c5x != null && c5x.h.b != null)
				{
					if (c5x.h.b.am().Contains("svgsg"))
					{
						int num = random.Next(1, 4);
						c5x.h.b.a("xpbl_svgsg" + num.ToString());
					}
					else
					{
						int num2 = random.Next(1, 3);
						c5x.h.b.a("xpbl_svgs" + num2.ToString());
					}
					if (A_2 >= 3 && random.Next(0, 101) > 50)
					{
						if (service.aq2() >= GameDifficulty.Hard && c5x.h.b.am().Contains("svgsg"))
						{
							c5x.h.b.aa().PsiAbilities.b(dgk.Get<dx2>());
							if (c5x.t.b != null)
							{
								c5x.t.b.ad()["FrightenPsiAbilityUser"] = true;
							}
						}
						c5x.h.b.aa().PsiAbilities.b(dgk.Get<ari>());
						c5x.h.b.aa().Feats.d(typeof(cqf));
						a6p aspect = c5x.GetAspect<a6p>();
						if (aspect != null)
						{
							aspect.d().Add("-feats");
							aspect.d().Add("-specials");
						}
					}
				}
			}
			else
			{
				c5x = vq.a(A_5[A_3], A_1, false);
			}
		}
		return c5x;
	}

	// Token: 0x060041C5 RID: 16837 RVA: 0x00196C30 File Offset: 0x00194E30
	private void a(c1a A_0, string A_1)
	{
		d60 d = A_0.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"raisedRamp"
			});
			List<b0b> list2 = d.ab4(new string[]
			{
				"loweredRamp",
				"bridgeTiles"
			});
			foreach (b0b b0b in list)
			{
				((c5x)b0b).ae = new float?(0f);
			}
			foreach (b0b b0b2 in list2)
			{
				c5x c5x = (c5x)b0b2;
				if (c5x.a("loweredRamp"))
				{
					c5x.ae = new float?((float)1);
				}
				c5x.TileFormationModifiers.s3(7);
				c5x.z();
				c5x.ah();
			}
			string a_ = "Xpbl_LowerBoneShipRamp";
			if (A_1 == "Pirates")
			{
				a_ = "LowerMetalShipRamp";
			}
			bfq bfq = new bfq();
			bfq.b("ramps");
			bfq.c(a_);
			bfq.ym(Enumerable.FirstOrDefault<b0b>(list), null, null);
			this.a(A_0, d);
		}
	}

	// Token: 0x060041C6 RID: 16838 RVA: 0x00196D98 File Offset: 0x00194F98
	private void a(c1a A_0, d60 A_1)
	{
		if (A_1 != null)
		{
			foreach (b0b b0b in A_1.ab4(new string[]
			{
				"crowdSoundEmitters"
			}))
			{
				aru aspect = ((c5x)b0b).GetAspect<aru>();
				if (aspect != null)
				{
					aspect.a("crowd", false);
				}
			}
		}
	}

	// Token: 0x060041C7 RID: 16839 RVA: 0x00196E1C File Offset: 0x0019501C
	private c5x a(cnk A_0, c5x A_1, int A_2)
	{
		if (A_1 != null)
		{
			if (A_0.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_haveShields", new bool?(false)).Value && (A_1.h.b.am().Contains("xpbl_pr6") || A_1.h.b.am().Contains("xpbl_prf4") || A_1.h.b.am().Contains("xpbl_prdv")))
			{
				A_1 = bry.a(A_1);
				if (A_1.h.b.aa().Gear.h().Item != null)
				{
					A_1.h.b.aa().Defense.a(true);
				}
			}
			if (A_2 > 3 && A_1.h.b.am().Contains("xpbl_svg") && cuo.a.Next(0, 101) <= 15)
			{
				A_1 = @is.a(A_1);
			}
			return A_1;
		}
		return null;
	}

	// Token: 0x02000B20 RID: 2848
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060041CA RID: 16842 RVA: 0x00196F54 File Offset: 0x00195154
		internal int a(csd A_0)
		{
			return int.Parse(A_0.Name.Substring(7));
		}

		// Token: 0x04001C19 RID: 7193
		public static readonly eq3.a a = new eq3.a();

		// Token: 0x04001C1A RID: 7194
		public static Func<csd, int> b;
	}
}
