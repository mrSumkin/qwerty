using System;
using System.Runtime.Serialization;

// Token: 0x02001CEE RID: 7406
[eiz("MRQ")]
[Serializable]
public sealed class em9 : brl, ICloneable
{
	// Token: 0x0600A2A7 RID: 41639 RVA: 0x003E9AD8 File Offset: 0x003E7CD8
	private em9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600A2A8 RID: 41640 RVA: 0x003E9AE4 File Offset: 0x003E7CE4
	public em9()
	{
	}

	// Token: 0x0600A2A9 RID: 41641 RVA: 0x003E9AEC File Offset: 0x003E7CEC
	public override int og()
	{
		return 1;
	}

	// Token: 0x0600A2AA RID: 41642 RVA: 0x003E9AF0 File Offset: 0x003E7CF0
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		return A_0.StatusEffects.a(y4.h);
	}

	// Token: 0x0600A2AB RID: 41643 RVA: 0x003E9B10 File Offset: 0x003E7D10
	public override string ToString()
	{
		return dh9.c("BeInMotion");
	}

	// Token: 0x0600A2AC RID: 41644 RVA: 0x003E9B1C File Offset: 0x003E7D1C
	public object Clone()
	{
		return new em9();
	}
}
