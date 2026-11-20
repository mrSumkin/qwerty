using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000696 RID: 1686
[eiz("PAP")]
[Serializable]
public class bd0 : eu7, ISerializable
{
	// Token: 0x06002BD1 RID: 11217 RVA: 0x000FCE34 File Offset: 0x000FB034
	protected bd0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bd0);
		}
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x000FCE60 File Offset: 0x000FB060
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x000FCE6C File Offset: 0x000FB06C
	internal bd0(TypedObjectReference<efk> A_0, ce5 A_1, object A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x000FCE7C File Offset: 0x000FB07C
	public float a()
	{
		ce5 ce = base.p() as ce5;
		if (ce != null)
		{
			return ce.e(this);
		}
		return 0f;
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x000FCEA8 File Offset: 0x000FB0A8
	public PsiSchool b()
	{
		ce5 ce = base.p() as ce5;
		if (ce != null)
		{
			return ce.School;
		}
		return PsiSchool.Metathermics;
	}

	// Token: 0x06002BD6 RID: 11222 RVA: 0x000FCED0 File Offset: 0x000FB0D0
	public override av xh()
	{
		return new bd0(base.s(), base.p() as ce5, base.b9());
	}
}
