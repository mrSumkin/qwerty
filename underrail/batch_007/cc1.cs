using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000F8D RID: 3981
[a(typeof(dy8))]
[eiz("PTICEA")]
[Serializable]
public sealed class cc1 : dy8
{
	// Token: 0x06005140 RID: 20800 RVA: 0x00249958 File Offset: 0x00247B58
	private cc1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("PTICEA:P", typeof(Guid));
		this.b = A_0.GetBoolean("PTICEA:S");
	}

	// Token: 0x06005141 RID: 20801 RVA: 0x00249994 File Offset: 0x00247B94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PTICEA:P", this.a);
		info.AddValue("PTICEA:S", this.b);
	}

	// Token: 0x06005142 RID: 20802 RVA: 0x002499C8 File Offset: 0x00247BC8
	public Guid b()
	{
		return this.a;
	}

	// Token: 0x06005143 RID: 20803 RVA: 0x002499D0 File Offset: 0x00247BD0
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005144 RID: 20804 RVA: 0x002499DC File Offset: 0x00247BDC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005145 RID: 20805 RVA: 0x002499E4 File Offset: 0x00247BE4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005146 RID: 20806 RVA: 0x002499F0 File Offset: 0x00247BF0
	public cc1(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005147 RID: 20807 RVA: 0x002499FC File Offset: 0x00247BFC
	protected override void o2()
	{
		axh axh = new EntityAspectReference<axh, axh>(base.a8().Area, this.a).ao();
		if (axh != null)
		{
			axh.a(null, this.b, null);
		}
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x00249A44 File Offset: 0x00247C44
	protected override void o3()
	{
		axh axh = new EntityAspectReference<axh, axh>(base.a8().Area, this.a).ao();
		if (axh != null)
		{
			axh.a(null, !this.b, null);
		}
	}

	// Token: 0x06005149 RID: 20809 RVA: 0x00249A8C File Offset: 0x00247C8C
	protected override void o4()
	{
	}

	// Token: 0x0400214F RID: 8527
	private Guid a;

	// Token: 0x04002150 RID: 8528
	private bool b;
}
