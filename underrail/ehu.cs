using System;
using System.Runtime.Serialization;

// Token: 0x020000AF RID: 175
[Serializable]
public class ehu : Exception, ISerializable
{
	// Token: 0x060003F7 RID: 1015 RVA: 0x000132FC File Offset: 0x000114FC
	public Type a()
	{
		return this.a;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00013304 File Offset: 0x00011504
	public ehu()
	{
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00013310 File Offset: 0x00011510
	public ehu(Type A_0) : base(ki.a("Failed to locate service of type '{0}'.", new object[]
	{
		A_0.Name
	}))
	{
		this.a = A_0;
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00013344 File Offset: 0x00011544
	public ehu(Type A_0, Exception A_1) : base(ki.a("Failed to locate service of type '{0}'.", new object[]
	{
		A_0.Name
	}), A_1)
	{
		this.a = A_0;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00013378 File Offset: 0x00011578
	protected ehu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x04000433 RID: 1075
	private Type a;
}
