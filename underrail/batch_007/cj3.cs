using System;
using System.Runtime.Serialization;

// Token: 0x02000FCF RID: 4047
[eiz("HCST")]
[Serializable]
public sealed class cj3 : dnh, ISerializable
{
	// Token: 0x06005339 RID: 21305 RVA: 0x0024FF20 File Offset: 0x0024E120
	private cj3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("HCST:H");
	}

	// Token: 0x0600533A RID: 21306 RVA: 0x0024FF44 File Offset: 0x0024E144
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HCST:H", this.a);
	}

	// Token: 0x0600533B RID: 21307 RVA: 0x0024FF60 File Offset: 0x0024E160
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x0024FF68 File Offset: 0x0024E168
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600533D RID: 21309 RVA: 0x0024FF74 File Offset: 0x0024E174
	public cj3()
	{
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x0024FF84 File Offset: 0x0024E184
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			ap9 classPropertyValue = A_1.GetClassPropertyValue<ap9>("otherParty");
			return (classPropertyValue != null && (classPropertyValue.g & d8o.b) > d8o.a) == this.a;
		}
		return false;
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x0024FFC8 File Offset: 0x0024E1C8
	public override string ToString()
	{
		if (this.a)
		{
			return "Цель - человек";
		}
		return "Цель - НЕ человек";
	}

	// Token: 0x04002201 RID: 8705
	private bool a = true;
}
