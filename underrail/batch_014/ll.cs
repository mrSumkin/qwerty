using System;
using System.Runtime.Serialization;

// Token: 0x02001A59 RID: 6745
[eiz("EC")]
[Serializable]
public sealed class ll : ISerializable
{
	// Token: 0x0600926C RID: 37484 RVA: 0x0039F69C File Offset: 0x0039D89C
	private ll(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (efk)A_0.GetValue("EC:C", typeof(efk));
			return;
		}
		if (base.GetType() == typeof(ll))
		{
			this.a = (efk)A_0.GetValue("_Character", typeof(efk));
			return;
		}
		this.a = (efk)A_0.GetValue("EffectContext+_Character", typeof(efk));
	}

	// Token: 0x0600926D RID: 37485 RVA: 0x0039F738 File Offset: 0x0039D938
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("EC:C", this.a);
	}

	// Token: 0x0600926E RID: 37486 RVA: 0x0039F74C File Offset: 0x0039D94C
	public efk a()
	{
		return this.a;
	}

	// Token: 0x0600926F RID: 37487 RVA: 0x0039F754 File Offset: 0x0039D954
	public ll(efk A_0)
	{
		czh.a(A_0, "character");
		this.a = A_0;
	}

	// Token: 0x04003853 RID: 14419
	private efk a;
}
