using System;
using System.Runtime.Serialization;

// Token: 0x02000528 RID: 1320
[eiz("LDE")]
[Serializable]
public sealed class ai6 : a0x, ISerializable
{
	// Token: 0x060021ED RID: 8685 RVA: 0x000B48C8 File Offset: 0x000B2AC8
	private ai6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000B48D4 File Offset: 0x000B2AD4
	public ai6()
	{
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000B48DC File Offset: 0x000B2ADC
	protected override string hk()
	{
		return "Замок успешно вскрыт.";
	}
}
