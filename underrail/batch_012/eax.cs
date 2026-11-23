using System;
using System.Runtime.Serialization;

// Token: 0x02001E56 RID: 7766
[eiz("CMD")]
[Serializable]
public sealed class eax : ISerializable
{
	// Token: 0x0600AC24 RID: 44068 RVA: 0x003F9154 File Offset: 0x003F7354
	private eax(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("CMD:N");
		this.b = (A_0.GetValue("CMD:D", typeof(double?)) as double?);
	}

	// Token: 0x0600AC25 RID: 44069 RVA: 0x003F91A0 File Offset: 0x003F73A0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CMD:N", this.a);
		info.AddValue("CMD:D", this.b);
	}

	// Token: 0x0600AC26 RID: 44070 RVA: 0x003F91CC File Offset: 0x003F73CC
	public eax()
	{
	}

	// Token: 0x04004018 RID: 16408
	public string a;

	// Token: 0x04004019 RID: 16409
	public double? b;
}
