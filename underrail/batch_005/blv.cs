using System;
using System.Runtime.Serialization;

// Token: 0x0200117D RID: 4477
[eiz("GLD")]
[Serializable]
public sealed class blv : ISerializable
{
	// Token: 0x06005FA5 RID: 24485 RVA: 0x0029AF18 File Offset: 0x00299118
	private blv(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("GLD:LD", typeof(ah7)) as ah7);
		this.b = A_0.GetSingle("GLD:SELF");
		this.c = A_0.GetSingle("GLD:EELF");
		this.d = A_0.GetSingle("GLD:ELR");
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x0029AFA0 File Offset: 0x002991A0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("GLD:LD", this.a);
		info.AddValue("GLD:SELF", this.b);
		info.AddValue("GLD:EELF", this.c);
		info.AddValue("GLD:ELR", this.d);
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x0029AFF4 File Offset: 0x002991F4
	public blv()
	{
	}

	// Token: 0x0400280C RID: 10252
	public ah7 a;

	// Token: 0x0400280D RID: 10253
	public float b = 0.2f;

	// Token: 0x0400280E RID: 10254
	public float c = 0.15f;

	// Token: 0x0400280F RID: 10255
	public float d = 6f;
}
