using System;
using System.Runtime.Serialization;

// Token: 0x02001AEB RID: 6891
[eiz("SI6")]
[Serializable]
public sealed class c1c : els, ISerializable
{
	// Token: 0x0600954B RID: 38219 RVA: 0x003A9634 File Offset: 0x003A7834
	private c1c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600954C RID: 38220 RVA: 0x003A9640 File Offset: 0x003A7840
	public c1c(int A_0) : base(c1c.a, "Spore Infection", ci8.c)
	{
		base.Icon = "Status.59";
		base.Duration = A_0;
		base.MaxStacks = c1c.b;
		base.StaticEffects.Add(new bh1(-c1c.c)
		{
			Priority = int.MaxValue
		});
		base.TickPeriod = d0u.b;
		this.z = "SI6T";
	}

	// Token: 0x0600954D RID: 38221 RVA: 0x003A96B4 File Offset: 0x003A78B4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SporeInfection", new object[]
		{
			(int)(Math.Round((double)base.Stacks * c1c.c, 2) * 100.0)
		});
	}

	// Token: 0x0600954E RID: 38222 RVA: 0x003A96F0 File Offset: 0x003A78F0
	protected override void c8()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			((bh1)d3e).a(-c1c.c * (double)base.Stacks);
		}
	}

	// Token: 0x04003978 RID: 14712
	public new static readonly string a = "sporeInfections";

	// Token: 0x04003979 RID: 14713
	public static readonly int b = 15;

	// Token: 0x0400397A RID: 14714
	public new static readonly double c = 0.02;
}
