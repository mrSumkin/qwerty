using System;
using System.Runtime.Serialization;

// Token: 0x020004F0 RID: 1264
[eiz("STSA")]
[Serializable]
public sealed class bnq : esc, ISerializable
{
	// Token: 0x060020A0 RID: 8352 RVA: 0x000B0350 File Offset: 0x000AE550
	private bnq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("STSA:GP");
		this.b = (A_0.GetValue("STSA:TS", typeof(TimeSpan?)) as TimeSpan?);
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000B039C File Offset: 0x000AE59C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STSA:GP", this.a);
		info.AddValue("STSA:TS", this.b);
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000B03D0 File Offset: 0x000AE5D0
	public string b()
	{
		return this.a;
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000B03D8 File Offset: 0x000AE5D8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000B03E4 File Offset: 0x000AE5E4
	public TimeSpan? a()
	{
		return this.b;
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000B03EC File Offset: 0x000AE5EC
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000B03F8 File Offset: 0x000AE5F8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		d8z.a(A_0, A_1, this.a, this.b);
		return 0;
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000B0414 File Offset: 0x000AE614
	public bnq()
	{
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000B0420 File Offset: 0x000AE620
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x04001420 RID: 5152
	private string a;

	// Token: 0x04001421 RID: 5153
	private TimeSpan? b;
}
