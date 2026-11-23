using System;
using System.Runtime.Serialization;

// Token: 0x020004EC RID: 1260
[eiz("SIAAP1")]
[Serializable]
public sealed class ctb : cdg, ISerializable
{
	// Token: 0x0600208A RID: 8330 RVA: 0x000B00D4 File Offset: 0x000AE2D4
	private ctb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SIAAP1:P");
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000B00F0 File Offset: 0x000AE2F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIAAP1:P", this.a);
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000B010C File Offset: 0x000AE30C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000B0114 File Offset: 0x000AE314
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x000B0120 File Offset: 0x000AE320
	public ctb()
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000B0128 File Offset: 0x000AE328
	protected override void ah6(x4 A_0)
	{
		A_0.b(this.a);
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000B0138 File Offset: 0x000AE338
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x0400141B RID: 5147
	private string a;
}
