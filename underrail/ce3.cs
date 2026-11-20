using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001380 RID: 4992
[eiz("PMFHHEA")]
[bs6("HFX:PlayerMutantFrostHand")]
[Serializable]
public sealed class ce3 : cpl, ISerializable
{
	// Token: 0x06007108 RID: 28936 RVA: 0x002F7638 File Offset: 0x002F5838
	private ce3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x002F7644 File Offset: 0x002F5844
	public ce3()
	{
	}

	// Token: 0x0600710A RID: 28938 RVA: 0x002F7650 File Offset: 0x002F5850
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() != null && base.a().aa() != null && !base.a().aa().Dead)
		{
			d3j d3j = Enumerable.FirstOrDefault<d3j>(base.a().aa().StatusEffects.Get<d3j>());
			if (d3j != null)
			{
				d3j d3j2 = d3j;
				int num = d3j2.Stacks - 1;
				d3j2.Stacks = num;
				if (num <= 0)
				{
					base.a().aa().StatusEffects.d(d3j);
				}
			}
		}
		return dc4.c;
	}
}
