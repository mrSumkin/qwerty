using System;
using System.Runtime.Serialization;

// Token: 0x02000526 RID: 1318
[eiz("LLE")]
[Serializable]
public sealed class e5s : a0x, ISerializable
{
	// Token: 0x060021E6 RID: 8678 RVA: 0x000B4804 File Offset: 0x000B2A04
	private e5s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000B4810 File Offset: 0x000B2A10
	public e5s()
	{
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000B4818 File Offset: 0x000B2A18
	protected override string hk()
	{
		return "Успешно заперто.";
	}
}
