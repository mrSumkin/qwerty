using System;
using System.Runtime.Serialization;

// Token: 0x020019B2 RID: 6578
[eiz("MSTACFME")]
[Serializable]
public sealed class ebc : cdh, ISerializable, d7s
{
	// Token: 0x06008C9B RID: 35995 RVA: 0x00391704 File Offset: 0x0038F904
	private ebc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MSTACFME:M");
	}

	// Token: 0x06008C9C RID: 35996 RVA: 0x00391720 File Offset: 0x0038F920
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSTACFME:M", this.a);
	}

	// Token: 0x06008C9D RID: 35997 RVA: 0x0039173C File Offset: 0x0038F93C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008C9E RID: 35998 RVA: 0x00391744 File Offset: 0x0038F944
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008C9F RID: 35999 RVA: 0x00391750 File Offset: 0x0038F950
	public override bool ae5()
	{
		return this.a > 0;
	}

	// Token: 0x06008CA0 RID: 36000 RVA: 0x0039175C File Offset: 0x0038F95C
	public ebc()
	{
	}

	// Token: 0x06008CA1 RID: 36001 RVA: 0x00391764 File Offset: 0x0038F964
	public override string b2()
	{
		if (this.a < 0)
		{
			return string.Format("Стоимость очков действия Бросок копья уменьшена на {0}", Math.Abs(this.a));
		}
		return string.Format("Стоимость очков действия Бросок копья увеличена на {0}", this.a);
	}

	// Token: 0x06008CA2 RID: 36002 RVA: 0x003917A4 File Offset: 0x0038F9A4
	public override d3e b3()
	{
		ebc ebc = new ebc();
		this.xx(ebc);
		return ebc;
	}

	// Token: 0x06008CA3 RID: 36003 RVA: 0x003917C0 File Offset: 0x0038F9C0
	public void cn(d3e A_0)
	{
		ebc ebc = A_0 as ebc;
		if (ebc != null)
		{
			this.a += ebc.a;
		}
	}

	// Token: 0x06008CA4 RID: 36004 RVA: 0x003917F0 File Offset: 0x0038F9F0
	public bool co(d3e A_0)
	{
		return A_0 is ebc;
	}

	// Token: 0x06008CA5 RID: 36005 RVA: 0x003917FC File Offset: 0x0038F9FC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ebc)A_0).a = this.a;
	}

	// Token: 0x040037A0 RID: 14240
	private new int a;
}
