using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B74 RID: 7028
[dgg("rocketLauncher")]
public sealed class a6q : c4r, bd3
{
	// Token: 0x06009852 RID: 38994 RVA: 0x003B4E80 File Offset: 0x003B3080
	public override string bt()
	{
		return "茪Ракетница";
	}

	// Token: 0x06009853 RID: 38995 RVA: 0x003B4E88 File Offset: 0x003B3088
	public override string bu()
	{
		return "rocketLauncher";
	}

	// Token: 0x06009854 RID: 38996 RVA: 0x003B4E90 File Offset: 0x003B3090
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009855 RID: 38997 RVA: 0x003B4E94 File Offset: 0x003B3094
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009856 RID: 38998 RVA: 0x003B4E98 File Offset: 0x003B3098
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009857 RID: 38999 RVA: 0x003B4EA0 File Offset: 0x003B30A0
	public a6q()
	{
		string[] a_ = new string[]
		{
			"airburstScope",
			"grenadeLauncherScope",
			"grenadeLauncherIronsights",
			"forwardGrip",
			"rifleBipod",
			"rocketLauncherEmrac"
		};
		base.Slots.Add(a6q.a, new cgo(new c6s(ms.by, 136), "Сборочный ПЗРК", false, 1, 0.1f, false, false, null));
		base.Slots.Add(a6q.b, new cgo(new c6s(ms.bz, 137), "Пусковой механизм", false, 1, 0.1f, false, false, null));
		base.Slots.Add(a6q.c, new cgo(new eh0(a_, 15), "Улучшение", true, 1, 0f, false, false, null));
		base.Slots.Add(a6q.d, new cgo(new eh0(a_, 15), "Улучшение", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009858 RID: 39000 RVA: 0x003B4FA4 File Offset: 0x003B31A4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(a6q.a, null);
		fv fv2 = A_1.SafeGet(a6q.b, null);
		fv fv3 = A_1.SafeGet(a6q.c, null);
		fv fv4 = A_1.SafeGet(a6q.d, null);
		if (fv == null || fv2 == null)
		{
			return null;
		}
		bool flag = true;
		int value = fv.Definition.a7().GetPrimitivePropertyValue<int>("StrengthRequirement", new int?(0)).Value;
		float value2 = fv.Definition.a7().GetPrimitivePropertyValue<float>("DamageMod", new float?(1f)).Value;
		int value3 = fv2.Definition.a7().GetPrimitivePropertyValue<int>("Index", new int?(0)).Value;
		if (fv3 != null && fv4 != null && ((fv3.TypedDefinition.a5() == "forwardGrip" && fv4.TypedDefinition.a5() == "rifleBipod") || (fv3.TypedDefinition.a5() == "rifleBipod" && fv4.TypedDefinition.a5() == "forwardGrip")))
		{
			A_2 = "Несовместимые улучшения.";
			return null;
		}
		if (fv3 != null && fv4 != null && fv3.TypedDefinition.i() == fv4.TypedDefinition.i())
		{
			A_2 = "Нельзя установить два улучшения одного типа.";
			return null;
		}
		double a_ = cwp.a(fv);
		bke bke = new bke();
		bke.a(AmmoType.Rocket_84);
		bke.d(1.0);
		bke.b(new double?((double)(fv.SingleItemValue + fv2.SingleItemValue)));
		bke.h(fv.SingleItemWeight + fv2.SingleItemWeight);
		bke.g((int)Math.Ceiling(a_));
		bke.a(fv.TypedDefinition.bc());
		bke.a(bhx.bv);
		bke.a2().Add(new aia("uwep"));
		bke.@as().Add(new aia("RocketLauncherAttackGround"));
		bke.b(0.15000000596046448);
		bke.a(0.3f);
		bke.a(ItemStealingCategory.WeaponHeavy);
		bke.a(a0.e);
		bke.a(2.0);
		c4r.a(bke, btz.l, WeaponSubtype.RocketLauncher_84, fv.TypedDefinition);
		c4r.a(bke, fv2.TypedDefinition);
		b1j? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<b1j>("DamageSpreadModifier", null);
		b1j b1j = c4r.a(A_0, WeaponSubtype.RocketLauncher_84, a_, (double)value2, null, primitivePropertyValue);
		bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
		bke.c(1);
		bke.b(value);
		bke.c("rocketLauncher");
		string text = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Name");
		if (text == null)
		{
			text = "";
		}
		bke.g(c4r.a(bke.ak()));
		bke bke2 = bke;
		bke2.g(bke2.az() + ((!string.IsNullOrEmpty(text)) ? text : "Ракетница"));
		bke.f(string.Format("rocketLauncher.{0}.{1}", text.ToLowerInvariant(), value3));
		string text2 = "";
		string text3 = "";
		bke.i(qv.a("Items\\Weapons/RocketLauncher", new object[]
		{
			c4r.a(bke.ak()),
			(!string.IsNullOrEmpty(text)) ? text : "unknown"
		}));
		string[] array = new string[]
		{
			"forwardGrip",
			"rifleBipod",
			"grenadeLauncherIronsights",
			"grenadeLauncherScope",
			"airburstScope",
			"rocketLauncherEmrac"
		};
		HashSet<string> hashSet = new HashSet<string>();
		foreach (fv fv5 in new fv[]
		{
			fv3,
			fv4
		})
		{
			if (fv5 != null)
			{
				hashSet.Add(fv5.Definition.a5());
				bke bke3 = bke;
				bke3.b(bke3.bf() + (double)fv5.SingleItemValue);
				bke bke4 = bke;
				bke4.h(bke4.a4() + fv5.SingleItemWeight);
				string text4 = fv5.TypedDefinition.a5();
				if (fv5.TypedDefinition.i() == ms.q)
				{
					if (!fv5.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("IsGrenadeLauncherScope", new bool?(false)).Value)
					{
						A_2 = "Несовместимый тип прицела.";
						return null;
					}
					if (fv5.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("Airburst", new bool?(false)).Value)
					{
						text2 = "До ударный " + text2;
						bke.n().Add(new dlp());
						bke bke5 = bke;
						bke5.i(bke5.a0() + " Он оснащён прицелом с функцией подрыва до удара, который повышает точность стрельбы и позволяет гранатам взрываться до столкновения с поверхностью.");
					}
					else if (text4 == "grenadeLauncherScope")
					{
						text2 = "Оснащённ. прицелом " + text2;
						bke bke6 = bke;
						bke6.i(bke6.a0() + " Он оснащён оптическим прицелом с дальномером, который повышает точность стрельбы.");
					}
					else
					{
						text2 = "Прицельный " + text2;
						bke bke7 = bke;
						bke7.i(bke7.a0() + " Он оснащён простым гранатомётным прицелом.");
					}
				}
				else if (text4 == "forwardGrip")
				{
					bke bke8 = bke;
					bke8.i(bke8.a0() + " Передний хват обеспечивает устойчивость оружия при стрельбе во время движения.");
					text3 += " тактики";
					bke bke9 = bke;
					bke9.g(bke9.ab() + 0.03);
					c4r.a(ref bke.v, -0.05);
				}
				else if (text4 == "rifleBipod")
				{
					bke bke10 = bke;
					bke10.i(bke10.a0() + " Сошки повышают точность стрельбы, но замедляют прицеливание.");
					float value4 = fv5.TypedDefinition.a7().GetPrimitivePropertyValue<float>("PrecisionBonus", new float?(0f)).Value;
					int num = fv5.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ApModifier", new int?(0)).Value / 2;
					text3 += " с сошками";
					bke bke11 = bke;
					bke11.g(bke11.ab() + (double)value4);
					bke bke12 = bke;
					bke12.a(bke12.v() + 5);
					c4r.a(ref bke.v, (double)(value4 / 2f));
					c4r.a(ref bke.u, Convert.ToSingle(value4 / 2f));
				}
				else if (text4 == "rocketLauncherEmrac")
				{
					flag = false;
					text3 += " ЭРУ";
					bke bke13 = bke;
					bke13.i(bke13.a0() + " Электромагнитный рельсовый ускоритель полностью нейтрализует любой обратный удар.");
				}
				c4r.a(bke, fv5.TypedDefinition);
			}
		}
		if (flag)
		{
			bke.n().Add(new ct2());
		}
		foreach (string text5 in array)
		{
			if (hashSet.Contains(text5))
			{
				bke bke14 = bke;
				bke14.f(bke14.a3() + "." + text5);
			}
		}
		bke.g(text2 + bke.az() + text3);
		bke bke15 = bke;
		bke15.b(bke15.bf() * (double)2);
		if (fv3 != null && fv4 != null)
		{
			bke bke16 = bke;
			bke16.b(bke16.bf() * 1.2);
		}
		cwp.a(bke, new coh[]
		{
			fv,
			fv2,
			fv3,
			fv4
		});
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x06009859 RID: 39001 RVA: 0x003B5834 File Offset: 0x003B3A34
	public List<bj8> bz()
	{
		int num = 0;
		int num2 = 19;
		string a_ = "xphw_Weapons";
		List<bj8> list = new List<bj8>();
		string[] array = new string[]
		{
			"sting",
			"stormbolt",
			"scepter",
			"beamer",
			"maul"
		};
		string[] array2 = new string[]
		{
			"forwardGrip",
			"rifleBipod"
		};
		string[] array3 = new string[]
		{
			"grenadeLauncherIronsights",
			"grenadeLauncherScope",
			"airburstScope"
		};
		for (int i = 0; i < array.Length; i++)
		{
			string arg = array[i];
			bj8 bj = new bj8();
			bj.a(string.Format("rocketLauncher.{0}.frame", arg));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = -1; k < 2; k++)
				{
					for (int l = -1; l < 3; l++)
					{
						for (int m = -1; m < 1; m++)
						{
							bj = new bj8();
							bj.a(string.Format("rocketLauncher.{0}.{1}", arg, j));
							if (k > -1)
							{
								bj8 bj2 = bj;
								bj2.a(bj2.c() + "." + array2[k]);
								bj.a().Add(new d8h(a_, new Point(num + 4 + k, num2 + i), 1f));
							}
							bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
							bj.a().Add(new d8h(a_, new Point(num + 1 + j, num2 + i), 1f));
							if (l > -1)
							{
								bj8 bj3 = bj;
								bj3.a(bj3.c() + "." + array3[l]);
								bj.a().Add(new d8h(a_, new Point(num + 6 + l, num2 + i), 1f));
							}
							if (m > -1)
							{
								bj8 bj4 = bj;
								bj4.a(bj4.c() + ".rocketLauncherEmrac");
								bj.a().Add(new d8h(a_, new Point(num + 9, num2 + i), 1f));
							}
							list.Add(bj);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x04003A63 RID: 14947
	public new static readonly string a = "launchTubeAssembly";

	// Token: 0x04003A64 RID: 14948
	public new static readonly string b = "firingMechanism";

	// Token: 0x04003A65 RID: 14949
	public static readonly string c = "enhancement1";

	// Token: 0x04003A66 RID: 14950
	public new static readonly string d = "enhancement2";
}
