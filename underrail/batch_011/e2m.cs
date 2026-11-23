using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020009E2 RID: 2530
[eiz("GENREWSRC")]
[Serializable]
public sealed class e2m : bdw, ISerializable
{
	// Token: 0x06003C85 RID: 15493 RVA: 0x00166C4C File Offset: 0x00164E4C
	private e2m(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<string>("GENREWSRC:RC", ref this.a, A_0);
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x00166C68 File Offset: 0x00164E68
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		di7.WriteList<string>("GENREWSRC:RC", this.a, info);
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x00166C7C File Offset: 0x00164E7C
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x06003C88 RID: 15496 RVA: 0x00166C84 File Offset: 0x00164E84
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003C89 RID: 15497 RVA: 0x00166C90 File Offset: 0x00164E90
	public e2m()
	{
	}

	// Token: 0x06003C8A RID: 15498 RVA: 0x00166C9C File Offset: 0x00164E9C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab2(this.a))
				{
					c5x c5x = (c5x)b0b;
					c5x.w();
					c5x.an();
				}
			}
		}
	}

	// Token: 0x04001B9B RID: 7067
	private List<string> a;
}
