using System;
using System.Runtime.Serialization;

// Token: 0x02001B03 RID: 6915
[eiz("PMFCSE")]
[Serializable]
public sealed class b4p : els, ISerializable
{
	// Token: 0x060095BC RID: 38332 RVA: 0x003AB168 File Offset: 0x003A9368
	private b4p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095BD RID: 38333 RVA: 0x003AB174 File Offset: 0x003A9374
	public b4p() : base(b4p.a, "Горячий коготь", ci8.c)
	{
		base.Duration = b4p.b;
		base.Icon = "Weapon.MutantClaw.Fast.Fire";
		base.Stacking = axm.b;
		base.Stacks = b4p.c;
		base.MaxStacks = b4p.c;
		this.ab = "PlayerMutant_FireHandBuff";
		this.y = "PlayerMutant_FireHandBuff_Expires";
		this.aa = "PlayerMutant_FireHandBuff_Expires";
	}

	// Token: 0x060095BE RID: 38334 RVA: 0x003AB1E8 File Offset: 0x003A93E8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PlayerMutantFireClaw", new object[0]);
	}

	// Token: 0x040039A2 RID: 14754
	public new static string a = "playerMutantFireClaw";

	// Token: 0x040039A3 RID: 14755
	private static int b = 300000;

	// Token: 0x040039A4 RID: 14756
	private new static int c = 10;
}
