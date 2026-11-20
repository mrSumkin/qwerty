using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020001CE RID: 462
[eiz("MUX")]
[Serializable]
public sealed class azj : ISerializable
{
	// Token: 0x06000DC5 RID: 3525 RVA: 0x00039AE0 File Offset: 0x00037CE0
	private azj(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<eva>("MUX:U", ref this.a, A_0);
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00039B04 File Offset: 0x00037D04
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<eva>("MUX:U", this.a, info);
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00039B18 File Offset: 0x00037D18
	public azj()
	{
	}

	// Token: 0x040007FD RID: 2045
	public List<eva> a = new List<eva>();
}
