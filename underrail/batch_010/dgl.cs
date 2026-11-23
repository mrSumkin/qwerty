using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001B7C RID: 7036
[dgg("chemicalPistol")]
public sealed class dgl : c4r, bd3
{
	// Token: 0x0600988E RID: 39054 RVA: 0x003B88C0 File Offset: 0x003B6AC0
	public override string bt()
	{
		return "莀Химический пистолет";
	}

	// Token: 0x0600988F RID: 39055 RVA: 0x003B88C8 File Offset: 0x003B6AC8
	public override string bu()
	{
		return "chemicalPistol";
	}

	// Token: 0x06009890 RID: 39056 RVA: 0x003B88D0 File Offset: 0x003B6AD0
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009891 RID: 39057 RVA: 0x003B88D4 File Offset: 0x003B6AD4
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009892 RID: 39058 RVA: 0x003B88D8 File Offset: 0x003B6AD8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Weapons;
	}

	// Token: 0x06009893 RID: 39059 RVA: 0x003B88DC File Offset: 0x003B6ADC
	public dgl()
	{
		base.Slots.Add(dgl.a, new cgo(new c6s(ms.a3, 50), "Рама", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dgl.b, new cgo(new c6s(ms.a5, 51), "Дозатор", false, 1, 0.1f, false, false, null));
		base.Slots.Add(dgl.c, new cgo(new c6s(ms.a4, 52), "Коллектор", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009894 RID: 39060 RVA: 0x003B8978 File Offset: 0x003B6B78
	public List<bj8> bz()
	{
		int num = 30;
		int num2 = 0;
		string a_ = "Weapons";
		List<bj8> list = new List<bj8>();
		for (int i = 0; i < 1; i++)
		{
			bj8 bj = new bj8();
			bj.a(string.Format("chemicalPistol.{0}.frame", i + 1));
			bj.a().Add(new d8h(a_, new Point(num, num2 + i), 1f));
			list.Add(bj);
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 1; k++)
				{
					bj = new bj8();
					bj.a(string.Format("chemicalPistol.{0}.{1}.{2}", i + 1, j + 1, k + 1));
					bj.a().Add(new d8h(a_, new Point(num + 1, num2 + j), 1f));
					bj.a().Add(new d8h(a_, new Point(num + 2, num2 + j), 0.5f));
					bj.a().Add(new d8h(a_, new Point(num + 3, num2 + k), 1f));
					list.Add(bj);
				}
			}
		}
		return list;
	}

	// Token: 0x06009895 RID: 39061 RVA: 0x003B8AC8 File Offset: 0x003B6CC8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(dgl.a, null);
		fv fv2 = A_1.SafeGet(dgl.b, null);
		fv fv3 = A_1.SafeGet(dgl.c, null);
		if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			double a_ = (cwp.a(fv2) + cwp.a(fv3)) / 2.0;
			int value = fv.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ChemicalPistolIndex", new int?(1)).Value;
			int value2 = fv2.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ChemicalPistolIndex", new int?(1)).Value;
			int value3 = fv3.TypedDefinition.a7().GetPrimitivePropertyValue<int>("ChemicalPistolIndex", new int?(1)).Value;
			bke bke = new bke();
			bke.b(new double?((double)(fv.SingleItemValue + fv3.SingleItemValue + fv2.SingleItemValue)));
			bke.h(fv.SingleItemWeight + fv3.SingleItemWeight + fv2.SingleItemWeight);
			bke.g((int)Math.Ceiling(a_));
			bke.a((cr1)Math.Max((int)fv2.TypedDefinition.bc(), (int)fv3.TypedDefinition.bc()));
			bke.a2().Add(new aia("uwep"));
			bke.a(ItemStealingCategory.Weapon);
			bke.a(a0.ar);
			c4r.a(bke, btz.a, this.a(value2, value3), fv.TypedDefinition);
			b1j b1j = c4r.a(A_0, this.a(value2, value3), a_, 1.0, null, null);
			if (value2 == 1)
			{
				bke.d(4f);
				bke.c(7f);
				bke.a(ImpactSpeed.Low);
				double num = 1.0;
				if (A_0 != null && A_0.Feats.Contains<ev4>())
				{
					num = 2.0 + (double)A_0.GetSpecializationValue<xz>(true) * xz.a;
				}
				if (value3 == 1)
				{
					bke.l().Add(new a1q(DamageType.Acid, (int)b1j.b, (int)b1j.c));
					bke.a(AmmoType.Vial_Acid);
					bke.a(bhx.x);
					bke.a(esu.k);
					bke.a(car.f);
					bke.aa().Add(new edm("acidicEntanglement", Math.Min(0.2 + (double)fv2.QualityLevel / 400.0, 0.65), (int)((double)(50 + fv3.QualityLevel / 2) * num), true));
					bke.aa().Add(new edm("SpewAcid", 1.0, 0, true));
				}
				else if (value3 == 2)
				{
					bke.l().Add(new a1q(DamageType.Mechanical, (int)(b1j.b * 0.33), (int)(b1j.c * 0.33)));
					bke.l().Add(new a1q(DamageType.Cold, (int)(b1j.b * 0.67), (int)(b1j.c * 0.67)));
					bke.a(AmmoType.Vial_Cryogel);
					bke.a(bhx.i);
					bke.a(esu.n);
					bke.a(car.g);
					bke.aa().Add(new edm("chill", 1.0, (int)((double)(2 + fv2.QualityLevel / 30) * num), true));
					bke.aa().Add(new edm("freeze", Math.Min(0.2 + (double)fv2.QualityLevel / 400.0, 0.65), (int)(1.0 * num), true));
					bke.c("iceProjectile");
				}
				else if (value3 == 3)
				{
					bke.l().Add(new a1q(DamageType.Heat, (int)b1j.b, (int)b1j.c));
					bke.a(AmmoType.Vial_Incendiary);
					bke.a(bhx.j);
					bke.a(esu.o);
					bke.a(car.h);
					bke.aa().Add(new edm("ignite", Math.Min(0.2 + (double)fv2.QualityLevel / 250.0, 0.75), (int)((double)(75 + fv3.QualityLevel) * num), true));
					bke.c("incendiaryBlob");
				}
			}
			string text = fv3.TypedDefinition.a7().GetClassPropertyValue<string>("ChemicalSubstance") ?? "Strange";
			string format = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("ChemicalWeaponType") ?? "{0}";
			bke.g(string.Format(format, text) + " пистолет");
			string classPropertyValue = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("ChemicalPistolDesc");
			bke.i(string.Format(classPropertyValue, text.ToLowerInvariant()));
			string classPropertyValue2 = fv3.TypedDefinition.a7().GetClassPropertyValue<string>("ChemicalPistolCollectorBonusText_" + value2.ToString());
			if (!string.IsNullOrEmpty(classPropertyValue2))
			{
				bke bke2 = bke;
				bke2.i(bke2.a0() + " " + classPropertyValue2);
			}
			bke.f(string.Format("chemicalPistol.{0}.{1}.{2}", value, value3, value2));
			bke bke3 = bke;
			bke3.b(bke3.bf() * (double)3);
			bke.b("ap");
			cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
			this.a(cd, A_0);
			return cd;
		}
		return null;
	}

	// Token: 0x06009896 RID: 39062 RVA: 0x003B9100 File Offset: 0x003B7300
	private void a(cd1 A_0, efk A_1)
	{
		if (A_1 != null)
		{
			dbb microfeat = A_1.GetMicrofeat<dbb>();
			if (microfeat != null)
			{
				A_0.TypedDefinition.f(Math.Max(0.0, A_0.TypedDefinition.ai() + microfeat.a()));
			}
		}
	}

	// Token: 0x06009897 RID: 39063 RVA: 0x003B914C File Offset: 0x003B734C
	private WeaponSubtype a(int A_0, int A_1)
	{
		if (A_1 == 1)
		{
			return WeaponSubtype.Pistol_Acid_Blob;
		}
		if (A_1 == 2)
		{
			return WeaponSubtype.Pistol_Cryo_Blob;
		}
		return WeaponSubtype.Pistol_Indendiary_Blob;
	}

	// Token: 0x04003A7B RID: 14971
	public new static readonly string a = "frame";

	// Token: 0x04003A7C RID: 14972
	public new static readonly string b = "dispenser";

	// Token: 0x04003A7D RID: 14973
	public static readonly string c = "collector";
}
