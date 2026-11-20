using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200090E RID: 2318
[eiz("CCDWHUS")]
[Serializable]
public sealed class cuc : bdw, ISerializable
{
	// Token: 0x06003927 RID: 14631 RVA: 0x001527AC File Offset: 0x001509AC
	private cuc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003928 RID: 14632 RVA: 0x001527B4 File Offset: 0x001509B4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x001527B8 File Offset: 0x001509B8
	public cuc()
	{
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x001527C0 File Offset: 0x001509C0
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_whu3");
		if (aud != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"guardBot"
				})) as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
			c5x a_ = new ar7(new Guid("9308d3f7-1a7a-41bc-95c6-b155edd11f99"), aud).ao() as c5x;
			new ae9().ym(null, a_, null);
		}
	}
}
