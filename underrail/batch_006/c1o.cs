using System;
using System.Runtime.Serialization;

// Token: 0x020009E3 RID: 2531
[eiz("XPHWUPCIP")]
[Serializable]
public sealed class c1o : bdw, ISerializable
{
	// Token: 0x06003C8B RID: 15499 RVA: 0x00166D18 File Offset: 0x00164F18
	private c1o(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C8C RID: 15500 RVA: 0x00166D20 File Offset: 0x00164F20
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x00166D24 File Offset: 0x00164F24
	public c1o()
	{
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x00166D30 File Offset: 0x00164F30
	public void av(c1a A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("3cc21abd-8fb0-426e-8fbc-a32d36bbd5e8"), A_0.n("xphw_up")).ao() as c5x;
		if (c5x != null)
		{
			a0l.a(c5x, "spanner_cutscene", true);
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4("spanner_cutscene");
			}
		}
	}
}
