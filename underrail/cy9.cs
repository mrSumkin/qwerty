using System;
using System.Runtime.Serialization;

// Token: 0x020019DB RID: 6619
[eiz("EHHCME")]
[Serializable]
public sealed class cy9 : cdh, ISerializable, d7s
{
	// Token: 0x06008E17 RID: 36375 RVA: 0x00394A8C File Offset: 0x00392C8C
	private cy9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008E18 RID: 36376 RVA: 0x00394A98 File Offset: 0x00392C98
	public cy9()
	{
	}

	// Token: 0x06008E19 RID: 36377 RVA: 0x00394AA0 File Offset: 0x00392CA0
	public override string b2()
	{
		return string.Format("Позволяет создавать обогащённые стимуляторы, которые имеют {0}% шанс на критическое исцеление.", Convert.ToInt32(cy9.a * 100.0));
	}

	// Token: 0x06008E1A RID: 36378 RVA: 0x00394AC8 File Offset: 0x00392CC8
	public override d3e b3()
	{
		cy9 cy = new cy9();
		this.xx(cy);
		return cy;
	}

	// Token: 0x06008E1B RID: 36379 RVA: 0x00394AE4 File Offset: 0x00392CE4
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06008E1C RID: 36380 RVA: 0x00394AE8 File Offset: 0x00392CE8
	public bool co(d3e A_0)
	{
		return A_0 is cy9;
	}

	// Token: 0x040037CE RID: 14286
	public new static readonly double a = 0.1;
}
