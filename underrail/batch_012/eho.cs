using System;
using System.Runtime.Serialization;

// Token: 0x020019A5 RID: 6565
[eiz("EBC")]
[dn2("ElectroboltChain")]
[Serializable]
public sealed class eho : buu, ISerializable
{
	// Token: 0x06008C27 RID: 35879 RVA: 0x00390C4C File Offset: 0x0038EE4C
	private eho(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x00390C58 File Offset: 0x0038EE58
	public eho()
	{
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x00390C64 File Offset: 0x0038EE64
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return qv.a("HitEffects/ElectroBoltChainChance", new object[]
			{
				(int)(A_0.Chance * 100.0),
				(int)(eho.b * 100.0),
				A_0.Power,
				(int)(eho.a * 100.0)
			});
		}
		return qv.a("HitEffects/ElectroBoltChain", new object[]
		{
			(int)(eho.b * 100.0),
			A_0.Power,
			(int)(eho.a * 100.0)
		});
	}

	// Token: 0x0400379A RID: 14234
	public new static readonly double a = 0.65;

	// Token: 0x0400379B RID: 14235
	public static readonly double b = 0.5;
}
