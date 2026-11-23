using System;
using System.Runtime.Serialization;

// Token: 0x02000A01 RID: 2561
[eiz("XPBLLERMAAI")]
[Serializable]
public sealed class c4d : bdw, ISerializable
{
	// Token: 0x06003D16 RID: 15638 RVA: 0x0016B93C File Offset: 0x00169B3C
	private c4d(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("XPBLLERMAAI:PM");
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x0016B958 File Offset: 0x00169B58
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("XPBLLERMAAI:PM", this.a);
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x0016B96C File Offset: 0x00169B6C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x0016B974 File Offset: 0x00169B74
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003D1A RID: 15642 RVA: 0x0016B980 File Offset: 0x00169B80
	public c4d()
	{
	}

	// Token: 0x06003D1B RID: 15643 RVA: 0x0016B988 File Offset: 0x00169B88
	public c4d(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x0016B998 File Offset: 0x00169B98
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"lemurianMines"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (this.a)
					{
						c5x.ae = new float?((float)1);
					}
					else
					{
						c5x.ae = new float?(0f);
					}
				}
			}
		}
	}

	// Token: 0x04001B9D RID: 7069
	private bool a;
}
