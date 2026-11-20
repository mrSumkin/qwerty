using System;
using System.Runtime.Serialization;

// Token: 0x02000913 RID: 2323
[eiz("CCUEO")]
[Serializable]
public sealed class e8v : bdw, ISerializable
{
	// Token: 0x0600393B RID: 14651 RVA: 0x00152F58 File Offset: 0x00151158
	private e8v(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x00152F60 File Offset: 0x00151160
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x00152F64 File Offset: 0x00151164
	public e8v()
	{
	}

	// Token: 0x0600393E RID: 14654 RVA: 0x00152F6C File Offset: 0x0015116C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_utility");
			if (aud != null)
			{
				axh aspect = (new ar7(new Guid("6fe4a7fa-6d93-4866-8a36-bc508ee702cd"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, true, null);
				}
			}
		}
	}
}
