using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020018F9 RID: 6393
[eiz("KI")]
[Serializable]
public sealed class arz : ISerializable
{
	// Token: 0x060087E4 RID: 34788 RVA: 0x003817CC File Offset: 0x0037F9CC
	private arz(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadDictionary<string, string>("KI:S", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(arz))
		{
			this.a = (Dictionary<string, string>)A_0.GetValue("Sections", typeof(Dictionary<string, string>));
			return;
		}
		this.a = (Dictionary<string, string>)A_0.GetValue("KnowledgeItem+Sections", typeof(Dictionary<string, string>));
	}

	// Token: 0x060087E5 RID: 34789 RVA: 0x00381864 File Offset: 0x0037FA64
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<string, string>("KI:S", this.a, info);
	}

	// Token: 0x060087E6 RID: 34790 RVA: 0x00381878 File Offset: 0x0037FA78
	public arz()
	{
	}

	// Token: 0x04003586 RID: 13702
	public Dictionary<string, string> a = new Dictionary<string, string>();
}
