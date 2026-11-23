using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B7B RID: 7035
[dgg("grenadeLauncher")]
public sealed class eg3 : c4r, bd3
{
	// Token: 0x06009883 RID: 39043 RVA: 0x003B79C4 File Offset: 0x003B5BC4
	public override string bt()
	{
		return "茩Гранатомёт";
	}

	// Token: 0x06009884 RID: 39044 RVA: 0x003B79CC File Offset: 0x003B5BCC
	public override string bu()
	{
		return "grenadeLauncher";
	}

	// Token: 0x06009885 RID: 39045 RVA: 0x003B79D4 File Offset: 0x003B5BD4
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009886 RID: 39046 RVA: 0x003B79D8 File Offset: 0x003B5BD8
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009887 RID: 39047 RVA: 0x003B79DC File Offset: 0x003B5BDC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009888 RID: 39048 RVA: 0x003B79E4 File Offset: 0x003B5BE4
	public eg3()
	{
		base.Slots.Add(eg3.a, new cgo(new c6s(ms.bq, 132), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eg3.b, new cgo(new c6s(ms.br, 17), "Ствол", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eg3.c, new cgo(new c6s(ms.bs, 133), "Магазин", false, 1, 0.1f, false, false, null));
		base.Slots.Add(eg3.d, new cgo(new eh0(new string[]
		{
			"airburstScope",
			"grenadeLauncherScope",
			"grenadeLauncherIronsights",
			"forwardGrip",
			"rifleBipod"
		}, 15), "Улучшение", true, 1, 0f, false, false, null));
		base.Slots.Add(eg3.e, new cgo(new eh0(new string[]
		{
			"airburstScope",
			"grenadeLauncherScope",
			"grenadeLauncherIronsights",
			"forwardGrip",
			"rifleBipod"
		}, 15), "Улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009889 RID: 39049 RVA: 0x003B7B38 File Offset: 0x003B5D38
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(eg3.a, null);
		fv fv2 = A_1.SafeGet(eg3.b, null);
		fv fv3 = A_1.SafeGet(eg3.c, null);
		fv fv4 = A_1.SafeGet(eg3.d, null);
		fv fv5 = A_1.SafeGet(eg3.e, null);
		if (fv == null || fv2 == null || fv3 == null)
		{
			return null;
		}
		GrenadeLauncherBarrelType? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<GrenadeLauncherBarrelType>("SupportedBarrelType", null);
		GrenadeLauncherBarrelType? primitivePropertyValue2 = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<GrenadeLauncherBarrelType>("BarrelType", null);
		bool value = fv.Definition.a7().GetPrimitivePropertyValue<bool>("IsRevolverType", new bool?(false)).Value;
		bool value2 = fv3.Definition.a7().GetPrimitivePropertyValue<bool>("IsRevolverType", new bool?(false)).Value;
		int value3 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", new int?(0)).Value;
		bool value4 = fv2.Definition.a7().GetPrimitivePropertyValue<bool>("IsLong", new bool?(false)).Value;
		int value5 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("Capacity", new int?(4)).Value;
		int value6 = fv3.Definition.a7().GetPrimitivePropertyValue<int>("MagIndex", new int?(0)).Value;
		if (primitivePropertyValue == null || primitivePropertyValue2 == null)
		{
			return null;
		}
		GrenadeLauncherBarrelType? grenadeLauncherBarrelType = primitivePropertyValue;
		GrenadeLauncherBarrelType? grenadeLauncherBarrelType2 = primitivePropertyValue2;
		if (!(grenadeLauncherBarrelType.GetValueOrDefault() == grenadeLauncherBarrelType2.GetValueOrDefault() & grenadeLauncherBarrelType != null == (grenadeLauncherBarrelType2 != null)))
		{
			A_2 = "Несовместимый тип ствола.";
			return null;
		}
		if (fv4 != null && fv5 != null && ((fv4.TypedDefinition.a5() == "forwardGrip" && fv5.TypedDefinition.a5() == "rifleBipod") || (fv4.TypedDefinition.a5() == "rifleBipod" && fv5.TypedDefinition.a5() == "forwardGrip")))
		{
			A_2 = "Несовместимые улучшения.";
			return null;
		}
		if (fv4 != null && fv5 != null && fv4.TypedDefinition.i() == fv5.TypedDefinition.i())
		{
			A_2 = "Нельзя установить два улучшения одного типа.";
			return null;
		}
		if (value != value2)
		{
			A_2 = "Несовместимый тип магазина.";
			return null;
		}
		double a_ = cwp.a(fv);
		bke bke = new bke();
		bke.a(this.b(primitivePropertyValue2.Value));
		bke.d(1.0);
		bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue)));
		bke.h(fv.SingleItemWeight + fv2.SingleItemWeight + fv3.SingleItemWeight);
		bke.g((int)Math.Ceiling(a_));
		bke.a(fv.TypedDefinition.bc());
		if (value)
		{
			bke.a(bhx.ad);
		}
		else
		{
			bke.a(bhx.ac);
		}
		bke.a2().Add(new aia("uwep"));
		bke.@as().Add(new aia("GrenadeLauncherAttackGround"));
		bke.b(0.05000000074505806);
		bke.a(0.1f);
		bke.a(ItemStealingCategory.WeaponHeavy);
		bke.a(a0.e);
		if (value2)
		{
			bke.a(Math.Round(2.33 + (double)(value5 - 4) * 0.165, 2));
		}
		else
		{
			bke.a(2.0);
		}
		double a_2 = 1.0;
		if (value4)
		{
			a_2 = 0.85;
		}
		c4r.a(bke, btz.h, this.a(primitivePropertyValue2.Value), fv.TypedDefinition);
		b1j? primitivePropertyValue3 = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
		b1j b1j = c4r.a(A_0, this.a(primitivePropertyValue2.Value), a_, a_2, null, primitivePropertyValue3);
		bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
		bke.c(value5);
		bke bke2 = bke;
		bke2.b(bke2.i() + value3);
		bke.c("grenadeLauncher");
		string text = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
		if (text == null)
		{
			text = "";
		}
		bke.g(c4r.a(bke.ak()));
		if (value2)
		{
			bke bke3 = bke;
			bke3.g(bke3.az() + string.Format("{0}-зарядный ", bke.f()));
		}
		else
		{
			bke bke4 = bke;
			bke4.g(bke4.az() + string.Format("{0}-патронажный ", bke.f()));
		}
		bke bke5 = bke;
		bke5.g(bke5.az() + ((!string.IsNullOrEmpty(text)) ? text : "Гранатомёт"));
		bke.f(string.Format("grenadeLauncher.{0}.{1}.{2}", text.ToLowerInvariant(), value6, value4 ? "long" : "short"));
		if (value4)
		{
			bke bke6 = bke;
			bke6.c(bke6.ad() + 2f);
			bke bke7 = bke;
			bke7.d(bke7.h() + 1f);
			bke.g("Длинный " + bke.az());
		}
		string text2 = "";
		string text3 = "";
		bke.i(qv.a("Items\\Weapons/GrenadeLauncher", new object[]
		{
			c4r.a(bke.ak()),
			(!string.IsNullOrEmpty(text)) ? text : "unknown"
		}));
		if (value4)
		{
			bke bke8 = bke;
			bke8.i(bke8.a0() + " Он имеет длинный ствол для увеличения дальности стрельбы.");
		}
		string[] array = new string[]
		{
			"forwardGrip",
			"rifleBipod",
			"grenadeLauncherIronsights",
			"grenadeLauncherScope",
			"airburstScope"
		};
		HashSet<string> hashSet = new HashSet<string>();
		foreach (fv fv6 in new fv[]
		{
			fv4,
			fv5
		})
		{
			if (fv6 != null)
			{
				hashSet.Add(fv6.Definition.a5());
				bke bke9 = bke;
				bke9.b(bke9.bf() + (double)fv6.SingleItemValue);
				bke bke10 = bke;
				bke10.h(bke10.a4() + fv6.SingleItemWeight);
				string text4 = fv6.TypedDefinition.a5();
				if (fv6.TypedDefinition.i() == ms.q)
				{
					if (!fv6.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("IsGrenadeLauncherScope", new bool?(false)).Value)
					{
						A_2 = "Несовместимый тип прицела.";
						return null;
					}
					if (fv6.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("Airburst", new bool?(false)).Value)
					{
						text2 = "До ударный " + text2;
						bke.n().Add(new dlp());
						bke bke11 = bke;
						bke11.i(bke11.a0() + " Он оснащён прицелом с функцией подрыва до удара, который повышает точность стрельбы и позволяет гранатам взрываться до столкновения с поверхностью.");
					}
					else if (text4 == "grenadeLauncherScope")
					{
						text2 = "Оснащённ. прицелом " + text2;
						bke bke12 = bke;
						bke12.i(bke12.a0() + " Он оснащён оптическим прицелом с дальномером, который повышает точность стрельбы.");
					}
					else
					{
						text2 = "Прицельный " + text2;
						bke bke13 = bke;
						bke13.i(bke13.a0() + " Он оснащён простым гранатомётным прицелом.");
					}
				}
				else if (text4 == "forwardGrip")
				{
					bke bke14 = bke;
					bke14.i(bke14.a0() + " Передний хват обеспечивает устойчивость оружия при стрельбе во время движения.");
					text3 += " тактики";
					bke bke15 = bke;
					bke15.g(bke15.ab() + 0.03);
					c4r.a(ref bke.v, -0.05);
				}
				else if (text4 == "rifleBipod")
				{
					bke bke16 = bke;
					bke16.i(bke16.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
					float value7 = fv6.TypedDefinition.a7().GetPrimitivePropertyValue<float>("PrecisionBonus", new float?(0f)).Value;
					int num = fv6.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ApModifier", new int?(0)).Value / 2;
					text3 += " с сошками";
					bke bke17 = bke;
					bke17.g(bke17.ab() + (double)value7);
					bke bke18 = bke;
					bke18.a(bke18.v() + num);
					c4r.a(ref bke.v, (double)(value7 / 2f));
					c4r.a(ref bke.u, Convert.ToSingle(value7 / 2f));
				}
				c4r.a(bke, fv6.TypedDefinition);
			}
		}
		foreach (string text5 in array)
		{
			if (hashSet.Contains(text5))
			{
				bke bke19 = bke;
				bke19.f(bke19.a3() + "." + text5);
			}
		}
		bke.g(text2 + bke.az() + text3);
		bke bke20 = bke;
		bke20.b(bke20.bf() * (double)3);
		if (fv4 != null && fv5 != null)
		{
			bke bke21 = bke;
			bke21.b(bke21.bf() * 1.2);
		}
		cwp.a(bke, new coh[]
		{
			fv,
			fv3,
			fv2,
			fv4,
			fv5
		});
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600988A RID: 39050 RVA: 0x003B85F8 File Offset: 0x003B67F8
	private AmmoType b(GrenadeLauncherBarrelType A_0)
	{
		if (A_0 == GrenadeLauncherBarrelType.Caliber_40)
		{
			return AmmoType.Grenade_40;
		}
		return AmmoType.Grenade_25;
	}

	// Token: 0x0600988B RID: 39051 RVA: 0x003B860C File Offset: 0x003B680C
	private WeaponSubtype a(GrenadeLauncherBarrelType A_0)
	{
		if (A_0 == GrenadeLauncherBarrelType.Caliber_40)
		{
			return WeaponSubtype.GrenadeLauncher_40;
		}
		return WeaponSubtype.GrenadeLauncher_25;
	}

	// Token: 0x0600988C RID: 39052 RVA: 0x003B861C File Offset: 0x003B681C
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 0;
		string a_ = "xphw_Weapons";
		List<bj8> list = new List<bj8>();
		string[] array = new string[]
		{
			"mangonel",
			"onager",
			"petard",
			"tsar"
		};
		string[] array2 = new string[]
		{
			"short",
			"long"
		};
		string[] array3 = new string[]
		{
			"forwardGrip",
			"rifleBipod"
		};
		string[] array4 = new string[]
		{
			"grenadeLauncherIronsights",
			"grenadeLauncherScope",
			"airburstScope"
		};
		for (int i = 0; i < array.Length; i++)
		{
			string arg = array[i];
			bj8 bj = new bj8();
			bj.a(string.Format("grenadeLauncher.{0}.frame", arg));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = -1; l < 2; l++)
					{
						for (int m = -1; m < 3; m++)
						{
							bj = new bj8();
							bj.a(string.Format("grenadeLauncher.{0}.{1}.{2}", arg, j, array2[k]));
							bj.a().Add(new d8h(a_, new Point(num + 1 + j, num2 + i), 1f));
							bj.a().Add(new d8h(a_, new Point(num + 5 + k, num2 + i), 1f));
							if (l > -1)
							{
								bj8 bj2 = bj;
								bj2.a(bj2.c() + "." + array3[l]);
								bj.a().Add(new d8h(a_, new Point(num + 7 + l, num2 + i), 1f));
							}
							if (m > -1)
							{
								bj8 bj3 = bj;
								bj3.a(bj3.c() + "." + array4[m]);
								bj.a().Add(new d8h(a_, new Point(num + 9 + m, num2 + i), 1f));
							}
							list.Add(bj);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x04003A76 RID: 14966
	public new static readonly string a = "frame";

	// Token: 0x04003A77 RID: 14967
	public new static readonly string b = "barrel";

	// Token: 0x04003A78 RID: 14968
	public static readonly string c = "magazine";

	// Token: 0x04003A79 RID: 14969
	public new static readonly string d = "enhancement1";

	// Token: 0x04003A7A RID: 14970
	public static readonly string e = "enhancement2";
}
