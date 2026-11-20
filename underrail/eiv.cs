using System;
using System.Runtime.Serialization;

// Token: 0x0200120D RID: 4621
[eiz("TT1")]
[Serializable]
public sealed class eiv : uo, ISerializable
{
	// Token: 0x06006342 RID: 25410 RVA: 0x002ADBF8 File Offset: 0x002ABDF8
	private eiv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006343 RID: 25411 RVA: 0x002ADC04 File Offset: 0x002ABE04
	protected override string rm()
	{
		return "FragMineActivate";
	}

	// Token: 0x06006344 RID: 25412 RVA: 0x002ADC0C File Offset: 0x002ABE0C
	protected override string rn()
	{
		return "осколочная мина";
	}

	// Token: 0x06006345 RID: 25413 RVA: 0x002ADC14 File Offset: 0x002ABE14
	protected override string ro()
	{
		return bby.j();
	}

	// Token: 0x06006346 RID: 25414 RVA: 0x002ADC1C File Offset: 0x002ABE1C
	protected override float rs()
	{
		return aju.a2;
	}

	// Token: 0x06006347 RID: 25415 RVA: 0x002ADC24 File Offset: 0x002ABE24
	protected override b6a rp()
	{
		return new crc();
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x002ADC2C File Offset: 0x002ABE2C
	protected override blv rq()
	{
		return bby.l();
	}

	// Token: 0x06006349 RID: 25417 RVA: 0x002ADC34 File Offset: 0x002ABE34
	protected override double rr()
	{
		return (double)bby.k();
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x002ADC3C File Offset: 0x002ABE3C
	public eiv(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}
}
