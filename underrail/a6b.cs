using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200071E RID: 1822
[eiz("COS")]
[Serializable]
public sealed class a6b : ISerializable
{
	// Token: 0x06002F5F RID: 12127 RVA: 0x0011F054 File Offset: 0x0011D254
	private a6b(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<wa>("COS:O", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(a6b))
		{
			this.a = (List<wa>)A_0.GetValue("_Opportunities", typeof(List<wa>));
			return;
		}
		this.a = (List<wa>)A_0.GetValue("CharacterOpportunitySet+_Opportunities", typeof(List<wa>));
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x0011F0EC File Offset: 0x0011D2EC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<wa>("COS:O", this.a, info);
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x0011F100 File Offset: 0x0011D300
	public List<wa> a()
	{
		return this.a;
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x0011F108 File Offset: 0x0011D308
	public a6b()
	{
	}

	// Token: 0x04001A31 RID: 6705
	private List<wa> a = new List<wa>();
}
