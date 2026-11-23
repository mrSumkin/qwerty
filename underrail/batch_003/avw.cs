using System;
using System.Runtime.Serialization;

// Token: 0x020004F7 RID: 1271
[eiz("MPRA")]
[Serializable]
public sealed class avw : esc
{
	// Token: 0x060020D3 RID: 8403 RVA: 0x000B0918 File Offset: 0x000AEB18
	private avw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetSingle("MPRA:V");
		this.a = (A_0.GetValue("MPRA:LL", typeof(float?)) as float?);
		this.b = (A_0.GetValue("MPRA:UL", typeof(float?)) as float?);
		this.e = A_0.GetBoolean("MPRA:I");
		this.d = (dkg)A_0.GetValue("MPRA:R", typeof(dkg));
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000B09D4 File Offset: 0x000AEBD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPRA:V", this.c);
		info.AddValue("MPRA:LL", this.a);
		info.AddValue("MPRA:UL", this.b);
		info.AddValue("MPRA:I", this.e);
		info.AddValue("MPRA:R", this.d);
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x000B0A50 File Offset: 0x000AEC50
	public float e()
	{
		return this.c;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x000B0A58 File Offset: 0x000AEC58
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x000B0A64 File Offset: 0x000AEC64
	public dkg d()
	{
		return this.d;
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000B0A6C File Offset: 0x000AEC6C
	public void a(dkg A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x000B0A78 File Offset: 0x000AEC78
	public bool b()
	{
		return this.e;
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x000B0A80 File Offset: 0x000AEC80
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000B0A8C File Offset: 0x000AEC8C
	public float? c()
	{
		return this.a;
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000B0A94 File Offset: 0x000AEC94
	public void b(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000B0AA0 File Offset: 0x000AECA0
	public float? a()
	{
		return this.b;
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000B0AA8 File Offset: 0x000AECA8
	public void a(float? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000B0AB4 File Offset: 0x000AECB4
	public avw()
	{
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x000B0AD8 File Offset: 0x000AECD8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (A_0 != null)
		{
			cs1.a(A_0, this.d, this.c, this.e, this.b, this.a);
		}
		return 0;
	}

	// Token: 0x0400142C RID: 5164
	private float? a = new float?((float)-2);

	// Token: 0x0400142D RID: 5165
	private float? b = new float?((float)2);

	// Token: 0x0400142E RID: 5166
	private float c;

	// Token: 0x0400142F RID: 5167
	private dkg d;

	// Token: 0x04001430 RID: 5168
	private bool e;
}
