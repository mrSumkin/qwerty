using System;
using System.Runtime.Serialization;

// Token: 0x0200097D RID: 2429
[eiz("TCHDCE")]
[Serializable]
public sealed class bpm : bdw, ISerializable
{
	// Token: 0x06003AEF RID: 15087 RVA: 0x0015DB34 File Offset: 0x0015BD34
	private bpm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x0015DB3C File Offset: 0x0015BD3C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AF1 RID: 15089 RVA: 0x0015DB40 File Offset: 0x0015BD40
	public bpm()
	{
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x0015DB4C File Offset: 0x0015BD4C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-dclift");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("0cbacbc3-9d09-4f84-937c-66ab74d5ad8c"), aud).ao() as c5x;
			if (c5x != null)
			{
				new cib().ym(c5x, null, null);
			}
		}
	}
}
