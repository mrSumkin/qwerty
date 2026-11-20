using System;
using System.Runtime.Serialization;

// Token: 0x02001AB0 RID: 6832
[eiz("PMFRCSE")]
[Serializable]
public sealed class d3j : els, ISerializable
{
	// Token: 0x06009430 RID: 37936 RVA: 0x003A57B0 File Offset: 0x003A39B0
	private d3j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009431 RID: 37937 RVA: 0x003A57BC File Offset: 0x003A39BC
	public d3j() : base(d3j.a, "Ледяной коготь", ci8.c)
	{
		base.Duration = d3j.b;
		base.Icon = "Weapon.MutantClaw.Huge.Frost";
		base.Stacking = axm.b;
		base.Stacks = d3j.c;
		base.MaxStacks = d3j.c;
		this.ab = "PlayerMutant_FrostHandBuff";
		this.y = "PlayerMutant_FrostHandBuff_Expires";
		this.aa = "PlayerMutant_FrostHandBuff_Expires";
	}

	// Token: 0x06009432 RID: 37938 RVA: 0x003A5830 File Offset: 0x003A3A30
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PlayerMutantFrostClaw", new object[0]);
	}

	// Token: 0x040038F5 RID: 14581
	public new static string a = "playerMutantFrostClaw";

	// Token: 0x040038F6 RID: 14582
	private static int b = 300000;

	// Token: 0x040038F7 RID: 14583
	private new static int c = 15;
}
