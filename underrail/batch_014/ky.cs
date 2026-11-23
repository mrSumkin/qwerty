using System;
using System.Runtime.Serialization;

// Token: 0x02000505 RID: 1285
[eiz("GNE")]
[Serializable]
public sealed class ky : c47, op, ISerializable
{
	// Token: 0x06002135 RID: 8501 RVA: 0x000B1CD0 File Offset: 0x000AFED0
	private ky(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GNE:T", typeof(ecs)) as ecs);
		this.b = (A_0.GetValue("GNE:D", typeof(int?)) as int?);
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x000B1D2C File Offset: 0x000AFF2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GNE:T", this.a);
		info.AddValue("GNE:D", this.b);
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000B1D60 File Offset: 0x000AFF60
	public bool d()
	{
		return true;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000B1D64 File Offset: 0x000AFF64
	public ecs c()
	{
		return this.a;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x000B1D6C File Offset: 0x000AFF6C
	public void a(ecs A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x000B1D78 File Offset: 0x000AFF78
	public int? e()
	{
		return this.b;
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000B1D80 File Offset: 0x000AFF80
	public void a(int? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000B1D8C File Offset: 0x000AFF8C
	public int? id()
	{
		return this.b;
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x000B1D94 File Offset: 0x000AFF94
	public ky(ecs A_0, int? A_1 = null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x000B1DAC File Offset: 0x000AFFAC
	public ecs ie()
	{
		return this.a;
	}

	// Token: 0x04001446 RID: 5190
	private ecs a;

	// Token: 0x04001447 RID: 5191
	private int? b;
}
