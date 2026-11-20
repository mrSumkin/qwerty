using System;
using System.Runtime.Serialization;

// Token: 0x020009AF RID: 2479
[eiz("FOTDOP")]
[Serializable]
public sealed class up : bdw, ISerializable
{
	// Token: 0x06003BB8 RID: 15288 RVA: 0x001617D4 File Offset: 0x0015F9D4
	private up(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BB9 RID: 15289 RVA: 0x001617DC File Offset: 0x0015F9DC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BBA RID: 15290 RVA: 0x001617E0 File Offset: 0x0015F9E0
	public up()
	{
	}

	// Token: 0x06003BBB RID: 15291 RVA: 0x001617E8 File Offset: 0x0015F9E8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && !A_1.r().GetPrimitivePropertyValue<bool>("npc_fo_todor_dead", new bool?(false)).Value && A_0 != null)
		{
			aud aud = A_0.n("fo_prison");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f6667db1-2de2-4330-b37e-ffb7a6c35df0"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
