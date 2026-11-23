using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B84 RID: 7044
[dgg("Balaclava")]
public sealed class dhl : cwp, bd3
{
	// Token: 0x060098CB RID: 39115 RVA: 0x003BA738 File Offset: 0x003B8938
	public override string bt()
	{
		return "茕Балаклава";
	}

	// Token: 0x060098CC RID: 39116 RVA: 0x003BA740 File Offset: 0x003B8940
	public override string bu()
	{
		return "Balaclava";
	}

	// Token: 0x060098CD RID: 39117 RVA: 0x003BA748 File Offset: 0x003B8948
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x060098CE RID: 39118 RVA: 0x003BA74C File Offset: 0x003B894C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Armor;
	}

	// Token: 0x060098CF RID: 39119 RVA: 0x003BA750 File Offset: 0x003B8950
	public dhl()
	{
		base.Slots.Add(dhl.a, new cgo(new c6s(ms.c, 3), "Ткань", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060098D0 RID: 39120 RVA: 0x003BA790 File Offset: 0x003B8990
	public List<bj8> bz()
	{
		int num = 0;
		int y = 20;
		string a_ = "Armors";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 4; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("balaclava.{0}", i));
			bj.a().Add(new d8h(a_, new Point(num + i, y), 1f));
			list.Add(bj);
		}
		return list;
	}

	// Token: 0x060098D1 RID: 39121 RVA: 0x003BA80C File Offset: 0x003B8A0C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dhl.a, null);
		if (fv != null)
		{
			ett ett = fv.Definition as ett;
			if (ett != null)
			{
				int num = fv.QualityLevel;
				if (A_0 != null && A_0.Feats.Contains<rh>())
				{
					num = (int)((double)num * (1.0 + rh.a(A_0)));
				}
				bqu bqu = new bqu();
				bqu.a(ett.bc());
				bqu.b(new double?((double)fv.SingleItemValue));
				bqu.h(fv.SingleItemWeight);
				bqu.g((int)Math.Ceiling(cwp.a(num)));
				bqu.a(ItemStealingCategory.Default);
				bqu.a(a0.q);
				bqu.a(ItemRepairCategory.Fabric);
				bqu.g("Балаклава");
				k7 k = new k7(new IndependentItemDefinitionProvider<bqu>(bqu));
				c6o.a(bqu, ett, (int)((double)num * 0.5));
				c6o.a(A_0, k, ett, num, true, 0.5, false);
				if (ett.a5() == "kevlarCloth")
				{
					bqu.i().Add(new du2(DamageType.Mechanical, 2, 0.0));
					dwb item = new dwb
					{
						Bonus = 2.0
					};
					bqu.f().Add(item);
				}
				else if (ett.a5() == "blastCloth")
				{
					double num2 = Math.Min(0.75, 0.1 + 0.002 * (double)num);
					bqu.ar().Add(new dcp(-num2));
				}
				bqu.f("balaclava." + ett.a7().GetPrimitivePropertyValue<int>("MatIndex", new int?(0)).Value.ToString());
				string classPropertyValue = ett.a7().GetClassPropertyValue<string>("BalaclavaPrefix");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					bqu.g(classPropertyValue + " " + bqu.az());
				}
				int num3 = bqu.i().FindIndex(new Predicate<du2>(dhl.a.a.a));
				du2 du;
				if (num3 == -1)
				{
					du = default(du2);
				}
				else
				{
					du = bqu.i()[num3];
				}
				du.a(DamageType.Cold);
				du.a(0.1);
				if (num3 == -1)
				{
					bqu.i().Add(du);
				}
				else
				{
					bqu.i()[num3] = du;
				}
				bqu.ar().Add(new dpw("Intimidation", 5));
				bqu.i(ett.a7().GetClassPropertyValue<string>("BalaclavaDesc"));
				bqu.b(0.0);
				return k;
			}
		}
		return null;
	}

	// Token: 0x04003A93 RID: 14995
	public new static readonly string a = "fabric";

	// Token: 0x02001B85 RID: 7045
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060098D5 RID: 39125 RVA: 0x003BAB14 File Offset: 0x003B8D14
		internal bool a(du2 A_0)
		{
			return A_0.b() == DamageType.Cold;
		}

		// Token: 0x04003A94 RID: 14996
		public static readonly dhl.a a = new dhl.a();

		// Token: 0x04003A95 RID: 14997
		public static Predicate<du2> b;
	}
}
