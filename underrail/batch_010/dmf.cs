using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x020000E5 RID: 229
[eiz("PHB")]
[XmlRoot("PhraseBook")]
[Serializable]
public sealed class dmf : ISerializable
{
	// Token: 0x06000505 RID: 1285 RVA: 0x00016AEC File Offset: 0x00014CEC
	private dmf(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<ehq>("PHB:P", ref this.a, A_0);
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00016B10 File Offset: 0x00014D10
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<ehq>("PHB:P", this.a, info);
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00016B24 File Offset: 0x00014D24
	public List<ehq> a()
	{
		return this.a;
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00016B2C File Offset: 0x00014D2C
	public void a(List<ehq> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00016B38 File Offset: 0x00014D38
	public dmf()
	{
	}

	// Token: 0x04000478 RID: 1144
	private List<ehq> a = new List<ehq>();
}
