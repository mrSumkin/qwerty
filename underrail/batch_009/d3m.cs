using System;
using System.Runtime.Serialization;

// Token: 0x02001E18 RID: 7704
[eiz("SBA2")]
[Serializable]
public sealed class d3m : to, ISerializable
{
	// Token: 0x0600AA9A RID: 43674 RVA: 0x003F4228 File Offset: 0x003F2428
	private d3m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AA9B RID: 43675 RVA: 0x003F4234 File Offset: 0x003F2434
	public d3m() : base("Strength")
	{
	}

	// Token: 0x0600AA9C RID: 43676 RVA: 0x003F4244 File Offset: 0x003F2444
	public d3m(int A_0) : base("Strength", A_0)
	{
	}

	// Token: 0x0600AA9D RID: 43677 RVA: 0x003F4254 File Offset: 0x003F2454
	public d3m(bn2 A_0) : base(A_0, "Strength")
	{
	}

	// Token: 0x0600AA9E RID: 43678 RVA: 0x003F4264 File Offset: 0x003F2464
	public d3m(bn2 A_0, int A_1) : base(A_0, "Strength", A_1)
	{
	}

	// Token: 0x04003FC7 RID: 16327
	private const string BaseAbilityName = "Strength";
}
