using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000986 RID: 2438
[eiz("TNVS")]
[Serializable]
public sealed class bgb : bdw, ISerializable
{
	// Token: 0x06003B13 RID: 15123 RVA: 0x0015E858 File Offset: 0x0015CA58
	private bgb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x0015E860 File Offset: 0x0015CA60
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x0015E864 File Offset: 0x0015CA64
	public bgb()
	{
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x0015E86C File Offset: 0x0015CA6C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch_met");
		if (aud != null && bpo.GetServiceOrThrow<cnk>() != null)
		{
			c5x c5x = new ar7(new Guid("a4f2cc50-e71b-46ac-8c5c-6e728d6e4c4e"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.Location = new Vector3(10f, 1f, 0f);
				c5x.ah();
			}
		}
	}
}
