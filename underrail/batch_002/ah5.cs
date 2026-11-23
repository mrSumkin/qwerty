using System;
using System.Runtime.Serialization;

// Token: 0x02000FCE RID: 4046
[eiz("MCST")]
[Serializable]
public sealed class ah5 : dnh, ISerializable
{
	// Token: 0x06005332 RID: 21298 RVA: 0x0024FE5C File Offset: 0x0024E05C
	private ah5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("MCST:M");
	}

	// Token: 0x06005333 RID: 21299 RVA: 0x0024FE80 File Offset: 0x0024E080
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCST:M", this.a);
	}

	// Token: 0x06005334 RID: 21300 RVA: 0x0024FE9C File Offset: 0x0024E09C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005335 RID: 21301 RVA: 0x0024FEA4 File Offset: 0x0024E0A4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005336 RID: 21302 RVA: 0x0024FEB0 File Offset: 0x0024E0B0
	public ah5()
	{
	}

	// Token: 0x06005337 RID: 21303 RVA: 0x0024FEC4 File Offset: 0x0024E0C4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			ap9 classPropertyValue = A_1.GetClassPropertyValue<ap9>("otherParty");
			return (classPropertyValue != null && (classPropertyValue.g & d8o.e) > d8o.a) == this.a;
		}
		return false;
	}

	// Token: 0x06005338 RID: 21304 RVA: 0x0024FF08 File Offset: 0x0024E108
	public override string ToString()
	{
		if (this.a)
		{
			return "Цель - машина";
		}
		return "Цель не является машиной";
	}

	// Token: 0x04002200 RID: 8704
	private bool a = true;
}
