using System;
using System.Runtime.Serialization;

// Token: 0x020004E9 RID: 1257
[eiz("SIAAP2")]
[Serializable]
public sealed class cus : cdg, ISerializable
{
	// Token: 0x06002075 RID: 8309 RVA: 0x000AFE9C File Offset: 0x000AE09C
	private cus(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SIAAP2:N");
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000AFEB8 File Offset: 0x000AE0B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIAAP2:N", this.a);
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000AFED4 File Offset: 0x000AE0D4
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000AFEDC File Offset: 0x000AE0DC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000AFEE8 File Offset: 0x000AE0E8
	public cus()
	{
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000AFEF0 File Offset: 0x000AE0F0
	protected override void ah6(x4 A_0)
	{
		A_0.c(this.a);
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000AFF00 File Offset: 0x000AE100
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x04001418 RID: 5144
	private string a;
}
