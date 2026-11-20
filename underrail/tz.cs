using System;
using System.Runtime.Serialization;

// Token: 0x020019B6 RID: 6582
[eiz("SFRME")]
[Serializable]
public sealed class tz : cdh, ISerializable, d7s
{
	// Token: 0x06008CC5 RID: 36037 RVA: 0x00391D30 File Offset: 0x0038FF30
	private tz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008CC6 RID: 36038 RVA: 0x00391D3C File Offset: 0x0038FF3C
	public tz()
	{
	}

	// Token: 0x06008CC7 RID: 36039 RVA: 0x00391D44 File Offset: 0x0038FF44
	public override string b2()
	{
		return string.Format("У врагов, попавших в конус атаки направленного огня (независимо от того, получили ли они урон), шанс попасть в цель уменьшается на {0}%, очки действия уменьшаются на {1}, а очки передвижения на {2} в течение {3}.", new object[]
		{
			(int)(be1.a * 100.0),
			be1.b,
			be1.c,
			l4.a((double)be1.d, false)
		});
	}

	// Token: 0x06008CC8 RID: 36040 RVA: 0x00391DA4 File Offset: 0x0038FFA4
	public override d3e b3()
	{
		tz tz = new tz();
		this.xx(tz);
		return tz;
	}

	// Token: 0x06008CC9 RID: 36041 RVA: 0x00391DC0 File Offset: 0x0038FFC0
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06008CCA RID: 36042 RVA: 0x00391DC4 File Offset: 0x0038FFC4
	public bool co(d3e A_0)
	{
		return A_0 is tz;
	}
}
