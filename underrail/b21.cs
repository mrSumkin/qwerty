using System;
using System.Runtime.Serialization;

// Token: 0x02000FC8 RID: 4040
[eiz("PIOBSCC")]
[Serializable]
public sealed class b21 : dnh, ISerializable
{
	// Token: 0x0600530A RID: 21258 RVA: 0x0024F8E0 File Offset: 0x0024DAE0
	private b21(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 454)
		{
			this.a = A_0.GetBoolean("PIOBSCC:I");
		}
	}

	// Token: 0x0600530B RID: 21259 RVA: 0x0024F90C File Offset: 0x0024DB0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIOBSCC:I", this.a);
	}

	// Token: 0x0600530C RID: 21260 RVA: 0x0024F928 File Offset: 0x0024DB28
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600530D RID: 21261 RVA: 0x0024F930 File Offset: 0x0024DB30
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600530E RID: 21262 RVA: 0x0024F93C File Offset: 0x0024DB3C
	public b21()
	{
	}

	// Token: 0x0600530F RID: 21263 RVA: 0x0024F944 File Offset: 0x0024DB44
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		return e3m.a() != null ^ this.a;
	}

	// Token: 0x040021F5 RID: 8693
	private bool a;
}
