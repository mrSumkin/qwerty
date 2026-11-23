using System;
using System.Runtime.Serialization;

// Token: 0x020019D3 RID: 6611
[eiz("PSHLME")]
[Serializable]
public sealed class coc : cdh, ISerializable, d7s, bdr
{
	// Token: 0x06008DB7 RID: 36279 RVA: 0x00393FB0 File Offset: 0x003921B0
	private coc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("BTCMME:S");
	}

	// Token: 0x06008DB8 RID: 36280 RVA: 0x00393FCC File Offset: 0x003921CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BTCMME:S", this.a);
	}

	// Token: 0x06008DB9 RID: 36281 RVA: 0x00393FE8 File Offset: 0x003921E8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008DBA RID: 36282 RVA: 0x00393FF0 File Offset: 0x003921F0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DBB RID: 36283 RVA: 0x00393FFC File Offset: 0x003921FC
	public override bool ae5()
	{
		return true;
	}

	// Token: 0x06008DBC RID: 36284 RVA: 0x00394000 File Offset: 0x00392200
	public coc()
	{
	}

	// Token: 0x06008DBD RID: 36285 RVA: 0x00394008 File Offset: 0x00392208
	public override string b2()
	{
		return string.Format("Не может иметь более {0} пси-слотов.", this.a);
	}

	// Token: 0x06008DBE RID: 36286 RVA: 0x00394020 File Offset: 0x00392220
	public override d3e b3()
	{
		coc coc = new coc();
		this.xx(coc);
		return coc;
	}

	// Token: 0x06008DBF RID: 36287 RVA: 0x0039403C File Offset: 0x0039223C
	public void cn(d3e A_0)
	{
		coc coc = A_0 as coc;
		if (coc != null)
		{
			this.a = Math.Min(this.a, coc.a);
		}
	}

	// Token: 0x06008DC0 RID: 36288 RVA: 0x00394070 File Offset: 0x00392270
	public bool co(d3e A_0)
	{
		return A_0 is coc;
	}

	// Token: 0x06008DC1 RID: 36289 RVA: 0x0039407C File Offset: 0x0039227C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((coc)A_0).a = this.a;
	}

	// Token: 0x040037C3 RID: 14275
	private new int a;
}
