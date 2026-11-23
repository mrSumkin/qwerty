using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020000DB RID: 219
[eiz("ESI")]
[Serializable]
internal sealed class ch1 : ISerializable
{
	// Token: 0x060004C6 RID: 1222 RVA: 0x00015A80 File Offset: 0x00013C80
	public ch1()
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00015A94 File Offset: 0x00013C94
	private ch1(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<b7v>("ESI:S", ref this.a, A_0);
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00015AB8 File Offset: 0x00013CB8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<b7v>("ESI:S", this.a, info);
	}

	// Token: 0x04000468 RID: 1128
	public List<b7v> a = new List<b7v>();
}
