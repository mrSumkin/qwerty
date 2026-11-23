using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x0200131A RID: 4890
[eiz("PEA1")]
[Serializable]
public sealed class b4u : Aspect<c5x>, aig, c02, ISerializable
{
	// Token: 0x06006E23 RID: 28195 RVA: 0x002E065C File Offset: 0x002DE85C
	private b4u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetDouble("PEA1:PC");
			this.b = A_0.GetSingle("PEA1:MPS");
			this.c = A_0.GetInt32("PEA1:F");
			this.d = A_0.GetSingle("PEA1:S");
			di7.ReadList<aig>("PEA1:CMH", ref this.e, A_0);
			this.f = (bdi)A_0.GetValue("PEA1:IA", typeof(bdi));
			return;
		}
		this.a = A_0.GetDouble("_PhaseCache");
		this.b = A_0.GetSingle("_MovementPhaseStep");
		this.c = A_0.GetInt32("_Frames");
		this.d = A_0.GetSingle("_Speed");
		this.f = (A_0.GetValue("IA", typeof(bdi)) as bdi);
		this.e = new List<aig>();
		di7.ReadList<aig>("_CustomMovementHandlers", ref this.e, A_0);
	}

	// Token: 0x06006E24 RID: 28196 RVA: 0x002E077C File Offset: 0x002DE97C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PEA1:PC", this.a);
		info.AddValue("PEA1:MPS", this.b);
		info.AddValue("PEA1:F", this.c);
		info.AddValue("PEA1:S", this.d);
		di7.WriteList<aig>("PEA1:CMH", this.e, info);
		info.AddValue("PEA1:IA", this.f);
	}

	// Token: 0x06006E25 RID: 28197 RVA: 0x002E07F8 File Offset: 0x002DE9F8
	public float h9()
	{
		return dz6.b(this.d);
	}

	// Token: 0x06006E26 RID: 28198 RVA: 0x002E0808 File Offset: 0x002DEA08
	public float ia()
	{
		return this.h9();
	}

	// Token: 0x06006E27 RID: 28199 RVA: 0x002E0810 File Offset: 0x002DEA10
	public List<aig> b()
	{
		return this.e;
	}

	// Token: 0x06006E28 RID: 28200 RVA: 0x002E0818 File Offset: 0x002DEA18
	public b4u(c5x A_0, bdi A_1, float A_2, int A_3, float A_4) : base(A_0)
	{
		this.f = A_1;
		base.a8().a(new EventHandler<c1>(this.a));
		this.d = A_2;
		this.c = A_3;
		this.b = A_4;
		this.a = (double)this.b;
		this.a();
	}

	// Token: 0x06006E29 RID: 28201 RVA: 0x002E0880 File Offset: 0x002DEA80
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if (this.c > 0 && (this.a -= (double)A_3) <= 0.0)
		{
			this.a = (double)this.b;
			this.f.qb(this.c, false);
		}
		if (this.e != null)
		{
			foreach (aig aig in this.e)
			{
				aig.hj(A_0, A_1, A_2, A_3);
			}
		}
		return false;
	}

	// Token: 0x06006E2A RID: 28202 RVA: 0x002E0934 File Offset: 0x002DEB34
	[dcc("PEA1:mAVDC")]
	private void a(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x06006E2B RID: 28203 RVA: 0x002E093C File Offset: 0x002DEB3C
	private void a()
	{
		this.f.qc(base.a8().ac);
	}

	// Token: 0x04002D09 RID: 11529
	private double a;

	// Token: 0x04002D0A RID: 11530
	private float b;

	// Token: 0x04002D0B RID: 11531
	private int c;

	// Token: 0x04002D0C RID: 11532
	private float d;

	// Token: 0x04002D0D RID: 11533
	private List<aig> e = new List<aig>();

	// Token: 0x04002D0E RID: 11534
	private bdi f;
}
