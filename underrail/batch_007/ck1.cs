using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001153 RID: 4435
[eiz("Z0")]
[Serializable]
public sealed class ck1 : ISerializable
{
	// Token: 0x06005F00 RID: 24320 RVA: 0x002841F4 File Offset: 0x002823F4
	private ck1(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<esz>("Z0:F", ref this.a, A_0);
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x00284218 File Offset: 0x00282418
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		di7.WriteList<esz>("Z0:F", this.a, info);
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x0028422C File Offset: 0x0028242C
	public List<esz> a()
	{
		return this.a;
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x00284234 File Offset: 0x00282434
	public void a(List<esz> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x00284240 File Offset: 0x00282440
	public ck1()
	{
	}

	// Token: 0x040025CD RID: 9677
	private List<esz> a = new List<esz>();
}
