using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019AC RID: 6572
[eiz("ACIE")]
[Serializable]
public sealed class al4 : dbj
{
	// Token: 0x06008C6D RID: 35949 RVA: 0x00391198 File Offset: 0x0038F398
	private al4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x003911A4 File Offset: 0x0038F3A4
	public override string f9()
	{
		return "anticoagulant";
	}

	// Token: 0x06008C6F RID: 35951 RVA: 0x003911AC File Offset: 0x0038F3AC
	public override string ga()
	{
		return "Антикоагулянт";
	}

	// Token: 0x06008C70 RID: 35952 RVA: 0x003911B4 File Offset: 0x0038F3B4
	public override string qj()
	{
		return "Anticoagulant";
	}

	// Token: 0x06008C71 RID: 35953 RVA: 0x003911BC File Offset: 0x0038F3BC
	public override SpellTargetType qk()
	{
		return SpellTargetType.PoisonableWeapon;
	}

	// Token: 0x06008C72 RID: 35954 RVA: 0x003911C4 File Offset: 0x0038F3C4
	public override string ql()
	{
		return "Components.Anticoagulant";
	}

	// Token: 0x06008C73 RID: 35955 RVA: 0x003911CC File Offset: 0x0038F3CC
	public al4()
	{
	}

	// Token: 0x06008C74 RID: 35956 RVA: 0x003911D4 File Offset: 0x0038F3D4
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008C75 RID: 35957 RVA: 0x003911D8 File Offset: 0x0038F3D8
	public override string qn(coh A_0)
	{
		return "ApplyPoisonToBlade";
	}

	// Token: 0x06008C76 RID: 35958 RVA: 0x003911E4 File Offset: 0x0038F3E4
	public override string gc(efk A_0)
	{
		return qv.a("StatusEffects/AnticoagulationItemEffect_Cap", new object[]
		{
			Convert.ToInt32(bfm.b * 100.0),
			Math.Abs(Convert.ToInt32(bfm.a * 100.0)),
			l4.a((double)r6.a(new edm("", 1.0, al4.a, true)), false),
			bfm.c
		});
	}

	// Token: 0x06008C77 RID: 35959 RVA: 0x00391274 File Offset: 0x0038F474
	public override string gd(efk A_0)
	{
		return qv.a("StatusEffects/AnticoagulationItemEffect_Applied", new object[]
		{
			Convert.ToInt32(bfm.b * 100.0),
			Math.Abs(Convert.ToInt32(bfm.a * 100.0)),
			l4.a((double)r6.a(new edm("", 1.0, al4.a, true)), false),
			bfm.c
		});
	}

	// Token: 0x06008C78 RID: 35960 RVA: 0x00391304 File Offset: 0x0038F504
	public override List<edm> qo(cd1 A_0, bool A_1)
	{
		if (A_1)
		{
			return new List<edm>
			{
				new edm("Anticoagulation", 1.0, al4.a, true)
			};
		}
		return null;
	}

	// Token: 0x0400379D RID: 14237
	private new static readonly int a = 2;
}
