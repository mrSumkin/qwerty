using System;
using System.Runtime.Serialization;

// Token: 0x020004E7 RID: 1255
[eiz("PREPC")]
[Serializable]
public sealed class afk : dnh
{
	// Token: 0x06002061 RID: 8289 RVA: 0x000AFC30 File Offset: 0x000ADE30
	private afk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PREPC:LL", typeof(float?)) as float?);
		this.b = (A_0.GetValue("PREPC:UL", typeof(float?)) as float?);
		this.c = A_0.GetBoolean("PREPC:I");
		this.d = (dkg)A_0.GetValue("PREPC:R", typeof(dkg));
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x000AFCC0 File Offset: 0x000ADEC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PREPC:LL", this.a);
		info.AddValue("PREPC:UL", this.b);
		info.AddValue("PREPC:I", this.c);
		info.AddValue("PREPC:R", this.d);
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000AFD28 File Offset: 0x000ADF28
	public float? c()
	{
		return this.a;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000AFD30 File Offset: 0x000ADF30
	public void b(float? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000AFD3C File Offset: 0x000ADF3C
	public float? a()
	{
		return this.b;
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x000AFD44 File Offset: 0x000ADF44
	public void a(float? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x000AFD50 File Offset: 0x000ADF50
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x000AFD58 File Offset: 0x000ADF58
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x000AFD64 File Offset: 0x000ADF64
	public dkg b()
	{
		return this.d;
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000AFD6C File Offset: 0x000ADF6C
	public void a(dkg A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000AFD78 File Offset: 0x000ADF78
	public afk()
	{
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x000AFD80 File Offset: 0x000ADF80
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_0 == null)
		{
			return this.c;
		}
		float num = cs1.a(A_0, this.d);
		if (this.a != null && num < this.a.Value)
		{
			return this.c;
		}
		if (this.b != null && num > this.b.Value)
		{
			return this.c;
		}
		return !this.c;
	}

	// Token: 0x04001412 RID: 5138
	private float? a;

	// Token: 0x04001413 RID: 5139
	private float? b;

	// Token: 0x04001414 RID: 5140
	private bool c;

	// Token: 0x04001415 RID: 5141
	private dkg d;
}
