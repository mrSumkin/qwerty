using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000697 RID: 1687
[eiz("SP1")]
[Serializable]
public class eu7 : av, ISerializable
{
	// Token: 0x06002BD7 RID: 11223 RVA: 0x000FCEFC File Offset: 0x000FB0FC
	protected eu7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x000FCF08 File Offset: 0x000FB108
	public SpellTargetType d()
	{
		return ((ehl)base.p()).bn(this);
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x000FCF1C File Offset: 0x000FB11C
	public new int g()
	{
		return ((ehl)base.p()).g(this);
	}

	// Token: 0x06002BDA RID: 11226 RVA: 0x000FCF34 File Offset: 0x000FB134
	public float c(object A_0)
	{
		if (A_0 != null)
		{
			return ((ehl)base.p()).afi(new eoj(base.b8(), base.b9(), A_0));
		}
		return ((ehl)base.p()).afi(this);
	}

	// Token: 0x06002BDB RID: 11227 RVA: 0x000FCF7C File Offset: 0x000FB17C
	public int m()
	{
		return ((ehl)base.p()).zb(new eoj(base.b8(), base.b9(), null));
	}

	// Token: 0x06002BDC RID: 11228 RVA: 0x000FCFAC File Offset: 0x000FB1AC
	public string b(object A_0)
	{
		return ((ehl)base.p()).p6(new eoj(base.b8(), base.b9(), A_0));
	}

	// Token: 0x06002BDD RID: 11229 RVA: 0x000FCFDC File Offset: 0x000FB1DC
	public int a(object A_0)
	{
		if (A_0 != null)
		{
			return ((ehl)base.p()).n(new eoj(base.b8(), base.b9(), A_0));
		}
		return ((ehl)base.p()).n(this);
	}

	// Token: 0x06002BDE RID: 11230 RVA: 0x000FD024 File Offset: 0x000FB224
	public int e()
	{
		return ((ehl)base.p()).s(this);
	}

	// Token: 0x06002BDF RID: 11231 RVA: 0x000FD038 File Offset: 0x000FB238
	public int k()
	{
		return ((ehl)base.p()).h(this);
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x000FD04C File Offset: 0x000FB24C
	public float j()
	{
		return ((ehl)base.p()).r(this);
	}

	// Token: 0x06002BE1 RID: 11233 RVA: 0x000FD060 File Offset: 0x000FB260
	public bna c()
	{
		return ((ehl)base.p()).iw(this);
	}

	// Token: 0x06002BE2 RID: 11234 RVA: 0x000FD074 File Offset: 0x000FB274
	public new double i()
	{
		return ((ehl)base.p()).m(this);
	}

	// Token: 0x06002BE3 RID: 11235 RVA: 0x000FD088 File Offset: 0x000FB288
	public double f()
	{
		return ((ehl)base.p()).q(this);
	}

	// Token: 0x06002BE4 RID: 11236 RVA: 0x000FD09C File Offset: 0x000FB29C
	public new ehl h()
	{
		return (ehl)base.p();
	}

	// Token: 0x06002BE5 RID: 11237 RVA: 0x000FD0AC File Offset: 0x000FB2AC
	public bool l()
	{
		return this.h().akb();
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x000FD0BC File Offset: 0x000FB2BC
	internal eu7(TypedObjectReference<efk> A_0, ehl A_1, object A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x000FD0CC File Offset: 0x000FB2CC
	public override av xh()
	{
		return new eu7(base.s(), base.p() as ehl, base.b9());
	}
}
