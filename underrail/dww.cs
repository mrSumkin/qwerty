using System;
using System.Runtime.Serialization;

// Token: 0x020011D0 RID: 4560
[eiz("GCVHC")]
[Serializable]
public sealed class dww : c1i
{
	// Token: 0x060061D2 RID: 25042 RVA: 0x002A7608 File Offset: 0x002A5808
	private dww(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GCVHC:G", typeof(drj)) as drj);
	}

	// Token: 0x060061D3 RID: 25043 RVA: 0x002A7634 File Offset: 0x002A5834
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GCVHC:G", this.a);
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x002A7650 File Offset: 0x002A5850
	public drj a()
	{
		return this.a;
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x002A7658 File Offset: 0x002A5858
	public void a(drj A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x002A7664 File Offset: 0x002A5864
	public dww()
	{
	}

	// Token: 0x060061D7 RID: 25047 RVA: 0x002A766C File Offset: 0x002A586C
	public dww(drj A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x002A767C File Offset: 0x002A587C
	public override bcx qy()
	{
		if (this.a != null)
		{
			return this.a.x4();
		}
		return null;
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x002A7698 File Offset: 0x002A5898
	public override c1i qz()
	{
		return new dww(this.a);
	}

	// Token: 0x0400298E RID: 10638
	private drj a;
}
