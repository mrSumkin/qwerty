using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000968 RID: 2408
[eiz("FORETF")]
[Serializable]
public sealed class diu : bdw, ISerializable
{
	// Token: 0x06003A9A RID: 15002 RVA: 0x0015B744 File Offset: 0x00159944
	private diu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x0015B74C File Offset: 0x0015994C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x0015B750 File Offset: 0x00159950
	public diu()
	{
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x0015B75C File Offset: 0x0015995C
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("lu-b24");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b24_l" + 3.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
