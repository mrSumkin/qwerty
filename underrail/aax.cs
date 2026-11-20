using System;
using System.Runtime.Serialization;

// Token: 0x020004E8 RID: 1256
[eiz("JPPA")]
[Serializable]
public sealed class aax : esc, ISerializable
{
	// Token: 0x0600206D RID: 8301 RVA: 0x000AFE00 File Offset: 0x000AE000
	private aax(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("JPPA:J");
		if (ell.a() >= 672)
		{
			this.b = A_0.GetBoolean("JPPA:D");
		}
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000AFE3C File Offset: 0x000AE03C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("JPPA:J", this.a);
		info.AddValue("JPPA:D", this.b);
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000AFE68 File Offset: 0x000AE068
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x000AFE70 File Offset: 0x000AE070
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000AFE7C File Offset: 0x000AE07C
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000AFE84 File Offset: 0x000AE084
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000AFE90 File Offset: 0x000AE090
	public override int d5(bq8 A_0, bq8 A_1)
	{
		return 0;
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x000AFE94 File Offset: 0x000AE094
	public aax()
	{
	}

	// Token: 0x04001416 RID: 5142
	private string a;

	// Token: 0x04001417 RID: 5143
	private bool b;
}
