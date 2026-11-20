using System;
using System.Runtime.Serialization;

// Token: 0x0200185B RID: 6235
[eiz("EA")]
[Serializable]
public sealed class bzg : btm, ISerializable
{
	// Token: 0x060084F5 RID: 34037 RVA: 0x00374424 File Offset: 0x00372624
	private bzg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060084F6 RID: 34038 RVA: 0x00374430 File Offset: 0x00372630
	public bzg(string A_0 = null) : base(A_0)
	{
	}

	// Token: 0x060084F7 RID: 34039 RVA: 0x0037443C File Offset: 0x0037263C
	protected override bool b4(e6d A_0)
	{
		return true;
	}
}
