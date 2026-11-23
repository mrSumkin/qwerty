using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000907 RID: 2311
[eiz("CCSWD")]
[Serializable]
public sealed class a7s : bdw, ISerializable
{
	// Token: 0x0600390B RID: 14603 RVA: 0x00151FAC File Offset: 0x001501AC
	private a7s(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x00151FB4 File Offset: 0x001501B4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x00151FB8 File Offset: 0x001501B8
	public a7s()
	{
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x00151FC4 File Offset: 0x001501C4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_warehouse");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_warehouse_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
