using System;
using System.Runtime.Serialization;

// Token: 0x02001A63 RID: 6755
[eiz("MPAM")]
[Serializable]
public sealed class cxu : bns, ISerializable
{
	// Token: 0x1700026C RID: 620
	// (get) Token: 0x060092A9 RID: 37545 RVA: 0x0039FDE4 File Offset: 0x0039DFE4
	// (set) Token: 0x060092AA RID: 37546 RVA: 0x0039FDEC File Offset: 0x0039DFEC
	public int MaxPoisonApplications
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060092AB RID: 37547 RVA: 0x0039FDF8 File Offset: 0x0039DFF8
	private cxu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPAM:A");
	}

	// Token: 0x060092AC RID: 37548 RVA: 0x0039FE1C File Offset: 0x0039E01C
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("MPAM:A", this.a);
	}

	// Token: 0x060092AD RID: 37549 RVA: 0x0039FE38 File Offset: 0x0039E038
	public cxu()
	{
	}

	// Token: 0x060092AE RID: 37550 RVA: 0x0039FE48 File Offset: 0x0039E048
	public override string h0(cd1 A_0)
	{
		return string.Format("Возможно нанести до {0} эффектов яда за раз", this.a);
	}

	// Token: 0x060092AF RID: 37551 RVA: 0x0039FE60 File Offset: 0x0039E060
	public override bns h1()
	{
		cxu cxu = new cxu();
		this.h2(cxu);
		return cxu;
	}

	// Token: 0x060092B0 RID: 37552 RVA: 0x0039FE7C File Offset: 0x0039E07C
	protected override void h2(bns A_0)
	{
		((cxu)A_0).a = this.a;
	}

	// Token: 0x04003860 RID: 14432
	private new int a = 2;
}
