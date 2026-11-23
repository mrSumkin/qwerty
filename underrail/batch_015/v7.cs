using System;
using System.Runtime.Serialization;

// Token: 0x02001AF4 RID: 6900
[eiz("CDQ")]
[Serializable]
public sealed class v7 : els, ISerializable
{
	// Token: 0x06009579 RID: 38265 RVA: 0x003AA29C File Offset: 0x003A849C
	private v7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600957A RID: 38266 RVA: 0x003AA2AC File Offset: 0x003A84AC
	public v7(int A_0) : base(v7.a, "Ползучий ужас", ci8.c)
	{
		base.Icon = "Status.CreepingDread";
		base.Duration = A_0;
		base.MaxStacks = v7.c;
		base.StaticEffects.Add(new bxb("Guns", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Heavy Guns", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Crossbows", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Throwing", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Melee", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Dodge", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Evasion", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Metathermics", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Thought Control", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Psychokinesis", -v7.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Temporal Manipulation", -v7.b)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x0600957B RID: 38267 RVA: 0x003AA48C File Offset: 0x003A868C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CreepingDread", new object[]
		{
			(int)(Math.Round((double)((float)base.Stacks * v7.b), 2) * 100.0)
		});
	}

	// Token: 0x0600957C RID: 38268 RVA: 0x003AA4C8 File Offset: 0x003A86C8
	protected override void c8()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			((bxb)d3e).a(-v7.b * (float)base.Stacks);
		}
	}

	// Token: 0x0400398E RID: 14734
	public new static readonly string a = "creepingDread";

	// Token: 0x0400398F RID: 14735
	public static readonly float b = 0.02f;

	// Token: 0x04003990 RID: 14736
	public new static readonly int c = 20;
}
