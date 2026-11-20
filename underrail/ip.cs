using System;
using System.Runtime.Serialization;

// Token: 0x02001E60 RID: 7776
[eiz("CS5")]
[Serializable]
public sealed class ip : ISerializable
{
	// Token: 0x0600AC56 RID: 44118 RVA: 0x003F993C File Offset: 0x003F7B3C
	private ip(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetDouble("CS5:R");
		this.b = A_0.GetDouble("CS5:D");
		if (ell.a() >= 548)
		{
			this.c = A_0.GetBoolean("CS5:A");
			this.d = A_0.GetBoolean("CS5:S");
		}
	}

	// Token: 0x0600AC57 RID: 44119 RVA: 0x003F99A4 File Offset: 0x003F7BA4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CS5:R", this.a);
		info.AddValue("CS5:D", this.b);
		info.AddValue("CS5:A", this.c);
		info.AddValue("CS5:S", this.d);
	}

	// Token: 0x0600AC58 RID: 44120 RVA: 0x003F99F8 File Offset: 0x003F7BF8
	public ip(double A_0, bool A_1, bool A_2)
	{
		this.b = A_0;
		this.a = A_0;
		this.c = A_1;
		this.d = A_2;
	}

	// Token: 0x0600AC59 RID: 44121 RVA: 0x003F9A20 File Offset: 0x003F7C20
	public bool a(double A_0)
	{
		return (this.a -= A_0) <= 0.0;
	}

	// Token: 0x0600AC5A RID: 44122 RVA: 0x003F9A50 File Offset: 0x003F7C50
	public bool a()
	{
		return (this.a -= (double)d0u.b) <= 0.0;
	}

	// Token: 0x04004039 RID: 16441
	public double a;

	// Token: 0x0400403A RID: 16442
	public double b;

	// Token: 0x0400403B RID: 16443
	public bool c;

	// Token: 0x0400403C RID: 16444
	public bool d;
}
