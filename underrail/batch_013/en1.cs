using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020000D7 RID: 215
[eiz("BSM")]
[Serializable]
public sealed class en1 : ISerializable
{
	// Token: 0x060004BC RID: 1212 RVA: 0x0001589C File Offset: 0x00013A9C
	private en1(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadDictionary<string, ei5>("BSM:I", ref this.a, A_0);
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x000158C0 File Offset: 0x00013AC0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<string, ei5>("BSM:I", this.a, info);
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x000158D4 File Offset: 0x00013AD4
	public en1()
	{
	}

	// Token: 0x0400045B RID: 1115
	public Dictionary<string, ei5> a = new Dictionary<string, ei5>();
}
