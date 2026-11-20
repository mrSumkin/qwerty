using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A82 RID: 6786
[eiz("BLARSE")]
[Serializable]
public sealed class bca : els, ISerializable
{
	// Token: 0x0600935A RID: 37722 RVA: 0x003A2040 File Offset: 0x003A0240
	private bca(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600935B RID: 37723 RVA: 0x003A204C File Offset: 0x003A024C
	public bca(int A_0) : base("blastedArmor", "Взрывная броня", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.BlastedArmor";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = (int)(bca.a * 100.0);
		base.StaticEffects.Add(new ah(DamageType.Mechanical, 1.0 - bca.a, true, true, false)
		{
			Priority = 1
		});
		base.StaticEffects.Add(new ah(DamageType.Heat, 1.0 - bca.a, true, true, false)
		{
			Priority = 1
		});
	}

	// Token: 0x0600935C RID: 37724 RVA: 0x003A20F4 File Offset: 0x003A02F4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BlastedArmor", new object[]
		{
			Convert.ToInt32(bca.a * 100.0)
		});
	}

	// Token: 0x0400388C RID: 14476
	public new static readonly double a = 0.2;
}
