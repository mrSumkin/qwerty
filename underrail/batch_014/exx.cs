using System;
using System.Runtime.Serialization;

// Token: 0x0200099D RID: 2461
[eiz("SGSDM")]
[Serializable]
public sealed class exx : bdw, ISerializable
{
	// Token: 0x06003B70 RID: 15216 RVA: 0x0015FF48 File Offset: 0x0015E148
	private exx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B71 RID: 15217 RVA: 0x0015FF50 File Offset: 0x0015E150
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B72 RID: 15218 RVA: 0x0015FF54 File Offset: 0x0015E154
	public exx()
	{
	}

	// Token: 0x06003B73 RID: 15219 RVA: 0x0015FF60 File Offset: 0x0015E160
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("MushroomCoveNE");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("bad8f763-91ac-4ae0-9c9b-bfc937c5dff1"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
