using System;
using System.Runtime.Serialization;

// Token: 0x02001462 RID: 5218
[eiz("IFTA")]
[Serializable]
public sealed class ch8 : b1z, ISerializable
{
	// Token: 0x060075A2 RID: 30114 RVA: 0x0031D04C File Offset: 0x0031B24C
	private ch8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("IFTA:R", typeof(ad5)) as ad5);
	}

	// Token: 0x060075A3 RID: 30115 RVA: 0x0031D078 File Offset: 0x0031B278
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IFTA:R", this.a);
	}

	// Token: 0x060075A4 RID: 30116 RVA: 0x0031D094 File Offset: 0x0031B294
	public ch8(ad5 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060075A5 RID: 30117 RVA: 0x0031D0A4 File Offset: 0x0031B2A4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null)
		{
			return dc4.e;
		}
		this.a.i();
		return dc4.c;
	}

	// Token: 0x04003020 RID: 12320
	private new ad5 a;
}
