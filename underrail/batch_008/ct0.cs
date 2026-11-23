using System;
using System.Runtime.Serialization;

// Token: 0x020004F4 RID: 1268
[eiz("C34")]
[Serializable]
public sealed class ct0 : esc, ISerializable
{
	// Token: 0x060020BA RID: 8378 RVA: 0x000B0618 File Offset: 0x000AE818
	private ct0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("C34:QN");
		this.a = A_0.GetBoolean("C34:PE");
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000B064C File Offset: 0x000AE84C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C34:QN", this.b);
		info.AddValue("C34:PE", this.a);
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000B0678 File Offset: 0x000AE878
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000B0680 File Offset: 0x000AE880
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000B068C File Offset: 0x000AE88C
	public string a()
	{
		return this.b;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000B0694 File Offset: 0x000AE894
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000B06A0 File Offset: 0x000AE8A0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atd(this.a(), this.a);
		return 0;
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000B06C0 File Offset: 0x000AE8C0
	public ct0()
	{
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000B06D0 File Offset: 0x000AE8D0
	public override bool h5(string A_0, bool A_1)
	{
		return !base.h5(A_0, A_1) && !string.IsNullOrEmpty(this.b) && this.b.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x04001426 RID: 5158
	private bool a = true;

	// Token: 0x04001427 RID: 5159
	private string b;
}
