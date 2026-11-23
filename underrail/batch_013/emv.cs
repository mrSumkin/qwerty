using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F5 RID: 1781
[eiz("FSCG")]
[Serializable]
public sealed class emv : d1k, ISerializable
{
	// Token: 0x06002E04 RID: 11780 RVA: 0x0010559C File Offset: 0x0010379C
	private emv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x001055A8 File Offset: 0x001037A8
	public emv()
	{
	}

	// Token: 0x06002E06 RID: 11782 RVA: 0x001055B0 File Offset: 0x001037B0
	protected override cd1 rf(int A_0)
	{
		be0 be = d79.Get<be0>();
		coe coe = d79.Get<coe>();
		if (be == null || coe == null)
		{
			return null;
		}
		a1k a1k = new a1k();
		a1k.b(new double?((double)50000));
		a1k.k("fusionCannonFrame");
		a1k.a(ms.a);
		a1k.i("На раме размещена мощная магнито-инерциальная система удержания и ускорения (МИСУУ), способная удерживать, сжимать и ускорять плотный плазмоид, создаваемый излучателем.");
		a1k.f("&StatusIcons.3");
		a1k.g("Fusion Cannon Frame");
		a1k.a(cr1.e);
		a1k.g().Add(new b8w(SkillEnum.Electronics.ToString(), 100f));
		a1k.a(a0.aw);
		a1k.h(12.5);
		a1k.a2().Add(new aia("genericUseJobItem"));
		a1k.a7()["UsageJob"] = this.a(false);
		fv value = new fv(new IndependentItemDefinitionProvider<a1k>(a1k));
		fv fv = y8.a("EnergyCores\\PlasmaCore", null);
		if (fv == null)
		{
			return null;
		}
		fv.QualityLevel = y8.a(A_0);
		int value2 = y8.a(A_0);
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary[coe.a] = y8.a("Weapons\\LaserEmitter", new int?(value2));
		dictionary[coe.b] = y8.a("Weapons\\ElectroshockGenerator", new int?(value2));
		dictionary[coe.c] = y8.a("Devices\\CircularWaveAmplifier", new int?(value2));
		dictionary[coe.d] = y8.a("Devices\\EmFieldStabilizer", new int?(value2));
		dictionary[coe.e] = y8.a("Devices\\HighEfficiencyEnergyConverter", new int?(value2));
		fv fv2 = coe.a(null, dictionary).a() as fv;
		if (fv2 == null)
		{
			return null;
		}
		fv2.Definition.a2().Add(new aia("genericUseJobItem"));
		fv2.Definition.a7()["UsageJob"] = this.a(true);
		dictionary.Clear();
		dictionary.Add(be0.a, value);
		dictionary.Add(be0.b, fv2);
		dictionary.Add(be0.c, fv);
		return be.a(null, dictionary).a() as cd1;
	}

	// Token: 0x06002E07 RID: 11783 RVA: 0x00105804 File Offset: 0x00103A04
	public override aw4 a1()
	{
		emv emv = new emv();
		this.rg(emv);
		return emv;
	}

	// Token: 0x06002E08 RID: 11784 RVA: 0x00105820 File Offset: 0x00103A20
	private bt1 a(bool A_0 = false)
	{
		bt1 bt = new bt1();
		bt.a(30);
		bt.a(true);
		bt.a(c0e.d);
		bt.c("ItemRepair_Mechanical");
		bt.b(5000);
		bt.b(false);
		bt.a(dsk.b);
		bt.e("Осмотр");
		bt.b(A_0 ? "XPHWIJGFEB" : "XPHWIJGFCB");
		bt.d("Осмотреть и попытаться " + (A_0 ? "воспроизвести разработку." : "обучиться создавать."));
		return bt;
	}
}
