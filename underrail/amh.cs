using System;
using System.Runtime.Serialization;

// Token: 0x020011D1 RID: 4561
[eiz("CCVHC")]
[Serializable]
public sealed class amh : c1i
{
	// Token: 0x060061DA RID: 25050 RVA: 0x002A76A8 File Offset: 0x002A58A8
	private amh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CCVHC:V", typeof(bcx)) as bcx);
	}

	// Token: 0x060061DB RID: 25051 RVA: 0x002A76D4 File Offset: 0x002A58D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCVHC:V", this.a);
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x002A76F0 File Offset: 0x002A58F0
	public bcx a()
	{
		return this.a;
	}

	// Token: 0x060061DD RID: 25053 RVA: 0x002A76F8 File Offset: 0x002A58F8
	public void a(bcx A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x002A7704 File Offset: 0x002A5904
	public amh()
	{
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x002A770C File Offset: 0x002A590C
	public amh(bcx A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x002A771C File Offset: 0x002A591C
	public override bcx qy()
	{
		return this.a;
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x002A7724 File Offset: 0x002A5924
	public override c1i qz()
	{
		return new amh(this.a);
	}

	// Token: 0x0400298F RID: 10639
	private bcx a;
}
