using System;
using System.Runtime.Serialization;

// Token: 0x0200023A RID: 570
[eiz("LLF")]
[Serializable]
public class b60 : alr, ISerializable
{
	// Token: 0x0600101F RID: 4127 RVA: 0x00042F00 File Offset: 0x00041100
	protected b60(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (ae8)A_0.GetValue("LLF:L", typeof(ae8));
			return;
		}
		if (base.GetType() == typeof(b60))
		{
			this.a = (ae8)A_0.GetValue("_Light", typeof(ae8));
			return;
		}
		this.a = (ae8)A_0.GetValue("LanternLightFragment+_Light", typeof(ae8));
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00042F9C File Offset: 0x0004119C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LLF:L", this.a);
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00042FB4 File Offset: 0x000411B4
	public b60(ae8 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00042FC4 File Offset: 0x000411C4
	public ae8 aej()
	{
		return this.a;
	}

	// Token: 0x0400096A RID: 2410
	private ae8 a;
}
