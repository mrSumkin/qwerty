using System;
using System.Runtime.Serialization;

// Token: 0x02000961 RID: 2401
[eiz("CVDTB")]
[Serializable]
public sealed class va : bdw, ISerializable
{
	// Token: 0x06003A7E RID: 14974 RVA: 0x0015A7A4 File Offset: 0x001589A4
	private va(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x0015A7AC File Offset: 0x001589AC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x0015A7B0 File Offset: 0x001589B0
	public va()
	{
	}

	// Token: 0x06003A81 RID: 14977 RVA: 0x0015A7BC File Offset: 0x001589BC
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cv16");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("198a59a0-69ab-466b-bfdc-0d0384966611"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
