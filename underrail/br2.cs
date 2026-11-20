using System;
using System.Runtime.Serialization;

// Token: 0x020019B1 RID: 6577
[eiz("FRSCME")]
[Serializable]
public sealed class br2 : cdh, ISerializable, d7s
{
	// Token: 0x06008C91 RID: 35985 RVA: 0x00391610 File Offset: 0x0038F810
	private br2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("FRSCME:R");
	}

	// Token: 0x06008C92 RID: 35986 RVA: 0x0039162C File Offset: 0x0038F82C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FRSCME:R", this.a);
	}

	// Token: 0x06008C93 RID: 35987 RVA: 0x00391648 File Offset: 0x0038F848
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008C94 RID: 35988 RVA: 0x00391650 File Offset: 0x0038F850
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008C95 RID: 35989 RVA: 0x0039165C File Offset: 0x0038F85C
	public br2()
	{
	}

	// Token: 0x06008C96 RID: 35990 RVA: 0x00391664 File Offset: 0x0038F864
	public override string b2()
	{
		if (this.a > 0)
		{
			return string.Format("Отражение уменьшает время перезарядки атаки Подсечением на {0}.", l4.a(this.a, false));
		}
		return "";
	}

	// Token: 0x06008C97 RID: 35991 RVA: 0x00391690 File Offset: 0x0038F890
	public override d3e b3()
	{
		br2 br = new br2();
		this.xx(br);
		return br;
	}

	// Token: 0x06008C98 RID: 35992 RVA: 0x003916AC File Offset: 0x0038F8AC
	public void cn(d3e A_0)
	{
		br2 br = A_0 as br2;
		if (br != null)
		{
			this.a += br.a;
		}
	}

	// Token: 0x06008C99 RID: 35993 RVA: 0x003916DC File Offset: 0x0038F8DC
	public bool co(d3e A_0)
	{
		return A_0 is br2;
	}

	// Token: 0x06008C9A RID: 35994 RVA: 0x003916E8 File Offset: 0x0038F8E8
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((br2)A_0).a = this.a;
	}

	// Token: 0x0400379F RID: 14239
	private new int a;
}
