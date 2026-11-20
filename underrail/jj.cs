using System;
using System.Runtime.Serialization;

// Token: 0x0200052A RID: 1322
[eiz("LUE")]
[Serializable]
public sealed class jj : a0x, ISerializable
{
	// Token: 0x060021F4 RID: 8692 RVA: 0x000B498C File Offset: 0x000B2B8C
	private jj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000B4998 File Offset: 0x000B2B98
	public jj()
	{
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000B49A0 File Offset: 0x000B2BA0
	protected override string hk()
	{
		return "Открыто.";
	}
}
