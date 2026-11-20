using System;
using System.Runtime.Serialization;

// Token: 0x020009E0 RID: 2528
[eiz("L27")]
[Serializable]
public sealed class b4g : bdw, ISerializable
{
	// Token: 0x06003C7D RID: 15485 RVA: 0x0016692C File Offset: 0x00164B2C
	private b4g(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x00166934 File Offset: 0x00164B34
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x00166938 File Offset: 0x00164B38
	public b4g()
	{
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x00166944 File Offset: 0x00164B44
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			csd a_ = A_0.g("bandit1");
			csd a_2 = A_0.g("bandit2");
			csd a_3 = A_0.g("bandit3");
			vq.a("creature\\characters\\support\\jqsd1", a_, true);
			vq.a("creature\\characters\\support\\jqsd2", a_2, true);
			vq.a("creature\\characters\\support\\jqsd3", a_3, true);
		}
	}
}
